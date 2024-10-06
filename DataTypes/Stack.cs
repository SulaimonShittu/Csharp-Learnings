namespace DataTypes;

public class Stack<T> {
    private T[] list = new T[100];
    private int num;
    public T Current => list[num - 1];

    public void Push(T value)
    {
        list[num++] = value;
    }

    public T Pop()
    {
        return list[--num];
    }
}