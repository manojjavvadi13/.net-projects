using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsBorrowed = false;
        }

        public override string ToString()
        {
            string status = IsBorrowed ? "Borrowed" : "Available";
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Status: {status}";
        }
    }
}
