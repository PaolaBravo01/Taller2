using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    public class Arbol_Nodo
    {
        public Arbolito raiz;
        public Arbolito actual;

        
        public Arbolito getActual()
        {
            return actual;
        }

        public void setActual(Arbolito pActual)
        {
            actual = pActual;
        }

        public bool estaVacio()
        {
            if(raiz == null)
            {
                return true;
            }
            return false;
        }

        public void moverArriba()
        {
            if(actual.getArriba()!= null)
            {
                actual = actual.getArriba();
            }
        }

        public void moverIzq()
        {
            if(actual.getIzquierda() != null)
            {
                actual = actual.getIzquierda();
            }
        }

        public void moverDer()
        {
            if(actual.getDerecha() != null)
            {
                actual = actual.getDerecha();
            }
        }


        public void agregarNodoIzq(Arbolito nvo)
        {
            if(estaVacio())
            {
                raiz = nvo;
                actual = raiz;
                return;
            }

            if(actual.getIzquierda() != null)
            {
                throw new Exception("No se puede adicionar a la izquierda");
            }

            actual.setIzquierda(nvo);
            nvo.setArriba(actual);
            nvo.setNivel(actual.getNivel() + 1);

            actual = nvo;

        }

        public void agregarNodoDer(Arbolito nvo)
        {
            if (estaVacio())
            {
                raiz = nvo;
                actual = raiz;
                return;
            }

            if (actual.getDerecha() != null)
            {
                throw new Exception("No se puede adicionar a la derecha");
            }

            actual.setDerecha(nvo);
            nvo.setArriba(actual);
            nvo.setNivel(actual.getNivel() + 1);

            actual = nvo;

        }

        public void modificar(String pNombre, int pEstatura)
        {

        }

        public void eliminar()
        {

        }




    }
}
