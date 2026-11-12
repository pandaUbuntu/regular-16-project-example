
namespace Regular16Project.Entities.Items
{

    public abstract class BaseItem : BaseEntity
    {
        protected int _price;
        protected int _value;

        public BaseItem(string name, int price, int value) : base(name)
        {
            _price = price;
            _value = value;
        }

        public int GetPrice() => _price;
    }
}
