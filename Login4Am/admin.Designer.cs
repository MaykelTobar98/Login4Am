
namespace Login4Am
{
    partial class admin
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
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_sms);
            this.panel1.Controls.Add(this.btn_cerrarsesion);
            this.panel1.Controls.Add(this.lbl_mensaje);
            this.panel1.Location = new System.Drawing.Point(43, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 493);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarsesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrarsesion.Location = new System.Drawing.Point(114, 191);
            this.btn_cerrarsesion.Margin = new System.Windows.Forms.Padding(6);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(227, 94);
            this.btn_cerrarsesion.TabIndex = 3;
            this.btn_cerrarsesion.Text = "Cerrar sesion";
            this.btn_cerrarsesion.UseVisualStyleBackColor = false;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(109, 394);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(201, 25);
            this.lbl_mensaje.TabIndex = 2;
            this.lbl_mensaje.Text = "Bienvenido al sistema";
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Location = new System.Drawing.Point(370, 393);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(0, 25);
            this.lbl_sms.TabIndex = 4;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 564);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "admin";
            this.Text = "admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Label lbl_sms;
    }
}