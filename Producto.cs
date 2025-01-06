using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMySQL2
{
    internal class Producto
    { 
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string Titulo { get; set; }
        public string NroISBN { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Genero { get; set; }
        public int Edicion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Idioma { get; set; }
        public int NumeroPaginas { get; set; }
        public long CantidadImpresa { get; set; }
        public object idLibro { get; set; }
    }
}
