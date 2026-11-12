
using Regular16Project.Utils;

namespace Regular16Project.Entities.Characters
{
    public class Enemy : BaseCharacter
    {
        protected int _attack = 0;
        protected int _defense = 0;
        protected int _rewardGold = 0;
        protected int _rewardXp = 0;

        public Enemy(string name, int level) : base(name, level)
        {
            _attack = 25 * level;
            _defense = 10 * level;
            this.HP = new ChangingValue(level * 500);

            _rewardGold = 20 * level;
            _rewardXp = 50 * level;
        }

        public int GetAttack() => _attack;
        public int GetDefense() => _defense;
        public int GetRewardGold() => _rewardGold;
        public int GetRewardXp() => _rewardXp;

    }
}
