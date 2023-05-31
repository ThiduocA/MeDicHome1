namespace MeDicHome
{
    partial class qlynv
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qlynvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlynvDataSet = new MeDicHome.qlynvDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qlynvTableAdapter = new MeDicHome.qlynvDataSetTableAdapters.QlynvTableAdapter();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlynvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlynvDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvDataGridViewTextBoxColumn,
            this.tennvDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.chucvuDataGridViewTextBoxColumn,
            this.tienluongDataGridViewTextBoxColumn,
            this.tkDataGridViewTextBoxColumn,
            this.mkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qlynvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // qlynvBindingSource
            // 
            this.qlynvBindingSource.DataMember = "Qlynv";
            this.qlynvBindingSource.DataSource = this.qlynvDataSet;
            // 
            // qlynvDataSet
            // 
            this.qlynvDataSet.DataSetName = "qlynvDataSet";
            this.qlynvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.txtmk);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txttk);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txttl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtchucvu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtngaysinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txthoten);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmanv);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1309, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật thông tin";
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1058, 186);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 51);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(1058, 99);
            this.btnsua.Margin = new System.Windows.Forms.Padding(0);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 50);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(1058, 24);
            this.btnthem.Margin = new System.Windows.Forms.Padding(0);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 50);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(578, 214);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(188, 27);
            this.txtmk.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "MK";
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(578, 154);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(188, 27);
            this.txttk.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(485, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "TK";
            // 
            // txttl
            // 
            this.txttl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttl.Location = new System.Drawing.Point(578, 96);
            this.txttl.Name = "txttl";
            this.txttl.Size = new System.Drawing.Size(188, 27);
            this.txttl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền lương";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.Location = new System.Drawing.Point(578, 36);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(188, 27);
            this.txtchucvu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức vụ";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(101, 151);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(200, 27);
            this.dtngaysinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(99, 95);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(202, 27);
            this.txthoten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NV";
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(99, 35);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(202, 27);
            this.txtmanv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // qlynvTableAdapter
            // 
            this.qlynvTableAdapter.ClearBeforeFill = true;
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = " Mã nv";
            this.manvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            this.manvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tennvDataGridViewTextBoxColumn
            // 
            this.tennvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennvDataGridViewTextBoxColumn.DataPropertyName = "tennv";
            this.tennvDataGridViewTextBoxColumn.HeaderText = "Tên nv";
            this.tennvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tennvDataGridViewTextBoxColumn.Name = "tennvDataGridViewTextBoxColumn";
            this.tennvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaysinhDataGridViewTextBoxColumn.Width = 130;
            // 
            // chucvuDataGridViewTextBoxColumn
            // 
            this.chucvuDataGridViewTextBoxColumn.DataPropertyName = "chucvu";
            this.chucvuDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chucvuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucvuDataGridViewTextBoxColumn.Name = "chucvuDataGridViewTextBoxColumn";
            this.chucvuDataGridViewTextBoxColumn.ReadOnly = true;
            this.chucvuDataGridViewTextBoxColumn.Width = 130;
            // 
            // tienluongDataGridViewTextBoxColumn
            // 
            this.tienluongDataGridViewTextBoxColumn.DataPropertyName = "tienluong";
            this.tienluongDataGridViewTextBoxColumn.HeaderText = "Tiền lương";
            this.tienluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienluongDataGridViewTextBoxColumn.Name = "tienluongDataGridViewTextBoxColumn";
            this.tienluongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tkDataGridViewTextBoxColumn
            // 
            this.tkDataGridViewTextBoxColumn.DataPropertyName = "tk";
            this.tkDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.tkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tkDataGridViewTextBoxColumn.Name = "tkDataGridViewTextBoxColumn";
            this.tkDataGridViewTextBoxColumn.ReadOnly = true;
            this.tkDataGridViewTextBoxColumn.Width = 130;
            // 
            // mkDataGridViewTextBoxColumn
            // 
            this.mkDataGridViewTextBoxColumn.DataPropertyName = "mk";
            this.mkDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.mkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mkDataGridViewTextBoxColumn.Name = "mkDataGridViewTextBoxColumn";
            this.mkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1346, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "qlynv";
            this.Text = "qlynv";
            this.Load += new System.EventHandler(this.qlynv_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlynvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlynvDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private qlynvDataSet qlynvDataSet;
        private System.Windows.Forms.BindingSource qlynvBindingSource;
        private qlynvDataSetTableAdapters.QlynvTableAdapter qlynvTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mkDataGridViewTextBoxColumn;
    }
}