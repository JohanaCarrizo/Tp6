using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;

namespace Tp6.Presentacion.Presentadores
{
    public class PrincipalPresentador: PresentadorBase<TareaBase, IPrincipalVista>
    {
        public PrincipalPresentador(IPrincipalVista vista): base(vista)
        {

        }

        public void IniciarProductos()
        {
            AdministradorDeTareas.Instance.Iniciar<ProductoTarea>(Vista);
        }
    }
}
