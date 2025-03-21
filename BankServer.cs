using System.Net.NetworkInformation;

/*BankServer                                                                                                                    |
+----------------------------------------------------------------------------------------------+
| - validCards: Dictionary<string, (int pin, BankAccount account)>                             |
+----------------------------------------------------------------------------------------------+
| + BankServer(initialCards: Dictionary<string, (int pin, BankAccount account)>      |
| + verifyCard(cardNumber: string) : bool                                                                       |
| + verifyPIN(cardNumber: string, pin: int) : bool                                                           |
| + processTransaction(cardNumber: string, amount: double) : bool                            |
| + checkBalance(cardNumber: string) : double*/
namespace ATM
{
   public class BankServer
    {
    
        public Dictionary<string, (int pin, BankAccount account)> validCards;
  
        public BankServer(Dictionary<string, (int pin, BankAccount account)> initialCards)
        {
            validCards = initialCards;
        
        }
        public bool verifyCard(string cardNumber)
        {
            return false;
        }
        public bool verifyPIN(string cardNumber, int pin)
        {
            return false;
        }
        public bool processTransaction(string cardNumber, double amount)
        {
            return false;
        }
        public double checkBalance(string cardNumber)
        {
            return 12;
        }

    }
}