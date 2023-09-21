namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Dice d1 = new Dice();
            Dice d2 = new Dice();

            d1.Sides = 7;
            d2.Sides = 3;
            Console.WriteLine("Br na stranite na zara e: " + d1.Sides);
            Console.WriteLine("Br na stranite na zara e: " + d2.Sides);
        }


    }

    public class Dice
    {
        int sides;
        public int Sides { get => sides; set => sides = 2 * value; }
    }
}