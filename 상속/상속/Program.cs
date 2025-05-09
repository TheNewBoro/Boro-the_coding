using System.Xml.Linq;

namespace 상속
{
    internal class Program
    {
        /*
         * 상속 (Inheritance)
         * 
         * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
         * is-a 관계
         */
        static void Main(string[] args)
        {
            Slime slime = new Slime();
            Dragon dragon = new Dragon();

            // 부모클래스 Monster를 상속한 자식클래스를 모두 부모클래스의 기능을 가지고 있음

            slime.Move();
            dragon.Move();

            // 자식클래스는 부모클래스의 기능에 자식만의 기능을 추가하여 구현할 수 있다.

            slime.Split();
            dragon.Breath();

            //업캐스팅 : 자식클래스는 부모클래스 자료형으로 암시적으로 형변환 가능
            Monster monster0 = new Slime();
            Monster monster1 = new Dragon();

            Item[] inventory = new Item[20];
            inventory[0] = new Potion();
            inventory[1] = new Weapon();
        }
    }
    
    
    
    // <상속>
    // 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
    // class 자식 클래스 : 부모클래스

    class Item
    {
        public string name;
    }

    class Potion : Item
    {

    }

    class Weapon : Item
    {

    }

    class Monster
    {
        protected string _name;         // 접근제한자인 protected는 자식까지는 외부참조를 허용해준다.
        public int hp;
        public float speed;


        public void Move()
        {
            Console.WriteLine("{0} 이/가 {1} 속도로 움직입니다.",_name, speed);
        }
    }    

    class Slime : Monster
    {
        public Slime()
        {
            _name = "슬라임";
            hp = 10;
            speed = 3.5f;
        }

        public void Split()
        {
            Console.WriteLine("몸을 두 개로 분열합니다.");
        }

    }

    class Dragon : Monster
    {
        public float speed;
        public Dragon()
        {
            _name = "드래곤";
            hp = 100;
            base.speed = 10f;           // base는 부모클래스를 가르킬 때 쓰는 키워드
            this.speed = 5.5f;          // this는 자식클래스의 고유 매개 변수를 가르킬 때 쓰는 키워드
        }

        public void Breath()
        {
            Console.WriteLine("불을 내뿜습니다.");
        }
    }
   
}
