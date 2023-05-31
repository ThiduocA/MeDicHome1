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
using System.Text.RegularExpressions;

namespace MeDicHome
{
    public partial class Form1 : Form
    {
        
        string chuoiketnoi = "Data Source=XHUNG\\SQLEXPRESS;" + "Initial Catalog=qlysp;" + "Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter dasp = new SqlDataAdapter();
        DataTable dtsp = new DataTable();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "select * from sanpham";
            dasp = new SqlDataAdapter(sql, conn);
            dtsp.Clear();
            dasp.Fill(dtsp);
            dgvsanpham.DataSource = dtsp;
            

        }
        private bool checknum()
        {
            string input = tensp.Text;
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }
        public void timkiem()
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql="select * from sanpham where tensp like N'%"+txSearch.Text+"%'";
            dasp = new SqlDataAdapter(sql, conn);
            dtsp.Clear();
            dasp.Fill(dtsp);
            dgvsanpham.DataSource = dtsp;
        }
        public void tb_clear()
        {
            masp.Clear();
            tensp.Clear();
            gia.Clear();
            chucnang.Clear();
        }
        public void them()
        {
            try
            {
                if (masp.Text != "" && tensp.Text != "" && gia.Text != "" && chucnang.Text != "")
                {
                    conn = new SqlConnection(chuoiketnoi);
                    conn.Open();
                    string sql = "insert into sanpham values('" + masp.Text + "',N'" + tensp.Text + "','" + gia.Text + "',N'" + chucnang.Text + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    string sql1 = "insert into kho values('"+masp.Text+"', '1', N'còn hàng')";
                    cmd = new SqlCommand(sql1, conn);
                    cmd.ExecuteNonQuery();
                    loaddata();
                    masp.ReadOnly = false;
                    tb_clear();
                    MessageBox.Show("Thêm thành công", "Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (checknum())
                {
                    MessageBox.Show("Tên không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void xoa()
        {
            if (masp.Text.Length == 0)
            {
            MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = new SqlConnection(chuoiketnoi);
                conn.Open();
                string sql1 = "Delete kho where masp='" + masp.Text + "'";
                string sql = "Delete sanpham where masp='" + masp.Text + "'";
                cmd = new SqlCommand(sql1, conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loaddata();
                tb_clear();
            }
        }
        public void sua()
        {
            try
            {
                if (masp.Text != "" && tensp.Text != "" && gia.Text != "" && chucnang.Text != "")
                {
                    conn = new SqlConnection(chuoiketnoi);
                    conn.Open();
                    string sql = "Update sanpham set tensp=N'" + tensp.Text + "',gia='" + gia.Text + "',chucnang= N'" + chucnang.Text + "' where masp='" + masp.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    loaddata();
                    tb_clear();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (checknum())
                {
                    MessageBox.Show("Tên không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysanphamDataSet.sanpham' table. You can move, or remove it, as needed.
            //this.sanphamTableAdapter.Fill(this.quanlysanphamDataSet.sanpham);
            loaddata();
        }

        

        private void btnthem_Click(object sender, EventArgs e)
        {
            them();
        }

        

        

        

        private void btnsua_Click(object sender, EventArgs e)
        {
            sua();
        }

        

        private void txSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvsanpham.SelectedRows.Count > 0)
            {
                string masp1 = dgvsanpham.SelectedRows[0].Cells[0].Value.ToString();
                string tensp1 = dgvsanpham.SelectedRows[0].Cells[1].Value.ToString();
                string gia1 = dgvsanpham.SelectedRows[0].Cells[2].Value.ToString();
                string chucnang1 = dgvsanpham.SelectedRows[0].Cells[3].Value.ToString();

                masp.Text = masp1;
                tensp.Text = tensp1;
                gia.Text = gia1;
                chucnang.Text = chucnang1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        
    }
}
