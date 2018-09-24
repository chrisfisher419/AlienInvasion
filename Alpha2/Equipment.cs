using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha2
{
    public class Equipment
    {
        public string AmmoType { get; set; }
        public string WeaponType { get; set; }
        public string FireRate { get; set; }
        public int MaxEffectiveRange { get; set; }
        public int MaxRange { get; set; }
        public string Name { get; set; }

        public Equipment(string name, string ammotype, string weapontype, string firerate, int maxeffectiverange, int maxrange)
        {
            AmmoType = ammotype;
            WeaponType = weapontype;
            FireRate = firerate;
            MaxEffectiveRange = maxeffectiverange;
            MaxRange = maxrange;
            Name = name;
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Pew pew pew!");
        }
        public virtual void Explode()
        {
            Console.WriteLine("Boom!");
        }
        public virtual void PrintStats()
        {
            Console.WriteLine($"{Name} specs: ");
            Console.WriteLine($"Ammo type is {AmmoType}, weapontype is {WeaponType}, firerate is {FireRate}, max effective range is {MaxEffectiveRange}, max range is {MaxRange}");
        }
    }
}
