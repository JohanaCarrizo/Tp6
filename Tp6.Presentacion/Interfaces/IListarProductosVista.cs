using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Dominio;

namespace Tp6.Presentacion.Interfaces
{
    public interface IListarProductosVista: IVista
    {
        void ActualizarTabla(List<Producto> inventario);
        void MostrarMensaje(string descripcion, Mensaje tipo);
        bool ConfirmarEliminacion();
    }
}
