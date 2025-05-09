namespace 빌더_패턴
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        

    }

    public class MonsterBulider
    {
        public string name;
        public string weapon;
        public string armor;

        public MonsterBuilder()
        {
            name = "몬스터";
            weapon = "기본무기";
            armor = "기본 갑옷";
        }

        
        
    }
    public class Monster
    {
        public string name;
        public string weapon;
        public string armor;
    }
}
