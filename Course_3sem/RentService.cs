namespace Course_3sem;

public class RentService : IRentService
{
    private readonly List<Rent> _rents = new ();
    
    public void AddRent(Rent rent)
    {
        _rents.Add(rent);
    }

    public List<Rent> GetRents()
    {
        return _rents;
    }
}