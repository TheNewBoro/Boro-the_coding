namespace 실습
{
    internal class Program
    {
        public abstract class Pocketmon
        {
            public string name;
            public int hp;
            public int def;
           
        }
        
        public class Pikachu : Pocketmon
        {
            name = "Pikachu"
            hp = 34;
            def = 2;
            atk = 5;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
