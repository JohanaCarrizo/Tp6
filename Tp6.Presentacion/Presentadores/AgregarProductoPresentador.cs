using System;
using Tp6.Presentacion.Interfaces;
using Tp6.Dominio;
using Tp6.Infraestructura.Datos;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    public class AgregarProductoPresentador :  PresentadorBase<ProductoTarea, IAgregarProductoVista>
    {
        Producto _productoSource;
        IRepositorio _repositorio;
        public AgregarProductoPresentador(IAgregarProductoVista vista, 
            IRepositorio repositorio) : base(vista)
        {
            _repositorio = repositorio;
            CrearProductoSource();
        }
        
        public void CrearProductoSource()
        {
            _productoSource = null;
            _productoSource = new Producto();
            Vista.RecibirProducto(_productoSource);
        }

        public void AgregarProductos()
        {
            try
            {
                _repositorio.AgregarProducto(_productoSource);
                Vista.MostrarMensaje("Producto agregado con exito.", Mensaje.EXITO);
                //_vista.ActualizarTabla(Inventario.ObtenerLista());                   
                CrearProductoSource();
            }
            catch (FormatException formatoExcepcion)
            {
                Vista.MostrarMensaje(formatoExcepcion.Message, Mensaje.ERROR);
            }
            catch (Exception excepcionExistencia)
            {
                Vista.MostrarMensaje(excepcionExistencia.Message, Mensaje.ERROR);
            }
        }
    }
}
