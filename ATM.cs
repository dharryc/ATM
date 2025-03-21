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
        if(bankServer.verifyCard(cardNumber))
        {
            Console.WriteLine("Card verification successful! Plese enter pin, then press enter:\n");
            enterPIN();
        }
        else ejectCard();
    }
    public bool enterPIN()
    {
        int pin = Convert.ToInt32(Console.ReadLine());
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