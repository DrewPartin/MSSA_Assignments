using System.Collections.Generic;
namespace Assignment_12._2.Models
{
    public interface IBookRepository
    {
        List<Book> Books { get; set; }
        List<Book> InitializeData();
        Book GetBook(int? Id);
    }
}
