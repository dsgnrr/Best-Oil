using System;

namespace XmlWorker
{
    public interface IFile
    {
        void Save<T>(T obj,string path);
        T Load<T>(string path);
    }
}
