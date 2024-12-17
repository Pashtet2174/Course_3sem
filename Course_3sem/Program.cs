using Course_3sem;

internal abstract class Program
{

    public static void Main(string[] args)
    {
        ICinemaService cinemaService = new CinemaService();
        IFilmService filmService = new FilmService();
        IVendorService vendorService = new VendorService();
        IRentService rentService = new RentService();

        bool running = true;

        while (running)
        {
            Console2.DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddFilm(filmService, vendorService);
                    break;
                case "2":
                    AddCinema(cinemaService);
                    break;
                case "3":
                    AddSupplier(vendorService);
                    break;
                case "4":
                    CreateRental(cinemaService, filmService, rentService);
                    break;
                case "5":
                    DisplayAllFilms(filmService);
                    break;
                case "6":
                    DisplayRentFilms(rentService);
                    break;

                case "7":

                    running = false;

                    Console2.DisplayMessage("Выход из программы.");

                    break;

                default:

                    Console2.DisplayMessage("Неверный выбор.");

                    break;

            }

        }


        void AddFilm(IFilmService filmService, IVendorService supplierService)
        {
            string title = Console2.GetUserInput("Введите название фильма: ");
            string category = Console2.GetUserInput("Введите категорию фильма: ");
            string screenwriter = Console2.GetUserInput("Введите автора сценария: ");
            string director = Console2.GetUserInput("Введите режиссера: ");
            string producerCompany = Console2.GetUserInput("Введите компанию-производителя: ");
            int releaseYear = int.Parse(Console2.GetUserInput("Введите год выпуска фильма: "));
            decimal purchaseCost = decimal.Parse(Console2.GetUserInput("Введите стоимость фильма: "));

            Console2.DisplayVendors(vendorService.GetVendors());
            int vendorIndex = int.Parse(Console2.GetUserInput("Выберите поставщика по номеру: ")) - 1;

            var vendors = vendorService.GetVendors();
            if (vendorIndex >= 0 && vendorIndex < vendors.Count)
            {
                var selectedVendor = vendors[vendorIndex];
                Film film = new Film(title, category, screenwriter, director, producerCompany, releaseYear,
                    purchaseCost, selectedVendor);
                filmService.AddFilm(film);
                supplierService.AddFilmToVendor(selectedVendor, film);
                Console2.DisplayMessage($"Фильм '{title}' добавлен.");
            }
            else
            {
                Console2.DisplayMessage("Неверный номер поставщика.");
            }
        }

        static void AddCinema(ICinemaService cinemaService)
        {
            string name = Console2.GetUserInput("Введите название кинотеатра: ");
            string address = Console2.GetUserInput("Введите адрес кинотеатра: ");
            string phone = Console2.GetUserInput("Введите телефон кинотеатра: ");
            int seatCount = int.Parse(Console2.GetUserInput("Введите количество посадочных мест: "));
            string director = Console2.GetUserInput("Введите имя директора кинотеатра: ");
            string owner = Console2.GetUserInput("Введите имя владельца кинотеатра: ");
            string bank = Console2.GetUserInput("Введите название банка кинотеатра: ");
            string bankAccount = Console2.GetUserInput("Введите номер счета кинотеатра: ");
            string inn = Console2.GetUserInput("Введите ИНН кинотеатра: ");

            Cinema cinema = new Cinema(name, address, phone, seatCount, director, owner, bank, bankAccount, inn);
            cinemaService.AddCinema(cinema);
            Console2.DisplayMessage($"Кинотеатр '{name}' добавлен.");
        }

        static void AddSupplier(IVendorService supplierService)
        {
            string name = Console2.GetUserInput("Введите название поставщика: ");
            string legalAddress = Console2.GetUserInput("Введите юридический адрес поставщика: ");
            string bank = Console2.GetUserInput("Введите название банка поставщика: ");
            string bankAccount = Console2.GetUserInput("Введите номер счета поставщика: ");
            string inn = Console2.GetUserInput("Введите ИНН поставщика: ");

            Vendor vendor = new Vendor(name, legalAddress, bank, bankAccount, inn);
            supplierService.AddVendor(vendor);
            Console2.DisplayMessage($"Поставщик '{name}' добавлен.");
        }

        static void CreateRental(ICinemaService cinemaService, IFilmService filmService, IRentService rentalService)
        {
            Console2.DisplayCinemas(cinemaService.GetCinemas());
            int cinemaIndex = int.Parse(Console2.GetUserInput("Выберите кинотеатр по номеру: ")) - 1;

            List<Cinema> cinemas = cinemaService.GetCinemas();
            if (cinemaIndex >= 0 && cinemaIndex < cinemas.Count)
            {
                Cinema selectedCinema = cinemas[cinemaIndex];

                Console2.DisplayFilms(filmService.GetFilms());
                int filmIndex = int.Parse(Console2.GetUserInput("Выберите фильм по номеру: ")) - 1;

                List<Film> films = filmService.GetFilms();
                if (filmIndex >= 0 && filmIndex < films.Count)
                {
                    Film selectedFilm = films[filmIndex];

                    DateTime startDate =
                        DateTime.Parse(Console2.GetUserInput("Введите дату начала аренды (например, 2024-12-17): "));
                    DateTime endDate =
                        DateTime.Parse(Console2.GetUserInput("Введите дату конца аренды (например, 2024-12-18): "));
                    decimal rentalPrice = decimal.Parse(Console2.GetUserInput("Введите цену аренды: "));
                    decimal lateFee = decimal.Parse(Console2.GetUserInput("Введите штраф за просрочку: "));

                    Rent rent = new Rent(selectedCinema, selectedFilm, startDate, endDate, rentalPrice, lateFee);
                    rentalService.AddRent(rent);
                    Console2.DisplayMessage(
                        $"Аренда фильма '{selectedFilm.Name}' в кинотеатре '{selectedCinema.Name}' создана.");
                }
                else
                {
                    Console2.DisplayMessage("Неверный номер фильма.");
                }
            }
            else
                Console2.DisplayMessage("Неверный номер кинотеатра.");
        }
        
        static void DisplayAllFilms(IFilmService filmService)
        {
            Console2.DisplayFilms(filmService.GetFilms());
        }
        
        static void DisplayRentFilms(IRentService rentService)
        {
            var rents = rentService.GetRents();
            Console.WriteLine("\nСписок арендованных фильмов:");
            if (rents.Count == 0)
            {
                Console.WriteLine("Нет арендованных фильмов.");
            }
            else
            {
                foreach (var rent in rents)
                {
                    Console.WriteLine($"Фильм: {rent.Film.Name}, Кинотеатр: {rent.Cinema.Name}, Даты: {rent.StartDate.ToShortDateString()} - {rent.EndDate.ToShortDateString()}");
                }
            }
        }
    }
}        