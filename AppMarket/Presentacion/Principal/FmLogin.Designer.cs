namespace Presentacion.Principal
{
    partial class fmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.LoginUserLabel = new System.Windows.Forms.Label();
            this.LoginPassawordLabel = new System.Windows.Forms.Label();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.iconPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.paLoginData = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paLoginData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 461);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.undraw_shopping_app_flsj;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(421, 461);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(125, 311);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 33);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(88, 236);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(198, 29);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.UseWaitCursor = true;
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AutoSize = true;
            this.LoginUserLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginUserLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginUserLabel.Location = new System.Drawing.Point(88, 144);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.Size = new System.Drawing.Size(60, 19);
            this.LoginUserLabel.TabIndex = 3;
            this.LoginUserLabel.Text = "Usuario";
            // 
            // LoginPassawordLabel
            // 
            this.LoginPassawordLabel.AutoSize = true;
            this.LoginPassawordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPassawordLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginPassawordLabel.Location = new System.Drawing.Point(88, 212);
            this.LoginPassawordLabel.Name = "LoginPassawordLabel";
            this.LoginPassawordLabel.Size = new System.Drawing.Size(84, 19);
            this.LoginPassawordLabel.TabIndex = 3;
            this.LoginPassawordLabel.Text = "Contraseña";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.White;
            this.iconUser.Image = global::Presentacion.Properties.Resources.icon_man;
            this.iconUser.Location = new System.Drawing.Point(283, 168);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(33, 29);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUser.TabIndex = 4;
            this.iconUser.TabStop = false;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.White;
            this.iconPassword.Image = global::Presentacion.Properties.Resources.empleados;
            this.iconPassword.Location = new System.Drawing.Point(283, 236);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(33, 29);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.White;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsuario.Location = new System.Drawing.Point(88, 168);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(198, 29);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.UseWaitCursor = true;
            // 
            // paLoginData
            // 
            this.paLoginData.AutoSize = true;
            this.paLoginData.BackColor = System.Drawing.Color.SeaGreen;
            this.paLoginData.Controls.Add(this.pictureBox3);
            this.paLoginData.Controls.Add(this.tbUsuario);
            this.paLoginData.Controls.Add(this.pictureBox1);
            this.paLoginData.Controls.Add(this.iconPassword);
            this.paLoginData.Controls.Add(this.iconUser);
            this.paLoginData.Controls.Add(this.LoginPassawordLabel);
            this.paLoginData.Controls.Add(this.LoginUserLabel);
            this.paLoginData.Controls.Add(this.tbPassword);
            this.paLoginData.Controls.Add(this.btnIngresar);
            this.paLoginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paLoginData.Location = new System.Drawing.Point(413, 0);
            this.paLoginData.Margin = new System.Windows.Forms.Padding(1);
            this.paLoginData.Name = "paLoginData";
            this.paLoginData.Size = new System.Drawing.Size(371, 461);
            this.paLoginData.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(339, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.paLoginData);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paLoginData.ResumeLayout(false);
            this.paLoginData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnIngresar;
        private TextBox tbPassword;
        private Label LoginUserLabel;
        private Label LoginPassawordLabel;
        private PictureBox iconUser;
        private PictureBox iconPassword;
        private PictureBox pictureBox1;
        private TextBox tbUsuario;
        private Panel paLoginData;
        private PictureBox pictureBox3;
    }
}