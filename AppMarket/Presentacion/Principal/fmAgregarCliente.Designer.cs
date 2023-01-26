namespace Presentacion.Principal
{
    partial class fmAgregarCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAP = new System.Windows.Forms.TextBox();
            this.labelAP = new System.Windows.Forms.Label();
            this.textBoxAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.empleados1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(404, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 25);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 12;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(61, 34);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(90, 15);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "Doc. Identidad :";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(171, 104);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(153, 23);
            this.textBoxDNI.TabIndex = 15;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doc. Identidad :";
            // 
            // textBoxAP
            // 
            this.textBoxAP.Location = new System.Drawing.Point(171, 157);
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new System.Drawing.Size(247, 23);
            this.textBoxAP.TabIndex = 17;
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(61, 160);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(101, 15);
            this.labelAP.TabIndex = 16;
            this.labelAP.Text = "Apellido Paterno :";
            // 
            // textBoxAM
            // 
            this.textBoxAM.Location = new System.Drawing.Point(171, 215);
            this.textBoxAM.Name = "textBoxAM";
            this.textBoxAM.Size = new System.Drawing.Size(247, 23);
            this.textBoxAM.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido Materno : ";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(171, 266);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(247, 23);
            this.textBoxNombres.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sexo : ";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "M",
            "F",
            "Indeciso",
            "Valor"});
            this.comboBoxSexo.Location = new System.Drawing.Point(171, 327);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(89, 23);
            this.comboBoxSexo.TabIndex = 24;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Image = global::Presentacion.Properties.Resources.empleados1;
            this.btnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCliente.Location = new System.Drawing.Point(210, 393);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(145, 25);
            this.btnGuardarCliente.TabIndex = 26;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(260, 426);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 15);
            this.labelMensaje.TabIndex = 27;
            // 
            // fmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAP);
            this.Controls.Add(this.labelAP);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelDNI);
            this.Name = "fmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmAgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private TextBox textBox1;
        private Label labelDNI;
        private TextBox textBoxDNI;
        private Label label1;
        private TextBox textBoxAP;
        private Label labelAP;
        private TextBox textBoxAM;
        private Label label3;
        private TextBox textBoxNombres;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxSexo;
        private Splitter splitter1;
        private Button btnGuardarCliente;
        private Label labelMensaje;
    }
}