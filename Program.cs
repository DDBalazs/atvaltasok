namespace Átváltások
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek adj meg egy hőmérséklet értéket: ");
            double homerseklet = int.Parse(Console.ReadLine());
            Console.Write("Kérlek mond meg hogy Celsiusból Farenheitbe vagy Farenheitből Celsiusba szeretnéd váltani (CF-FC): ");
            string valasz = Console.ReadLine();
            if (valasz == "CF")
            {
                Console.WriteLine($"Farenheit: {homerseklet*1.8000+32}°F");
            }
            else if (valasz == "FC")
            {
                Console.WriteLine($"Celsius: {(homerseklet-32)/1.8000:00.000}°C");
            }
            else
            {
                Console.WriteLine("nem jó választ adtál");
            }
        }
    }
}
