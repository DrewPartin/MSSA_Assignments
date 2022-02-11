using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDll
{
    public class Book
    {
        public string Series { get; set; }
        public string BookNumber { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    public class BookRepository
    {
        private List<Book> booklist;
        public BookRepository()
        {
            #region Book List
            booklist = new List<Book>()
            {
                new Book() { Series = "The Wheel of Time", BookNumber = "0", Title = "New Spring", YearPublished = "2004", Author = "Robert Jordan", ISBN = "9768913480457"},
                new Book() { Series = "The Wheel of Time", BookNumber = "1", Title = "The Eye of the World", YearPublished = "1990", Author = "Robert Jordan", ISBN = "9874638759477"},
                new Book() { Series = "The Wheel of Time", BookNumber = "2", Title = "The Great Hunt", YearPublished = "1990", Author = "Robert Jordan", ISBN = "9475214685959"}, 
                new Book() { Series = "The Wheel of Time", BookNumber = "3", Title = "The Dragon Reborn", YearPublished = "1991", Author = "Robert Jordan", ISBN = "9714632100548"},
                new Book() { Series = "The Wheel of Time", BookNumber = "4", Title = "The Shadow Rising", YearPublished = "1992", Author = "Robert Jordan", ISBN = "9765220145677"},
                new Book() { Series = "The Wheel of Time", BookNumber = "5", Title = "The Fires of Heaven", YearPublished = "1993", Author = "Robert Jordan", ISBN = "9602005487596"},
                new Book() { Series = "The Wheel of Time", BookNumber = "6", Title = "Lord of Chaos", YearPublished = "1994", Author = "Robert Jordan", ISBN = "9713466523894"},
                new Book() { Series = "The Wheel of Time", BookNumber = "7", Title = "A Crown of Swords", YearPublished = "1996", Author = "Robert Jordan", ISBN = "9425875696321"},
                new Book() { Series = "The Wheel of Time", BookNumber = "8", Title = "The Path of Daggers", YearPublished = "1998", Author = "Robert Jordan", ISBN = "9945463020014"},
                new Book() { Series = "The Wheel of Time", BookNumber = "9", Title = "Winter's Heart", YearPublished = "2000", Author = "Robert Jordan", ISBN = "9766582146549"},
                new Book() { Series = "The Wheel of Time", BookNumber = "10", Title = "Crossroads of Twilight", YearPublished = "2003", Author = "Robert Jordan", ISBN = "9799858522013"},
                new Book() { Series = "The Wheel of Time", BookNumber = "11", Title = "Knife of Dreams", YearPublished = "2005", Author = "Robert Jordan", ISBN = "9544856201334"},
                new Book() { Series = "The Wheel of Time", BookNumber = "12", Title = "The Gathering Storm", YearPublished = "2009", Author = "Brandon Sanderson", ISBN = "9494785213005"},
                new Book() { Series = "The Wheel of Time", BookNumber = "13", Title = "Towers of Midnight", YearPublished = "2010", Author = "Brandon Sanderson", ISBN = "9797456852525"},
                new Book() { Series = "The Wheel of Time", BookNumber = "14", Title = "A Memory of Light", YearPublished = "2013", Author = "Brandon Sanderson", ISBN = "9100548759688"},
            }; 
            #endregion
        }

        public List<Book> GetBooks()
        {
            return booklist.ToList();
        }

        public void AddBook(Book newbook)
        {
            booklist.Add(newbook);
        }

        public void DeleteBook(int index)
        {
            booklist.RemoveAt(index);
        }
    }
}
