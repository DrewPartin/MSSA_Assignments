using System.Collections.Generic;
namespace Assignment_12._2.Models
{
    public class BookDetails : IBookRepository
    {
        public List<Book> Books { get; set; }

        public Book GetBook(int? Id)
        {
            if (Id == null)
            {
                return null;
            }
            else
            {
                return Books.Find(x => x.Id == Id);
            }
        }

        public List<Book> InitializeData()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 10001,
                    Title = "On The Shoulders Of Giants",
                    SubTitle = "The Great Works of Physics and Astronomy",
                    Author = "Stephen Hawking",
                    Summary = "World-renowned physicist and bestselling author Stephen Hawking presents a revolutionary look at the momentous discoveries that changed our perception of the world with this first-ever compilation of seven classic works on physics and astronomy. His choice of landmark writings by some of the world's great thinkers traces the brilliant evolution of modern science and shows how each figure built upon the genius of his predecessors. On the Shoulders of Giants includes, in their entirety, On the Revolution of Heavenly Spheres by Nicolaus Copernicus; Principia by Sir Isaac Newton; The Principle of Relativity by Albert Einstein; Dialogues Concerning Two Sciences by Galileo Galilei with Alfonso De Salvio; plus Mystery of the Cosmos, Harmony of the World, and Rudolphine Tables by Johannes Kepler. It also includes five critical essays and a biography of each featured physicist, written by Hawking himself.",
                    ImageName = "ShouldersOfGiants.jpg"
                },

                new Book()
                {
                    Id = 10002,
                    Title = "Clean Code",
                    SubTitle = "A Handbook of Agile Software Craftsmanship",
                    Author = "Robert C. Martin",
                    Summary = "Noted software expert Robert C. Martin, presents a revolutionary paradigm with Clean Code: A Handbook of Agile Software Craftsmanship. Martin, who has helped bring agile principles from a practitioner’s point of view to tens of thousands of programmers, has teamed up with his colleagues from Object Mentor to distill their best agile practice of cleaning code “on the fly” into a book that will instill within you the values of software craftsman, and make you a better programmer―but only if you work at it.",
                    ImageName = "CleanCode.jpg"
                },

                new Book()
                {
                    Id = 10003,
                    Title = "The Clean Coder",
                    SubTitle = "A Code of Conduct for Professional Programmers",
                    Author = "Robert C. Martin",
                    Summary = "In The Clean Coder: A Code of Conduct for Professional Programmers, legendary software expert Robert C. Martin introduces the disciplines, techniques, tools, and practices of true software craftsmanship. This book is packed with practical advice - about everything from estimating and coding to refactoring and testing. It covers much more than technique: It is about attitude. Martin shows how to approach software development with honor, self-respect, and pride; work well and work clean; communicate and estimate faithfully; face difficult decisions with clarity and honesty; and understand that deep knowledge comes with a responsibility to act.",
                    ImageName = "CleanCoder.jpg"
                },

                new Book()
                {
                    Id = 20001,
                    Title = "Elon Musk",
                    SubTitle = "Tesla, SpaceX, and the Quest for a Fantastic Future",
                    Author = "Ashlee Vance",
                    Summary = "\"Elon Musk\" spotlights the technology and vision of Elon Musk, the renowned entrepreneur and innovator behind SpaceX, Tesla, and SolarCity, who sold one of his Internet companies, PayPal, for $1.5 billion. Ashlee Vance captures the full spectacle and arc of the genius's life and work, from his tumultuous upbringing in South Africa and flight to the United States to his dramatic technical innovations and entrepreneurial pursuits.",
                    ImageName = "ElonMusk.jpg"
                },

                new Book()
                {
                    Id = 20002,
                    Title = "The Inventions, Researches and Writings of Nikola Tesla",
                    SubTitle = null,
                    Author = "Nikola Tesla & Thomas Commerford Martin",
                    Summary = "The Inventions, Researches and Writings of Nikola Tesla is the definitive record of the pioneering work of one of the modern world's most groundbreaking inventors. During the early twentieth century, Tesla blazed the trail that electrical technology followed for decades afterward. Although he pioneered inventions like alternating current (AC), radio, wireless transmission, and X-rays, and worked with innovators like George Westinghouse and Thomas Edison, the once-celebrated Tesla was later largely forgotten by history. This beautiful leatherbound edition brings together many of the findings and theories that made this genius famous (and to some, infamous), showing not only the scope of Nikola Tesla's theories and inventions, but allowing contemporary readers to experience the visionary range of his thinking. In addition to its many detailed reproductions of Tesla's patents and inventions, this highly collectible book includes dozens of thought-provoking lectures and articles. The Inventions, Researches and Writings of Nikola Tesla affords a rare glimpse of a true genius at work.",
                    ImageName = "NikolaTesla.jpg"
                },
            };
            return Books;
        }
    }
}
