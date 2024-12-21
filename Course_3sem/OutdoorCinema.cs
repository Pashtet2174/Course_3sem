namespace Course_3sem;

public class OutdoorCinema : Cinema
{
    public int ParcingCapacity { get; set; }

    public OutdoorCinema(string name, string address, string phone, int seatCapacity,  string diretor, string owner,  string bankName, string bankAccount, string innCinema, int parcingCapacity )
        : base(name, address, phone, seatCapacity,diretor, owner, bankName, bankAccount, innCinema)
    {
        ParcingCapacity = parcingCapacity;
    }

    public override void DisplayCinemaType()
    {
        Console.WriteLine($"Кинотеатр {Name} - Под открытым небом.");
    }
}