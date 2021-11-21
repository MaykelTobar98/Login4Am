
namespace Login4Am
{
    partial class Login
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_intentos = new System.Windows.Forms.Label();
            this.lnk_registro = new System.Windows.Forms.LinkLabel();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl__usuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_usu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_intentos);
            this.panel1.Controls.Add(this.lnk_registro);
            this.panel1.Controls.Add(this.btn_ingresar);
            this.panel1.Controls.Add(this.lbl_pass);
            this.panel1.Controls.Add(this.lbl__usuario);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 555);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(151, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bienvenido al sistema";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Info;
            this.txt_pass.Location = new System.Drawing.Point(158, 244);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(221, 29);
            this.txt_pass.TabIndex = 7;
            // 
            // txt_usu
            // 
            this.txt_usu.BackColor = System.Drawing.SystemColors.Info;
            this.txt_usu.Location = new System.Drawing.Point(158, 148);
            this.txt_usu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(221, 29);
            this.txt_usu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // lbl_intentos
            // 
            this.lbl_intentos.AutoSize = true;
            this.lbl_intentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intentos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_intentos.Location = new System.Drawing.Point(162, 438);
            this.lbl_intentos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_intentos.Name = "lbl_intentos";
            this.lbl_intentos.Size = new System.Drawing.Size(96, 25);
            this.lbl_intentos.TabIndex = 4;
            this.lbl_intentos.Text = "Intentos";
            // 
            // lnk_registro
            // 
            this.lnk_registro.AutoSize = true;
            this.lnk_registro.LinkColor = System.Drawing.Color.Red;
            this.lnk_registro.Location = new System.Drawing.Point(404, 372);
            this.lnk_registro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnk_registro.Name = "lnk_registro";
            this.lnk_registro.Size = new System.Drawing.Size(116, 25);
            this.lnk_registro.TabIndex = 3;
            this.lnk_registro.TabStop = true;
            this.lnk_registro.Text = "Registrarme";
            this.lnk_registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_registro_LinkClicked);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ingresar.Location = new System.Drawing.Point(158, 347);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(138, 52);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(21, 244);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(124, 25);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl__usuario
            // 
            this.lbl__usuario.AutoSize = true;
            this.lbl__usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__usuario.Location = new System.Drawing.Point(21, 161);
            this.lbl__usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl__usuario.Name = "lbl__usuario";
            this.lbl__usuario.Size = new System.Drawing.Size(86, 25);
            this.lbl__usuario.TabIndex = 0;
            this.lbl__usuario.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 581);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_intentos;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl__usuario;
        protected System.Windows.Forms.LinkLabel lnk_registro;
    }
}