using System.Collections.Generic;
using System.Linq;

class Person
{
    private string name = string.Empty;
    private int age = 0;
    private List<BankAccount> accounts = null;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Person(string name, int age, List<BankAccount> accounts)
        : this(name, age)
    {
        this.accounts = accounts;
    }

    public double GetBalance()
    {
        return this.accounts.Sum(a => a.Balance);
    }
}

