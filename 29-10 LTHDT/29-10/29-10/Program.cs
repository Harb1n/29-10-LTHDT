class A
{
    protected int m_a;
    public A()
    {
        m_a = 0;
    }
    public A(int a)
    {
        m_a = a;
    }
    public int getA()
    {
        return m_a;
    }

    public void setA(int a)
    {
        m_a = a;
    }
}
class B : A
{

    private int m_b;
    public B():base()
    {
        m_b = 0;
    }
    public B(int a,int b): base(a) // Gọi phương thức tạo lập của lớp a để gán a.
    {
        m_b = b;

    }
    public void setAB(int a,int b)
    {
        m_b = b;
        m_a = a;
    }
    public int getB(int b)
    {
        return m_b;

    }
    public void setB(int b)
    {
        m_b = b;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        B x = new B();
        x.setAB(2, 3);
        Console.WriteLine("A={0}: \tB={1}" ,x.getA(),x.getB());

    }

}