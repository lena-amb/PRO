using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            SkladnikPizza = new HashSet<SkladnikPizza>();
        }

        public int IdPizza { get; set; }
        public string Nazwa { get; set; }
        public int Rozmiar { get; set; }
        public decimal Cena { get; set; }
        public int IdKategoria { get; set; }

        public virtual KategoriaPizza IdKategoriaNavigation { get; set; }
        public virtual ICollection<SkladnikPizza> SkladnikPizza { get; set; }
    }
}
