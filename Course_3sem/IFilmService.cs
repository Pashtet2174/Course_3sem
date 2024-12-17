namespace Course_3sem;

public interface IFilmService
{
    void AddFilm(Film film);
    List<Film> GetFilms();
}