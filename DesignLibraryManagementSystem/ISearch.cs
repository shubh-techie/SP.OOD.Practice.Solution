using System;
using System.Collections.Generic;
using System.Text;

namespace DesignLibraryManagementSystem
{
    public interface ISearch
    {
        List<string> SearchByTitle(string title);
        List<string> SearchByAuthor(string author);
        List<string> SearchByPublication(string publication);
        List<string> SearchBySubject(string subject);
        List<string> SearchByPublicationDate(DateTime publicationDate);
    }

}
