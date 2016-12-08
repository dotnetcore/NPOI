/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for additional information regarding copyright ownership.
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
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Npoi.Core.Util
{
    public class Arrays
    {
  
        public static void Fill<T>(T[] array, T defaultValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = defaultValue;
            }
        }

        /// <summary>
        /// Equals the specified a1.
        /// </summary>
        /// <param name="a1">The a1.</param>
        /// <param name="b1">The b1.</param>
        /// <returns></returns>
        public static bool Equals<T>(T[] a1, T[] b1)
        {
            return Enumerable.SequenceEqual(a1, b1);            
        }

        /// <summary>
        ///  Copies the specified array, truncating or padding with zeros (if
        /// necessary) so the copy has the specified length. This method is temporary
        /// replace for Arrays.copyOf() until we start to require JDK 1.6.
        /// </summary>
        /// <param name="source">the array to be copied</param>
        /// <param name="newLength">the length of the copy to be returned</param>
        /// <returns>a copy of the original array, truncated or padded with zeros to obtain the specified length</returns>
        public static byte[] CopyOf(byte[] source, int newLength)
        {
            byte[] result = new byte[newLength];
            Array.Copy(source, 0, result, 0,
                    Math.Min(source.Length, newLength));
            return result;
        }

        internal static int[] CopyOfRange(int[] original, int from, int to)
        {
            int newLength = to - from;
            if (newLength < 0)
                throw new ArgumentException(from + " > " + to);
            int[] copy = new int[newLength];
            Array.Copy(original, from, copy, 0,
                             Math.Min(original.Length - from, newLength));
            return copy;
        }

        internal static byte[] CopyOfRange(byte[] original, int from, int to)
        {
            int newLength = to - from;
            if (newLength < 0)
                throw new ArgumentException(from + " > " + to);
            byte[] copy = new byte[newLength];
            Array.Copy(original, from, copy, 0,
                             Math.Min(original.Length - from, newLength));
            return copy;
        }

        public static int HashCode(byte[] a)
        {
            if (a == null)
                return 0;

            int result = 1;
            foreach (byte element in a)
                result = 31 * result + element;

            return result;
        }


        public static string ToString(byte[] a)
        {
            if (a == null)
                return "null";
            return "[" + string.Join(",", a) + "]";
        }

        public static string ToString(object[] a)
        {
            if (a == null)
                return "null";
            return "[" + string.Join(",", a) + "]";
        }
    }
}