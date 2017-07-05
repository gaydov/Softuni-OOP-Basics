public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public double Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }
}

