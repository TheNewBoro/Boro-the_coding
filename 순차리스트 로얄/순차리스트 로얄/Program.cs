using System.Numerics;

namespace 순차리스트_로얄
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);            //맨 뒤에 추가하기 0(1)
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Insert(3, 999);    //중간에 끼워넣기 0(n)


            //삭제
            list.Remove(999);       //똑같은거 찾아서 삭제하기 : 0(n)
            list.RemoveAt(1);       //특정 위치에 있는 요소 지우기 0(n)
            list.Remove(555);       //찾아서 지울 때 없으면 무시 (반환은 false)

            //접근 = 0(1)
            list[1] = 222;          //리스트는 배열로 구현되어 있기 떄문에 인덱스를 통한 접근이 가능하다.
            int value = list[1];

            //탐색
            int index = list.IndexOf(333);              //찾아서 인덱스 가져오기
            bool contain = list.Contains(333);          //찾아서 있으면 true, 없으면 false

            int count = list.Count;               //리스트에 소유중인 갯수

        }
    }
}
