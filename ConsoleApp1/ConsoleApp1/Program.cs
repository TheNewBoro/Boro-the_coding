namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요. 이름을 말해주시겠어요?");
            string s = Console.ReadLine();
            Console.WriteLine($"당신의 이름은 {s}군요!");
            Console.WriteLine("안녕하세요 {0}님!", s);
        }
    }
}
