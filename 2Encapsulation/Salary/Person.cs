public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:F2} leva";
    }

    public void IncreaseSalary(double percent)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * percent / 100;
        }
        else
        {
            this.salary += this.salary * percent / 200;
        }
    }
}