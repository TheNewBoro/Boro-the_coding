using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_M.Scenes
{
    public abstract class Scene
    {

        protected ConsoleKey input;
        public abstract void Render();
        public abstract void Choice();
        public void Input()
            {
                input = Console.ReadKey(true).Key;
            }
        public abstract void Result();
        public abstract void Standby();
        public abstract void Next();
    }
}
