using System;

public static class BookFactory
{
    public static Book CreateBook()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        return new Book(title, author, isbn);
    }

    public static Book CreateEBook()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Enter File Size (MB): ");
        int fileSize = int.Parse(Console.ReadLine());

        return new EBook(title, author, isbn, fileSize);
    }
}

