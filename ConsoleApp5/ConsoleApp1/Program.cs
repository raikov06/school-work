namespace DefiniraneNaPoletaIswoistwa
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");

            Dice d1 = new Dice();
            Dice d2 = new Dice();
            d1.Sides = 15;
            d2.Sides = 5;
            d1.PresentInfo();
            // Console.WriteLine($"Br na stranite na zara e: {d1.Sides} A cveta na stranata na zarcheto: {d1.Color}");
            Console.WriteLine(new string('=', 20));
            d1.Color = "Magenta"; ;

            d1.PresentInfo();

            d2.PresentInfo();
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d1.RollDice();
                Console.WriteLine($"Hwurlihme zarche N1 i poluchihme: {rolledNumber}");
            }

            //Console.WriteLine("Br na stranite na zara e: "+d2.Sides);
        }


    }
