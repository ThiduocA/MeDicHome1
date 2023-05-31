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
    public partial class qlynv : Form
    {
        public qlynv()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=XHUNG\\SQLEXPRESS; " + " Initial Catalog=qlynv; " + "Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        //SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable datatable = new DataTable();
        private bool checknum()
        {
            string input = txthoten.Text;
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }
        private bool checknum1()
        {
            string input = txtchucvu.Text;
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input))
            {
                return true;
            }
            else return false;
        }
        

        private void loaddata()
        {
            
            datatable.Clear();
            this.qlynvTableAdapter.Fill(this.qlynvDataSet.Qlynv);

        }
        private void cleartxt()
        {
            txtmanv.Text = string.Empty;
            txthoten.Text = string.Empty;
            txtchucvu.Text = string.Empty;
            txttl.Text = string.Empty;
            txttk.Text = string.Empty;
            txtmk.Text = string.Empty;
        }
        private void qlynv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlynvDataSet.Qlynv' table. You can move, or remove it, as needed.
            this.qlynvTableAdapter.Fill(this.qlynvDataSet.Qlynv);
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            loaddata();
        }

        
        
        private bool checktk()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[5];
                if(cell.Value != null && cell.Value.ToString() == txttk.Text)
                {
                    return true;
                }
            }
            return false;

        }
        private void btnthem_Click(object sender, EventArgs e)
        {

            try
            {

                if ((txthoten.Text.Length == 0 || txtchucvu.Text.Length == 0 || txttl.Text.Length == 0 || txttk.Text.Length == 0 || txtmk.Text.Length == 0))
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(checktk())
                {
                    MessageBox.Show("Tên tài khoản không được trùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttk.Focus();

                }
                else if (checknum())
                {
                    MessageBox.Show("Tên không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checknum1())
                {
                    MessageBox.Show("Chức vụ không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    command = conn.CreateCommand();
                    command.CommandText = "insert into Qlynv values('" + txtmanv.Text + "', N'" + txthoten.Text + "', '" + dtngaysinh.Text + "', N'" + txtchucvu.Text + "', '" + txttl.Text + "', '" + txttk.Text + "', '" + txtmk.Text + "')";
                    command.ExecuteNonQuery();
                    loaddata();
                    txtmanv.ReadOnly = false;
                    cleartxt();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập không đúng định dạng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txthoten.Text.Length == 0 || txtchucvu.Text.Length == 0 || txttl.Text.Length == 0 || txttk.Text.Length == 0 || txtmk.Text.Length == 0))
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checknum())
                {
                    MessageBox.Show("Tên không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (checknum1())
                {
                    MessageBox.Show("Chức vụ không được chứa số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    command = conn.CreateCommand();
                    command.CommandText = "update Qlynv set tennv = N'" + txthoten.Text + "', ngaysinh = '" + dtngaysinh.Text + "', chucvu = N'" + txtchucvu.Text + "', tienluong = " + txttl.Text + ", tk = '" + txttk.Text + "', mk = '" + txtmk.Text + "' where manv = '" + txtmanv.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    txtmanv.ReadOnly = false;
                    cleartxt();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txthoten.Text.Length == 0 || txtchucvu.Text.Length == 0 || txttl.Text.Length == 0 || txttk.Text.Length == 0 || txtmk.Text.Length == 0))
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    command = conn.CreateCommand();
                    command.CommandText = "delete from Qlynv where manv = '" + txtmanv.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    txtmanv.ReadOnly = false;
                    cleartxt();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtmanv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txthoten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dtngaysinh.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtchucvu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txttl.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txttk.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtmk.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            txtmanv.ReadOnly = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.ReadOnly = false;
        }

        
    }
}
