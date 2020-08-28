using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public class ParkingDisplayBoard
    {
        private string id;
        private HandicappedSpot handicappedFreeSpot;
        private CompactSpot compactFreeSpot;
        private LargeSpot largeFreeSpot;
        private MotorbikeSpot motorbikeFreeSpot;
        private ElectricSpot electricFreeSpot;

        public void ShowDispalyMessage()
        {
            string message = "";
            if (handicappedFreeSpot.IsFree)
            {
                message += "Free Handicapped: " + handicappedFreeSpot.GetFreeNumber();
            }
            else
            {
                message += "Handicapped is full";
            }
            message += Environment.NewLine;

            ShowDispalyMessageInBoard(message);
        }

        private void ShowDispalyMessageInBoard(string message)
        {
            Console.WriteLine(message);
        }
    }
}
