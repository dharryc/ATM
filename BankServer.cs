using System.Net.NetworkInformation;

namespace ATM
{
   public class BankServer

    {
    
        private Dictionary<string, (int pin, BankAccount account)> ValidCards;

        public BankServer(Dictionary<string, (int pin, BankAccount account)> initialCards = null)
        {
            ValidCards = initialCards ?? new Dictionary<string, (int pin, BankAccount account)>();
        }

        public bool verifyCard(string cardNumber)
        {
            return ValidCards.ContainsKey(cardNumber);
        }
        public bool verifyPIN(string cardNumber, int pin)
        {
            if (ValidCards.TryGetValue(cardNumber, out var cardInfo))
            {
                return cardInfo.pin == pin;
            }
            return false;
        }
        public bool processTransaction(string cardNumber, double amount)
        {
            if (ValidCards.TryGetValue(cardNumber, out var cardInfo))
            {
                if (cardInfo.account.hasSufficientFunds(amount))
                {
                    return cardInfo.account.Withdraw(amount);
                }
            }
            return false;
        }
        public double checkBalance(string cardNumber)
        {
            if (ValidCards.TryGetValue(cardNumber, out var cardInfo))
            {
                return cardInfo.account.GetBalance();
            }
            return 0;
        }

    }
}