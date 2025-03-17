namespace ATM;

public class ATM
{
    private bool cardInserted;
    private bool pinValidated;
    private BankServer bankServer = new();
    private string? currentCardNumber;

    public ATM(BankServer server)
    {
        bankServer = server;
    }
    public void insertCard(string cardNumber)
    {

    }
    public bool enterPIN()
    {
        return true;
    }
    public void requestAmount()
    {

    }
    public void dispenseCash()
    {

    }
    public void ejectCard()
    {
        cardInserted = false;
    }
    public void checkBalance()
    {

    }
    public void getNextAction()
    {
        
    }
}