namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri cirkel = new Circle();
            Console.WriteLine($"Area cirkel: {cirkel.Area()}");

            Geometri fyrkant = new Square();
            Console.WriteLine($"Area fyrkant: {fyrkant.Area()}");

            Geometri rektangel = new Rectangle();
            Console.WriteLine($"Area rektangel: {rektangel.Area()}");

            Geometri ellips = new Ellips();
            Console.WriteLine($"Area ellips: {ellips.Area()}");

            Geometri parallell = new Parallellogram();
            Console.WriteLine($"Area parallellogram: {parallell.Area()}");

        }
    }
}