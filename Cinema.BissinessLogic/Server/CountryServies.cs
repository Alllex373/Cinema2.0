using Cinema.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BisinessLogic.Server
{
    public interface ICountryServies
    {
        Country GetOne(int id);

        void Delete(int id);

        void Add(Country country);

        void Update(Country country);

        List<Country> GetAll();
    }

    public class CountryServies : ICountryServies
    {
        private readonly CountryRepozitory _countryRepozitory;

        public CountryServies()
        {
            _countryRepozitory = new CountryRepozitory();
        }

        public List<Country> GetAll()
        {
            return _countryRepozitory.GetAll()
                .OrderBy(g => g.Name)
                .ToList();

        }

        public Country GetOne(int id)
        {
            return _countryRepozitory.GetOne(id);
        }

        public void Add(Country country)
        {
            _countryRepozitory.Add(country);
        }

        public void Delete(int id)
        {
            _countryRepozitory.Delete(id);
        }

        public void Update(Country country)
        {
            _countryRepozitory.Update(country);
        }
    }
}
