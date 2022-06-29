Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c) 
{
    Console.Write("max = " + a);
}
else
{
    if (b > c)
    {
        Console.Write("max = " + b);
    }
    else
    {
        Console.Write("max = " + c);
    }    
}
