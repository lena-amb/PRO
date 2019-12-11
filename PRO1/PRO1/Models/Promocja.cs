using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Promocja
    {
        public Promocja()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdPromocja { get; set; }
        public string Opis { get; set; }
        public int RabatProcent { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
