using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_SAP.Models
{
    public class ResultRFC
    {
        public ResultRFC() { }

        public Boolean Exito { get; set; }
        public long Tiempo { get; set; }
        public Object Datos { get; set; }
        public Object Valor { get; set; }
    }
}
