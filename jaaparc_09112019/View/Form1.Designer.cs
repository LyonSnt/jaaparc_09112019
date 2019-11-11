namespace View
{
    partial class Form1
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
            this.tablaresul = new System.Windows.Forms.DataGridView();
            this.txtComu = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblcomid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaresul)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaresul
            // 
            this.tablaresul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaresul.Location = new System.Drawing.Point(78, 92);
            this.tablaresul.Name = "tablaresul";
            this.tablaresul.Size = new System.Drawing.Size(339, 241);
            this.tablaresul.TabIndex = 0;
            // 
            // txtComu
            // 
            this.txtComu.Location = new System.Drawing.Point(142, 38);
            this.txtComu.Name = "txtComu";
            this.txtComu.Size = new System.Drawing.Size(100, 20);
            this.txtComu.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(255, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Guardar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(342, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(342, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblcomid
            // 
            this.lblcomid.AutoSize = true;
            this.lblcomid.Location = new System.Drawing.Point(139, 12);
            this.lblcomid.Name = "lblcomid";
            this.lblcomid.Size = new System.Drawing.Size(0, 13);
            this.lblcomid.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 345);
            this.Controls.Add(this.lblcomid);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtComu);
            this.Controls.Add(this.tablaresul);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaresul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaresul;
        private System.Windows.Forms.TextBox txtComu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblcomid;
    }
}

