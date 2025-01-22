public class EBook : Book
{
    public int FileSizeMB { get; private set; }

    public EBook(string title, string author, string isbn, int fileSizeMB)
        : base(title, author, isbn)
    {
        FileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return base.ToString() + $", File Size: {FileSizeMB} MB";
    }
}
