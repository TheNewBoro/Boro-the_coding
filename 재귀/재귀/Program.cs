using System.Runtime.Remoting;

namespace 재귀
{
    internal class Program
    {
        /**************************************************
         * 재귀(Recursion)
         * 
         * 어떠한 것을 정의할 때 자기 자신을 참조하는 것
         * 함수를 정의할 때 자기자신을 이용하여 표현하는 방법
         **************************************************/

        // 폴더 삭제
        public class Folder
        {
            public List<string> files;
            public List<Folder> Children;
        }

        public static void RemoveFolder(Folder folder)
        {

            foreach(Folder child in folder.Children)
            {
                RemoveFolder(child);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
