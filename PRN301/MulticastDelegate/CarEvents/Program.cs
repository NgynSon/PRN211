using CarEvents;

class program
{
    static void Main(string[] args)
    {

        Car c1 = new Car(10, 90, "Mercedes");
        

        Console.WriteLine("******** Speed up ********");
        for (int i = 0; i < 3; i++)
        {
            c1.Accelerate(20);
        }
        Console.ReadLine();

        static void display1(string msg)
        {
            Console.WriteLine("\n*** Message From Car Object ***");
            Console.WriteLine($"=> {msg}");
            Console.WriteLine("******************************\n");
        }
        static void display2(string msg)
        {
            Console.WriteLine($"=> {msg.ToUpper()}");
        }

        static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            if(sender is Car c1)
            {
                Console.WriteLine($"Critical Message from {c1.CarName}");
            }
        }

        static void CarExploded(object sender, CarEventArgs e)
        {
            Console.WriteLine($"{sender} says: {e.msg}");
        }
    }
}