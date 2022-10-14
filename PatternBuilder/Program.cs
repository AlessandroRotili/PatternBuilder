using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            PizzaBuilder pizzaMargheritaBuilder = new PizzaMargherita();

            Cook cook = new Cook();

            cook.SetPizzaBuilder(pizzaMargheritaBuilder);
            cook.ConstructPizza();

            Pizza pizzaMargherita = cook.Pizza;

            Console.WriteLine(pizzaMargherita.Dough);
            Console.WriteLine(pizzaMargherita.Sauce);
            Console.WriteLine(pizzaMargherita.Topping);
        }
    }
}
