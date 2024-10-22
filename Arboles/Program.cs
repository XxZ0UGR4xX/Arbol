namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo();
            raiz.Valor = 60;

            raiz.NodoDer = new Nodo();
            raiz.NodoDer.Valor = 74;

            raiz.NodoIzq = new Nodo(); 
            raiz.NodoIzq.Valor = 41;

            raiz.NodoIzq.NodoIzq= new Nodo();
            raiz.NodoIzq.NodoIzq.Valor = 1; 

            raiz.NodoIzq.NodoDer = new Nodo();
            raiz . NodoIzq.NodoDer.Valor = 53; 
            
            raiz.NodoDer.NodoIzq = new Nodo ();
            raiz.NodoDer.NodoIzq.Valor = 65; 

            raiz.NodoIzq.NodoIzq.NodoDer = new Nodo ();
            raiz.NodoIzq.NodoIzq.NodoDer.Valor = 25;

            raiz.NodoIzq.NodoDer.NodoIzq = new Nodo();
            raiz.NodoIzq.NodoDer.NodoIzq.Valor = 46; 

            raiz.NodoIzq.NodoDer.NodoDer= new Nodo ();
            raiz.NodoIzq.NodoDer.NodoDer.Valor = 55; 

            raiz.NodoDer.NodoIzq.NodoIzq = new Nodo ();
            raiz.NodoDer.NodoIzq.NodoIzq.Valor = 63;

            raiz.NodoDer.NodoIzq.NodoDer = new Nodo();
            raiz.NodoDer.NodoIzq.NodoDer.Valor = 70;

            raiz.NodoIzq.NodoDer.NodoIzq.NodoIzq= new Nodo ();
            raiz.NodoIzq.NodoDer.NodoIzq.NodoIzq.Valor =42;

            raiz.NodoDer.NodoIzq.NodoIzq.NodoIzq = new Nodo();
            raiz.NodoDer.NodoIzq.NodoIzq.NodoIzq.Valor = 62;

            raiz.NodoDer.NodoIzq.NodoIzq.NodoDer = new Nodo();
            raiz.NodoDer.NodoIzq.NodoIzq.NodoDer.Valor = 64;







        }
    }
}
