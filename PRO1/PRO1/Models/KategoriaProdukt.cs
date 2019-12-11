using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class KategoriaProdukt
    {
        public KategoriaProdukt()
        {
            ProduktMenu = new HashSet<ProduktMenu>();
        }

        public int IdKategoriaProdukt { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<ProduktMenu> ProduktMenu { get; set; }
    }
}
