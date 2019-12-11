using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Skadnik
    {
        public Skadnik()
        {
            SkladnikPizza = new HashSet<SkladnikPizza>();
        }

        public int IdSkładnik { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public virtual ICollection<SkladnikPizza> SkladnikPizza { get; set; }
    }
}
