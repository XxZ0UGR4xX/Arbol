using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Nodo
    {
        public int Valor {  get; set; }
        public Nodo NodoIzq { get; set; }

        public Nodo NodoDer {  get; set; }

    }
}
