
namespace Regular16Project.Entities.Items
{
    public class Armor : BaseItem
    {
        public Armor(string name, int price, int defence) : base(name, price, defence)
        {
        }

        public int GetDefence() => _value;
    }
}
