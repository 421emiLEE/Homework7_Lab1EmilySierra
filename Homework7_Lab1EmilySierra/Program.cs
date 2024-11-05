using Homework7_Lab1EmilySierra;

internal class Program
{
    private static void Main(string[] args)
    {
        Pizza pizza1 = new Pizza();
        Console.WriteLine(pizza1.toString());
        Pizza pizza2 = new Pizza("large", 4, 4,4);
        pizza2.CalculateCost();
        Pizza pizza3 = new Pizza("medium", 2, 2, 2);
        pizza3.CalculateCost();
        Pizza pizza4 = new Pizza("small", 1, 1, 1);
        pizza4.CalculateCost();
        Console.WriteLine(pizza2.toString());
        Console.WriteLine(pizza3.toString());
        Console.WriteLine(pizza4.toString());
    }
}