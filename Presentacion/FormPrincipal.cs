using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormatoHija(object FormatoHija)
        {
            if (panelPaginas.Controls.Count > 0)
                panelPaginas.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            formatohija.TopLevel = false;
            formatohija.Dock = DockStyle.Fill;
            panelPaginas.Controls.Add(formatohija);
            panelPaginas.Tag = formatohija;
            formatohija.Show();

        }

        private void Registar_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FormRegistrarEmpleados());
        }
    }
}
