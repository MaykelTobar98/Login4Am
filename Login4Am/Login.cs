using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Login4Am
{
    public partial class Login : Form
    {
        //creamos cadena de conexion
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0L945B1;Initial Catalog=LOGWFA;Integrated Security=True");
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_usu.Text) || String.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Campos vacios...!!");
            }
            else
            {
                logear(txt_usu.Text, txt_usu.Text);
            }
        }

        private void logear(string usu, string pass)
        {
            try
            {
                //verificamos en base de datos si el usuario existe
                con.Open();
                SqlCommand cmd = new SqlCommand("select usu_nombre, tusu_id from Tbl_Usuario where usu_nomlogin = @usuario", con);
                cmd.Parameters.AddWithValue("usuario", usu);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count ==1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre, tusu_id from Tbl_Usuario where usu_nomlogin = @usuario and usu_password = @passw", con);
                    cmd1.Parameters.AddWithValue("usuario", usu);
                    cmd1.Parameters.AddWithValue("passw", pass);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    con.Close();

                    if (dt1.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt1.Rows[0][1].ToString()== "1")
                        {
                            new admin().ShowDialog();
                        }
                        else if (dt1.Rows[0][1].ToString() == "2")
                        {
                            new Usuario().ShowDialog();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no registrado..");
                }
            }
            catch(Exception ex)
            { 
            throw;

            }
        }

        private void lnk_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
