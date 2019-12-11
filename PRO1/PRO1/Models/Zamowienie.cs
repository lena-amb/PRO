using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Zamowienie
    {
        public Zamowienie()
        {
            ProduktZamowienie = new HashSet<ProduktZamowienie>();
        }

        public int NumerZamowienia { get; set; }
        public int NrKlienta { get; set; }
        public decimal Cena { get; set; }
        public string Ulica { get; set; }
        public int NumerDomu { get; set; }
        public int? NumerLokalu { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public int? IdPromocja { get; set; }
        public DateTime Data { get; set; }

        public virtual Promocja IdPromocjaNavigation { get; set; }
        public virtual Klient NrKlientaNavigation { get; set; }
        public virtual ICollection<ProduktZamowienie> ProduktZamowienie { get; set; }
    }
}
