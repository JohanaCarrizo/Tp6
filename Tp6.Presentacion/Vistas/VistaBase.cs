using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tp6.Presentacion.Interfaces;
using Tp6.Presentacion.Presentadores;

namespace Tp6.Presentacion.Vistas
{
    /// <summary>
    /// Implementación base de la interfaz <see cref="IVista"/> para formularios de Windows.
    /// Esta clase sirve para ser heredada.
    /// <para>
    /// Se recomienda el uso de la versión genérica de la clase <see cref="VistaBase{T}"/>
    /// con asociación fuertemente tipada al presentador.
    /// </para>
    /// </summary>
    public abstract class VistaBase : Form, IVista
    {
        /// <summary>
        /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IVista.Presentador"/>
        /// </summary>
        public virtual IPresentador Presentador { get; set; }

        /// <summary>
        /// Implementación de <see cref="IVista.Mostrar(IVista)"/>
        /// </summary>
        public void Mostrar(IVista padre = null)
        {
            if (padre != null)
            {
                MdiParent = (Form)padre;
            }
            Show();
        }

        /// <summary>
        /// Implementación de <see cref="IVista.MostrarComoDialogo"/>
        /// </summary>
        public void MostrarComoDialogo()
        {
            ShowDialog();
        }

        /// <summary>
        /// Método especial para validar que se ingresen solo números en 
        /// un cuadro de texto.
        /// </summary>
        /// <param name="sender">Cuadro de texto a validar</param>
        protected void SoloNumeros(TextBox sender)
        {
            var text = sender.Text;
            var pos = sender.SelectionStart;

            Regex rgx = new Regex("[^0-9]");

            text = rgx.Replace(text, "");

            sender.Text = text;

            sender.Select(Math.Max(pos, 0), 0);
        }
    }
}
