using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }
        public int TotalPagina
        {
            get
            {
                var qtds = (int)Math.Ceiling((decimal)(ItensTotal / ItensPorPagina));

                if ((ItensTotal % ItensPorPagina) > 0) 
                ++qtds;  

                return qtds;

            }
        }
    }
    
}