using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Presentadores;

namespace Tp6.Presentacion.Tareas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="ITarea"/>.
    /// <para>
    /// Las tareas sirven como objetos de contexto para la interacción de
    /// varios presentadores (y sus vistas).
    /// </para>
    /// </summary>
    public abstract class TareaBase : ITarea
    {
        /// <summary>
        /// Propiedad para determinar la vista padre en relaciones MDI (padre-hijo).
        /// </summary>
        public IVista MdiPadre { get; set; }

        /// <summary>
        /// Método que debe ser implementado en todas las clases que hereden de ésta.
        /// <para>
        /// Se utiliza para inicializar lo necesario desde la tarea. Como la llamada a un presentador inicial.
        /// </para>
        /// </summary>
        /// <param name="mdiPadre"></param>
        public abstract void Iniciar(IVista mdiPadre = null);
        
        public void NavegarA<TPresentador>(bool esDialogo = false, bool esMdiHijo = false)
            where TPresentador : IPresentador
        {
            var presentador = Factoria.Instance.Crear<TPresentador>();
            presentador.Tarea = this;
            if (esDialogo)
            {
                presentador.Vista.MostrarComoDialogo();
            }
            else
            {
                presentador.Vista.Mostrar(MdiPadre);
            }
        }
    }
}
