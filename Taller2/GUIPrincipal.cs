using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Taller2
{
    public partial class GUIPrincipal : Form
    {
        private Arbol_Nodo arbol;

        public GUIPrincipal()
        {
            InitializeComponent();
            arbol = new Arbol_Nodo();
            
        }

        private void butAddDer_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int estatura = Int32.Parse(txtEstatura.Text);

            Arbolito nuevo = new Arbolito(estatura, nombre, null, null, null);

            arbol.agregarNodoDer(nuevo);


        }

        private void butAddIzq_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int estatura = Int32.Parse(txtEstatura.Text);

            Arbolito nuevo = new Arbolito(estatura, nombre, null, null, null);

            arbol.agregarNodoIzq(nuevo);
        }
        

        public void mostrar(Arbolito actual)
        {
            if(actual == null)
            {
                rbtArbol.Text = "Arbol vacio";

            }
            else
            {
                rbtArbol.Text = "Nodo actual" + Environment.NewLine + "Nombre: " + actual.getNombre() +
                                Environment.NewLine + "Estatura: " + actual.getEstaura() + Environment.NewLine +
                                "Nivel: " + actual.getNivel();
            }
        }

        private void butMostrar_Click(object sender, EventArgs e)
        {
            mostrar(arbol.getActual());
        }

       
    }
}
