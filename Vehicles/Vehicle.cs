using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Color;
        public ushort MaxSpeed;

        public Vehicle()
        {
            Console.WriteLine("Car Created");
        }

        public Vehicle(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        }

        public Vehicle(string brand, string model, string color, ushort maxSpeed) : this(brand, model)
        {
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public virtual string Info()
        {
            return $"Brand: {Brand}\nModel: {Model}\nColor: {Color}\nMax Speed: {MaxSpeed}";
        }
    }
}
