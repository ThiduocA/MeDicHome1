using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeDicHome
{
    public partial class HomeForm1 : Form
    {
        Login cur_form1;
        public HomeForm1(Login form1)
        {
            cur_form1 = form1;
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn chắc muốn đăng xuất chứ ?","Thông báo",MessageBoxButtons.OKCancel);
            if(tb == DialogResult.OK) {
                this.Close();
                cur_form1.Show();
            
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
          
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null) 
            {
                currentFormChild.Close();            
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
            userName.Text = button1.Text;

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qlykho());
            userName.Text = button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new qlykh());
            userName.Text = button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
