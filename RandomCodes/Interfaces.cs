namespace RandomCode;

public interface IEnumerator
{
    bool MoveNext();
    object Current { get; }
    void Reset();
}

internal class Countdown : IEnumerator
{
    private int count = 15;
    public bool MoveNext() => count-- > 0;
    public Object Current => count;
    public void Reset() => count = 15;
}

interface ISquare1
{
    void Square(int x);
}

interface ISquare2
{
    int Square(int x);
}

public class multiplier : ISquare1, ISquare2
{
    
    void ISquare1.Square(int x) => Console.WriteLine(x * x);
    public int Square(int x) => x * x;
}

public struct oo
{
    
}

public class TopLevel
{
    protected class Nested { }
}
public class SubTopLevel : TopLevel
{
    static void Foo() { new Nested(); }
}







