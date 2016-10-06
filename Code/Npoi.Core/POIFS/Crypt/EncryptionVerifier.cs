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


using System;
using System.Text;
using System.Xml;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Npoi.Core.POIFS.FileSystem;

namespace Npoi.Core.POIFS.Crypt
{
	public class EncryptionVerifier
	{
		private byte[] salt;
		private byte[] verifier;
		private byte[] verifierHash;
		private byte[] encryptedKey;
		private int verifierHashSize;
		private int spinCount;
		private int algorithm;
		private int cipherMode;

		public EncryptionVerifier(string descriptor)
		{
			XElement keyData = null;
			try
			{
				MemoryStream ms = new MemoryStream(
					EncodingX.Default.GetBytes(descriptor)
					);
				XDocument xml = XDocument.Load(ms);
				var nodes = xml.Descendants(XName.Get("keyEncryptor")).ToList();
				var keyEncryptor = nodes[0].Descendants().ToList();

				for (int i = 0; i < keyEncryptor.Count; i++)
				{
					var node = keyEncryptor[i];
					if (node.Name.Equals("p:encryptedKey"))
					{
						keyData = node;
						break;
					}
				}

				if (keyData == null)
					throw new EncryptedDocumentException("");

				spinCount = Int32.Parse(keyData.Attribute("spinCount").Value);
				verifier = Convert.FromBase64String(keyData.Attribute("encryptedVerifierHashInput").Value);
				salt = Convert.FromBase64String(keyData.Attribute("saltValue").Value);
				encryptedKey = Convert.FromBase64String(keyData.Attribute("encryptedKeyValue").Value);

				int saltSize = Int32.Parse(keyData.Attribute("saltSize").Value);

				if (saltSize != salt.Length)
					throw new EncryptedDocumentException("Invalid salt size");

				verifierHash = Convert.FromBase64String(keyData.Attribute("encryptedVerifierHashValue").Value);

				int blockSize = Int32.Parse(keyData.Attribute("blockSize").Value);

				string alg = keyData.Attribute("cipherAlgorithm").Value;

				if ("AES".Equals(alg))
				{
					if (blockSize == 16)
						algorithm = EncryptionHeader.ALGORITHM_AES_128;
					else if (blockSize == 24)
						algorithm = EncryptionHeader.ALGORITHM_AES_192;
					else if (blockSize == 32)
						algorithm = EncryptionHeader.ALGORITHM_AES_256;
					else
						throw new EncryptedDocumentException("Unsupported block size");
				}
				else
					throw new EncryptedDocumentException("Unsupported cipher");

				string chain = keyData.Attribute("cipherChaining").Value;

				if ("ChainingModeCBC".Equals(chain))
					cipherMode = EncryptionHeader.MODE_CBC;
				else if ("ChainingModeCFB".Equals(chain))
					cipherMode = EncryptionHeader.MODE_CFB;
				else
					throw new EncryptedDocumentException("Unsupported chaining mode");

				verifierHashSize = Int32.Parse(keyData.Attribute("hashSize").Value);

			}
			catch
			{
				throw new EncryptedDocumentException("Unable to parse keyEncryptor");
			}
		}

		public EncryptionVerifier(DocumentInputStream dis, int encryptedLength)
		{
			int saltSize = dis.ReadInt();

			if (saltSize != 16)
				throw new Exception("Salt size != 16 !?");

			salt = new byte[16];
			dis.ReadFully(salt);
			verifier = new byte[16];
			dis.ReadFully(verifier);

			verifierHashSize = dis.ReadInt();

			verifierHash = new byte[encryptedLength];
			dis.ReadFully(verifierHash);

			spinCount = 50000;
			algorithm = EncryptionHeader.ALGORITHM_AES_128;
			cipherMode = EncryptionHeader.MODE_ECB;
			encryptedKey = null;
		}

		public byte[] Salt
		{
			get { return salt; }
		}

		public byte[] Verifier
		{
			get { return verifier; }
		}
		public byte[] VerifierHash
		{
			get
			{
				return verifierHash;
			}
		}
		public int SpinCount
		{
			get { return spinCount; }
		}

		public int CipherMode
		{
			get { return cipherMode; }
		}

		public int Algorithm
		{
			get { return algorithm; }
		}

		public byte[] EncryptedKey
		{
			get { return encryptedKey; }
		}
	}
}


































