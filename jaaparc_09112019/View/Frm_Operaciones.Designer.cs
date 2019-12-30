namespace View
{
    partial class Frm_Operaciones
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnfibonacci = new System.Windows.Forms.Button();
            this.btnfactorial = new System.Windows.Forms.Button();
            this.btnpares = new System.Windows.Forms.Button();
            this.btnpascal = new System.Windows.Forms.Button();
            this.listresultado = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(59, 46);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(147, 20);
            this.txtnumero.TabIndex = 0;
            // 
            // btnfibonacci
            // 
            this.btnfibonacci.Location = new System.Drawing.Point(212, 44);
            this.btnfibonacci.Name = "btnfibonacci";
            this.btnfibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnfibonacci.TabIndex = 1;
            this.btnfibonacci.Text = "Fibonacci";
            this.btnfibonacci.UseVisualStyleBackColor = true;
            this.btnfibonacci.Click += new System.EventHandler(this.btnfibonacci_Click);
            // 
            // btnfactorial
            // 
            this.btnfactorial.Location = new System.Drawing.Point(374, 46);
            this.btnfactorial.Name = "btnfactorial";
            this.btnfactorial.Size = new System.Drawing.Size(75, 23);
            this.btnfactorial.TabIndex = 3;
            this.btnfactorial.Text = "Factorial";
            this.btnfactorial.UseVisualStyleBackColor = true;
            this.btnfactorial.Click += new System.EventHandler(this.btnfactorial_Click);
            // 
            // btnpares
            // 
            this.btnpares.Location = new System.Drawing.Point(212, 75);
            this.btnpares.Name = "btnpares";
            this.btnpares.Size = new System.Drawing.Size(237, 23);
            this.btnpares.TabIndex = 4;
            this.btnpares.Text = "Suma 100 primeros pares";
            this.btnpares.UseVisualStyleBackColor = true;
            this.btnpares.Click += new System.EventHandler(this.btnpares_Click);
            // 
            // btnpascal
            // 
            this.btnpascal.Location = new System.Drawing.Point(212, 104);
            this.btnpascal.Name = "btnpascal";
            this.btnpascal.Size = new System.Drawing.Size(237, 23);
            this.btnpascal.TabIndex = 5;
            this.btnpascal.Text = "Triangulo de Pascal";
            this.btnpascal.UseVisualStyleBackColor = true;
            this.btnpascal.Click += new System.EventHandler(this.btnpascal_Click);
            // 
            // listresultado
            // 
            this.listresultado.FormattingEnabled = true;
            this.listresultado.Location = new System.Drawing.Point(59, 72);
            this.listresultado.Name = "listresultado";
            this.listresultado.Size = new System.Drawing.Size(147, 225);
            this.listresultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listresultado);
            this.Controls.Add(this.btnpascal);
            this.Controls.Add(this.btnpares);
            this.Controls.Add(this.btnfactorial);
            this.Controls.Add(this.btnfibonacci);
            this.Controls.Add(this.txtnumero);
            this.Name = "Frm_Operaciones";
            this.Text = "Frm_Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnfibonacci;
        private System.Windows.Forms.Button btnfactorial;
        private System.Windows.Forms.Button btnpares;
        private System.Windows.Forms.Button btnpascal;
        private System.Windows.Forms.ListBox listresultado;
        private System.Windows.Forms.Button button1;
    }
}