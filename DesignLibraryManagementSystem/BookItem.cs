using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public class Rack
    {
        private int Number;
        private string LocationIdentifier;
    }

    public abstract class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Publisher { get; set; }
        public string language { get; set; }
        public int pageCount { get; set; }
        public List<Author> Authors { get; set; }
    }

    public class BookItem : Book
    {
        private string BarCode;
        private bool IsReferenceOnly;
        private DateTime Borrowed;
        private DateTime DueDate;
        private double Price;
        private BookFormat format;
        private BookStatus status;
        private DateTime DateOfPublication;
        private DateTime PurchaseDate;
        private Rack PlaceAt;

        public bool CheckOut(string memberID)
        {
            if (this.IsReferenceOnly)
            {
                throw new Exception("This book is only for reference purpose");
            }

            if ()
            {

            }

            this.UpdateBookStatus()
                {

            }
        }
    }
}
