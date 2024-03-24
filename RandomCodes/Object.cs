

namespace RandomCode;

public class Stack(int length)
{
    private int count;
    private Object[] data = new object[length];
    public Object Pop() => data[--count];
    public void Append(Object x) => data[count++] = x;
}