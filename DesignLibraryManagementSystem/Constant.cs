using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public enum BookFormat
    {
        HARDCOVER,
        PAPERWORK,
        AUDIOBOOK,
        EBOOK,
        NEWSPAPER,
        MAGAZINE,
        JOURNAL,
        NONE
    }
    public enum BookStatus
    {
        AVAILABLE,
        RESERVED,
        LOANDED,
        LOST,
        NONE
    }

    public enum ReservationStatus
    {
        WAITING,
        PENDING,
        CANCELLED,
        NONE
    }

    public enum AccountStatus
    {
        ACTIVE,
        CLOSED,
        CANCELLED,
        BLACKLISTED,
        NONE
    }

    public class Address
    {
        public string StreeName { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public Address address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public string GetName()
        {
            this.Name = "James Carmron.";
            return this.Name;
        }
    }

    class Constant
    {
        public static int MAX_BOOKS_Limit_PER_USER = 5;
        public static int MAX_LENDING_DAY = 10;
    }
}
