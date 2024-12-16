namespace Course_3sem;

public class Vendor
{
    public string Name;
    public string LegalAddress;
    public string Bank;
    public string BankAccountNumber;
    public string Inn;
    public List<Film> Films;

    public Vendor(string name, string legalAddress, string bank, string bankAccountNumber, string inn, List<Film> films)
    {
        Name = name;
        LegalAddress = legalAddress;
        Bank = bank;
        BankAccountNumber = bankAccountNumber;
        Inn = inn;
        Films = films;
    }
}