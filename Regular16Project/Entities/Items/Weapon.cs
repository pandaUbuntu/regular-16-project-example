using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular16Project.Entities.Items
{
    public class Weapon : BaseItem
    {
        public Weapon(string name, int price, int damage) : base(name, price, damage)
        {
        }

        public int GetDamage() => _value;
    }
}
