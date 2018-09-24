using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class M203 : Equipment
    {
        public M203(string name, string ammotype, string weapontype, string firerate, int maxeffectiverange, int maxrange) : base(name, ammotype, weapontype, firerate, maxeffectiverange, maxrange)
        {

        }
    }
}
