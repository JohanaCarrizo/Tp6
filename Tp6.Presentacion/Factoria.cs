using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Tp6.Presentacion
{
    public class Factoria
    {
        /// <summary>
        /// Implemplementacion Singleton
        /// </summary>
        private static volatile Factoria _instance; //Recurso para hacer un bloqueo. Impedir que se creee mas de una instancia de la clase.
        private static readonly object _syncLock = new object(); //Varios hilos puden acceder a la variable, solo uno de los hilos puede instanciar.
        //Si algun hilo accede a _instance, bloquea el acceso a otro hilo y garantiza que se cree una sola instancia.

        private UnityContainer _container;

        private Factoria()
        {

        }

        public static Factoria Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if(_instance == null)
                    {
                        _instance = new Factoria();
                    }
                }
                return _instance;
            }
        }

        public void SetContenedor(UnityContainer container)
        {
            _container = container;
        }

        public T Crear<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
