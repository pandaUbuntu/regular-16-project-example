
namespace Regular16Project.Entities
{
    public abstract class BaseEntity
    {
        public readonly int Id;
        private static int _nextId = 1;
        protected string _name;

        public BaseEntity(string name)
        {
            Id = _nextId;
            _nextId++;
            _name = name;
        }

        public string GetName() => _name;
    }
}
