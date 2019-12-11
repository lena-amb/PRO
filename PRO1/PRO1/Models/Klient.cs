using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class Klient
    {
        public Klient()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int NrKlient { get; set; }
        public int? NrKartyDuzejRodziny { get; set; }
        public int? NrLegitymacji { get; set; }
        public int IdOsoba { get; set; }

        public virtual Osoba IdOsobaNavigation { get; set; }
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
