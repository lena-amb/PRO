using System;
using System.Collections.Generic;

namespace PRO1.Models
{
    public partial class SkladnikPizza
    {
        public int IdSkladnik { get; set; }
        public int IdPizza { get; set; }

        public virtual Pizza IdPizzaNavigation { get; set; }
        public virtual Skadnik IdSkladnikNavigation { get; set; }
    }
}
