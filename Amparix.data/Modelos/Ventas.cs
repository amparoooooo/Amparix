using System.Globalization;

namespace Amparix.data.Context
{
    public class Ventas
    {
        public int Id { get; set; }

        public required string NumeroFactura { get; set; }

        public int Cantidad { get; set; }

        public required string Codigo { get; set; }

        public required string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Itbis{ get; set; }
        public decimal Valor { get; set; }
    }
}
