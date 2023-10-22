using BLL;
using Entity;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrarEmpleados : Form
    {
        public empleadoService empleadoService = new empleadoService();
        public Empleados empleados = new Empleados();
        public FormRegistrarEmpleados()
        {
            InitializeComponent();
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

        private void panelFondo_Paint(object sender, PaintEventArgs e)
        {

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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrarEstado.Text == "Todos")
            {
                dataGridView1.DataSource = null;
                RespuestaConsulta respuesta = new RespuestaConsulta();
                respuesta = empleadoService.Consultar();
                dataGridView1.DataSource = respuesta.Empleados;

            }
            else if(comboBoxFiltrarEstado.Text == "Activo")
            {
                dataGridView1.DataSource = null;
                RespuestaListaEstado respuestaLista = new RespuestaListaEstado();
                respuestaLista = empleadoService.FiltradoPorEstados("Activo");
                dataGridView1.DataSource = respuestaLista.Empleados;

            }
            else if(comboBoxFiltrarEstado.Text == "Inactivo")
            {
                dataGridView1.DataSource = null;
                RespuestaListaEstado respuestaLista = new RespuestaListaEstado();
                respuestaLista = empleadoService.FiltradoPorEstados("Inactivo");
                dataGridView1.DataSource = respuestaLista.Empleados;
            }
            if (textBoxFiltrarName.Text != "")
            {
                dataGridView1.DataSource = null;
                RespuestaListaEstado respuestaLista = new RespuestaListaEstado();
                respuestaLista = empleadoService.FiltradoPorEstados("Activo");
                dataGridView1.DataSource = respuestaLista.Empleados;
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLetras(e);
        }

        private void textBoxFiltrarName_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyLetras(e);
        }

        private void llenarDataGriv()
        {
            dataGridView1.DataSource = null;
            RespuestaListaEstado respuestaLista = new RespuestaListaEstado();
            respuestaLista = empleadoService.FiltradoPorNombre(textBoxFiltrarName.Text);
            dataGridView1.DataSource = respuestaLista.Empleados;
        }
    }
}
