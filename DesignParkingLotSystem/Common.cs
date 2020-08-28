using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParkingLotSystem
{
    public enum AccountStatus
    {
        CTIVE, CLOSED, CANCELLED, BLACKLISTED, NONE
    }

    public enum VechileType
    {
        CAR, VAN, TRUCK, MOTORBIKE, NONE, ELECTRIC
    }

    public enum SpotType
    {
        COMPACT, LARGE, MOTORBILE, ELECTRIC, PHYSICALCHALLENGED, FREESPOT
    }

    public enum TicketStatus
    {
        ACTIVE, PAID, LOST, NONE,
    }

    public class Address
    {
        public string SteetName;
        public string City;
        public string State;
        public string Country;
        public string ZipCode;
    }

    public class Person
    {
        public string Name;
        public Address address;
        public string Email;
        public string Phone;
    }

    class Common
    {
    }
}
