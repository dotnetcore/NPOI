using ICSharpCode.SharpZipLib.Zip;
using System.Collections;
using System.IO;

namespace Npoi.Core.OpenXml4Net.Util
{
    /**
     * A ZipEntrySource wrapper around a ZipFile.
     * Should be as low in terms of memory as a
     *  normal ZipFile implementation is.
     */

    public class ZipFileZipEntrySource : ZipEntrySource
    {
        private ZipFile zipArchive;

        public ZipFileZipEntrySource(ZipFile zipFile)
        {
            this.zipArchive = zipFile;
        }

        public void Close()
        {
            if (zipArchive != null)
            {
                zipArchive.Close();
            }
        }

        public IEnumerator Entries
        {
            get
            {
                if (zipArchive == null)
                    throw new InvalidDataException("Zip File is closed");
                return zipArchive.GetEnumerator();
            }
        }

        public Stream GetInputStream(ZipEntry entry)
        {
            if (zipArchive == null)
                throw new InvalidDataException("Zip File is closed");
            Stream s = zipArchive.GetInputStream(entry);
            return s;
        }
    }
}