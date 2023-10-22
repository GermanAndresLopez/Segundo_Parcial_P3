namespace Presentacion
{
    partial class FormRegistrarEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFondo = new System.Windows.Forms.Panel();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelSalarioBase = new System.Windows.Forms.Label();
            this.textBoxSalarioBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFiltrarEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFiltrarName = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.label3);
            this.panelFondo.Controls.Add(this.comboBoxFiltrarEstado);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.textBoxFiltrarName);
            this.panelFondo.Controls.Add(this.buttonBuscar);
            this.panelFondo.Controls.Add(this.dataGridView1);
            this.panelFondo.Controls.Add(this.textBoxNombre);
            this.panelFondo.Controls.Add(this.comboBoxEstado);
            this.panelFondo.Controls.Add(this.textBoxId);
            this.panelFondo.Controls.Add(this.buttonRegistar);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.label4);
            this.panelFondo.Controls.Add(this.labelNombre);
            this.panelFondo.Controls.Add(this.labelSalarioBase);
            this.panelFondo.Controls.Add(this.textBoxSalarioBase);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(800, 450);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(160, 114);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 12;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(160, 204);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEstado.TabIndex = 18;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(160, 65);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(191, 264);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(69, 35);
            this.buttonRegistar.TabIndex = 17;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estado";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(85, 117);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            // 
            // labelSalarioBase
            // 
            this.labelSalarioBase.AutoSize = true;
            this.labelSalarioBase.Location = new System.Drawing.Point(85, 159);
            this.labelSalarioBase.Name = "labelSalarioBase";
            this.labelSalarioBase.Size = new System.Drawing.Size(66, 13);
            this.labelSalarioBase.TabIndex = 15;
            this.labelSalarioBase.Text = "Salario Base";
            // 
            // textBoxSalarioBase
            // 
            this.textBoxSalarioBase.Location = new System.Drawing.Point(160, 156);
            this.textBoxSalarioBase.Name = "textBoxSalarioBase";
            this.textBoxSalarioBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioBase.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado";
            // 
            // comboBoxFiltrarEstado
            // 
            this.comboBoxFiltrarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarEstado.FormattingEnabled = true;
            this.comboBoxFiltrarEstado.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.comboBoxFiltrarEstado.Location = new System.Drawing.Point(554, 42);
            this.comboBoxFiltrarEstado.Name = "comboBoxFiltrarEstado";
            this.comboBoxFiltrarEstado.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFiltrarEstado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // textBoxFiltrarName
            // 
            this.textBoxFiltrarName.Location = new System.Drawing.Point(554, 69);
            this.textBoxFiltrarName.Name = "textBoxFiltrarName";
            this.textBoxFiltrarName.Size = new System.Drawing.Size(94, 20);
            this.textBoxFiltrarName.TabIndex = 21;
            this.textBoxFiltrarName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltrarName_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(676, 66);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 20;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 235);
            this.dataGridView1.TabIndex = 19;
            // 
            // FormRegistrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarEmpleados";
            this.Text = "FormRegistrarEmpleados";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSalarioBase;
        private System.Windows.Forms.TextBox textBoxSalarioBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFiltrarEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFiltrarName;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}