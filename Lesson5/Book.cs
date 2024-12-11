namespace Lesson5;

internal class Book
{
    private string _title;

    private string _author;

    private int _pages;

    public string Title
    {
        get
        {
            return _title;
        }
        set
        {
            bool bIsEmpty = String.IsNullOrEmpty(value);
            while (bIsEmpty == true)
            {
                Console.WriteLine("Введены неверные данные.");
                Console.WriteLine("Введите название добавляемой книги:");
                value = Console.ReadLine();
                bIsEmpty = String.IsNullOrEmpty(value);
            }
            _title = value;
        }
    }

    public string Author
    {
        get
        {
            return _author;
        }
        set
        {
            bool bIsEmpty = String.IsNullOrEmpty(value);
            while (bIsEmpty == true)
            {
                Console.WriteLine("Введены неверные данные.");
                Console.WriteLine("Введите автора добавляемой книги:");
                value = Console.ReadLine();
                bIsEmpty = String.IsNullOrEmpty(value);
            }
            _author = value;
        }
    }

    public int Pages
    {
        get
        {
            return _pages;
        }
        set
        {
            _pages = value;
        }
    }

    public Book()
    {
        _title = "Unknown";
        _author = "Unknown";
        _pages = 0;
    }

    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
    }

    public void GetDiscription()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Страниц: {Pages}");
    }
}

