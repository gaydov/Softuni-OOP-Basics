using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    private string name = string.Empty;
    private decimal salary = 0;
    private string position = string.Empty;
    private string department = string.Empty;

    private string email = "n/a";
    private int age = -1;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public string Department
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
    }
}

