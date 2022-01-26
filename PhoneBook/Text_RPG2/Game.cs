using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG2
{
    public enum GameMode
    {
        None,
        Lobby,
        Town,
        Field,
    }

    class Game
    {
        private GameMode mode = GameMode.None;

        private Player player = null;
        private Monster monster = null;

        private Random rand = new Random();

        public void Process()
        {
            // TODO
            // Loby, Town, Field로 입장.
            // 최초 게임 시작할때는 기본값으로 Loby로 가도록 한다.

            switch (mode)
            {
                case GameMode.None:
                    break;
                case GameMode.Lobby:
                    ProcessLobby();
                    break;
                case GameMode.Town:
                    ProcessTown();
                    break;
                case GameMode.Field:
                    ProcessField();
                    break;
            }
        }

        private void ProcessLobby()
        {
            Console.Clear();
            Console.WriteLine("\n" + "직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            // TODO
            // 직업을 선택한 뒤 Town으로 이동
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    break;
                case "2":
                    player = new Archer();
                    break;
                case "3":
                    player = new Mage();
                    break;
            }
            mode = GameMode.Town;
        }

        private void ProcessTown()
        {
            Console.Clear();
            Console.WriteLine("\n" + "마을에 입장했습니다!");
            Console.WriteLine("[1] 필드로 가기");
            Console.WriteLine("[2] 로비로 돌아가기");

            // TODO
            // 필드와 로비로 이동
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    mode = GameMode.Field;
                    break;
                case "2":
                    mode = GameMode.Lobby;
                    break;
            }
        }

        private void ProcessField()
        {
            Console.WriteLine("\n" + "필드에 입장했습니다!");
            Console.WriteLine("[1] 끝까지 싸우기");
            Console.WriteLine("[2] 일정 확률로 마을로 돌아가기");

            CreateRandomMonster();

            // TODO
            // 일
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;
            }
        }

        private void CreateRandomMonster()
        {
            // TODO
            // 필드로 이동하면 랜덤한 몬스터를 생성함

            int random = rand.Next(0, 3);
            switch (random)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임이 생성되었습니다");
                    break;
                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크가 생성되었습니다");
                    break;
                case 2:
                    monster = new Skeleton();
                    Console.WriteLine("해골이 생성되었습니다");
                    break;
            }
        }

        private void ProcessFight()
        {
            // TODO
            // 몬스터와 싸우는 함수
            // ProcessField 함수에서 이용함.

            while (true) // 계속 싸움을 반복 해야하니까
            {
                // 플레이어가 먼저 공격한다
                int attack = player.GetAttack();
                monster.OnDamaged(attack);
                if (monster.IsDead())
                {
                   // 몬스터의 hp가 0이되면 플레이어의 승리이다
                    Console.WriteLine("승리했습니다");
                    Console.WriteLine($"남은 체력{player.GetHp()}");
                    break;
                }

                // 플레이어도 몬스터의 데미지를 받는다
                attack = monster.GetAttack();
                player.OnDamaged(attack);
                if (player.IsDead())
                { 
                    // 플레이어의 hp가 0이 되면 Lobby로 간다
                    Console.WriteLine("패배했습니다");
                    Console.WriteLine($"남은 체력{player.GetHp()}");
                    mode = GameMode.Lobby;
                    break;
                }
            }
        }

        private void TryEscape()
        {
            // TODO
            // 일정 확률로 도망치는 함수
            // ProcessField 함수에서 이용함.

            int random = rand.Next(0, 101);
            if(random < 33)
            {
                Console.WriteLine("동망가는데 성공했습니다" + "\n");
                mode = GameMode.Town;
            }
            else // 77
            {
                Console.WriteLine("도망가는데 실패했습니다" + "\n");
                ProcessFight();
            }
        }
    }
}
