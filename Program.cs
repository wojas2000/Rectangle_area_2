using System;

namespace Rectangle_area_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole;
            Console.WriteLine("Program liczy pole prostokąta.");
            Console.WriteLine("Podaj długość dłuższego boku:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość krótszego boku:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Pole prostokąta wynosi: {pole = a * b}");
        }
    }
}
