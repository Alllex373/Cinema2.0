
    using Cinema.Model.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Cinema.BisinessLogic.Server
    {
        public interface IGenreServies
        {
            Genre GetOne(int id);

            void Delete(int id);

            void Add(Genre genre);

            void Update(Genre genre);

            List<Genre> GetAll();
        }

        public class GenreServies : IGenreServies
        {
            private readonly GenreRepozitory _genreRepozitory;

            public FilmServies()
            {
                _genreRepozitory = new GenreRepozitory();
            }

            public List<Genre> GetAll()
            {
                return _genreRepozitory.GetAll()
                    .OrderBy(g => g.Name)
                    .ToList();

            }

            public Genre GetOne(int id)
            {
                return _genreRepozitory.GetOne(id);
            }

            public void Add(Genre genre)
            {
                _genreRepozitory.Add(genre);
            }

            public void Delete(int id)
            {
                _genreRepozitory.Delete(id);
            }

            public void Update(Genre genre)
            {
                _genrtRepozitory.Update(genre);
            }
        }
    }
}
