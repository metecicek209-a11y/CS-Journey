
public class AbstractClassExample
{
    public void Run()
    {


        PurpleGlass Catedral = new PurpleGlass("Mete", 500);
        BlueGlass Icy = new BlueGlass("famouse", 2000);
        CheckTransparent(Icy);
        Console.WriteLine("");
        CheckTransparent(Catedral);
        CheckBreakable(Catedral);

        void CheckTransparent(Glass sample)
        {
            if (sample.PassLight())
            {
                Console.WriteLine("It allows the light pass through");

            }
            else
            {
                Console.WriteLine("It does not allow the light pass through");
            }
        }
        void CheckBreakable(IBreakable sample)
        {
            if (sample.Break())
            {
                Console.WriteLine($"{sample}It can be broken");
            }
            else
            {
                Console.WriteLine($"{sample} cant be broken");
            }
        }
    }
}
public abstract class Glass
{

    public int Price { get; set; }
    public string Brand { get; set; }

    public Glass(string _brand, int _price)
    {
        Price = _price;
        Brand = _brand;
    }
    public abstract bool PassLight();
}

public interface IBreakable
{
    public bool Break();
}
public class BlueGlass : Glass, IBreakable
{

    public BlueGlass(string _brand, int _price) : base(_brand, _price) { }
    public override bool PassLight()
    {
        return true;
    }
    public bool Break()
    {
        return true;
    }

}
// her sinif yalnizca bir miras alabilir ama istedigin kadar interface verebilirsin 
public class PurpleGlass : Glass, IBreakable
{

    public PurpleGlass(string _brand, int _price) : base(_brand, _price) { }
    public override bool PassLight()
    {
        return false;
    }
    public bool Break()
    {
        return false;
    }


}