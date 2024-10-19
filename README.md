# BuilderDesignPatternPOC

## The project demonstrates the "Builder Design Pattern" through a custom car-building application. The Builder Pattern is a creational design pattern that allows for the construction of complex objects step by step. It separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

## The order of setting attributes in the CarDirector class does not matter, allowing for a flexible and readable construction process.

## Following SOLID Design Principles-
  - Single Responsibility Principle (SRP): Each class has a single responsibility, enhancing code maintainability and readability. For example, the Car class handles only car-related properties and methods, while the CarConcreteBuilder focuses solely on building car instances hence contains all the methods with single responsibility.
  - Open/Closed Principle (OCP): The Code is Created to allow for the extension of new car types without modifying existing code. By simply creating new methods in the CarDirector, additional car types can be supported without altering the existing functionality.
