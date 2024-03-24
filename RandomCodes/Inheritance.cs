namespace RandomCode;


public abstract class Asset
{
    public string Name;
    public virtual decimal NetValue { get; }
}

public class Stock : Asset
{
    public long SharesOwned;
    public decimal CurrentPrice;
    public override decimal NetValue => SharesOwned * CurrentPrice;
}

public class House : Asset
{
    public decimal Mortgage;
}


