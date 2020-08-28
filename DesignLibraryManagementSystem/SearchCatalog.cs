using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public class SearchCatalog : ISearch
    {
        private Dictionary<string, List<string>> BookTitles;
        private Dictionary<string, List<string>> BookAuthors;
        private Dictionary<string, List<string>> BookSubjects;
        private Dictionary<string, List<string>> BookPublications;
        private Dictionary<DateTime, List<string>> BookPublicationDate;

        public List<string> SearchByTitle(string strTitle)
        {
            // Call the database stored procedure or API to pull the records from database.
            BookTitles = new Dictionary<string, List<string>>();
            if (BookTitles.ContainsKey(strTitle))
                return this.BookTitles[strTitle];
            else
            {
                BookTitles = null; //default();//DBHelper(strTitle);
                return this.BookTitles[strTitle];
            }
        }
        public List<string> SearchByAuthor(string strAuthor)
        {
            return this.BookAuthors[strAuthor];
        }

        public List<string> SearchByPublication(string strPublication)
        {
            return this.BookSubjects[strPublication];
        }

        public List<string> SearchBySubject(string strSubject)
        {
            return this.BookPublications[strSubject];
        }

        public List<string> SearchByPublicationDate(DateTime publicationDate)
        {
            return this.BookPublicationDate[publicationDate];
        }

    }
}
