using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Director;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarDirector director = new CarDirector();
            CarConcreteBuilder builder = new CarConcreteBuilder();

            Car luxuryCar = director.BuildLuxuryCar(builder);

            Console.WriteLine("=====Custom Car Building Management System=====\n");
            Console.WriteLine("Luxury Car Details:");
            luxuryCar.PrintDetails();
            Console.WriteLine();

            Car sportsCar = director.BuildSportsCar(builder);
            Console.WriteLine("Sports Car Details:");
            sportsCar.PrintDetails();
            Console.WriteLine();


            Car electricCar = director.BuildElectricCar(builder);
            Console.WriteLine("Electric Car Details:");
            electricCar.PrintDetails();

        }
    }
}
