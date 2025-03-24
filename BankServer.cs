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
        BankAccount account = new BankAccount(1000);
    
        public Dictionary<string, (int pin, BankAccount account)> validCards;
  
        public BankServer(Dictionary<string, (int pin, BankAccount account)> initialCards)
        {
            validCards = initialCards;
        
        }
        public bool verifyCard(string cardNumber)
        {
            return validCards.ContainsKey(cardNumber);
        }
        public bool verifyPIN(string cardNumber, int pin)
        {
            if(validCards.ContainsKey(cardNumber))
            {
                var storePin = validCards[cardNumber].pin;
                return storePin == pin;
            }
            return false;
        }
        public bool processTransaction(string cardNumber, double amount)
        {
            if(account.hasSufficientFunds(amount))
            {
                return 
            }
        }
        public double checkBalance(string cardNumber)
        {
            return 12;
        }

    }
}