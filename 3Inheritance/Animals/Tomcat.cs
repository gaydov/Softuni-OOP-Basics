public class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base(name, age, "Male")
    {
    }

    public override string MakeSound()
    {
        return "Give me one million b***h";
    }
}