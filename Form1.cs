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
using System.Runtime.Remoting.Contexts;

namespace MeDicHome
{
    public partial class qlykho : Form
    {
        string chuoiketnoi = "Data Source=XHUNG\\SQLEXPRESS; " + " Initial Catalog=qlysp; " + "Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        SqlCommand cmd = null;
        DataTable dt = null;
        public qlykho()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "select sanpham.masp ,sanpham.tensp, kho.soluongton, kho.tinhtrang from sanpham inner join kho on kho.masp = sanpham.masp";
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvsanpham.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlkhoDataSet4.kho' table. You can move, or remove it, as needed.
            //this.khoTableAdapter.Fill(this.qlkhoDataSet4.kho);
            loaddata();
        }

        void select()
        {
            if (dgvsanpham.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string masp = dgvsanpham.SelectedRows[0].Cells[0].Value + string.Empty;
                string tensp = dgvsanpham.SelectedRows[0].Cells[1].Value + string.Empty;
                string soluong = dgvsanpham.SelectedRows[0].Cells[2].Value + string.Empty;
                string tinhtrang = dgvsanpham.SelectedRows[0].Cells[3].Value + string.Empty;


                TBmasp.Text = masp;
                TBtensp.Text = tensp;
                TBsoluong.Text = soluong;
                TBtinhtrang.Text = tinhtrang;
            }
        }

        void Sua()
        {
            //if (dgvsanpham.SelectedRows.Count > 0) // make sure user select at least 1 row 
            //{

            //}
            try
            {
                if ( TBmasp.Text.Length == 0 || TBtensp.Text.Length == 0)
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn = new SqlConnection(chuoiketnoi);
                    conn.Open();

                    string sql = "update kho set soluongton = '" + TBsoluong.Text + "', tinhtrang = '" + TBtinhtrang.Text + "' where masp = '" + TBmasp.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Giá tiền phải là số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
        private void dgvsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
            
            loaddata();
        }

        
    }
}
