namespace 객체지향과_클래스
{
    internal class Program
    {

        //캡슐화
        //접근제한자는 외부로부터의 간섭을 제한한다. 그 함수에 있는 변수값을 다른 함수가 간섭하여 값을 변경하게 만든다. 즉 읽기 전용으로 만든다.
        class Human
        {
            string name;
            //public은 외부에서 접근 가능 
            //private는 외부에서 접근 제한       <-접근제한자
            public int age;
            public float height;
            // 외부 허용 X : 심장박동           <-접근 제한자
            // 외부 허용 O : 나이, 키 등
        }
        class Player
        {

            // 변수 (명사) : 정보
            int level;
            int attackPoint;


            // 함수(동사) : 행동
            void Attack(Monster monster)
            {
                monster.Attacked(Monster monster);
            }
        }

        class Monster
        {
            int hp = 100;

            void Attacked(int attackPoint)
                {
                hp -= attackPoint;


                }
        }
        // 설계도를 토대로 구성품을 만들어준다.
        static void Main(string[] args)
        {
            Player player = new Player();       //new를 통해서 인스턴스를 만들어 준다. 즉 실체화 시켜준다. 위에 있는 클래스가 붕어빵 틀, new가 들어가면서 실체화되어 만들어진 것이 붕어빵, 즉 인스턴스
            Monster monter = new Monster();

            //플레이어가 몬스터 공격하기
            // 1. 플레이어 공격력 설정
            // 2. 몬스터 체력 설정
            // 3. 플레이어 공격력 만큼 몬스터 체력 감소

            int playerAP = 10;
            int monster = 100;
            int monsterHp = -playerAP;

            
        }
    }
}
