using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWMAMPAS.Data.Models
{
    public class Performer
    {
        public Guid PerformerId { get; set; }
        public string Name { get; set; }

        public Performer(string Name)
        {
            this.Name = Name;
        }
    }
}
