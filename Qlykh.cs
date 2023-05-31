using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MeDicHome
{
    public partial class qlykh : Form
    {
        string connectionString = "Data Source=XHUNG\\SQLEXPRESS;Initial Catalog=sqlall;Integrated Security=True";
        SqlConnection connection = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public qlykh()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM khach";
                adapter = new SqlDataAdapter(sql, connection);
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
        }

     
        private void InsertData()
        {
            try
            {
                if (string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox4.Text) )
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "INSERT INTO khach (makhachhang, hovaten, sdt, ngaymua, thuocmuaganday) VALUES (@makhachhang, @hovaten, @sdt, @ngaymua, @thuocmuaganday)";
                            command.Parameters.AddWithValue("@makhachhang", textBox5.Text);
                            command.Parameters.AddWithValue("@hovaten", textBox1.Text);
                            command.Parameters.AddWithValue("@sdt", textBox2.Text);
                            //command.Parameters.AddWithValue("@ngaymua", dateTimePicker1.Value.Date);
                            command.Parameters.AddWithValue("@thuocmuaganday", textBox4.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteData()
        {

            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                cmd = connection.CreateCommand();
                string sql1 = "delete from khach where makhachhang = '" + textBox5.Text + "'";
                cmd = new SqlCommand(sql1, connection);
                cmd.ExecuteNonQuery();
            }
        }


        private void LoadGridByKeyWord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM khach WHERE hovaten LIKE @keyword";
                adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + textBox3.Text + "%");
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
        }

        private void qlykh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData();
            LoadData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteData();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show("Dữ liệu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                //string sql = "update khach set hovaten = N'" + textBox1.Text + "', sdt = '" + textBox2.Text + "',ngaymua = '" + dateTimePicker1.Value.ToShortDateString() + "' ,thuocmuaganday = N'" + textBox4.Text + "' where makhachhang = '" + textBox5.Text + "'";
                //cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadGridByKeyWord();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index; 
            textBox5.Text = dgv.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dgv.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dgv.Rows[i].Cells[2].Value.ToString();
            //dateTimePicker1.Text = dgv.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void qlykh_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sqlallDataSet1.khach' table. You can move, or remove it, as needed.
            this.khachTableAdapter1.Fill(this.sqlallDataSet1.khach);
            // TODO: This line of code loads data into the 'khDataSet.khach' table. You can move, or remove it, as needed.
            //this.khachTableAdapter.Fill(this.khDataSet.khach);

            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
