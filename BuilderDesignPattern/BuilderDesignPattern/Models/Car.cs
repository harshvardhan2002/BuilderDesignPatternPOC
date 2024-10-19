using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Models
{
    public class Car
    {
        public string Color { get; set; }
        public int TopSpeed { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($" Model: {Model}\n" +
                $" Color: {Color}\n" +
                $" Top Speed: {TopSpeed}\n" +
                $" Price: {Price}\n\n" +
                $"Engine: {Engine.Type}, HorsePower: {Engine.HorsePower}, Capacity: {Engine.Capacity}");
        }
    }

}
