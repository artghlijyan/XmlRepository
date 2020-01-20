using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"Data\Model.xml";
            Repositories.ModelRepository modelRepo = new Repositories.ModelRepository(fileName);
            IEnumerable<Models.Model1> modelList = modelRepo.AsEnumerable().ToList();

            foreach (var model in modelList)
            {
                Console.WriteLine(model);
            }
        }
    }
}
