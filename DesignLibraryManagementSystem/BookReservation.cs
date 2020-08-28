using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public class BookReservation
    {
        private DateTime creationDate;
        private ReservationStatus status;
        private string BookItemBarcode;
        private string MemberId;

        public static BookReservation FetchReservationDetails(string barcode)
        {
            return new BookReservation();
        }
    }


    public class BookLending
    {
        private DateTime CreationDate;
        private DateTime DReturnDate;
        private string BookItemBarcode;
        private string MemberId;

        //public static void lendBook(string barcode, string memberId);
        // public static BookLending fetchLendingDetails(string barcode);
    }

    public class Fine
    {
        private DateTime CreationDate;
        private double BookItemBarcode;
        private string MemberId;

        //public static void collectFine(string memberId, long days) { }
    }
}
