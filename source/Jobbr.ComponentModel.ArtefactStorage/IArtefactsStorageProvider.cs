using System.Collections.Generic;
using System.IO;
using Jobbr.ComponentModel.ArtefactStorage.Model;

namespace Jobbr.ComponentModel.ArtefactStorage
{
    public interface IArtefactsStorageProvider
    {
        void Save(string container, string fileName, Stream content);

        Stream Load(string container, string fileName);

        List<JobbrArtefact> GetArtefacts(string container);
    }
}
