using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : Vehicle
    {
        public byte PassengerCount;

        public Bus(string brand, string model, string color, ushort maxSpeed, byte passengerCount) : base(brand, model, color, maxSpeed)
        {
            PassengerCount = passengerCount;
        }

        public override string Info()
        {
            return base.Info() + "\nPassenger Count: " + PassengerCount;
        }
    }
}
