namespace View
{
    partial class Frm_Factura
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
            this.PanelContenedorfactura = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelContenedorfactura
            // 
            this.PanelContenedorfactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorfactura.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedorfactura.Name = "PanelContenedorfactura";
            this.PanelContenedorfactura.Size = new System.Drawing.Size(800, 450);
            this.PanelContenedorfactura.TabIndex = 0;
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelContenedorfactura);
            this.Name = "Frm_Factura";
            this.Text = "Frm_Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedorfactura;
    }
}