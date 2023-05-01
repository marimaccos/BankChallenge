namespace Bank
{
    public class SavingAccount : BankAccount {
        private int WithdrawCount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;
        public decimal InterestRate { get; set; }

        public SavingAccount(string firstName, string lastName, decimal interest, decimal balance) 
            : base(firstName, lastName, balance) {
            InterestRate = interest;
        }

        public void ApplyInterest() {
            // add the new amount to the existing balance
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount) {
            // Don't allow overdraw - print a denial message
            if (amount > Balance) {
                Console.WriteLine("Attempt to overdraw savings - denied");
            }
            else {
                base.Withdraw(amount);

                // charge for more than 3 withdrawals
                WithdrawCount++;
                if (WithdrawCount > WITHDRAW_LIMIT) {
                    Console.WriteLine("More than 3 withdrawals - extra charge");
                    base.Withdraw(WITHDRAW_CHARGE);
                }
            }
        }
    }
}
