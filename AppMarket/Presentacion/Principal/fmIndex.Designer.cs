namespace Presentacion.Principal
{
    partial class fmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmIndex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.paHeaderCentro = new System.Windows.Forms.Panel();
            this.paHeaderIzquierda = new System.Windows.Forms.Panel();
            this.imgIconMenu = new System.Windows.Forms.PictureBox();
            this.paHeaderIDerecha = new System.Windows.Forms.Panel();
            this.ImgIconClose = new System.Windows.Forms.PictureBox();
            this.paMenuVertical = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnBoton = new System.Windows.Forms.Button();
            this.paMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.paHeaderIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconMenu)).BeginInit();
            this.paHeaderIDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIconClose)).BeginInit();
            this.paMenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.paHeaderCentro);
            this.panel1.Controls.Add(this.paHeaderIzquierda);
            this.panel1.Controls.Add(this.paHeaderIDerecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 40);
            this.panel1.TabIndex = 0;
            // 
            // paHeaderCentro
            // 
            this.paHeaderCentro.BackColor = System.Drawing.Color.SeaGreen;
            this.paHeaderCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paHeaderCentro.Location = new System.Drawing.Point(60, 0);
            this.paHeaderCentro.Name = "paHeaderCentro";
            this.paHeaderCentro.Size = new System.Drawing.Size(652, 40);
            this.paHeaderCentro.TabIndex = 4;
            this.paHeaderCentro.Paint += new System.Windows.Forms.PaintEventHandler(this.paHeaderCentro_Paint);
            // 
            // paHeaderIzquierda
            // 
            this.paHeaderIzquierda.BackColor = System.Drawing.Color.SeaGreen;
            this.paHeaderIzquierda.Controls.Add(this.imgIconMenu);
            this.paHeaderIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.paHeaderIzquierda.Location = new System.Drawing.Point(0, 0);
            this.paHeaderIzquierda.Name = "paHeaderIzquierda";
            this.paHeaderIzquierda.Size = new System.Drawing.Size(60, 40);
            this.paHeaderIzquierda.TabIndex = 3;
            // 
            // imgIconMenu
            // 
            this.imgIconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgIconMenu.Image = global::Presentacion.Properties.Resources.Mobile_Menu_Icon;
            this.imgIconMenu.Location = new System.Drawing.Point(12, 3);
            this.imgIconMenu.Name = "imgIconMenu";
            this.imgIconMenu.Size = new System.Drawing.Size(34, 34);
            this.imgIconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIconMenu.TabIndex = 0;
            this.imgIconMenu.TabStop = false;
            this.imgIconMenu.Click += new System.EventHandler(this.imgIconMenu_Click);
            // 
            // paHeaderIDerecha
            // 
            this.paHeaderIDerecha.BackColor = System.Drawing.Color.SeaGreen;
            this.paHeaderIDerecha.Controls.Add(this.ImgIconClose);
            this.paHeaderIDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.paHeaderIDerecha.Location = new System.Drawing.Point(712, 0);
            this.paHeaderIDerecha.Name = "paHeaderIDerecha";
            this.paHeaderIDerecha.Size = new System.Drawing.Size(172, 40);
            this.paHeaderIDerecha.TabIndex = 2;
            // 
            // ImgIconClose
            // 
            this.ImgIconClose.Image = ((System.Drawing.Image)(resources.GetObject("ImgIconClose.Image")));
            this.ImgIconClose.Location = new System.Drawing.Point(140, 4);
            this.ImgIconClose.Name = "ImgIconClose";
            this.ImgIconClose.Size = new System.Drawing.Size(29, 30);
            this.ImgIconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgIconClose.TabIndex = 1;
            this.ImgIconClose.TabStop = false;
            this.ImgIconClose.Click += new System.EventHandler(this.ImgIconClose_Click);
            // 
            // paMenuVertical
            // 
            this.paMenuVertical.BackColor = System.Drawing.Color.DarkOrange;
            this.paMenuVertical.Controls.Add(this.panel2);
            this.paMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.paMenuVertical.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.paMenuVertical.Location = new System.Drawing.Point(0, 40);
            this.paMenuVertical.Name = "paMenuVertical";
            this.paMenuVertical.Size = new System.Drawing.Size(60, 721);
            this.paMenuVertical.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnFacturas);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnBoton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 250);
            this.panel2.TabIndex = 10;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 180);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 45);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturas.Image")));
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 135);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(250, 45);
            this.btnFacturas.TabIndex = 12;
            this.btnFacturas.Text = "Venta";
            this.btnFacturas.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 90);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(250, 45);
            this.btnProductos.TabIndex = 11;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 45);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 45);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoton.FlatAppearance.BorderSize = 0;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBoton.ForeColor = System.Drawing.Color.White;
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoton.Location = new System.Drawing.Point(0, 0);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(250, 45);
            this.btnBoton.TabIndex = 9;
            this.btnBoton.Text = "Venta";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // paMain
            // 
            this.paMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paMain.Location = new System.Drawing.Point(60, 40);
            this.paMain.Name = "paMain";
            this.paMain.Size = new System.Drawing.Size(824, 721);
            this.paMain.TabIndex = 3;
            // 
            // fmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.paMain);
            this.Controls.Add(this.paMenuVertical);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.paHeaderIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgIconMenu)).EndInit();
            this.paHeaderIDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgIconClose)).EndInit();
            this.paMenuVertical.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel paMenuVertical;
        private Panel paMain;
        private PictureBox imgIconMenu;
        private PictureBox ImgIconClose;
        private Button btnInicio;
        private Button btnReportes;
        private Button btnFacturas;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnVenta;
        private Button btnInformacion;
        private Button btnConfiguracion;
        private Button btnPersonal;
        private Button btnBoton;
        private Panel panel2;
        private Panel paHeaderCentro;
        private Panel paHeaderIzquierda;
        private Panel paHeaderIDerecha;
    }
}