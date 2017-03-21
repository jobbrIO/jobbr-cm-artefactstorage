using System.IO;

namespace Jobbr.ComponentModel.ArtefactStorage
{
    public class JobbrArtefact
    {
        public string FileName { get; set; }

        public string MimeType { get; set; }
        
        public long Size { get; set; }

        public Stream Data { get; set; }
    }
}