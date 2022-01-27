using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG2
{
    public enum CreatureType
    {
        None = 0,
        Player = 1,
        Monster = 2,
    }

    class Creature
    {
        CreatureType type = CreatureType.None;

        // 나중에 상속을 받을 것 이니 protected을 사용하자
        protected int hp = 0;
        protected int attack = 0;

        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        // 외부에서 hp, attack을 넣어주도록 해보자
        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }

        // hp와 attack을 protected로 만들어 주었기에 외부에서 볼 수 있도록 Get을 붙여서 만들어줌
        public int GetHp() { return hp; }
        public int GetAttack() { return attack; }

        public bool IsDead() { return hp <= 0; }
        public void OnDamaged(int damage) // ref을 쓰던 안 쓰던 상관없지만, 쓰는 것이 더 좋을 수도 있다
        {
            hp -= damage;
            if (hp < 0)
                hp = 0;
        }
    }
}
