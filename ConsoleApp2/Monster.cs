using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum MonsterType // enum은 하나의 타입을 만들어내는거라 public internal빼가 불가능
    {
        None = 0,
        Slime = 1,
        Oke = 2,
        Dragon = 3
    }
    class Monster : Creature
    {
        protected MonsterType mjop = MonsterType.None; // 초기값넣는이유는 오류및 직관성때문에
        protected Monster(MonsterType type) : base(Chose.Monster) 
        { 
            mjop = type;
        }

        public MonsterType GetMonsterType() { return mjop; } // return시 반환하는 것이 잇어야함 void는 반환 x임
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            Setinfo(10,10);
        }
    }

    class Oke : Monster
    {
        public Oke() : base(MonsterType.Oke)
        {
            Setinfo(50, 50);
        }
    }

    class Dragon : Monster
    {
        public Dragon() : base(MonsterType.Dragon)
        {
            Setinfo(100, 100);
        }
    }
}
