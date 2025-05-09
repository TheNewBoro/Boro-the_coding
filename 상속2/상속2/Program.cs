namespace 상속2
{
    internal class Program
    {
        class Car
        {
            public float speed;
            public Car()
            {
                Console.WriteLine("부모 생산자");
            }
        }

        class Truck : Car
        {
            public Truck()
            {
                Console.WriteLine("자식 생성자");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
