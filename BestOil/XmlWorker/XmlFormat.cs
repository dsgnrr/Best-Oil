using System;
using System.Xml.Serialization;
using System.IO;

namespace XmlWorker
{
    class XmlFormat:IFile
    {
        FileStream stream;
        XmlSerializer serializer;
        public XmlFormat()
        {
            stream = null;
            serializer = null;
        }
        public void Save<T>(T obj,string path)
        {
            stream = new FileStream(path, FileMode.Create);
            serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, obj);
            stream.Close();
        }
        public T Load<T>(string path)
        {
            T obj;
            if (File.Exists(path))
            {
                stream = new FileStream(path, FileMode.Open);
                serializer = new XmlSerializer(typeof(T));
                obj = (T)serializer.Deserialize(stream);
                stream.Close();
                return obj;
            }
            else return default(T);
        }
    }
}
