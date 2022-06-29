// See https://aka.ms/new-console-template for more information

var fact = Fact(10);
Console.WriteLine(fact);
Console.ReadLine();

//Watch the call stack
static int Fact(int x)
{
    Console.WriteLine(x);
    if (x.Equals(1))
    {
        return 1;
    }
    else
    {
        return x * Fact(x - 1);
    }
}
