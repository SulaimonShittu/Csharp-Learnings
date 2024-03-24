namespace RandomCode;

public class Person
{
    public string name;
    public int age;
}

public class Multipilier
{
    public int Square(int x) => x * x;
    public int Cube(int x) => x * x * x;
    public double Square(double x) => x * x;
}

public class Panda
{
    public string Name;
    public static int Population;

    public Panda(string name)
    {
        Name = name;
        Population++;
    }

    public void Deconstruct(out string name, out int population)
    {
        name = Name;
        population = Population;
    }
}

public class Wine
{
    public decimal Price;
    public int Year;
    public Wine(decimal price) => Price = price;
    public Wine(decimal price, int year) : this(price) => Year = year;
    public Wine(decimal price, DateTime year) : this(price, year.Year) { }
}

public class Animal
{
    public string Name;
    public bool LikesMeat;
    public bool LikesVegs;

    public Animal() {}
    public Animal(string name) => Name = name;
}

public class MarriedHuman
{
    public MarriedHuman Partner;

    public void Marry(MarriedHuman wife)
    {
        Partner = wife;
        wife.Partner = this;
    }
}

public class Stocki
{
    private decimal currentPrice;

    public decimal CurrentPrice
    {
        get { return currentPrice;}
        set { currentPrice = value; }
    }
}

public class Note
{
    private readonly int _pitch;

    public int Pitch
    {
        get => _pitch;
        init => _pitch = value;
    }
}

public class Applicant(string firstName, string lastName)
{
    public string FirstName => firstName;
    public string LastName => lastName;
    public int Age;
    public string Degree;
    public Applicant(string firstName, string lastName, int age, string degree) : this(firstName, lastName)
    {
        Age = age;
        Degree = degree;
    }
}

public class Messeage()
{ 
    static Messeage() => Print();
    public static void Print() => Console.WriteLine("Hello World|");
}

partial class Papi
{
    public partial int Papo();
}

partial class Papi
{
    public partial int Papo() => 2;
}

partial class Papi
{
    partial void Papoa();
}






