class A
{
    public int m;
}
class B : A
{
    public int m;
}
internal class Program
{
    private static void Main(string[] args)
    {
        B x = new B();
        x.m = 2;
        A y = x;
        y.m = 3;

        Console.WriteLine("a = {0} \tB = {1}", y.m, x.m);

    }
}