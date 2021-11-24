using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6.Dominio
{
    public class Producto
    {
        #region Constructores
        public Producto()
        {
            _estado = EstadoProducto.ACTIVO;
        }

        public Producto(Producto aCopiar)
        {
            Codigo = aCopiar.Codigo;
            Descripcion = aCopiar.Descripcion;
            PrecioBase = aCopiar.PrecioBase;
            PorcentajeIVA = aCopiar.PorcentajeIVA;
            PrecioIVA = aCopiar.PrecioIVA;
            PrecioFinal = aCopiar.PrecioFinal;
            MargenGanancia = aCopiar.MargenGanancia;
            Existencia = aCopiar.Existencia;
            Estado = aCopiar.Estado;
        }
        #endregion

        #region Atributos
        private int _codigo;
        private double _precioBase;
        private double _porcentajeIVA; 
        private double _precioIVA;
        private double _precioFinal;
        private double _margenGanancia;
        private string _descripcion;
        private int _existencia;
        private EstadoProducto _estado;
        #endregion

        #region Propiedades
        public int Codigo 
        { 
            get { return _codigo; } 
            set { _codigo = value; } 
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public double PrecioBase {
            get { return _precioBase; }
            set 
            { 
                _precioBase = value; 
                _precioIVA = _precioBase + _precioBase * _porcentajeIVA / 100; 
            }
        }

        public double PorcentajeIVA {
            get { return _porcentajeIVA; }
            set 
            { 
                _porcentajeIVA = value; 
                _precioIVA = _precioBase + _precioBase * _porcentajeIVA / 100; 
            }
        }

        public double PrecioIVA {
            get { return _precioIVA; }
            set { _precioIVA = _precioBase + _precioBase * _porcentajeIVA / 100; } 
        }

        public double PrecioFinal {
            get { return _precioFinal; }
            set 
            {
                _precioFinal = value; 
                _margenGanancia = _precioFinal / _precioIVA - 1; 
            } 
        }

        public double MargenGanancia {
            get { return _margenGanancia; }
            set 
            { 
                _margenGanancia = value; 
                _precioFinal = _precioIVA * (_margenGanancia / 100 + 1); ;
            }
        }

        public int Existencia { 
            get { return _existencia; }
            set { _existencia = value; } 
        }

        public EstadoProducto Estado { 
            get { return _estado; }
            set { _estado = value; } 
        }
        #endregion
    }
}
