using System;
using System.Collections.Generic;
using System.Xml;

namespace BaseRepasitories
{
    public abstract class BaseRepository<TModel> where TModel : class
    {
        protected abstract TModel ToModel(XmlNode xnode);

        public string FileName { get; }

        public BaseRepository(string fileName)
        {
            FileName = fileName;
        }

        public IEnumerable<TModel> AsEnumerable()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(FileName);
            XmlElement xRoot = xDoc.DocumentElement;
            
            foreach (XmlNode xnode in xRoot.ChildNodes)
            {
                yield return ToModel(xnode);
            }
        }

    }
}
