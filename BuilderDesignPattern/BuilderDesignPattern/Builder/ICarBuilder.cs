using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Builder
{
    public interface ICarBuilder
    {
        //using this interface class, we define the methods required to build our custom car
        //we can use these methods for different types of cars to be build.
        void SetColor(string color);
        void SetTopSpeed(int topSpeed);
        void SetPrice(int price);
        void SetModel(string model);
        void SetEngine(string type, int horsePower, double capacity);
        Car Build();
    }
}
