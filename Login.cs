using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace MeDicHome
{
    public partial class Login : Form
    {
        string chuoiketnoi = "Data Source=XHUNG\\SQLEXPRESS; " + " Initial Catalog=qlynv; " + "Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        string tk, mk;
        private bool check()
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            command = conn.CreateCommand();
            command.CommandText = "select tk, mk from Qlynv where chucvu = N'Quản lý' and tk = '" + userNametxb.Text + "' and mk = '" + passWordtxb.Text + "'";
            
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                tk = rdr["tk"].ToString();
                mk = (rdr["mk"]).ToString();
            }
            if ((tk == userNametxb.Text) && (mk == passWordtxb.Text))
            {
                return true;
            }
            return false;
        }
        private bool check1()
        {
            conn = new SqlConnection (chuoiketnoi);
            conn.Open();
            command = conn.CreateCommand ();
            command.CommandText = "select tk, mk from Qlynv where chucvu = N'Nhân viên' and tk = '" + userNametxb.Text + "' and mk = '" + passWordtxb.Text + "'";
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                tk = rdr["tk"].ToString();
                mk = rdr["mk"].ToString();
            }
            if ((tk == userNametxb.Text) && (mk == passWordtxb.Text))
            {
                return true;
            }
            return false;
        }
        public Login()
        {   
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

           
            try
            {
                if (check() == true)
                {

                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomeForm f = new HomeForm(this);
                    f.Show();
                    this.Hide();

                }
                else if (check1() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HomeForm1 f1 = new HomeForm1(this);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !" + "\nSai thông tin đăng nhập.");
                }
            }
            catch(Exception) 
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void openNewForm(object obj)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userNametxb_TextChanged(object sender, EventArgs e)
        {
            if (userNametxb.Text.Length != 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Black;
            }
        }

        private void passWordtxb_TextChanged(object sender, EventArgs e)
        {
            if (passWordtxb.Text.Length != 0)
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
