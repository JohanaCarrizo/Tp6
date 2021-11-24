using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Dominio;

namespace Tp6.Infraestructura.Datos
{
    public class Inventario : IRepositorio
    {
        private List<Producto> _inventario = new List<Producto>();

        public void AgregarProducto(Producto nuevoProducto)
        {        
            if (YaExiste(nuevoProducto.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
            _inventario.Add(nuevoProducto);
        }

        public void EliminarProducto(int codigo)
        {
            if(YaExiste(codigo))
            {
                int indiceEliminar = _inventario.FindIndex(x => x.Codigo == codigo);
                _inventario.RemoveAt(indiceEliminar);
            }
        }

        public Producto BuscarProducto(int codigo)
        {
            return _inventario.Find(x => x.Codigo == codigo);
        }

        public void ModificarProducto(int codigoActual, Producto productoModificado)
        {
            if (codigoActual != productoModificado.Codigo && YaExiste(productoModificado.Codigo)) throw new Exception("Ya existe un producto con este codigo.");
            int indiceModificar = _inventario.FindIndex(x => x.Codigo == codigoActual);
            _inventario[indiceModificar] = productoModificado;
        }

        private bool YaExiste(int codigoConsulta)
        {
            return _inventario.Exists(x => x.Codigo == codigoConsulta);
        }

        public List<Producto> ObtenerLista()
        {
            return _inventario;
        }

        public List<Producto> FiltrarLista(string terminoBusqueda)
        {
            return _inventario.FindAll(x => x.Descripcion.ToLower().Contains(terminoBusqueda?.ToLower()));
        }
    }
}
