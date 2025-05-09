using System.Reflection.Emit;

namespace 디자인패턴
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 스테이지 1-1
            MonsterFactory monsterFactory = new MonsterFactory();
            // 1. 처음 맵을 만들어 졌을 때 -> 몬스터 3마리
            for (int i = 0; i< 3; i++)
            {
                Monster monster = new Monster("슬라임", 1);
            }

            // 2. 다음 장소로 이동했을 때 -> 몬스터 5마리
            Monster monster1 = monsterFactory.Create("슬라임");
            Monster monster2 = monsterFactory.Create("슬라임");
            Monster monster3 = monsterFactory.Create("슬라임");
            Monster monster4 = monsterFactory.Create("슬라임");
            Monster monster5 = monsterFactory.Create("슬라임");

            // 3. 보스룸 입장하면 -> 몬스터 2마리
            Monster bossMonster = monsterFactory.Create("오크족장");
            Monster subMonster1 = monsterFactory.Create("고블린");
            Monster subMonster2 = monsterFactory.Create("고블린");
        }
    }

    public class MonsterFactory
    {
        public Monster Create(string name)
        {
            switch(name)
            {
                case "슬라임": return new Monster("슬라임", 1);
                case "고블린": return new Monster("고블린", 3);
                case "오크족장": return new Monster("오크족장", 10);
            }
            
            
            return null;
        }
    }

    public class Monster
    {
        public string name;
        public int level;

        public Monster(string name, int level)
        {
            this.name = name;
            this.level = level;

            if(name == "고블린")
            {
                this.level = 3;
            }
        }
    }
}
