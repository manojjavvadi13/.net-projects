using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;

        public void AddBook(string title, string author)
        {
            Book book = new Book(nextId++, title, author);
            books.Add(book);
            Console.WriteLine("Book added successfully.\n");
        }

        public void ViewBooks()
        {
            if (!books.Any())
            {
                Console.WriteLine("No books available.\n");
                return;
            }

            Console.WriteLine("\nAll Books:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void BorrowBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (book.IsBorrowed)
            {
                Console.WriteLine("Book already borrowed.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine("Book borrowed successfully.");
            }
        }

        public void ReturnBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("Book is not currently borrowed.");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine("Book returned successfully.");
            }
        }
    }
}
