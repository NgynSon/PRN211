namespace PRN211_Onclass_SP24
{
    internal class Program
    {
        /*public class Car
        {
            public string Make;
            public string Model;
            public void Driving()
            {
                Console.WriteLine("Driving.");
            }
            public void Accelerating() { Console.WriteLine("Accelerating"); }
            public void Braking() { Console.WriteLine("Braking"); }
        }*/
        /*class Customer
        {
            private int Id;
            //Full properties
            public int CustomerID
            {
                get
                {
                    return Id;
                }
                set
                {
                    Id = value;
                }
            }
            //Automatic properties
            public string CustomerName { get; set; } = "New customer";
            public void Print()
            {
                Console.WriteLine($"ID: {CustomerID}, Name: {CustomerName}");
            }
        }*/
        class Employee
        {
            private int id;
            private string name;
            //Constructor
            public Employee(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
            //Properties
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
        }
        class Manager : Employee
        {
            private string email;
            public Manager(int id, string name, string email) : base(id, name)
            {
                this.Email = email;
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Email: {Email}";
            }
        }
        static void Main(string[] args)
        {
            /*Customer obj = new Customer();
            obj.CustomerID = 1000;
            Console.WriteLine($"ID:{obj.CustomerID}, Name: {obj.CustomerName}");
            obj.CustomerID = 2000;
            obj.CustomerName = "Jack";
            obj.Print();
            Console.ReadLine();*/
            Manager jack = new Manager(1000, "Jack", "Jack@gmail.com");
            Console.WriteLine(jack);
        }
    }
}
