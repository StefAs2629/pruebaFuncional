using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace programacionfuncionaltemporal
{
    internal class OperacionesFinancieras
    {

        public double DescuentoFuncional(double cantidad)
        {
            Func<double, double> descuento = (cantidad) =>cantidad>1500?cantidad * 0.8:cantidad;

            return descuento(cantidad);
        }


        public double CalcularDescuento(double cantidad)
        {
            double descuento;
            if (cantidad > 1500)
                descuento = cantidad * 0.8;

            else
                descuento = cantidad;

            return descuento;
        }

        public double IvaFuncional(double cantidad)
        {
            Func<double, double> iva = (n) => n * 1.16;
            
            return iva(cantidad);

        }

        public double CalcularIva(double cantidad)
        {
           
            return cantidad* 1.16;
        }
    }
}
