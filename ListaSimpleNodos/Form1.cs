using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimpleNodos
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
            miLista.Cargar("testListaSimple");
            miLista.Mostrar(lstDato1);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtingresar.Text);
            string nombre = txtNombre.Text;
            string telefono = txttelefono.Text;
            Nodo n = new Nodo(numero, nombre, telefono);
            miLista.Agregar(n);
            txtingresar.Clear();
            txtNombre.Clear();
            txttelefono.Clear();
            txtingresar.Focus();
            miLista.Mostrar(lstDato1);
            miLista.Guardar("ListaCircular");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtingresar.Text);
                miLista.Eliminar(numero);
                txtingresar.Clear();
                txtNombre.Clear();
                txttelefono.Clear();
                txtingresar.Focus();
                miLista.Mostrar(lstDato1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtingresar.Text);
                Nodo b = new Nodo();
                if (miLista.Buscar(numero, ref b))
                {
                    txtNombre.Text = b.Nombre;
                    txttelefono.Text = b.Telefono;
                    //MessageBox.Show("Existe");
                }
                else
                {
                    txtingresar.Clear();
                    txtNombre.Clear();
                    txttelefono.Clear();
                    MessageBox.Show("No existe");
                }
                txtingresar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void btnModifi_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtingresar.Text);
                miLista.Modificar(numero, txtNombre.Text, txttelefono.Text);
                txtingresar.Clear();
                txtNombre.Clear();
                txttelefono.Clear();
                txtingresar.Focus();
                miLista.Mostrar(lstDato1);
                //MessageBox.Show(miLista + " ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
