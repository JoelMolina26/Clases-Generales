using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades;

namespace Tienda.Negocio
{
    class NClsCompra
    {
        public String Compra(ClsCompra compra) {

            if (compra.Dia == "Martes" || compra.Dia == "Jueves")
            {


                Double descuento = compra.Total * 0.15;

                return " Total: " + compra.Total +
                    "\n decuento: " + descuento +
                    "\n Total con descuento: " + (compra.Total - descuento);


            }

            else
            {

                return " Total: " + compra.Total;



            }







        }
    }


}


