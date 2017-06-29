public class BankAccount
{
    private int id = 0;
    private double balance = 0;

    public double Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public int ID
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {this.id}, balance {this.balance}";
    }
}

