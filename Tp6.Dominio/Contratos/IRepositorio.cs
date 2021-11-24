using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Dominio;

namespace Tp6.Dominio
{
    public interface IRepositorio
    {
        void AgregarProducto(Producto nuevoProducto);
        Producto BuscarProducto(int codigo);
        void EliminarProducto(int codigo);
        List<Producto> FiltrarLista(string terminoBusqueda);
        void ModificarProducto(int codigoActual, Producto productoModificado);
        List<Producto> ObtenerLista();
    }
}
