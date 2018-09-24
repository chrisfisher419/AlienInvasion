using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Platoon
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Platoon(int count, string name, string type)
        {
            Count = count;
            Name = name;
            Type = type;
        }
    }
}
