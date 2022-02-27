using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWMAMPAS.Data.Models
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public List<Performer> Performers { get; set; }

        public Movie(string Title, string Director)
        {
            this.Title = Title;
            this.Director = Director;
            Performers = new List<Performer>();
        }
    }
}
