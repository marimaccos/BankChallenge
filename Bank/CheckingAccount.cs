namespace Bank
{
    public class CheckingAccount : BankAccount 
    {
        private const decimal OVERDRAW_CHARGE = 35.0m;

        public CheckingAccount(string firstName, string lastName, decimal balance) 
            : base (firstName, lastName, balance) {
        }

        public override void Withdraw(decimal amount) {
            // if the account gets overdrawn add an extra charge
            if (amount > Balance) {
                amount += OVERDRAW_CHARGE;
            }
            base.Withdraw(amount);
        }
    }
}
