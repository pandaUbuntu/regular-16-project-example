using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular16Project.Entities.Items
{
    public class Sword : Weapon
    {
        protected int _criticalChance;
        public Sword(string name, int price, int damage, int _criticalChance) : base(name, price, damage)
        {
            this._criticalChance = _criticalChance;
        }
    }
}
