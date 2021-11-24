using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    /// <summary>
    /// Todos los presentadores deben implementar la interfaz.
    /// En la práctica es más útil heredar de <see cref="PresentadorBase"/> 
    /// o la versión genérica <see cref="PresentadorBase{Task, View}"/> que
    /// implementan los miembros de IPresentador.
    /// </summary>
    public interface IPresentador
    {
        /// <summary>
        /// Enlaza el presentador con el objeto de contexto <see cref="ITarea"/>
        /// y que sirve para relacionar varios presentadores y como medio para compartir
        /// datos.
        /// <para>
        /// El método setter de la propiedad Tarea se puede utilizar para inicializar lo
        /// necesario en el presentador.
        /// <code>
        /// class MiPresentador : PresentadorBase
        /// {
        ///     public override ITarea Tarea
        ///     {
        ///         get { return base.Tarea; }
        ///         set
        ///         {
        ///             base.Tarea = value;
        ///             //Inicializar lo necesario
        ///         }
        ///     }
        /// }
        /// </code>
        /// </para>
        /// </summary>
        ITarea Tarea { get; set; }

        /// <summary>
        /// Enlaza al presentador con su vista. De acuerdo al patrón MVP, el presentador
        /// accede a su vista.
        /// <para>
        /// El método setter de la propiedad Vista se puede utilizar para inicializar lo
        /// necesario en vista.
        /// <code>
        /// class MiPresentador : PresentadorBase
        /// {
        ///     public override IVista Vista
        ///     {
        ///         get { return base.Vista; }
        ///         set
        ///         {
        ///             base.Vista = value;
        ///             //Inicializar lo necesario en la vista
        ///         }
        ///     }
        /// }
        /// </code>
        /// </para>
        /// </summary>
        IVista Vista { get; set; }
    }
}
