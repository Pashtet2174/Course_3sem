namespace Course_3sem;

public class Vendor: IBank
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

    public string BankName
    {
        get => _bank;
        set => _bank = value;
    }

    public string BankAccount
    {
        get => _bankAccountNumber;
        set => _bankAccountNumber = value;
    }

    public string Inn
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
        BankName = bank;
        BankAccount = bankAccountNumber;
        Inn = inn;
        Films = new List<Film>();

    }

    public void AddFilm(Film film)
    {
        Films.Add(film);;
    }

    public string GetBankDetails()
    {
        return $"Банк: {BankName}\nСчет: {BankAccount}\nИНН: {Inn}";
    }
}