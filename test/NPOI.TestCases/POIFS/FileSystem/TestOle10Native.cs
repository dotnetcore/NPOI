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

namespace TestCases.POIFS.FileSystem
{
    using System;
    using NUnit.Framework;
    using TestCases;
    using System.IO;
    using System.Collections.Generic;
    using NPOI.Util;
    using NPOI.POIFS.FileSystem;



    [TestFixture]
    public class TestOle10Native
    {
        private static POIDataSamples dataSamples = POIDataSamples.GetPOIFSInstance();


        [Test]
        public void TestOleNative()
        {
            POIFSFileSystem fs = new POIFSFileSystem(dataSamples.OpenResourceAsStream("oleObject1.bin"));

            Ole10Native ole = Ole10Native.CreateFromEmbeddedOleObject(fs);

            Assert.AreEqual("File1.svg", ole.Label);
            Assert.AreEqual("D:\\Documents and Settings\\rsc\\My Documents\\file1.svg", ole.Command);
        }       

        void FindOle10(List<Entry> entries, DirectoryNode dn, String path, String filename)
        {
            IEnumerator<Entry> iter = dn.Entries;
            while (iter.MoveNext())
            {
                Entry e = iter.Current;
                if (Ole10Native.OLE10_NATIVE.Equals(e.Name))
                {
                    if (entries != null) entries.Add(e);
                    // System.out.Println(filename+" : "+path);
                }
                else if (e.IsDirectoryEntry)
                {
                    FindOle10(entries, (DirectoryNode)e, path + e.Name + "/", filename);
                }
            }
        }
    }
}