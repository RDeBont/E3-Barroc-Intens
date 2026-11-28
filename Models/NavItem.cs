using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Barroc_Intens.Models
{

        // Eén knop in de menubalk: de tekst en de pagina die in het Frame geladen wordt
        public record NavItem(string Title, Type PageType);
    
}
