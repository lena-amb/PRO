using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class KategoriaPizza
    {
        public KategoriaPizza()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int IdKategoriaPizza { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
