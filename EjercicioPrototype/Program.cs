namespace EjercicioPrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Casa casaold = new Casa()
            {
                NumExt = 123,
                Calle = "Calle", 
                NumHabitaciones = 3,
                Extras = "Alberca"
            };
            Casa casanew = casaold.Clone() as Casa;
            casanew.Extras = "Albercas y balcon";

            Console.WriteLine(casaold.NumExt);
            Console.WriteLine(casaold.Calle);
            Console.WriteLine(casaold.NumHabitaciones);
            Console.WriteLine(casaold.Extras);
            Console.WriteLine("----------------------");
            Console.WriteLine(casanew.NumExt);
            Console.WriteLine(casanew.Calle);
            Console.WriteLine(casanew.NumHabitaciones);
            Console.WriteLine(casanew.Extras);
        }
    }
}