using Cinema.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.BisinessLogic.Server
{
    public interface ISessionServies
    {
        Session GetOne(int id);

        void Delete(int id);

        void Add(Session session);

        void Update(Session session);

        List<Session> GetAll();
    }

    public class SessionServies : ISessionServies
    {
        private readonly SessionRepozitory _sessionRepozitory;

        public SessionService()
        {
            _sessionRepozitory = new SessionRepozitory();
        }

        public List<Session> GetAll()
        {
            return _sessionRepozitory.GetAll()
                .OrderBy(g => g.Name)
                .ToList();

        }

        public Session GetOne(int id)
        {
            return _sessionRepozitory.GetOne(id);
        }

        public void Add(Session session)
        {
            _sessionRepozitory.Add(session);
        }

        public void Delete(int id)
        {
            _sessionRepozitory.Delete(id);
        }

        public void Update(Session session)
        {
            _sessionRepozitory.Update(session);
        }

    }
}
