using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApp
{
    public class User
    {
        public string NomerVTablice { get; set; }
        public string LubimoeChislo { get; set; }
        public string Name { get; set; }
    }

}
