using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancarias
{
    public enum TipoExtraccion
    {
        CajeroHumano = 1,
        CajeroAutomatico = 2
    }

    public class Cuentas
    {
        protected decimal fondo;

        public decimal Fondo { get => fondo; set => fondo = value; }

        public void Insercion(int monto)
        {
            Fondo += monto;
        }

        public virtual decimal Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto <= Fondo)
            {
                Fondo -= monto;
                return monto;
            }            
            else
            {
                Console.WriteLine("Fondos insuficientes");
                return 0;
            }

        }
    }
}
