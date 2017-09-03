using System;

namespace PizzaCalories
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                string[] args = input.Split();

                if (args[0].Equals("Dough"))
                {
                    try
                    {
                        Dough dough = new Dough(args[1], args[2], double.Parse(args[3]));
                        Console.WriteLine($"{dough.CalcDoughCalories():F2}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                else if (args[0].Equals("Topping"))
                {
                    try
                    {
                        Topping topping = new Topping(args[1], double.Parse(args[2]));
                        Console.WriteLine($"{topping.CalcToppingCalories():F2}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                else if (args[0].Equals("Pizza"))
                {
                    try
                    {
                        Pizza pizza = new Pizza(args[1], int.Parse(args[2]));
                        input = Console.ReadLine();
                        args = input.Split();
                        Dough dough = new Dough(args[1], args[2], double.Parse(args[3]));
                        pizza.Dough = dough;

                        for (int i = 0; i < pizza.ToppingsCount; i++)
                        {
                            args = Console.ReadLine().Split();
                            pizza.AddToping(args[1], double.Parse(args[2]));
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.CalcTotalCalories():F2} Calories.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
