namespace Presentacion
{
    partial class FormPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Liquidacion = new System.Windows.Forms.Button();
            this.Registar = new System.Windows.Forms.Button();
            this.panelPaginas = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.Liquidacion);
            this.panelMenu.Controls.Add(this.Registar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(116, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // Liquidacion
            // 
            this.Liquidacion.Location = new System.Drawing.Point(0, 100);
            this.Liquidacion.Name = "Liquidacion";
            this.Liquidacion.Size = new System.Drawing.Size(114, 50);
            this.Liquidacion.TabIndex = 1;
            this.Liquidacion.Text = "Liquidacion";
            this.Liquidacion.UseVisualStyleBackColor = true;
            // 
            // Registar
            // 
            this.Registar.Location = new System.Drawing.Point(0, 28);
            this.Registar.Name = "Registar";
            this.Registar.Size = new System.Drawing.Size(114, 50);
            this.Registar.TabIndex = 0;
            this.Registar.Text = "Registar Emplado";
            this.Registar.UseVisualStyleBackColor = true;
            this.Registar.Click += new System.EventHandler(this.Registar_Click);
            // 
            // panelPaginas
            // 
            this.panelPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaginas.Location = new System.Drawing.Point(116, 0);
            this.panelPaginas.Name = "panelPaginas";
            this.panelPaginas.Size = new System.Drawing.Size(948, 681);
            this.panelPaginas.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panelPaginas);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Liquidacion;
        private System.Windows.Forms.Button Registar;
        private System.Windows.Forms.Panel panelPaginas;
    }
}