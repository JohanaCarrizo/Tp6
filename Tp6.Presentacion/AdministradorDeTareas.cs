using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion
{
    //En esta clase la funcion es brindar un medio para ejecuctar las tareas
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas _instance;
        private static readonly object _syncLock = new object();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdministradorDeTareas();
                    }
                }
                return _instance;
            }
        }
        #endregion

        public void Iniciar<TTarea>(IVista mdiPadre = null)
            where TTarea : ITarea
        {
            var tarea = Factoria.Instance.Crear<TTarea>(); 
            tarea.Iniciar(mdiPadre);
        }
    }
}
