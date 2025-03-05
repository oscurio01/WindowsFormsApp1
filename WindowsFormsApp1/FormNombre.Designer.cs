namespace WindowsFormsApp1
{
    partial class FormNombre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Submit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // labNombre
            // 
            this.labNombre.Location = new System.Drawing.Point(34, 69);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(70, 23);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre:";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(78, 106);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(128, 38);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar nombre";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.listBox1.Location = new System.Drawing.Point(260, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(101, 100);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Submit1
            // 
            this.Submit1.Location = new System.Drawing.Point(127, 211);
            this.Submit1.Name = "Submit1";
            this.Submit1.Size = new System.Drawing.Size(92, 33);
            this.Submit1.TabIndex = 4;
            this.Submit1.Text = "Submit";
            this.Submit1.UseVisualStyleBackColor = true;
            this.Submit1.Click += new System.EventHandler(this.Submit1_Click);
            // 
            // FormNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 331);
            this.Controls.Add(this.Submit1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormNombre";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Submit1;
    }
}

