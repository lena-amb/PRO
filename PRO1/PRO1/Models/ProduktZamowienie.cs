using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class ProduktZamowienie
    {
        public int IdProdukt { get; set; }
        public int NumerZamowienia { get; set; }

        public virtual ProduktMenu IdProduktNavigation { get; set; }
        public virtual Zamowienie NumerZamowieniaNavigation { get; set; }
    }
}
