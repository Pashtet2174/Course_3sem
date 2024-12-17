namespace Course_3sem;

public class Console2
{
    public static void DisplayMenu()
    {
        Console.WriteLine("\nМеню:");
        Console.WriteLine("1. Добавить фильм");
        Console.WriteLine("2. Добавить кинотеатр");
        Console.WriteLine("3. Добавить поставщика");
        Console.WriteLine("4. Создать аренду");
        Console.WriteLine("5. Показать все фильмы.");
        Console.WriteLine("6. Показать арендованные фильмы.");
        Console.WriteLine("7. Выйти");
        Console.Write("Выберите действие: ");
    }

    public static void DisplayCinemas(List<Cinema> cinemas)
    {
        Console.WriteLine("\nСписок кинотеатров:");
        if (cinemas.Count == 0)
        {
            Console.WriteLine("Нет добавленных кинотеатров.");
        }
        else
        {
            for (int i = 0; i < cinemas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cinemas[i].Name}");
            }
        }
    }

    public static void DisplayFilms(List<Film> films)
    {
        Console.WriteLine("\nСписок фильмов:");
        if (films.Count == 0)
        {
            Console.WriteLine("Нет добавленных фильмов.");
        }
        else
        {
            for (int i = 0; i < films.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {films[i].Name}");
            }
        }
    }

    public static void DisplayVendors(List<Vendor> vendors)
    {
        Console.WriteLine("\nСписок поставщиков:");
        if (vendors.Count == 0)
        {
            Console.WriteLine("Нет добавленных поставщиков.");
        }
        else
        {
            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vendors[i].Name}");
            }
        }
    }

    public static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}