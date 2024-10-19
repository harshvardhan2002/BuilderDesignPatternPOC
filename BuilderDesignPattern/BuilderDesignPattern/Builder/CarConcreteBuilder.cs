using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Builder
{
    internal class CarConcreteBuilder : ICarBuilder
    {
        private Car car;
        public CarConcreteBuilder()
        {
            car = new Car();
        }
        public void SetColor(string color)
        {
            car.Color = color;
        }
        public void SetTopSpeed(int topSpeed)
        {
            car.TopSpeed = topSpeed;
        }
        public void SetPrice(int price)
        {
            car.Price = price;
        }
        public void SetModel(string model)
        {
            car.Model = model;
        }
        public void SetEngine(string type, int horsePower, double capacity)
        {
            car.Engine = new Engine 
            { 
                Type = type, 
                HorsePower = horsePower, 
                Capacity = capacity 
            };
        }
        public Car Build()
        {
            return car;
        }
    }
}
