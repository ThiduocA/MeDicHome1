
namespace MeDicHome
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.sanphamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysanphamDataSet = new MeDicHome.quanlysanphamDataSet();
            this.sanphamTableAdapter = new MeDicHome.quanlysanphamDataSetTableAdapters.sanphamTableAdapter();
            this.masp = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.tensp = new System.Windows.Forms.TextBox();
            this.gia = new System.Windows.Forms.TextBox();
            this.chucnang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysanphamDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // txSearch
            // 
            this.txSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearch.Location = new System.Drawing.Point(492, 23);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(500, 27);
            this.txSearch.TabIndex = 1;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(1029, 23);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(115, 27);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Location = new System.Drawing.Point(12, 310);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.ReadOnly = true;
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.RowTemplate.Height = 24;
            this.dgvsanpham.Size = new System.Drawing.Size(1322, 310);
            this.dgvsanpham.TabIndex = 0;
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // sanphamBindingSource
            // 
            this.sanphamBindingSource.DataMember = "sanpham";
            this.sanphamBindingSource.DataSource = this.quanlysanphamDataSet;
            // 
            // quanlysanphamDataSet
            // 
            this.quanlysanphamDataSet.DataSetName = "quanlysanphamDataSet";
            this.quanlysanphamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanphamTableAdapter
            // 
            this.sanphamTableAdapter.ClearBeforeFill = true;
            // 
            // masp
            // 
            this.masp.Location = new System.Drawing.Point(162, 41);
            this.masp.Name = "masp";
            this.masp.Size = new System.Drawing.Size(314, 27);
            this.masp.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnthem.Location = new System.Drawing.Point(586, 41);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 36);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // tensp
            // 
            this.tensp.Location = new System.Drawing.Point(162, 85);
            this.tensp.Name = "tensp";
            this.tensp.Size = new System.Drawing.Size(315, 27);
            this.tensp.TabIndex = 3;
            // 
            // gia
            // 
            this.gia.Location = new System.Drawing.Point(162, 125);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(316, 27);
            this.gia.TabIndex = 4;
            // 
            // chucnang
            // 
            this.chucnang.Location = new System.Drawing.Point(162, 171);
            this.chucnang.Name = "chucnang";
            this.chucnang.Size = new System.Drawing.Size(316, 27);
            this.chucnang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức năng";
            // 
            // btnsua
            // 
            this.btnsua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsua.Location = new System.Drawing.Point(586, 99);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 35);
            this.btnsua.TabIndex = 0;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.chucnang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gia);
            this.groupBox1.Controls.Add(this.tensp);
            this.groupBox1.Controls.Add(this.masp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(365, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(586, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btntim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1346, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvsanpham);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.btntim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysanphamDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private quanlysanphamDataSet quanlysanphamDataSet;
        private System.Windows.Forms.BindingSource sanphamBindingSource;
        private quanlysanphamDataSetTableAdapters.sanphamTableAdapter sanphamTableAdapter;
        private System.Windows.Forms.TextBox masp;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox tensp;
        private System.Windows.Forms.TextBox gia;
        private System.Windows.Forms.TextBox chucnang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
    }
}

