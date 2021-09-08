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

    class CuentaCorrientePesos
    {
        decimal fondo;

        public decimal Fondo { get => fondo; set => fondo = value; }

        public void Insercion(int monto)
        {
            Fondo += monto;
        }

        public decimal Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto <= Fondo + 5000)
            {
                if (tipo == TipoExtraccion.CajeroAutomatico)
                {
                    return monto;
                }
                else
                {
                    if (monto <= 20000)
                    {
                        return monto;
                    }
                    else
                    {
                        Console.WriteLine("El monto máximo de extraccion por cajero automatico es de $20.000");
                        return 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
                return 0;
            }
            
        }
    }
}
