using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancarias
{
    class CuentaCorreinteDolares : Cuentas
    {
        public override decimal Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto <= Fondo)
            {
                if (tipo == TipoExtraccion.CajeroHumano)
                {
                    return monto;
                }
                else
                {
                    if (monto <= 200)
                    {
                        return monto;
                    }
                    else
                    {
                        Console.WriteLine("El monto máximo de extraccion por cajero automatico es de $200");
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
