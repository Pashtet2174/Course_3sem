namespace Course_3sem;

public class FourDCinema : Cinema
{
    public string SeatsWithEffects { get; set; } 

    public FourDCinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccount, string innCinema, string seatsWithEffects)
        : base(name, address, phone, seatCapacity, director, owner, bankName, bankAccount, innCinema)
    {
        SeatsWithEffects = seatsWithEffects;
    }

    public override void DisplayCinemaType()
    {
        Console.WriteLine($"Кинотеатр {Name} - 4D.");
    }
}