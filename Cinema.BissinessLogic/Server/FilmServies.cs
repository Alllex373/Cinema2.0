using Cinema.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BisinessLogic.Service
{
    public interface IFilmServies
    {
        Film GetOne(int id);

        void Delete(int id);

        void Add(Film film);

        void Update(Film film);

        List<Film> GetAll();
    }

    public class FilmServies : IFilmServies
    {
        private readonly FilmRepozitory _filmRepozitory;

        public FilmServies()
        {
            _filmRepozitory = new FilmRepozitory();
        }

        public List<Film> GetAll()
        {
            return _filmRepozitory.GetAll()
                .OrderBy(g => g.Name)
                .ToList();

        }

        public Film GetOne(int id)
        {
            return _filmRepozitory.GetOne(id);
        }

        public void Add(Film film)
        {
            _filmRepozitory.Add(film);
        }

        public void Delete(int id)
        {
            _filmRepozitory.Delete(id);
        }

        public void Update(Film film)
        {
            _filmRepozitory.Update(film);
        }

    }
}
