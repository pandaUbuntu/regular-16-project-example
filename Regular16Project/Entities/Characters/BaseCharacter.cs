using Regular16Project.Utils;

namespace Regular16Project.Entities.Characters
{
    public abstract class BaseCharacter : BaseEntity
    {
        protected int _level;
        public ChangingValue HP;

        public BaseCharacter(string name, int level) : base(name)
        {
            this._level = level;
        }
    }
}
