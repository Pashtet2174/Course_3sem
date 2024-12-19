namespace Course_3sem;

public interface IBank
{
    string BankName { get; set; }
    string BankAccount { get; set; }
    string Inn { get; set; }    

    string GetBankDetails();

}