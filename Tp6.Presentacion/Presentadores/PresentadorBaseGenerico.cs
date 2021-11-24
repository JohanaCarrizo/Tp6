using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    /// <summary>
    /// Clase base que implementa la interfaz <see cref="IPresentador{TTask, TView}"/>.
    /// Tiene asociaciones fuertemente tipadas a la tarea y vista vinculadas
    /// (de los tipos de parámetros genéricos TTask y TView respectivamente).
    /// </summary>
    /// <para>
    /// Los miembros se definieron virtuales para poder sobreescribirse en las clases derivadas.
    /// </para>
    /// <typeparam name="TTask">Representa el tipo de la tarea asociada. Debe ser un 
    /// subtipo de <see cref="ITarea"/></typeparam>
    /// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
    public class PresentadorBase<TTask, TView> : IPresentador<TTask, TView>
        where TTask: class, ITarea
        where TView: class, IVista
    {
        /// <summary>
        /// Simple implementación de la propiedad <see cref="IPresentador{TTask, TView}.Tarea"/>
        /// Representa una asociación fuertemente tipada a la tarea enlazada.
        /// <para>
        /// Para su uso ver <see cref="IPresentador{TTask, TView}.Tarea"/>
        /// </para>
        /// </summary>
        public virtual TTask Tarea { get; set; }

        /// <summary>
        /// Simple implementación de la propiedad <see cref="IPresentador{TTask, TView}.Vista"/>
        /// Representa una asociación fuertemente tipada a la vista enlazada.
        /// <para>
        /// Para su uso ver <see cref="IPresentador{TTask, TView}.Vista"/>
        /// </para>
        /// </summary>
        public virtual TView Vista { get; set; }

        /// <summary>
        /// Implementación de <see cref="IPresentador.Tarea"/> 
        /// como puerta de enlace al propiedad fuertemente tipada a la
        /// propiedad <see cref="IPresentador{TTask, TView}.Tarea"/>
        /// </summary>
        ITarea IPresentador.Tarea
        {
            get { return Tarea; }
            set { Tarea = value as TTask; }
        }

        /// <summary>
        /// Implementación de <see cref="IPresentador.Vista"/> 
        /// como puerta de enlace al propiedad fuertemente tipada a la
        /// propiedad <see cref="IPresentador{TTask, TView}.Vista"/>
        /// </summary>
        IVista IPresentador.Vista
        {
            get { return Vista; }
            set { Vista = value as TView; }
        }

        /// <summary>
        /// Constructor definido para que la vista sea inyectada (via DI).
        /// Se asocia el mismo presentador a la vista, para que ésta pueda invocarlo.
        /// </summary>
        /// <param name="vista">Tipo asociado a la vista</param>
        public PresentadorBase(TView vista)
        {
            Vista = vista;
            Vista.Presentador = this;
        }
    }
}
