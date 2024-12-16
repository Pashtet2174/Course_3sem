namespace Course_3sem;

public class Cinema
{
    public string Name;
    public string Address;
    public string Phone;
    public int SeatCapacity;
    public string Director;
    public string Owner;
    public string BankName; 
    public string BankAccount;
    public string InnCinema;

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