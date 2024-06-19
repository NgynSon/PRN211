using static BookPackage.BookPackage;

namespace BookPackage
{
    class Program
    {
        public static void Main(string[] args)
        {
            BookPackage b1 = new BookPackage(50, 10);
            BookHandler bh = new BookHandler(DisplayMess);
            b1.RegisterBook(bh);
            Console.WriteLine("BookPackage");
            for (int i = 0; i < 4; i++)
            {
                b1.AddBook(15);
            }
            Console.ReadLine();
        }

        static void DisplayMess(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
