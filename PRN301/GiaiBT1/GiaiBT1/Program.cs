double a, b;
Console.WriteLine("Giai phuong trinh bac nhat");
while(true)
{
    try
    {
        Console.Write("Input a = ");
        a = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("A phai la so!");
    }
}
while (true)
{
    try
    {
        Console.Write("Input b = ");
        b = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception)
    {
        Console.WriteLine("B phai la so!");
    }
}

if(a==0 && b == 0)
{
    Console.WriteLine("Phuong trnh vo so nghiem");

}
else if(a == 0)
{
    Console.WriteLine("Phuong trinh vo nghiem");
}
else
{
    Console.WriteLine("Phuong trinh co nghiem : " + (-b/a));
}
