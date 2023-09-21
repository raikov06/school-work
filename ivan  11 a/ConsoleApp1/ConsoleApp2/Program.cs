namespace ConsoleApp2
{
    internal class StartUP
    {
        static void Main()
        {
            int rentOfHall = int.Parse(Console.ReadLine());
            decimal statuesValue = rentOfHall * 0.7m;
            decimal ceteringValue = rentOfHall * 0.7m;
            decimal soundValue = rentOfHall * 0.7m;
            decimal totalCost = rentOfHall * 0.7m;
            Console.WriteLine($"otgovorut e {totalCost:F2}");
        }
        private static void Zadacha2()
        {
            int rentOfHall = int.Parse(Console.ReadLine());
        }
}