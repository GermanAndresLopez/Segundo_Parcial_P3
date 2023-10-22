using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        empleadoService empleadoService = new empleadoService();
        Empleados empleados = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Empleados registarDatos()
        {
            Empleados empleado = new Empleados()
            {
                identifiacion = textBoxId.Text,
                nombre = textBoxNombre.Text,
                salarioBase = double.Parse(textBoxSalarioBase.Text),
                estado = comboBoxEstado.Text
            };
            return empleado;
        } 

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Equals("") || textBoxNombre.Text.Equals("") || textBoxSalarioBase.Text.Equals("") || comboBoxEstado.Text.Equals(""))
            {
                MessageBox.Show("hay un campon Vacio");
            }
            else
            {
                MessageBox.Show(empleadoService.Registar(registarDatos()));
            }
        }

        private void keyLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLetras(e);
        }
    }
}
