using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEDEfacturacion
{

    public partial class Form1 : Form

    {
        private BusinessLogicLayer _businessLogicLayer;
        public Form1()

        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {


        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SaveCliente();///llama a objeto cliente
        }
        private void SaveCliente()
        {
            Cliente cliente = new Cliente();///he creado un objeto de la clase cliente
            cliente.Nombre = txtnombre.Text;///Los atributos de l clase clietne es igual a lo que tengo
            cliente.DNI = txtDNI.Text;///en la caja de texto o text box
            cliente.Direccion = txtdireccion.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Estado = txtestado.Text;

            _businessLogicLayer.SaveCliente(cliente);///estoy llamando el metodo de la clase negocios
        }                                            ///y le paso com parametros lo que tengo en el objeto
                                                     ///de la clase cliente   
        private void Form1_Load(object sender, EventArgs e)///ejecuta funcion al inicio de form
        {
            PopulateClientes();///llama a funcion para grilla, carga funcion a la grilla
        }
        private void PopulateClientes()
        {
            List<Cliente> Clientes = _businessLogicLayer.GetClientes();
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
