using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRO1.Models
{
    public partial class ProduktMenu
    {
        public ProduktMenu()
        {
            ProduktZamowienie = new HashSet<ProduktZamowienie>();
        }

        public int IdProdukt { get; set; }
        [Required(ErrorMessage = "Nazwa produktu jest wymagana")]
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int IdKategoria { get; set; }

        public virtual KategoriaProdukt IdKategoriaNavigation { get; set; }
        public virtual ICollection<ProduktZamowienie> ProduktZamowienie { get; set; }
    }
}
