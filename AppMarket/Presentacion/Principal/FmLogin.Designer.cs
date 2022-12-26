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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paLoginData = new System.Windows.Forms.Panel();
            this.iconPassword = new System.Windows.Forms.PictureBox();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.LoginPassawordLabel = new System.Windows.Forms.Label();
            this.LoginUserLabel = new System.Windows.Forms.Label();
            this.LoginTextBoxUsuer = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.paLoginData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 461);
            this.panel1.TabIndex = 0;
            // 
            // paLoginData
            // 
            this.paLoginData.AutoSize = true;
            this.paLoginData.Controls.Add(this.iconPassword);
            this.paLoginData.Controls.Add(this.iconUser);
            this.paLoginData.Controls.Add(this.LoginPassawordLabel);
            this.paLoginData.Controls.Add(this.LoginUserLabel);
            this.paLoginData.Controls.Add(this.LoginTextBoxUsuer);
            this.paLoginData.Controls.Add(this.textBoxPassword);
            this.paLoginData.Controls.Add(this.btnIngresar);
            this.paLoginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paLoginData.Location = new System.Drawing.Point(353, 0);
            this.paLoginData.Name = "paLoginData";
            this.paLoginData.Size = new System.Drawing.Size(431, 461);
            this.paLoginData.TabIndex = 1;
            // 
            // iconPassword
            // 
            this.iconPassword.Image = global::Presentacion.Properties.Resources.empleados;
            this.iconPassword.Location = new System.Drawing.Point(310, 215);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(28, 33);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPassword.TabIndex = 5;
            this.iconPassword.TabStop = false;
            // 
            // iconUser
            // 
            this.iconUser.Image = global::Presentacion.Properties.Resources.icon_man;
            this.iconUser.Location = new System.Drawing.Point(312, 135);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(28, 32);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUser.TabIndex = 4;
            this.iconUser.TabStop = false;
            // 
            // LoginPassawordLabel
            // 
            this.LoginPassawordLabel.AutoSize = true;
            this.LoginPassawordLabel.Location = new System.Drawing.Point(128, 207);
            this.LoginPassawordLabel.Name = "LoginPassawordLabel";
            this.LoginPassawordLabel.Size = new System.Drawing.Size(67, 15);
            this.LoginPassawordLabel.TabIndex = 3;
            this.LoginPassawordLabel.Text = "Contraseña";
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AutoSize = true;
            this.LoginUserLabel.Location = new System.Drawing.Point(126, 104);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.Size = new System.Drawing.Size(47, 15);
            this.LoginUserLabel.TabIndex = 3;
            this.LoginUserLabel.Text = "Usuario";
            // 
            // LoginTextBoxUsuer
            // 
            this.LoginTextBoxUsuer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTextBoxUsuer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.LoginTextBoxUsuer.Location = new System.Drawing.Point(128, 141);
            this.LoginTextBoxUsuer.Name = "LoginTextBoxUsuer";
            this.LoginTextBoxUsuer.Size = new System.Drawing.Size(176, 23);
            this.LoginTextBoxUsuer.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(128, 225);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(176, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.UseWaitCursor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(189, 311);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.paLoginData);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmLogin";
            this.paLoginData.ResumeLayout(false);
            this.paLoginData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel paLoginData;
        private Label LoginUserLabel;
        private TextBox LoginTextBoxUsuer;
        private TextBox textBoxPassword;
        private Button btnIngresar;
        private Label LoginPassawordLabel;
        private PictureBox iconPassword;
        private PictureBox iconUser;
    }
}