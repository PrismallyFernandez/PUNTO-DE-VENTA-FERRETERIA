using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class ClaProductos
    {
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO { get; set; }

        public decimal COSTO { get; set; }

        public char ESTADO { get; set; }

        public string SUPLIDOR { get; set; }

    }
}
