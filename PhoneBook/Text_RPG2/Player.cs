using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG2
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }
    class Player : Creature // Creature : 할아버지 / Plyaer : 부모님 / Knight, Archer, Mage : 자식
    {
        protected PlayerType type = PlayerType.None;

        // Player player = new Player();
        // Main함수에서 Player를 new하는데 무슨 타입인지도 모르는게 만들어진다
        // 그래서 Player을 생성할 때에는 꼭 Type을 정해줘야 하도록 해보자

        // Player player = new Player(PlayerType.Knight);
        // 접근한정자는 protected로 하여 Player에게 직접접근 하는 것이 아닌
        // Type에 접근하도록 하여 간접적으로 Player을 만들어주자
        protected Player(PlayerType type) : base(CreatureType.Player)
        {
            // 이렇게 만들었다는 것을 우리가 인자를 가진 버전을 만드는 순간
            // 아무것도 인자가 없던 버전은 안 만드는 이상 사용할 수 가 없다
            this.type = type;
        }

        public PlayerType GetPlayerType() { return type; }
    }

    // 각각의 클래스들은 Player을 상속 받는다 왜? Player 안 에 있는 것을 사용하기 위해서
    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            SetInfo(100, 10);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer)
        {
            SetInfo(75, 12);
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(50, 15);
        }
    }
}
