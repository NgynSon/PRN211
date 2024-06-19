using MulticastDelegate;

class program
{
    static void Main(string[] args)
    {

        Car c1 = new Car(40, 90, "Mercedes");
        c1.RegisterCarEngine(new Car.CarEngineHandler(display1));

        Console.WriteLine("******** Speed up ********");
        for (int i = 0; i < 3; i++)
        {
            c1.Accelerate(20);
        }Console.ReadLine();

        static void display1(string msg)
        {
            Console.WriteLine("\n*** Message From Car Object ***");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("******************************\n");
        }
        static void display2(string msg) {
            Console.WriteLine($"=> {msg.ToUpper()}");
        }
    }
}
