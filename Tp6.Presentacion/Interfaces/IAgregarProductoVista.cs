using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Dominio;

namespace Tp6.Presentacion.Interfaces
{
    public interface IAgregarProductoVista : IVista
    {
        void RecibirProducto(Producto producto);
        void MostrarMensaje(string descripcion, Mensaje tipo);
    }
}
