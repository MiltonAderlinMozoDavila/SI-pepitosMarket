namespace Presentacion.Principal
{
    partial class fmClientes
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
            this.paMenu = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.paMain = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.paMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(800, 39);
            this.paMenu.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 350);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(800, 100);
            this.footer.TabIndex = 1;
            // 
            // paMain
            // 
            this.paMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.paMain.Controls.Add(this.btnGuardar);
            this.paMain.Controls.Add(this.labelRespuesta);
            this.paMain.Controls.Add(this.labelEstado);
            this.paMain.Controls.Add(this.comboBoxEstados);
            this.paMain.Controls.Add(this.btnBuscar);
            this.paMain.Controls.Add(this.textBox4);
            this.paMain.Controls.Add(this.labelCodigo);
            this.paMain.Controls.Add(this.textBox3);
            this.paMain.Controls.Add(this.labelNombres);
            this.paMain.Controls.Add(this.textBox2);
            this.paMain.Controls.Add(this.labelSexo);
            this.paMain.Controls.Add(this.textBox1);
            this.paMain.Controls.Add(this.labelDNI);
            this.paMain.Controls.Add(this.textBoxTipo);
            this.paMain.Controls.Add(this.lbTipo);
            this.paMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paMain.Location = new System.Drawing.Point(0, 39);
            this.paMain.Name = "paMain";
            this.paMain.Size = new System.Drawing.Size(800, 311);
            this.paMain.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(400, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Location = new System.Drawing.Point(367, 124);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(69, 15);
            this.labelRespuesta.TabIndex = 13;
            this.labelRespuesta.Text = "Respuesta : ";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(331, 215);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(48, 15);
            this.labelEstado.TabIndex = 12;
            this.labelEstado.Text = "Estado :";
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Bloqueado"});
            this.comboBoxEstados.Location = new System.Drawing.Point(386, 212);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEstados.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.empleados1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(307, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(200, 35);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(617, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 23);
            this.textBox4.TabIndex = 9;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(550, 169);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(52, 15);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "Codigo :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(369, 23);
            this.textBox3.TabIndex = 7;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(69, 169);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(62, 15);
            this.labelNombres.TabIndex = 6;
            this.labelNombres.Text = "Nombres :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(617, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 23);
            this.textBox2.TabIndex = 5;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(564, 215);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(38, 15);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 3;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(41, 35);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(90, 15);
            this.labelDNI.TabIndex = 2;
            this.labelDNI.Text = "Doc. Identidad :";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(617, 32);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(153, 23);
            this.textBoxTipo.TabIndex = 1;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(564, 35);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(36, 15);
            this.lbTipo.TabIndex = 0;
            this.lbTipo.Text = "Tipo :";
            // 
            // fmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paMain);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.paMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmClientes";
            this.Text = "fmClientes";
            this.paMain.ResumeLayout(false);
            this.paMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel paMenu;
        private Panel footer;
        private Panel paMain;
        private Button btnBuscar;
        private TextBox textBox4;
        private Label labelCodigo;
        private TextBox textBox3;
        private Label labelNombres;
        private TextBox textBox2;
        private Label labelSexo;
        private TextBox textBox1;
        private Label labelDNI;
        private TextBox textBoxTipo;
        private Label lbTipo;
        private Button btnGuardar;
        private Label labelRespuesta;
        private Label labelEstado;
        private ComboBox comboBoxEstados;
    }
}