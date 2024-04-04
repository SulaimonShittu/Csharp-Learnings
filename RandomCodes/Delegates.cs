public delegate int Transformer(int value);

public class Converter
{
    public double ConvertFromMilliToDeci(double value) => value / 10;
}

public delegate double ConvertorDel(double value);
