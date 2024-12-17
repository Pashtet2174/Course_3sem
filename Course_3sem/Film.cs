namespace Course_3sem;

public class Film
{
    private string _name;
    private string _category;
    private string _scriptwriter;
    private string _productionDirector;
    private string _productionCompany;
    private int _releaseYear;
    private decimal _cost;
    private Vendor _vendor;

    public string Name
    {
        get => _name;
        set => _name = value; // Уникальное поле, изменяется только через конструктор
    }

    public string Category
    {
        get => _category;
        set => _category = value;
    }

    public string Scriptwriter
    {
        get => _scriptwriter;
        set => _scriptwriter = value;
    }

    public string ProductionDirector
    {
        get => _productionDirector;
        set => _productionDirector = value;
    }

    public string ProductionCompany
    {
        get => _productionCompany;
        set => _productionCompany = value;
    }

    public int ReleaseYear
    {
        get => _releaseYear;
        set => _releaseYear = value;
    }

    public  Vendor Vendor
    {
        get => _vendor;
        set => _vendor = value;
    }

    public decimal Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public Film(string name, string category, string scriptwriter, string productionDirector, string productionCompany,
        int releaseYear, decimal cost, Vendor vendor)
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