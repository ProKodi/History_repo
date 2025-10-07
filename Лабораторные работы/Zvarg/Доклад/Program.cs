using System.Runtime.CompilerServices;

class Country
{
    public static Country instance;
    public string goverment { get; private set; }
    private Country(string name)
    { 
        goverment = name;
    }
    public static Country GetGoverment (string goverment)
    {
        if (instance == null)
        {
            instance = new Country(goverment);
        }
        return instance;
    }
}

class Program
{
    static void Main ()
    {
        Country goverm1 = Country.GetGoverment("Правительство Аргентины");
        Country goverm2 = Country.GetGoverment("Правительство ЮАР");
        System.Console.WriteLine(goverm1.goverment);
        System.Console.WriteLine(goverm2.goverment);
    }
}