using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_M.Scenes
{
    internal class TitleScene : Scene
    {
        
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료");
        }

        public override void Input()
        {
            
        }

        public override void Next()
        {
            //  TODO : 다음 씬으로 전환 구현 필요
        }

        public override void Render()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("              Eternal Looping            ");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }

        public override void Result() { }

        public override void Standby() { }
    }
}
