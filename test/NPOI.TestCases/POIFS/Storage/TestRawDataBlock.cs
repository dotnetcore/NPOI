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

using System;
using System.IO;
using System.Collections;

using NUnit.Framework;
using NPOI.POIFS.Storage;
using NPOI.Util;
using NPOI.POIFS.FileSystem;
using TestCases.Util;
using TestCases.POIFS.FileSystem;

namespace TestCases.POIFS.Storage
{
    /**
     * Class to Test RawDataBlock functionality
     *
     * @author Marc Johnson
     */
    [TestFixture]
    public class TestRawDataBlock
    {
        public TestRawDataBlock()
        {

        }

        /**
         * Test creating a normal RawDataBlock
         *
         * @exception IOException
         */
        [Test]
        public void TestNormalConstructor()
        {
            byte[] data = new byte[512];

            for (int j = 0; j < 512; j++)
            {
                data[j] = (byte)j;
            }
            RawDataBlock block = new RawDataBlock(new MemoryStream(data));

            Assert.IsTrue(!block.EOF, "Should not be at EOF");
            byte[] out_data = block.Data;

            Assert.AreEqual(data.Length, out_data.Length, "Should be same Length");
            for (int j = 0; j < 512; j++)
            {
                Assert.AreEqual(data[j],
                             out_data[j], "Should be same value at offset " + j);
            }
        }

        /**
         * Test creating an empty RawDataBlock
         *
         * @exception IOException
         */
        [Test]
        public void TestEmptyConstructor()
        {
            byte[] data = new byte[0];
            RawDataBlock block = new RawDataBlock(new MemoryStream(data));

            Assert.IsTrue(block.EOF, "Should be at EOF");
            try
            {
                byte[] a = block.Data;
            }
            catch (IOException )
            {

                // as expected
            }
        }      
    }
}