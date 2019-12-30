namespace View
{
    partial class Frm_Clientes
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
            this.TabPanelPrincipal = new System.Windows.Forms.TabControl();
            this.TabPanelAsignarMedidor = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumCuota = new System.Windows.Forms.TextBox();
            this.CbxNumeroMedidorAsignar = new System.Windows.Forms.ComboBox();
            this.TxtFechaInstalacion = new System.Windows.Forms.TextBox();
            this.TxtIdClienteAsignar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGuardarAsignarCliente = new System.Windows.Forms.Button();
            this.TxtFechaLimitePago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CbxBasePagar = new System.Windows.Forms.ComboBox();
            this.TxtValorPagado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCostoRegistro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtIntereses = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TabPanelActualizaeEstado = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtIdMedidorFinalizar = new System.Windows.Forms.TextBox();
            this.BtnFinalizarRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumMedidorFinalizar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.CbxGenero = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CbxComunidad = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtnGuardarClientes = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdClienteRegistrar = new System.Windows.Forms.TextBox();
            this.TabPageRegistrarCliente = new System.Windows.Forms.TabPage();
            this.TabPanelPrincipal.SuspendLayout();
            this.TabPanelAsignarMedidor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabPanelActualizaeEstado.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabPageRegistrarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPanelPrincipal
            // 
            this.TabPanelPrincipal.Controls.Add(this.TabPageRegistrarCliente);
            this.TabPanelPrincipal.Controls.Add(this.TabPanelAsignarMedidor);
            this.TabPanelPrincipal.Controls.Add(this.TabPanelActualizaeEstado);
            this.TabPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabPanelPrincipal.Name = "TabPanelPrincipal";
            this.TabPanelPrincipal.SelectedIndex = 0;
            this.TabPanelPrincipal.Size = new System.Drawing.Size(835, 709);
            this.TabPanelPrincipal.TabIndex = 40;
            // 
            // TabPanelAsignarMedidor
            // 
            this.TabPanelAsignarMedidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TabPanelAsignarMedidor.Controls.Add(this.panel1);
            this.TabPanelAsignarMedidor.Location = new System.Drawing.Point(4, 22);
            this.TabPanelAsignarMedidor.Name = "TabPanelAsignarMedidor";
            this.TabPanelAsignarMedidor.Padding = new System.Windows.Forms.Padding(3);
            this.TabPanelAsignarMedidor.Size = new System.Drawing.Size(827, 683);
            this.TabPanelAsignarMedidor.TabIndex = 1;
            this.TabPanelAsignarMedidor.Text = "Asignar Medidor";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNumCuota);
            this.panel1.Controls.Add(this.CbxNumeroMedidorAsignar);
            this.panel1.Controls.Add(this.TxtFechaInstalacion);
            this.panel1.Controls.Add(this.TxtIdClienteAsignar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnGuardarAsignarCliente);
            this.panel1.Controls.Add(this.TxtFechaLimitePago);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.CbxBasePagar);
            this.panel1.Controls.Add(this.TxtValorPagado);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtCostoRegistro);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.TxtIntereses);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(155, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 606);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Número de Cuota";
            // 
            // TxtNumCuota
            // 
            this.TxtNumCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtNumCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumCuota.ForeColor = System.Drawing.Color.White;
            this.TxtNumCuota.Location = new System.Drawing.Point(26, 293);
            this.TxtNumCuota.Name = "TxtNumCuota";
            this.TxtNumCuota.Size = new System.Drawing.Size(475, 23);
            this.TxtNumCuota.TabIndex = 76;
            this.TxtNumCuota.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumeroCuota);
            // 
            // CbxNumeroMedidorAsignar
            // 
            this.CbxNumeroMedidorAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.CbxNumeroMedidorAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxNumeroMedidorAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNumeroMedidorAsignar.ForeColor = System.Drawing.Color.White;
            this.CbxNumeroMedidorAsignar.FormattingEnabled = true;
            this.CbxNumeroMedidorAsignar.Location = new System.Drawing.Point(26, 127);
            this.CbxNumeroMedidorAsignar.Name = "CbxNumeroMedidorAsignar";
            this.CbxNumeroMedidorAsignar.Size = new System.Drawing.Size(477, 24);
            this.CbxNumeroMedidorAsignar.TabIndex = 74;
            // 
            // TxtFechaInstalacion
            // 
            this.TxtFechaInstalacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtFechaInstalacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFechaInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaInstalacion.ForeColor = System.Drawing.Color.White;
            this.TxtFechaInstalacion.Location = new System.Drawing.Point(26, 348);
            this.TxtFechaInstalacion.Name = "TxtFechaInstalacion";
            this.TxtFechaInstalacion.Size = new System.Drawing.Size(477, 23);
            this.TxtFechaInstalacion.TabIndex = 73;
            // 
            // TxtIdClienteAsignar
            // 
            this.TxtIdClienteAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtIdClienteAsignar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdClienteAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdClienteAsignar.ForeColor = System.Drawing.Color.White;
            this.TxtIdClienteAsignar.Location = new System.Drawing.Point(28, 72);
            this.TxtIdClienteAsignar.Name = "TxtIdClienteAsignar";
            this.TxtIdClienteAsignar.Size = new System.Drawing.Size(475, 23);
            this.TxtIdClienteAsignar.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Fecha Instalación";
            // 
            // BtnGuardarAsignarCliente
            // 
            this.BtnGuardarAsignarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.BtnGuardarAsignarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarAsignarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarAsignarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarAsignarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarAsignarCliente.Location = new System.Drawing.Point(26, 556);
            this.BtnGuardarAsignarCliente.Name = "BtnGuardarAsignarCliente";
            this.BtnGuardarAsignarCliente.Size = new System.Drawing.Size(475, 35);
            this.BtnGuardarAsignarCliente.TabIndex = 72;
            this.BtnGuardarAsignarCliente.Text = "Siguiente";
            this.BtnGuardarAsignarCliente.UseVisualStyleBackColor = false;
            this.BtnGuardarAsignarCliente.Click += new System.EventHandler(this.BtnGuardarAsignarCliente_Click);
            // 
            // TxtFechaLimitePago
            // 
            this.TxtFechaLimitePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtFechaLimitePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFechaLimitePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaLimitePago.ForeColor = System.Drawing.Color.White;
            this.TxtFechaLimitePago.Location = new System.Drawing.Point(26, 403);
            this.TxtFechaLimitePago.Name = "TxtFechaLimitePago";
            this.TxtFechaLimitePago.Size = new System.Drawing.Size(477, 23);
            this.TxtFechaLimitePago.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Identificador Único del Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Costo Registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Fecha Límite Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Concepto de Pago";
            // 
            // CbxBasePagar
            // 
            this.CbxBasePagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.CbxBasePagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxBasePagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBasePagar.ForeColor = System.Drawing.Color.White;
            this.CbxBasePagar.FormattingEnabled = true;
            this.CbxBasePagar.Location = new System.Drawing.Point(28, 182);
            this.CbxBasePagar.Name = "CbxBasePagar";
            this.CbxBasePagar.Size = new System.Drawing.Size(477, 24);
            this.CbxBasePagar.TabIndex = 70;
            // 
            // TxtValorPagado
            // 
            this.TxtValorPagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtValorPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorPagado.ForeColor = System.Drawing.Color.White;
            this.TxtValorPagado.Location = new System.Drawing.Point(26, 458);
            this.TxtValorPagado.Name = "TxtValorPagado";
            this.TxtValorPagado.Size = new System.Drawing.Size(477, 23);
            this.TxtValorPagado.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "Interés";
            // 
            // TxtCostoRegistro
            // 
            this.TxtCostoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtCostoRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCostoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoRegistro.ForeColor = System.Drawing.Color.White;
            this.TxtCostoRegistro.Location = new System.Drawing.Point(26, 237);
            this.TxtCostoRegistro.Name = "TxtCostoRegistro";
            this.TxtCostoRegistro.Size = new System.Drawing.Size(477, 23);
            this.TxtCostoRegistro.TabIndex = 67;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(25, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "Valor a Pagar";
            // 
            // TxtIntereses
            // 
            this.TxtIntereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtIntereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntereses.ForeColor = System.Drawing.Color.White;
            this.TxtIntereses.Location = new System.Drawing.Point(26, 513);
            this.TxtIntereses.Name = "TxtIntereses";
            this.TxtIntereses.Size = new System.Drawing.Size(477, 23);
            this.TxtIntereses.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "Número Medidor";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(528, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ingresar datos";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TabPanelActualizaeEstado
            // 
            this.TabPanelActualizaeEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TabPanelActualizaeEstado.Controls.Add(this.panel3);
            this.TabPanelActualizaeEstado.Location = new System.Drawing.Point(4, 22);
            this.TabPanelActualizaeEstado.Name = "TabPanelActualizaeEstado";
            this.TabPanelActualizaeEstado.Padding = new System.Windows.Forms.Padding(3);
            this.TabPanelActualizaeEstado.Size = new System.Drawing.Size(827, 683);
            this.TabPanelActualizaeEstado.TabIndex = 2;
            this.TabPanelActualizaeEstado.Text = "Finalizar";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtIdMedidorFinalizar);
            this.panel3.Controls.Add(this.BtnFinalizarRegistro);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtNumMedidorFinalizar);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.textBox67);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(148, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 285);
            this.panel3.TabIndex = 3;
            // 
            // TxtIdMedidorFinalizar
            // 
            this.TxtIdMedidorFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtIdMedidorFinalizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdMedidorFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdMedidorFinalizar.ForeColor = System.Drawing.Color.White;
            this.TxtIdMedidorFinalizar.Location = new System.Drawing.Point(28, 72);
            this.TxtIdMedidorFinalizar.Name = "TxtIdMedidorFinalizar";
            this.TxtIdMedidorFinalizar.Size = new System.Drawing.Size(475, 23);
            this.TxtIdMedidorFinalizar.TabIndex = 57;
            // 
            // BtnFinalizarRegistro
            // 
            this.BtnFinalizarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.BtnFinalizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFinalizarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizarRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizarRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinalizarRegistro.Location = new System.Drawing.Point(26, 226);
            this.BtnFinalizarRegistro.Name = "BtnFinalizarRegistro";
            this.BtnFinalizarRegistro.Size = new System.Drawing.Size(475, 35);
            this.BtnFinalizarRegistro.TabIndex = 72;
            this.BtnFinalizarRegistro.Text = "Finalizar Registro";
            this.BtnFinalizarRegistro.UseVisualStyleBackColor = false;
            this.BtnFinalizarRegistro.Click += new System.EventHandler(this.BtnFinalizarRegistro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Identificador Único del Medidor";
            // 
            // TxtNumMedidorFinalizar
            // 
            this.TxtNumMedidorFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtNumMedidorFinalizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumMedidorFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumMedidorFinalizar.ForeColor = System.Drawing.Color.White;
            this.TxtNumMedidorFinalizar.Location = new System.Drawing.Point(26, 128);
            this.TxtNumMedidorFinalizar.Name = "TxtNumMedidorFinalizar";
            this.TxtNumMedidorFinalizar.Size = new System.Drawing.Size(477, 23);
            this.TxtNumMedidorFinalizar.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Estado del Medidor";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(25, 108);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(150, 17);
            this.label25.TabIndex = 60;
            this.label25.Text = "Número de Medidor";
            // 
            // textBox67
            // 
            this.textBox67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox67.ForeColor = System.Drawing.Color.White;
            this.textBox67.Location = new System.Drawing.Point(26, 183);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(477, 23);
            this.textBox67.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(528, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Finalizar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.TabPanelPrincipal);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(835, 669);
            this.PanelContenedor.TabIndex = 41;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtIdClienteRegistrar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtCedula);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.BtnGuardarClientes);
            this.panel2.Controls.Add(this.TxtTelefono);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.CbxComunidad);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.CbxGenero);
            this.panel2.Controls.Add(this.TxtCelular);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.TxtApellido);
            this.panel2.Controls.Add(this.TxtNombre);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.TxtEmail);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Location = new System.Drawing.Point(150, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 609);
            this.panel2.TabIndex = 40;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(528, 35);
            this.button12.TabIndex = 0;
            this.button12.Text = "Ingresar datos";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(24, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 17);
            this.label24.TabIndex = 68;
            this.label24.Text = "Nombre:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(25, 510);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(477, 23);
            this.TxtEmail.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(24, 435);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 17);
            this.label23.TabIndex = 60;
            this.label23.Text = "Celular:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.White;
            this.TxtNombre.Location = new System.Drawing.Point(27, 179);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(475, 23);
            this.TxtNombre.TabIndex = 69;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.White;
            this.TxtApellido.Location = new System.Drawing.Point(27, 234);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(475, 23);
            this.TxtApellido.TabIndex = 67;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(24, 490);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 17);
            this.label22.TabIndex = 58;
            this.label22.Text = "Email:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.ForeColor = System.Drawing.Color.White;
            this.TxtCelular.Location = new System.Drawing.Point(25, 455);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(477, 23);
            this.TxtCelular.TabIndex = 61;
            // 
            // CbxGenero
            // 
            this.CbxGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.CbxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGenero.ForeColor = System.Drawing.Color.White;
            this.CbxGenero.FormattingEnabled = true;
            this.CbxGenero.Location = new System.Drawing.Point(25, 289);
            this.CbxGenero.Name = "CbxGenero";
            this.CbxGenero.Size = new System.Drawing.Size(477, 24);
            this.CbxGenero.TabIndex = 70;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(24, 214);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 17);
            this.label21.TabIndex = 66;
            this.label21.Text = "Apellido:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(24, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Teléfono:";
            // 
            // CbxComunidad
            // 
            this.CbxComunidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.CbxComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxComunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxComunidad.ForeColor = System.Drawing.Color.White;
            this.CbxComunidad.FormattingEnabled = true;
            this.CbxComunidad.Location = new System.Drawing.Point(25, 345);
            this.CbxComunidad.Name = "CbxComunidad";
            this.CbxComunidad.Size = new System.Drawing.Size(477, 24);
            this.CbxComunidad.TabIndex = 71;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(24, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 65;
            this.label19.Text = "Genero:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(24, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 56;
            this.label18.Text = "Cédula:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.White;
            this.TxtTelefono.Location = new System.Drawing.Point(25, 400);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(477, 23);
            this.TxtTelefono.TabIndex = 63;
            // 
            // BtnGuardarClientes
            // 
            this.BtnGuardarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(139)))), ((int)(((byte)(198)))));
            this.BtnGuardarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarClientes.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarClientes.Location = new System.Drawing.Point(27, 546);
            this.BtnGuardarClientes.Name = "BtnGuardarClientes";
            this.BtnGuardarClientes.Size = new System.Drawing.Size(475, 35);
            this.BtnGuardarClientes.TabIndex = 72;
            this.BtnGuardarClientes.Text = "Siguiente";
            this.BtnGuardarClientes.UseVisualStyleBackColor = false;
            this.BtnGuardarClientes.Click += new System.EventHandler(this.BtnGuardarClientes_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(24, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 17);
            this.label17.TabIndex = 64;
            this.label17.Text = "Comunidad:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.ForeColor = System.Drawing.Color.White;
            this.TxtCedula.Location = new System.Drawing.Point(27, 124);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(475, 23);
            this.TxtCedula.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Identificador Único del Cliente";
            // 
            // TxtIdClienteRegistrar
            // 
            this.TxtIdClienteRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TxtIdClienteRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdClienteRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdClienteRegistrar.ForeColor = System.Drawing.Color.White;
            this.TxtIdClienteRegistrar.Location = new System.Drawing.Point(27, 69);
            this.TxtIdClienteRegistrar.Name = "TxtIdClienteRegistrar";
            this.TxtIdClienteRegistrar.Size = new System.Drawing.Size(475, 23);
            this.TxtIdClienteRegistrar.TabIndex = 74;
            // 
            // TabPageRegistrarCliente
            // 
            this.TabPageRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.TabPageRegistrarCliente.Controls.Add(this.panel2);
            this.TabPageRegistrarCliente.Controls.Add(this.BtnCerrar);
            this.TabPageRegistrarCliente.Location = new System.Drawing.Point(4, 22);
            this.TabPageRegistrarCliente.Name = "TabPageRegistrarCliente";
            this.TabPageRegistrarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRegistrarCliente.Size = new System.Drawing.Size(827, 683);
            this.TabPageRegistrarCliente.TabIndex = 0;
            this.TabPageRegistrarCliente.Text = "Registrar Cliente";
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 669);
            this.Controls.Add(this.PanelContenedor);
            this.Name = "Frm_Clientes";
            this.Text = "Frm_Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.TabPanelPrincipal.ResumeLayout(false);
            this.TabPanelAsignarMedidor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabPanelActualizaeEstado.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabPageRegistrarCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabPanelPrincipal;
        private System.Windows.Forms.TabPage TabPanelAsignarMedidor;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage TabPanelActualizaeEstado;
        private System.Windows.Forms.TextBox TxtIdClienteAsignar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGuardarAsignarCliente;
        private System.Windows.Forms.TextBox TxtFechaLimitePago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CbxBasePagar;
        private System.Windows.Forms.TextBox TxtValorPagado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCostoRegistro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtIntereses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtFechaInstalacion;
        private System.Windows.Forms.ComboBox CbxNumeroMedidorAsignar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumCuota;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtIdMedidorFinalizar;
        private System.Windows.Forms.Button BtnFinalizarRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumMedidorFinalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage TabPageRegistrarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtIdClienteRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnGuardarClientes;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CbxComunidad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CbxGenero;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button BtnCerrar;
    }
}