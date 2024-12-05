using Iterator;

class Program
{
    static void Main()
    {
        // Создание экземпляров книг
        var book1 = new Book("Теория всего", "Стивен Хокинг", 2002);
        var book2 = new Book("Дневник Карла Маркса", "Карл Маркс", 1867);
        var book3 = new Book("Война и мир", "Лев Толстой", 1869);

        // Создание библиотеки и добавление книг
        var library = new Library();
        
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Итерация по библиотеке
        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("/////////////////////");
        var library_ = new Library();
        var book4 = new Book("Так говорил Заратустра", "Фридрих Ницше", 1883);
        library_.AddBook(book1);
        library_.AddBook(book1);
        library_.AddBook(book4);
       
        foreach (var book in library_)
        {
            Console.WriteLine(book);
        }
    }
}
