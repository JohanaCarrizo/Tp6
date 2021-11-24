using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Presentadores;

namespace Tp6.Presentacion.Vistas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="IVista{T}"/> para formularios de Windows.
    /// Tiene una asociación fuertemente tipada al presentador. Esta clase sirve para ser heredada.
    /// <para>
    /// Se recomienda el uso de esta clase para heredar en los formularios de Windows.
    /// </para>
    /// </summary>
    public abstract class VistaBase<T> : VistaBase, IVista<T>
        where T: class, IPresentador
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IVista{T}.Presentador"/>
        /// </summary>
        public new T Presentador { get; set; }

        /// <summary>
        /// Implementación de <see cref="IVista.Presentador"/> 
        /// como puerta de enlace al propiedad fuertemente tipada a la
        /// propiedad <see cref="IVista{T}.Presentador"/>
        /// </summary>
        IPresentador IVista.Presentador
        {
            get { return Presentador; }
            set { Presentador = value as T; }
        }
    }
}
