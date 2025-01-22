public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        IsAvailable = false;
    }

    public void ReturnBook()
    {
        IsAvailable = true;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {IsAvailable}";
    }
}
