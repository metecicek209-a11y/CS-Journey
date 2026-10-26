// generics 
// importances can be reprsented with numbers or with text;

public class Importance<T>
{

    public T ImportanceValue;
    public Importance(T _importanceValue)
    {
        this.ImportanceValue = _importanceValue;

    }
    public void ValueWriter()
    {
        Console.WriteLine(ImportanceValue);
    }
}

public class GenericsExample
{
    public void Run()
    {
        Importance<string> Computer = new Importance<string>("Crucial") { };
        Importance<int> Socks = new Importance<int>(50) { };

        Socks.ValueWriter();
        Computer.ValueWriter();
    }
}