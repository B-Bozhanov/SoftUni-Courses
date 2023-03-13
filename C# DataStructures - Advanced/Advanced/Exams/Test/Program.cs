
string a = "50000000000123456789";
string b = "50000000000123456789";

int a1 = a.GetHashCode();
int b1 = b.GetHashCode();

var A1 = new A1();
var B1 = new B1();

int aa1 = A1.GetHashCode();
int nn1 = B1.GetHashCode();



Console.WriteLine();

public class A1
{
    private int b = 123456789;
    public int A()
    {
        return 0;
    }
}


public class B1
{
    private int b = 123456789;
    public int A()
    {
        return 0;
    }
}

