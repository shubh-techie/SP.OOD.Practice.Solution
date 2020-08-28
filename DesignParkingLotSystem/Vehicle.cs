using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public abstract class Vehicle
    {
        private string LicensePlate;
        private VechileType type;

        public Vehicle(VechileType type)
        {
            this.type = type;
        }
    }


    public class Car : Vehicle
    {
        public Car() : base(VechileType.CAR)
        {
        }
    }

    public class MotorBike : Vehicle
    {
        public MotorBike() : base(VechileType.MOTORBIKE)
        {
        }
    }

    public class Truck : Vehicle
    {
        public Truck() : base(VechileType.TRUCK)
        {
        }
    }

    public class Electric : Vehicle
    {
        public Electric() : base(VechileType.ELECTRIC)
        {
        }
    }


}
