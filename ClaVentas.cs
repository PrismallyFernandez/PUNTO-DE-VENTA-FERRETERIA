using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class ClaVentas
    {
        public int ID { get; set; }

        public int IDCLIENTE { get; set; }

        public decimal MONTO { get; set; }

        public string TIPO { get; set; }
        public string FechaVenta { get; set; }

        public ClaVentas()
        {
            FechaVenta = DateTime.Today.ToString("yyyy-MM-dd");
        }

    }
}
