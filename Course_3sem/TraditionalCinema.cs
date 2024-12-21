namespace Course_3sem;

public class TraditionalCinema : Cinema
{
    public string ScreenType { get; set; }

    public TraditionalCinema(string name, string address, string phone, int seatCapacity, string director, string owner, string bankName, string bankAccount, string innCinema, string screenType )
        : base(name, address, phone, seatCapacity, director, owner, bankName, bankAccount, innCinema)
    {
        ScreenType = screenType;
    }

    public override void DisplayCinemaType()
    {
        Console.WriteLine($"Кинотеатр {Name} - Традиционный.");
    }
}