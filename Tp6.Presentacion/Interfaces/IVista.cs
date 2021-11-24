using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Presentacion.Presentadores;

namespace Tp6.Presentacion.Interfaces
{
    /// <summary>
    /// Las vistas deben implementar esta interfaz.
    /// <para>
    /// Por conveniencia se definió la versión genérica <see cref="IVista{T}"/>
    /// para asociaciones fuertemente tipadas al presentador.
    /// </para>   
    /// </summary>
    public interface IVista
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista.
        /// </summary>
        IPresentador Presentador { get; set; }

        /// <summary>
        /// Método para visualizar la vista.
        /// Si se incluye el argumento en la llamada la vista se inicia como hija.
        /// </summary>
        /// <param name="padre">Vista padre para casos MDI</param>
        void Mostrar(IVista padre = null);

        /// <summary>
        /// Método para visualizar la vista como un cuadro de diálogo.
        /// </summary>
        void MostrarComoDialogo();
    }
}
