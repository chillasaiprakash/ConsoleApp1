using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Language Integrated Query
            //One of the use is to query objects

            //you can query objects in memory
            //Databases ( LINQ to entities )  - Entity Framework

            var books = GetBooks();
            var cheapBooks = new List<Book>();

            foreach (var item in books)
            {
                if (item.Price < 10)
                {
                    cheapBooks.Add(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Without LINQ");
            foreach (var item in cheapBooks) Console.WriteLine(item.Title + " " + item.Price);


            // LINQ Query Operators
            // In general LINQ Query operators always starts with from and ends with select
            var cheapBooksWithLQO = from b in books
                                    where b.Price < 10
                                    orderby b.Title
                                    select b.Title;

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("with LINQ Query operators");
            foreach (var item in cheapBooksWithLQO) Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Where() With LINQ Extension Methods");
            var cheapBooksWithLinq = books.Where(p => p.Price < 10);
            foreach (var item in cheapBooksWithLinq) Console.WriteLine(item.Title + " " + item.Price);

            //LINQ Extenion Methods
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Where() and OrderBy() With LINQ Extension Methods");
            var cheapBooksWithWAndO = books
                                        .Where(p => p.Price < 10)
                                        .OrderBy(t => t.Title);

            foreach (var item in cheapBooksWithWAndO) Console.WriteLine(item.Title + " " + item.Price);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Where(), OrderBy() and Select() With LINQ Extension Methods");
            var cheapBooksWithWOAndS = books
                                        .Where(p => p.Price < 10)
                                        .OrderBy(t => t.Title)
                                        .Select(t => t.Title);

            foreach (var item in cheapBooksWithWOAndS) Console.WriteLine(item);

            var book3 = books.Single(b => b.Title == "Book3");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Single() using LINQ Extension Method");
            Console.WriteLine(book3.Title + " " + book3.Price);

            var book1 = books.SingleOrDefault(b => b.Title == "Book1");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("SingleOrDefault() using LINQ Extension Method");
            Console.WriteLine(book1 == null);

            var firstBook = books.First();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("First() using LINQ Extension Method");
            Console.WriteLine(firstBook.Title + " " + firstBook.Price);

            var firstBookOrDefault = books.FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("First() using LINQ Extension Method");
            Console.WriteLine(firstBookOrDefault.Title + " " + firstBookOrDefault.Price);


            var paginatedRecords = books.Skip(2).Take(2);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Skip() and Take() using LINQ Extension Method");
            foreach (var item in paginatedRecords) Console.WriteLine(item.Price + " " + item.Title);

            Console.ReadLine();
        }

        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Title="Book7", Price=5},
                new Book { Title="Book0", Price=9},
                new Book { Title="Book3", Price=12},
                new Book { Title="Book2", Price=7},
                new Book { Title="Book5", Price=9}
            };
        }
    }
}
