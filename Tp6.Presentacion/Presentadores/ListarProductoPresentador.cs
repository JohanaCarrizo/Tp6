using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Vistas;
using Tp6.Dominio;
using Tp6.Infraestructura.Datos;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    public class ListarProductoPresentador: PresentadorBase<ProductoTarea, IListarProductosVista>
    {
        private readonly IRepositorio _repositorio;

        public ListarProductoPresentador(IListarProductosVista vista, 
            IRepositorio repositorio): base(vista)
        {
            _repositorio = repositorio;
        }

        public void ActualizarInventario()
        {
            Vista.ActualizarTabla(_repositorio.ObtenerLista());
        }

        public void FiltarInventario(string terminoBusqueda)
        {
            if (string.IsNullOrEmpty(terminoBusqueda))
            {
                ActualizarInventario();
            }
            else
            {
                Vista.ActualizarTabla(_repositorio.FiltrarLista(terminoBusqueda));
            }           
        }

        public void AgregarProducto()
        {
            Tarea.NavegarA<AgregarProductoPresentador>(esDialogo: true, esMdiHijo: true);
            ActualizarInventario();
        }

        public void ModificarProducto(int codigoModificar)
        {
            Tarea.ProductoId = codigoModificar;
            Tarea.NavegarA<ModificarProductoPresentador>(esDialogo: true, esMdiHijo: true);
            ActualizarInventario();
        }

        public void EliminarProducto(int codigo)
        {
            if (Vista.ConfirmarEliminacion())
            {
                _repositorio.EliminarProducto(codigo);
                Vista.MostrarMensaje("Producto eliminado con exito.", Mensaje.EXITO);
                ActualizarInventario();
            }
        }
    }
}
