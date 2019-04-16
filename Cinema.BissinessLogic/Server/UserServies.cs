using Cinema.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BisinessLogic.Service
{

    public interface IUserServies
    {
        User GetOne(int id);

        void Delete(int id);

        void Add(User user);

        void Update(User user);

        List<User> GetAll();

    }

    public class UserServies : IUserServies
    {
        private readonly UserRepozitory _userRepozitory;

        public UserServies()
        {
            _userRepozitory = new UserRepozitory();
        }

        public List<User> GetAll()
        {
            return _userRepozitory.GetAll()
                .OrderBy(g => g.Name)
                .ToList();

        }

        public User GetOne(int id)
        {
            return _userRepozitory.GetOne(id);
        }

        public void Add(User user)
        {
            _userRepozitory.Add(user);
        }

        public void Delete(int id)
        {
            _userRepozitory.Delete(id);
        }

        public void Update(User user)
        {
            _userRepozitory.Update(user);
        }

    }
}
