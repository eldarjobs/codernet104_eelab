using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace library.Models
{
    public class Book
    {
        static int BookId = 0;
        private int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public double Pages { get; set; }
        public string Code { get; set; }

        public Book(string name, string author, double price, double pages)
        {
            Name = name;
            AuthorName = author;
            Price = price;
            Pages = pages;
            BookId++;
            Code = Name.Substring(0, 1) + BookId;
        }
    }
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        public Book GetBook(Predicate<Book> predicate)
        {
            return Books.Find(predicate);

        }
        public List<Book> FindAllBooks(Predicate<Book> predicate)
        {
            return Books.FindAll(predicate);
        }

    }
    public class Order
    {
        private static int OrderId = 1;
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public List<Book> OrderedBooks = new List<Book>();
        public void Sale(Book book)
        {
            OrderedBooks.Add(book);
        }

        public Order(List<Book> orderedBooks)
        {
            Id = OrderId;
            OrderId++;
            TotalPrice = CalculatePrice(orderedBooks);
            Date = DateTime.Now;
            OrderedBooks = orderedBooks;
        }
        public double CalculatePrice(List<Book> books)
        {
            double price = 0;
            foreach (var book in books)
            {
                price += book.Price;
            }
            return price;
        }

    }


}



