using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Presentadores;

namespace Tp6.Presentacion.Tareas
{
    public class ProductoTarea: TareaBase
    {
        public int ProductoId { get; set; }

        public ProductoTarea()
        {
            
        }

        public override void Iniciar(IVista mdiPadre = null)
        {
            MdiPadre = mdiPadre;
            NavegarA<ListarProductoPresentador>(esMdiHijo: true);
        }
    }
}
