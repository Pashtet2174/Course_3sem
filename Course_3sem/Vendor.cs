namespace Course_3sem;

public class Vendor
{
    private string _name;
    private string _legalAddress;
    private string _bank;
    private string _bankAccountNumber;
    private string _inn;
    private List<Film> _films;

    public string Name
    {
        get { return _name; }
        set {_name = value;}
    }
    
    public string LegalAddress
    {
        get => _legalAddress;
        set => _legalAddress = value;
    }

    public string Bank
    {
        get => _bank;
        set => _bank = value;
    }

    public string BankAccountNumber
    {
        get => _bankAccountNumber;
        set => _bankAccountNumber = value;
    }

    public string INN
    {
        get => _inn;
        set => _inn = value;
    }
    public List<Film> Films
    {
        get { return _films; }
        set
        {
            if (value == null)
                _films = new List<Film>();
            else
                _films = value;
        }
    }
    public Vendor(string name, string legalAddress, string bank, string bankAccountNumber, string inn)
    {
        Name = name;
        LegalAddress = legalAddress;
        Bank = bank;
        BankAccountNumber = bankAccountNumber;
        INN = inn;
        Films = new List<Film>();

    }

    public void AddFilm(Film film)
    {
        Films.Add(film);;
    }
}