using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades;
using Tienda.Negocio;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsCompra compra = new ClsCompra();
            NClsCompra nclscompra = new NClsCompra();

            Console.WriteLine("¿Qué día es ahora? ");
            compra.Dia = Console.ReadLine();

            Console.WriteLine("Ingrese el total a pagar: ");

            compra.Total= Double.Parse(Console.ReadLine());

            Console.WriteLine(nclscompra.Compra(compra));

            Console.ReadLine();
        }
    }
}
