namespace 스택
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();


            // 추가
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            //꺼내기
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());

            if(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //stack.TryPop(out int pop);
            //stack.TryPeek(out int peek);

            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);

            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
