﻿using DesignPatterns.ConsoleApp.CreationalPatterns.FactoryMethod.Factories.FactoryContract;
using DesignPatterns.ConsoleApp.CreationalPatterns.FactoryMethod.Products.ConcreteProducts;
using DesignPatterns.ConsoleApp.CreationalPatterns.FactoryMethod.Products.ProductContract;

namespace DesignPatterns.ConsoleApp.CreationalPatterns.FactoryMethod.Factories.ConcreteFactories
{
    public class NYPizzaFactory : IPizzaFactory
    {
        public IPizza BakePizza()
        {
            return new NYPizza();
        }
    }
}
