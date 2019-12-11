using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Osoba
    {
        public Osoba()
        {
            Klient = new HashSet<Klient>();
            Pracownik = new HashSet<Pracownik>();
        }

        public int IdOsoba { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Klient> Klient { get; set; }
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
