using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model.Model
{
    public class Session
    {
        public int Id { get; set; }
        public List<Film> Film { get; set; }
        public DateTime Sloat { get; set; }
        public List<Hall> Hall { get; set; }
    }
}
