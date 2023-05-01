namespace Bank
{
    public class BankAccount 
    {
        private string FirstName;
        private string LastName;
        public decimal Balance { get; set; }
        public string AccountOwner { get => $"{FirstName} {LastName}"; }

        public BankAccount(string firstName, string lastName, decimal balance=0.0m) {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount) {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}