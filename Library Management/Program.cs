// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        LibraryManager manager = LibraryManager.GetInstance();
        manager.Run();
    }
}

