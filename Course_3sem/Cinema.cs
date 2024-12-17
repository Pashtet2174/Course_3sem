namespace Course_3sem;

public class Cinema
{
    private string _name;
    private string _address;
    private string _phone;
    private int _seatCapacity;
    private string _director;
    private string _owner;
    private string _bankName; 
    private string _bankAccount;
    private string _innCinema;

    public string Name
    {
        get => _name;
        set => _name = value; // Уникальное поле, изменяется только через конструктор
    }

    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public string Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public int SeatCapacity
    {
        get => _seatCapacity;
        set => _seatCapacity = value;
    }

    public string Director
    {
        get => _director;
        set => _director = value;
    }

    public string Owner
    {
        get => _owner;
        set => _owner = value;
    }

    public string BankName
    {
        get => _bankName;
        set => _bankName = value;
    }

    public string BankAccount
    {
        get => _bankAccount;
        set => _bankAccount = value;
    }

    public string InnCinema
    {
        get => _innCinema;
        set => _innCinema = value;
    }

    public Cinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccount, string innCinema)
    {
        Name = name;
        Address = address;
        Phone = phone;
        SeatCapacity = seatCapacity;
        Director = director;
        Owner = owner;
        BankName = bankName;
        BankAccount = bankAccount;
        InnCinema = innCinema;
    }
}