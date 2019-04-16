using Cinema.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BisinessLogic.Service
{
    public interface IHallServies
    {
        Hall GetOne(int id);

        void Delete(int id);

        void Add(Hall hall);

        void Update(Hall hall);

        List<Hall> GetAll();
    }

    public class HallServies : IHallServies
    {
        private readonly HallRepozitory _hallRepozitory;

        public HallServies()
        {
            _hallRepozitory = new HallRepozitory();
        }

        public List<Hall> GetAll()
        {
            return _hallRepozitory.GetAll()
                .OrderBy(g => g.Name)
                .ToList();

        }

        public Hall GetOne(int id)
        {
            return _hallRepozitory.GetOne(id);
        }

        public void Add(Hall hall)
        {
            _hallRepozitory.Add(hall);
        }

        public void Delete(int id)
        {
            _hallRepozitory.Delete(id);
        }

        public void Update(Hall hall)
        {
            _hallRepozitory.Update(hall);
        }

    }
}
