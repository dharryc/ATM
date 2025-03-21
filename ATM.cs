namespace ATM;

public class ATM
{
    private bool cardInserted;
    private bool pinValidated;
    private BankServer bankServer;
    private string? currentCardNumber;

    public ATM(BankServer server)
    {
        bankServer = server;
    }
    public void insertCard(string cardNumber)
    {
        if (bankServer.verifyCard(cardNumber))
        {
            Console.WriteLine("Card verification successful! Plese enter pin, then press enter:\n");
            if(enterPIN())
            {
                Console.WriteLine("How much would you like to withdraw?");
                requestAmount();
            }
            else ejectCard();
        }
        else ejectCard();
    }
    public bool enterPIN()
    {
        try{
            int pin = Convert.ToInt32(Console.ReadLine());
            return(bankServer.verifyPIN(pin));
        }
        catch
        {
            Console.WriteLine("Please enter a valid pin");
            return enterPIN();
        }
        return false;
    }
    public void requestAmount()
    {
        int amountOut;
        try{
            amountOut = Convert.ToInt32(Console.ReadLine());
        }
        catch{
            Console.WriteLine("Please enter a valid number");
            requestAmount();
        }
        
    }
    public void dispenseCash()
    {

    }
    public void ejectCard()
    {
        Console.WriteLine("That card wasn't recognized. Card ejecting.");
        cardInserted = false;
    }
    public void checkBalance()
    {

    }
    public void getNextAction()
    {

    }
}