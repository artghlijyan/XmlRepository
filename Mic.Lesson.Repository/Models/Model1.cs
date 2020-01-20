using System;

namespace Models
{
    public class Model1
    {
        public int Id { get; set; }
        public string ModelName { get; set; }

        public override string ToString()
        {
            return $"ModelId: {Id}\nModelName: {ModelName}";
        }
    }
}