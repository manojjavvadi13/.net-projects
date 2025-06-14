using System;

namespace Library_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Library Menu =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                

                if (! int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();
                        library.AddBook(title, author);
                        break;
                    case 2:
                        library.ViewBooks();
                        break;
                    case 3:
                        Console.Write("Enter Book ID to borrow: ");
                        if (int.TryParse(Console.ReadLine(), out int borrowId))
                            library.BorrowBook(borrowId);
                        else Console.WriteLine("Invalid ID.");
                        break;
                    case 4:
                        Console.Write("Enter Book ID to return: ");
                        if (int.TryParse(Console.ReadLine(), out int returnId))
                            library.ReturnBook(returnId);
                        else Console.WriteLine("Invalid ID.");
                        break;
                    case 5:
                        Console.WriteLine("Thankyou!....");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
