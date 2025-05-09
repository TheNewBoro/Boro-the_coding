namespace 인터페이스_Interface_
{
    internal class Program
    {
        /***********************************************************************
         * 인터페이스 (interface)
         * 
         * 인터페이스는 멤버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구형해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
         * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함
         ***********************************************************************/
        public class Enterance
        {
            public void join() { }
        }

        public class Chest
        {

        }
        public class Player
        {

            public void Enter(Enterance enterance)
            {
                enterance.join();
            }
        }

        public class Dungeon : Enterance
        {

        }
        public class Door : Enterance
        {

        }

        public class Check
        {

        }



        static void Main(string[] args)
        {
            Player player = new Player();
            Door door = new Door();
            Dungeon dungeon = new Dungeon();
        }
    }
}
