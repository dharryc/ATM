namespace ATM
{
    class BankServer

    {
        private Dictionary<string, (int pin, BankAccount account)> validCards;

        public BankServer(Dictionary<string, (int pin, BankAccount account)> initialCards = null)
        {
            validCards = initialCards ?? new Dictionary<string, (int pin, BankAccount account)>();
        }

        public bool verifyCard(string cardNumber)
        {
            return validCards.ContainsKey(cardNumber);
        }
        public bool verifyPIN(string cardNumber, int pin)
        {
            if (validCards.ContainsKey(cardNumber))
            {
                var storePin = validCards[cardNumber].pin;
                return storePin == pin;
            }
            return false;
        }
        public bool processTransaction(string cardNumber, double amount)
        {
            if (validCards[cardNumber].account.hasSufficientFunds(amount))
            {
                return true;
            }
            return false;
        }
        public double checkBalance(string cardNumber)
        {
            return validCards[cardNumber].account.GetBalance();
        }

    }
}