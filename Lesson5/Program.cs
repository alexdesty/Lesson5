namespace Lesson5;
internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Book book2 = new Book("Лолита", "Владимир Набоков", 350);
        Console.WriteLine("Добавление книги");
        Console.WriteLine("Введите название добавляемой книги:");
        Book book3 = new Book();
        book3.Title = Console.ReadLine();
        Console.WriteLine("Введите автора добавляемой книги:");
        book3.Author = Console.ReadLine();
        int pages;
        Console.WriteLine("Введите количество страниц добавляемой книги:");
        while ((!int.TryParse(Console.ReadLine(), out pages) || pages<=0))
        {
            Console.WriteLine("Введены неверные данные. \nВведите количество страниц добавляемой книги:");
        }
        book3.Pages = pages;
        Console.WriteLine("Книга, добавленная пользователем:");
        book3.GetDiscription();
        Console.WriteLine("\nКниги, добавленные ранее:");
        book2.GetDiscription();
    }
}


