using System;

public class LibraryManager
{
    private static LibraryManager instance;
    private readonly Library library;

    private LibraryManager()
    {
        library = new Library();
    }

    public static LibraryManager GetInstance()
    {
        return instance ??= new LibraryManager();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add EBook");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Search Book");
            Console.WriteLine("5. List All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    AddEBook();
                    break;
                case "3":
                    RemoveBook();
                    break;
                case "4":
                    SearchBook();
                    break;
                case "5":
                    library.ListBooks();
                    break;
                case "6":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddBook()
    {
        Book book = BookFactory.CreateBook();
        library.AddBook(book);
    }

    private void AddEBook()
    {
        EBook ebook = (EBook)BookFactory.CreateEBook();
        library.AddBook(ebook);
    }

    private void RemoveBook()
    {
        Console.Write("Enter ISBN to remove: ");
        string isbn = Console.ReadLine();
        library.RemoveBook(isbn);
    }

    private void SearchBook()
    {
        Console.Write("Enter title to search: ");
        string title = Console.ReadLine();
        library.SearchBook(title);
    }
}
