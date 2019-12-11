using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Pracownik
    {
        public int IdPracownik { get; set; }
        public int IdOsoba { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public DateTime? DataKoncaUmowy { get; set; }

        public virtual Osoba IdOsobaNavigation { get; set; }
    }
}
