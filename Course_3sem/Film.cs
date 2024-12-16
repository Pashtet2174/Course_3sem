namespace Course_3sem;

public class Film
{
    public string Name;
    public string Category;
    public string Scriptwriter;
    public string ProductionDirector;
    public string ProductionCompany;
    public int ReleaseYear;
    public decimal Cost;
    public Vendor Vendor;


    public Film(string name, string category, string scriptwriter, string productionDirector, string productionCompany, int releaseYear, decimal cost, Vendor vendor)
    {
        Name = name;
        Category = category;
        Scriptwriter = scriptwriter;
        ProductionDirector = productionDirector;
        ProductionCompany = productionCompany;
        ReleaseYear = releaseYear;
        Cost = cost;
        Vendor = vendor;
    }
}