namespace RandomCode;

public class Stack<T>
{
    private int count = 0;
    private T[] data = new T[100];
    public void Push(T x) => data[count++] = x;
    public T Pop() => data[--count];
}

class MyClass<T>
{
    public T sra
    {
        get;
    }
}