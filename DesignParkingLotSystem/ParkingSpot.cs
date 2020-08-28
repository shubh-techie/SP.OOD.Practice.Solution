using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public abstract class ParkingSpot
    {
        private string Number;
        public bool IsFree { get; set; }
        private SpotType type;
        private Vehicle vehicle;

        public ParkingSpot(SpotType type)
        {
            this.type = type;
        }

        public bool AssignVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            this.IsFree = false;
            return true;
        }

        public bool RemoveVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            this.IsFree = true;
            return true;
        }
    }


    public class HandicappedSpot : ParkingSpot
    {
        public HandicappedSpot(SpotType type) : base(type)
        {

        }
        public int GetFreeNumber()
        {
            return 0;
        }
    }

    public class CompactSpot : ParkingSpot
    {
        public CompactSpot(SpotType type) : base(type)
        {
        }
    }

    public class LargeSpot : ParkingSpot
    {
        public LargeSpot(SpotType type) : base(type)
        {
        }
    }

    public class MotorbikeSpot : ParkingSpot
    {
        public MotorbikeSpot(SpotType type) : base(type)
        {
        }
    }

    public class ElectricSpot : ParkingSpot
    {
        public ElectricSpot(SpotType type) : base(type)
        {
        }
    }

}
