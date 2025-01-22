using System;
using System.Collections.Generic;

public class Library
{
    private readonly List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void RemoveBook(string isbn)
    {
        Book book = books.Find(b => b.ISBN == isbn);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void SearchBook(string title)
    {
        Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(book != null ? book.ToString() : "Book not found.");
    }

    public void ListBooks()
    {
        if (books.Count > 0)
        {
            Console.WriteLine("\nBooks in Library:");
            books.ForEach(b => Console.WriteLine(b));
        }
        else
        {
            Console.WriteLine("No books in the library.");
        }
    }
}
