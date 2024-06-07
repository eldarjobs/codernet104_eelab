using library.Models;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();


            Book book1 = new Book("Python Programming", "John Doe", 300, 25.99 );
            Book book12 = new Book("Python Programming", "John Doe", 300, 25.99 );
            Book book2 = new Book("Python Programming", "John Doe", 300, 25.99 );

            library.AddBook(book1);
            library.AddBook(book12);
            library.AddBook(book2);



            Book foundBook = library.GetBook(b => b.Name == "Python Programming");
            List<Book> foundBook1 = library.FindAllBooks(b => b.Pages >= 10 );
            if (foundBook != null)
            {
                Console.WriteLine($"Axtarılan kitab tapıldı: {foundBook.Name} - Müəllif: {foundBook.AuthorName}");
            }
            else
            {
                Console.WriteLine("Axtarılan kitab tapılmadı.");
            }
            Order order = new Order(foundBook1);
            Console.WriteLine(order.TotalPrice);

        }
    }
}