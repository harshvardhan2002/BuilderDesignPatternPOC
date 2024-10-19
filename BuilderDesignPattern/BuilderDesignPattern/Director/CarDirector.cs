using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderDesignPattern.Builder;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Director
{
    internal class CarDirector //managing whole building process here.
    {
        private ICarBuilder builder;
        public Car BuildLuxuryCar(ICarBuilder builder)
        {
            builder.SetColor("White");//We can see that there is sequence independence for parameters, it doesnt matter that we can call any of those methods and pass certain values (but all methods must be called before calling the Build() method that goes the Car class and calls printDetails() method.)
            builder.SetTopSpeed(300);
            builder.SetPrice(200000);
            builder.SetModel("S-Class");
            builder.SetEngine("V8", 450, 4.0);//When constructing the Engine object, we are passing values to those methods (or we could create constructor that would have particular parameters), the order of it matters; if the order is wrong, would give compilation error.
            return builder.Build();
        }

        public Car BuildSportsCar(ICarBuilder builder)//calling methods from builder class to construct another customized car type
        {
            builder.SetColor("Red");
            builder.SetPrice(3000000);
            builder.SetTopSpeed(350);
            builder.SetModel("488 GTB");
            builder.SetEngine("V8", 600, 3.9);
            return builder.Build();
        }

        public Car BuildElectricCar(ICarBuilder builder)//third customized car type
        {
            builder.SetTopSpeed(250);
            builder.SetColor("Blue");
            builder.SetPrice(8000000);
            builder.SetModel("Model S");
            builder.SetEngine("Electric", 1020, 0);
            return builder.Build();
        }
    }
}
