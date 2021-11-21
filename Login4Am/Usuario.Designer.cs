
namespace Login4Am
{
    partial class Usuario
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
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_sms);
            this.panel1.Controls.Add(this.btn_cerrarsesion);
            this.panel1.Controls.Add(this.lbl_cerrar);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 502);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.Location = new System.Drawing.Point(51, 232);
            this.btn_cerrarsesion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(230, 63);
            this.btn_cerrarsesion.TabIndex = 1;
            this.btn_cerrarsesion.Text = "Cerrar Sesion";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.Location = new System.Drawing.Point(20, 395);
            this.lbl_cerrar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(314, 32);
            this.lbl_cerrar.TabIndex = 0;
            this.lbl_cerrar.Text = "Bienvenido al sistema";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Location = new System.Drawing.Point(401, 401);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(0, 25);
            this.lbl_sms.TabIndex = 2;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 533);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.Label lbl_sms;
    }
}