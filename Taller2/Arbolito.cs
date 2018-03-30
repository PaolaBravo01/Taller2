using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    class Arbolito
    {
        private Arbolito izquierda;
        private Arbolito derecha;
        private Arbolito arriba;
        private int nivel;
        private int estatura;
        private String nombre;

        public Arbolito(int pEstatura, String pNombre, Arbolito pIzquierda, Arbolito pDerecha, Arbolito pArriba)
        {
            estatura = pEstatura;
            nombre = pNombre;
            izquierda = pIzquierda;
            derecha = pDerecha;
            arriba = pArriba;
            nivel = 0;


        }


        public Arbolito getIzquierda()
        {
            return izquierda;
        }
        public void setIzquierda(Arbolito pIzquierda)
        {
            izquierda = pIzquierda;
        }
        public Arbolito getDerecha()
        {
            return derecha;
        }
        public void setDerecha(Arbolito pDerecha)
        {
            derecha = pDerecha;
        }
        public Arbolito getArriba()
        {
            return arriba;
        }
        public void setArriba(Arbolito pArriba)
        {
            arriba = pArriba;
        }

        public int getNivel()
        {
            return nivel;
        }

        public void setNivel(int pNivel)
        {
            nivel = pNivel;
        }

        public int getEstaura()
        {
            return estatura;
        }

        public void setEstatura(int pEstatura)
        {
            estatura = pEstatura;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }


    }
}
