using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public class ParkingFloor
    {
        private string Name;
        private Dictionary<string, HandicappedSpot> HandiCappedSpots;

        public ParkingFloor(string name)
        {
            this.Name = name;
        }

        public void AddParkingSpot(ParkingSpot spot)
        {
            switch (spot)
            {
                default:
                    break;
            }
        }
    }
}
