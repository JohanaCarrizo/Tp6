using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp6.Dominio;
using Tp6.Infraestructura.Datos;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Tareas;
using Tp6.Presentacion.Vistas;
using Unity;

namespace Tp6.Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new UnityContainer();
            Factoria.Instance.SetContenedor(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Registracion de Tipos
            container.RegisterType<IPrincipalVista, PrincipalVista>();
            container.RegisterType<IAgregarProductoVista, AgregarProductoVista>();
            container.RegisterType<IListarProductosVista, ListarProductosVista>();
            container.RegisterType<IModificarProductoVista, ModificarProductoVista>();
            container.RegisterSingleton<IRepositorio, Inventario>();
            #endregion

            AdministradorDeTareas.Instance.Iniciar<PrincipalTarea>();
            Application.Run(Application.OpenForms[0]);
        }
    }
}
