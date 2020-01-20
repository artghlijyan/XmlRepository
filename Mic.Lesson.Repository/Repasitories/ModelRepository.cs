using System;
using System.Collections.Generic;
using System.Xml;

namespace Repositories
{
    public class ModelRepository : BaseRepasitories.BaseRepository<Models.Model1>
    {
        public ModelRepository(string fileName) : base(fileName) { }

        protected override Models.Model1 ToModel(XmlNode xnode)
        {
            Models.Model1 model = new Models.Model1();
            foreach (XmlNode xChild in xnode.ChildNodes)
            {
                switch (xChild.Name)
                {
                    case Keyword.Keywords.modelId:
                        int id = 0;
                        if (int.TryParse(xChild.InnerText, out id))
                        {
                            model.Id = id;
                        }
                        break;

                    case Keyword.Keywords.modelName:
                        model.ModelName = xChild.InnerText;
                        break;
                }
            }
            return model;
        }
    }
}