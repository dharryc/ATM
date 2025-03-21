namespace ATM;

public class Program
{
    BankServer TheServer = new BankServer();
    ATM TheATM = new ATM(TheServer);

    public static void Main()
    {
        Console.WriteLine("Welcome to the ATM");

    }

    public void insert()
    {
        Console.WriteLine("Please insert your card");
        string cardNum = Console.ReadLine();
        TheATM.insertCard(cardNum);
    }


}