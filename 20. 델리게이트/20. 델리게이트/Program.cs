namespace _20._델리게이트
{
        


        // <델리게이트 정의>
        // delegate 반환형 델리게이트이름 (매개변수들);
        public delegate float DelegateMethod1(float left, float right);     //다른 구조체, 함수들처럼 설계도를 만들어주면 된다.
        public delegate void DelegateMethod2(string str);
    internal class Program
    {
        public static float plus(float left, float right)
        {
            return left + right;
        }

        public static float Minus(float left, float right)
        {
            return left - right;
        }
        public static float Multi(float left, float right)
        {
            return left * right;
        }
        public static float Divide(float left, float right)
        {
            return left / right;
        }

        public static void Message(string message)
        {
            Console.WriteLine("메세지로 {0}를 전송합니다.", message);
        }

        public class File
        {
         
            public void Save()
            {
                Console.WriteLine("저장하기 합니다.");
            }

            public void Load()
            {
                Console.WriteLine("불러오기 합니다.");
            }
        }

        public class Button
        {
            public delegate void ClickListener();
            public ClickListener clickListener;
            public void Click()
            {
                if(clickListener != null)
                {
                    clickListener();
                }

            }
        }

        static void Main(string[] args)
        {
            DelegateMethod1 delegate1 = plus;
            DelegateMethod2 delegate2 = Message;      //이렇게 정의해줘야만 사용이 가능하다.


            // <델리게이트 사용>
            //변환형과 매개변수가 일치하는 함수를 델리게이트 변수에 할당
            //델리게이트 변수에 참조한 함수를 대리자를 통해 호출가능
            delegate1 = plus;
            Console.WriteLine(delegate1(20f, 10f));     // Plus(20f, 10f)
            delegate1 = Minus;
            Console.WriteLine(delegate1(20f, 10f));     // Minus(20f, 10f)
            delegate1 = Multi;
            Console.WriteLine(delegate1(20f, 10f));     // Multi(20f, 10f)
            delegate1 = Divide;
            Console.WriteLine(delegate1(20f, 10f));     // Divide(20f, 10f)

            File file = new File();

            Button saveButton = new Button();
            saveButton.clickListener = file.Save;

            Button loadButton = new Button();
            loadButton.clickListener = file.Load();

            saveButton.Click();     //저장하기
            loadButton.Click();     //불러오기
        }
    }
}
