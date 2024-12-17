namespace Course_3sem;

public interface IRentService
{
    void AddRent(Rent rent);
    List<Rent> GetRents();
}