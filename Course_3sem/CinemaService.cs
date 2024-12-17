namespace Course_3sem;

public class CinemaService : ICinemaService
{
    private readonly List<Cinema> _cinemas = new();

    public void AddCinema(Cinema cinema)
    {
        _cinemas.Add(cinema);
    }

    public List<Cinema> GetCinemas()
    {
        return _cinemas;
    }
}