namespace ATM;

public class ATM
{
    private bool cardInserted;
    private bool pinValidated;
    private BankServer bankServer = new();
    private string? currentCardNumber;
}