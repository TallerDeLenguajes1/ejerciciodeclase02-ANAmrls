using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancarias
{    
    class CuentaCorrientePesos : Cuentas
    {
        public override decimal Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto <= Fondo + 5000)
            {
                if (tipo == TipoExtraccion.CajeroHumano)
                {
                    Fondo -= monto;
                    return monto;
                }
                else
                {
                    if (monto <= 20000)
                    {
                        Fondo -= monto;
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
