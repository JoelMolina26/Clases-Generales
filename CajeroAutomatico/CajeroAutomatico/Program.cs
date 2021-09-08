using CajeroAutomatico.Entidades;
using CajeroAutomatico.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsCajero constructor = new ClsCajero();
            NClsCajero nclscajero = new NClsCajero();


            int opcion = 1;
            int dato;
            while (opcion == 1)
            {

                Console.WriteLine(" Ingrese la cantidad que deseas retirar");
                dato = Convert.ToInt32(Console.ReadLine());
                constructor.Dato = dato;
                Console.WriteLine(nclscajero.SacarDinero(constructor));
            }
        }
    }
}
