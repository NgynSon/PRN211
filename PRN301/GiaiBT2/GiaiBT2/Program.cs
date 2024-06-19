Console.WriteLine("Giai phuong trinh bac 2");

double a, b, c;

while (true)
{
    try
    {
        Console.Write("Nhap A: ");
        a = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {

        Console.WriteLine("A phai la so!");
    }
} while (true)
{
    try
    {
        Console.Write("Nhap B: ");
        b = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {

        Console.WriteLine("B phai la so!");
    }
}
while (true)
{
    try
    {
        Console.Write("Nhap C: ");
        c = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {

        Console.WriteLine("C phai la so!");
    }
}

    double delta = b * b - 4 * a * c;

    if (delta > 0)
    {
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}");
    }
    else if (delta == 0)
    {
        double xkep = -b / (2 * a);
        Console.WriteLine($"Phuong trinh co nghiem kep: x = {xkep}");
    }
    else
    {
        Console.WriteLine("Phuong trinh vo nghiem.");
    }


