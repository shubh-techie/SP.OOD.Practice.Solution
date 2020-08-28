using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public abstract class Account
    {
        private string UserName;
        private string Password;
        private AccountStatus Status;
        private Person person;

        public abstract bool ResetPassword();
    }

    public class Admin : Account
    {
        //add floor
        //add parking spot
        //add display panel
        //add customer info panel
        
        //add entrance panel
        //add exit panel
        public override bool ResetPassword() { return true; }
    }


    public class ParkingAttendant : Account
    {
        public bool ProcessTicket(string ticketNumber) { return false; }
        public override bool ResetPassword() { return true; }
    }
}
