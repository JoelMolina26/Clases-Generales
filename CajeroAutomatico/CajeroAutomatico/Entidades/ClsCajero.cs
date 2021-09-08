using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entidades
{
    class ClsCajero
    {
        private int dato;

        public ClsCajero()
        {
        }

        public ClsCajero(int dato)
        {
            this.dato = dato;
        }

        public int Dato { get => dato; set => dato = value; }
    }
}
