/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

/* ================================================================
 * About NPOI
 * Author: Tony Qu
 * Author's email: tonyqus (at) gmail.com
 * Author's Blog: tonyqus.wordpress.com.cn (wp.tonyqus.cn)
 * HomePage: http://www.codeplex.com/npoi
 * Contributors:
 *
 * ==============================================================*/

using Npoi.Core.POIFS.Common;
using Npoi.Core.POIFS.Dev;
using Npoi.Core.POIFS.EventFileSystem;
using Npoi.Core.POIFS.Properties;
using Npoi.Core.POIFS.Storage;
using Npoi.Core.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Npoi.Core.POIFS.FileSystem
{
    /// <summary>
    /// This class manages a document in the POIFS filesystem.
    /// @author Marc Johnson (mjohnson at apache dot org)
    /// </summary>
    public class POIFSDocument : BATManaged, BlockWritable, POIFSViewable
    {
        private static DocumentBlock[] EMPTY_BIG_BLOCK_ARRAY = { };
        private static SmallDocumentBlock[] EMPTY_SMALL_BLOCK_ARRAY = { };

        private DocumentProperty _property;
        private int _size;

        private POIFSBigBlockSize _bigBigBlockSize;
        private SmallBlockStore _small_store;

        private BigBlockStore _big_store;

        public POIFSDocument(string name, RawDataBlock[] blocks, int length)
        {
            _size = length;
            if (blocks.Length == 0)
                _bigBigBlockSize = POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
            else
            {
                _bigBigBlockSize = (blocks[0].BigBlockSize == POIFSConstants.SMALLER_BIG_BLOCK_SIZE ?
                    POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS : POIFSConstants.LARGER_BIG_BLOCK_SIZE_DETAILS);
            }

            _big_store = new BigBlockStore(_bigBigBlockSize, ConvertRawBlocksToBigBlocks(blocks));
            _property = new DocumentProperty(name, _size);
            _small_store = new SmallBlockStore(_bigBigBlockSize, EMPTY_SMALL_BLOCK_ARRAY);
            _property.Document = this;
        }

        private static DocumentBlock[] ConvertRawBlocksToBigBlocks(ListManagedBlock[] blocks)
        {
            DocumentBlock[] result = new DocumentBlock[blocks.Length];
            for (int i = 0; i < result.Length; i++)
                result[i] = new DocumentBlock((RawDataBlock)blocks[i]);
            return result;
        }

        private static SmallDocumentBlock[] ConvertRawBlocksToSmallBlocks(ListManagedBlock[] blocks)
        {
            if (blocks is SmallDocumentBlock[])
                return (SmallDocumentBlock[])blocks;
            SmallDocumentBlock[] result = new SmallDocumentBlock[blocks.Length];
            System.Array.Copy(blocks, 0, result, 0, blocks.Length);
            return result;
        }

        public POIFSDocument(string name, SmallDocumentBlock[] blocks, int length)
        {
            _size = length;
            if (blocks.Length == 0)
                _bigBigBlockSize = POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
            else
                _bigBigBlockSize = blocks[0].BigBlockSize;

            _big_store = new BigBlockStore(_bigBigBlockSize, EMPTY_BIG_BLOCK_ARRAY);
            _property = new DocumentProperty(name, _size);
            _small_store = new SmallBlockStore(_bigBigBlockSize, blocks);
            _property.Document = this;
        }

        public POIFSDocument(string name, POIFSBigBlockSize bigBlockSize, ListManagedBlock[] blocks, int length)
        {
            _size = length;
            _bigBigBlockSize = bigBlockSize;
            _property = new DocumentProperty(name, _size);
            _property.Document = this;

            if (Property.IsSmall(_size))
            {
                _big_store = new BigBlockStore(bigBlockSize, EMPTY_BIG_BLOCK_ARRAY);
                _small_store = new SmallBlockStore(bigBlockSize, ConvertRawBlocksToSmallBlocks(blocks));
            }
            else
            {
                _big_store = new BigBlockStore(bigBlockSize, ConvertRawBlocksToBigBlocks(blocks));
                _small_store = new SmallBlockStore(bigBlockSize, EMPTY_SMALL_BLOCK_ARRAY);
            }
        }

        public POIFSDocument(string name, POIFSBigBlockSize bigBlockSize, Stream stream)
        {
            List<DocumentBlock> blocks = new List<DocumentBlock>();

            _size = 0;
            _bigBigBlockSize = bigBlockSize;
            while (true)
            {
                DocumentBlock block = new DocumentBlock(stream, bigBlockSize);
                int blockSize = block.Size;

                if (blockSize > 0)
                {
                    blocks.Add(block);
                    _size += blockSize;
                }
                if (block.PartiallyRead)
                    break;
            }

            DocumentBlock[] bigBlocks = blocks.ToArray();
            _big_store = new BigBlockStore(bigBlockSize, bigBlocks);
            _property = new DocumentProperty(name, _size);
            _property.Document = this;

            if (_property.ShouldUseSmallBlocks)
            {
                _small_store = new SmallBlockStore(bigBlockSize, SmallDocumentBlock.Convert(bigBlockSize, bigBlocks, _size));
                _big_store = new BigBlockStore(bigBlockSize, new DocumentBlock[0]);
            }
            else
            {
                _small_store = new SmallBlockStore(bigBlockSize, EMPTY_SMALL_BLOCK_ARRAY);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="POIFSDocument"/> class.
        /// </summary>
        /// <param name="name">the name of the POIFSDocument</param>
        /// <param name="stream">the InputStream we read data from</param>
        public POIFSDocument(string name, Stream stream)
            : this(name, POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, stream)
        {
        }

        public POIFSDocument(string name, int size, POIFSBigBlockSize bigBlockSize, POIFSDocumentPath path, POIFSWriterListener writer)
        {
            _size = size;
            _bigBigBlockSize = bigBlockSize;
            _property = new DocumentProperty(name, _size);
            _property.Document = this;
            if (_property.ShouldUseSmallBlocks)
            {
                _small_store = new SmallBlockStore(_bigBigBlockSize, path, name, size, writer);
                _big_store = new BigBlockStore(_bigBigBlockSize, EMPTY_BIG_BLOCK_ARRAY);
            }
            else
            {
                _small_store = new SmallBlockStore(_bigBigBlockSize, EMPTY_SMALL_BLOCK_ARRAY);
                _big_store = new BigBlockStore(_bigBigBlockSize, path, name, size, writer);
            }
        }

        public POIFSDocument(string name, int size, POIFSDocumentPath path, POIFSWriterListener writer)
            : this(name, size, POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, path, writer)
        {
        }

        /// <summary>
        /// Constructor from small blocks
        /// </summary>
        /// <param name="name">the name of the POIFSDocument</param>
        /// <param name="blocks">the small blocks making up the POIFSDocument</param>
        /// <param name="length">the actual length of the POIFSDocument</param>
        public POIFSDocument(string name, ListManagedBlock[] blocks, int length)
            : this(name, POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, blocks, length)
        {
        }

        /// <summary>
        /// read data from the internal stores
        /// </summary>
        /// <param name="buffer">the buffer to write to</param>
        /// <param name="offset">the offset into our storage to read from</param>
        public virtual void Read(byte[] buffer, int offset)
        {
            if (_property.ShouldUseSmallBlocks)
            {
                SmallDocumentBlock.Read(_small_store.Blocks, buffer, offset);
            }
            else
            {
                DocumentBlock.Read(_big_store.Blocks, buffer, offset);
            }
        }

        /// <summary>
        /// Writes the blocks.
        /// </summary>
        /// <param name="stream">The stream.</param>
        public virtual void WriteBlocks(Stream stream)
        {
            _big_store.WriteBlocks(stream);
        }

        public DataInputBlock GetDataInputBlock(int offset)
        {
            if (offset >= _size)
            {
                if (offset > _size)
                {
                    throw new Exception("Request for Offset " + offset + " doc size is " + _size);
                }

                return null;
            }

            if (_property.ShouldUseSmallBlocks)
            {
                return SmallDocumentBlock.GetDataInputBlock(_small_store.Blocks, offset);
            }

            return DocumentBlock.GetDataInputBlock(_big_store.Blocks, offset);
        }

        /// <summary>
        /// Gets the number of BigBlock's this instance uses
        /// </summary>
        /// <value>count of BigBlock instances</value>
        public virtual int CountBlocks
        {
            get
            {
                return _big_store.CountBlocks;
            }
        }

        /// <summary>
        /// Gets the document property.
        /// </summary>
        /// <value>The document property.</value>
        public virtual DocumentProperty DocumentProperty
        {
            get
            {
                return _property;
            }
        }

        /// <summary>
        /// Provides a short description of the object to be used when a
        /// POIFSViewable object has not provided its contents.
        /// </summary>
        /// <value><c>true</c> if [prefer array]; otherwise, <c>false</c>.</value>
        public virtual bool PreferArray
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets the short description.
        /// </summary>
        /// <value>The short description.</value>
        public virtual string ShortDescription
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Document: \"").Append(_property.Name).Append("\"");
                builder.Append(" size = ").Append(Size);
                return builder.ToString();
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>The size.</value>
        public virtual int Size
        {
            get
            {
                return _size;
            }
        }

        /// <summary>
        /// Gets the small blocks.
        /// </summary>
        /// <value>The small blocks.</value>
        public virtual BlockWritable[] SmallBlocks
        {
            get
            {
                return _small_store.Blocks;
            }
        }

        /// <summary>
        /// Sets the start block for this instance
        /// </summary>
        /// <value>
        /// index into the array of BigBlock instances making up the the filesystem
        /// </value>
        public virtual int StartBlock
        {
            get
            {
                return _property.StartBlock;
            }
            set
            {
                _property.StartBlock = value;
            }
        }

        /// <summary>
        /// Get an array of objects, some of which may implement POIFSViewable
        /// </summary>
        /// <value>The viewable array.</value>
        public Array ViewableArray
        {
            get
            {
                string message;
                object[] objArray = new object[1];
                try
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        BlockWritable[] blocks = null;
                        if (_big_store.Valid)
                        {
                            blocks = _big_store.Blocks;
                        }
                        else if (_small_store.Valid)
                        {
                            blocks = _small_store.Blocks;
                        }
                        if (blocks != null)
                        {
                            for (int i = 0; i < blocks.Length; i++)
                            {
                                blocks[i].WriteBlocks(stream);
                            }
                            byte[] sourceArray = stream.ToArray();
                            if (sourceArray.Length > _property.Size)
                            {
                                byte[] buffer2 = new byte[_property.Size];
                                Array.Copy(sourceArray, 0, buffer2, 0, buffer2.Length);
                                sourceArray = buffer2;
                            }
                            using (MemoryStream ms = new MemoryStream())
                            {
                                HexDump.Dump(sourceArray, 0L, ms, 0);
                                byte[] buffer = ms.ToArray();
                                char[] destinationArray = new char[(int)ms.Length];
                                Array.Copy(buffer, 0, destinationArray, 0, destinationArray.Length);
                                message = new string(destinationArray);
                            }
                        }
                        else
                        {
                            message = "<NO DATA>";
                        }
                    }
                }
                catch (IOException exception)
                {
                    message = exception.Message;
                }
                objArray[0] = message;
                return objArray;
            }
        }

        /// <summary>
        /// Give viewers a hint as to whether to call ViewableArray or ViewableIterator
        /// </summary>
        /// <value>The viewable iterator.</value>
        public virtual IEnumerator ViewableIterator
        {
            get
            {
                return new List<object>().GetEnumerator();
            }
        }

        public event POIFSWriterEventHandler BeforeWriting;

        protected virtual void OnBeforeWriting(POIFSWriterEventArgs e)
        {
            if (BeforeWriting != null)
            {
                BeforeWriting(this, e);
            }
        }

        internal class SmallBlockStore
        {
            private SmallDocumentBlock[] smallBlocks;
            private POIFSDocumentPath path;
            private string name;
            private int size;
            private POIFSWriterListener writer;
            private POIFSBigBlockSize bigBlockSize;

            internal SmallBlockStore(POIFSBigBlockSize bigBlockSize, SmallDocumentBlock[] blocks)
            {
                this.bigBlockSize = bigBlockSize;
                smallBlocks = (SmallDocumentBlock[])blocks.Clone();
                path = null;
                name = null;
                size = -1;
                writer = null;
            }

            internal SmallBlockStore(POIFSBigBlockSize bigBlockSize, POIFSDocumentPath path, string name, int size, POIFSWriterListener writer)
            {
                this.bigBlockSize = bigBlockSize;
                smallBlocks = new SmallDocumentBlock[0];
                this.path = path;
                this.name = name;
                this.size = size;
                this.writer = writer;
            }

            // internal virtual BlockWritable[] Blocks
            internal virtual SmallDocumentBlock[] Blocks
            {
                get
                {
                    if (Valid && (writer != null))
                    {
                        MemoryStream stream = new MemoryStream(size);
                        DocumentOutputStream dstream = new DocumentOutputStream(stream, size);
                        //OnBeforeWriting(new POIFSWriterEventArgs(dstream, this.path, this.name, this.size));
                        writer.ProcessPOIFSWriterEvent(new POIFSWriterEvent(dstream, path, name, size));
                        smallBlocks = SmallDocumentBlock.Convert(bigBlockSize, stream.ToArray(), size);
                    }
                    return smallBlocks;
                }
            }

            internal virtual bool Valid
            {
                get
                {
                    return ((smallBlocks.Length > 0) || (writer != null));
                }
            }
        }

        internal class BigBlockStore
        {
            private DocumentBlock[] bigBlocks;
            private POIFSDocumentPath path;
            private string name;
            private int size;
            private POIFSWriterListener writer;
            private POIFSBigBlockSize bigBlockSize;

            internal BigBlockStore(POIFSBigBlockSize bigBlockSize, DocumentBlock[] blocks)
            {
                this.bigBlockSize = bigBlockSize;
                bigBlocks = (DocumentBlock[])blocks.Clone();
                path = null;
                name = null;
                size = -1;
                writer = null;
            }

            internal BigBlockStore(POIFSBigBlockSize bigBlockSize, POIFSDocumentPath path, string name, int size, POIFSWriterListener writer)
            {
                this.bigBlockSize = bigBlockSize;
                bigBlocks = new DocumentBlock[0];
                this.path = path;
                this.name = name;
                this.size = size;
                this.writer = writer;
            }

            internal virtual bool Valid
            {
                get
                {
                    return ((bigBlocks.Length > 0) || (writer != null));
                }
            }

            internal virtual DocumentBlock[] Blocks
            {
                get
                {
                    if (Valid && (writer != null))
                    {
                        MemoryStream stream = new MemoryStream(size);
                        DocumentOutputStream stream2 = new DocumentOutputStream(stream, size);
                        //OnBeforeWriting(new POIFSWriterEventArgs(stream2, this.path, this.name, this.size));
                        writer.ProcessPOIFSWriterEvent(new POIFSWriterEvent(stream2, path, name, size));
                        bigBlocks = DocumentBlock.Convert(bigBlockSize, stream.ToArray(), size);
                    }
                    return bigBlocks;
                }
            }

            internal virtual void WriteBlocks(Stream stream)
            {
                if (Valid)
                {
                    if (writer != null)
                    {
                        DocumentOutputStream stream2 = new DocumentOutputStream(stream, size);
                        //OnBeforeWriting(new POIFSWriterEventArgs(stream2, this.path, this.name, this.size));
                        writer.ProcessPOIFSWriterEvent(new POIFSWriterEvent(stream2, path, name, size));
                        stream2.WriteFiller(CountBlocks * POIFSConstants.BIG_BLOCK_SIZE, DocumentBlock.FillByte);
                    }
                    else
                    {
                        for (int i = 0; i < bigBlocks.Length; i++)
                        {
                            bigBlocks[i].WriteBlocks(stream);
                        }
                    }
                }
            }

            internal virtual int CountBlocks
            {
                get
                {
                    int num = 0;
                    if (!Valid)
                    {
                        return num;
                    }
                    if (writer != null)
                    {
                        return (((size + POIFSConstants.BIG_BLOCK_SIZE) - 1) / POIFSConstants.BIG_BLOCK_SIZE);
                    }
                    return bigBlocks.Length;
                }
            }
        }
    }
}