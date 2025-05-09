namespace 클래스와_Static
{
    internal class Program
    {
        //시스템 설정 : 불륨 크기(0~100), 해상도, 화면 밝기
        static void Swap(ref int left, ref int right)
        {
            int temp = left;       //이 함수 시작시 나타났다가 함수가 끝날 떄 사라지는 원리를 가진다. 중괄호 밖에서는 사용이 불가능하다.
            left = right;
            right = temp;
        }

        class Player
        {
            public void Attack()
            {
                Console.WriteLine("공격 사운드 재생!");
            }
        }

        class Monster
        {
            public void TakeDamage(int damage)
            {
                Console.WriteLine(" 피격음 재생!");
            }
        }
        static void Main(string[] args)
        {
            
            Player player = new Player();
            Monster monster = new Monster();
            player.Attack();
            monster.TakeDamage(100);
        }
        
    }
}