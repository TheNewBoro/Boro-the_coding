using System.Security.Cryptography.X509Certificates;

namespace _21.이벤트
{
    internal class Program
    {
        public class Player
        {
            public int hp = 100;

            public Action<int> OnHPChanged;
            public Action OnDied;

            public void SetHP(int hp)
            {
                this.hp = hp;

                if(OnHPChanged != null)
                {
                    OnHPChanged(hp);
                }
            }
            
            public void Die()
            {
                Console.WriteLine("플레이어가 쓰러집니다.");

                if (OnDied != null)
                {
                    OnDied();
                }
            }
        }

        public class HPBar
        {
            public void SetHpBar(int hp)
            {
                Console.WriteLine("현재 플레이어의 체력은 {0}입니다.",hp);
            }
        }

        public class Monster
        {
            public void Stop()
            {
                Console.WriteLine("몬스터가 더 이상 플레이어를 쫓아가지 않습니다.");
            }
        }

        public class Game
        {
            public void GameOver()
            {
                Console.WriteLine("게임오버 UI를 띄웁니다.");
            }
        }

        public class SFX
        {
            public void DieSound()
            {
                Console.WriteLine("슬픈 음악이 재생됩니다.");
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            HPBar playerHpBar = new HPBar();

            playerHpBar.OnHPChanged += playerHpBar.SetHpBar;

            player.SetHP(100);
            //Monster monster1 = new Monster();
            //Monster monster2 = new Monster();
            //Game game = new Game();
            //SFX sfx = new SFX();

            //player.OnDied += monster1.Stop;
            //player.OnDied += monster2.Stop;
            //player.OnDied += game.GameOver;
            //player.OnDied += sfx.DieSound;




            //player.OnDied -= monster1.Stop;

            //player.Die();

        }
    }
}
