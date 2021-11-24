using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    /// <summary>
    /// Implementación simple de la interfaz <see cref="IPresentador"/>.
    /// Los miembros se definen como virtuales para poder ser sobreescritos en las clases derivadas.
    /// <para>
    /// Se recomienda el uso de la versión genérica de la clase <see cref="PresentadorBase{Task, View}"/>
    /// con asociaciones fuertemente tipadas.
    /// </para>
    /// </summary>
    public class PresentadorBase : IPresentador
    {
        /// <summary>
        /// Propiedad que representa la tarea asociada al presentador.
        /// Puede ser sobreescrita en las clases derivadas <see cref="IPresentador.Tarea"/>
        /// </summary>
        public virtual ITarea Tarea { get; set; }

        /// <summary>
        /// Propiedad que representa la vista asociada al presentador.
        /// Puede ser sobreescrita en las clases derivadas <see cref="IPresentador.Vista"/>
        /// </summary>
        public virtual IVista Vista { get; set; }
    }
}
