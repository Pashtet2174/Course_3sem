namespace Course_3sem;

public class Rent
{
    public Cinema Cinema { get; set; }
    public Film Film { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal RentalAmount { get; set; }
    public decimal Penalty { get; set; }
}