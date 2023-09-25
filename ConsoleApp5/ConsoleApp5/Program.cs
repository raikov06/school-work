
namespace DefiniraneNaPoletaIswoistwa
{
    internal class Program
    {
        static void Main()
        {
            #region
            /*
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
            */
            #endregion
        }


    }

    public class Dice
    {
        int sides;
        public int Sides { get => sides; set => sides = 2 * value; }

        string color = "white";
        public string Color { get => color; set => color = value; }

        public void PresentInfo()
        {
            Console.WriteLine($"Br na stranite na zara e: {Sides} A cveta na stranata na zarcheto: {Color}");
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, Sides + 1);
            Thread.Sleep(1000);




            return result;
        }
    }
}