namespace MeDicHome
{
    partial class qlykho
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
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.thêm = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.TBtinhtrang = new System.Windows.Forms.TextBox();
            this.TBsoluong = new System.Windows.Forms.TextBox();
            this.TBtensp = new System.Windows.Forms.TextBox();
            this.TBmasp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qlkhoDataSet4 = new MeDicHome.qlkhoDataSet4();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new MeDicHome.qlkhoDataSet4TableAdapters.khoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.thêm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AllowUserToOrderColumns = true;
            this.dgvsanpham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvsanpham.Location = new System.Drawing.Point(13, 261);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.ReadOnly = true;
            this.dgvsanpham.RowHeadersWidth = 51;
            this.dgvsanpham.Size = new System.Drawing.Size(1338, 300);
            this.dgvsanpham.TabIndex = 0;
            this.dgvsanpham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellDoubleClick);
            // 
            // thêm
            // 
            this.thêm.Controls.Add(this.btnSua);
            this.thêm.Controls.Add(this.TBtinhtrang);
            this.thêm.Controls.Add(this.TBsoluong);
            this.thêm.Controls.Add(this.TBtensp);
            this.thêm.Controls.Add(this.TBmasp);
            this.thêm.Controls.Add(this.label4);
            this.thêm.Controls.Add(this.label3);
            this.thêm.Controls.Add(this.label2);
            this.thêm.Controls.Add(this.label1);
            this.thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêm.Location = new System.Drawing.Point(16, 15);
            this.thêm.Margin = new System.Windows.Forms.Padding(4);
            this.thêm.Name = "thêm";
            this.thêm.Padding = new System.Windows.Forms.Padding(4);
            this.thêm.Size = new System.Drawing.Size(427, 238);
            this.thêm.TabIndex = 2;
            this.thêm.TabStop = false;
            this.thêm.Text = "Thêm số lượng sản phẩm";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(135, 192);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 38);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // TBtinhtrang
            // 
            this.TBtinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtinhtrang.Location = new System.Drawing.Point(135, 157);
            this.TBtinhtrang.Margin = new System.Windows.Forms.Padding(4);
            this.TBtinhtrang.Name = "TBtinhtrang";
            this.TBtinhtrang.Size = new System.Drawing.Size(215, 27);
            this.TBtinhtrang.TabIndex = 7;
            // 
            // TBsoluong
            // 
            this.TBsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsoluong.Location = new System.Drawing.Point(135, 122);
            this.TBsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.TBsoluong.Name = "TBsoluong";
            this.TBsoluong.Size = new System.Drawing.Size(215, 27);
            this.TBsoluong.TabIndex = 6;
            // 
            // TBtensp
            // 
            this.TBtensp.Enabled = false;
            this.TBtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtensp.Location = new System.Drawing.Point(135, 87);
            this.TBtensp.Margin = new System.Windows.Forms.Padding(4);
            this.TBtensp.Name = "TBtensp";
            this.TBtensp.ReadOnly = true;
            this.TBtensp.Size = new System.Drawing.Size(215, 27);
            this.TBtensp.TabIndex = 5;
            // 
            // TBmasp
            // 
            this.TBmasp.Enabled = false;
            this.TBmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBmasp.Location = new System.Drawing.Point(135, 48);
            this.TBmasp.Margin = new System.Windows.Forms.Padding(4);
            this.TBmasp.Name = "TBmasp";
            this.TBmasp.ReadOnly = true;
            this.TBmasp.Size = new System.Drawing.Size(215, 27);
            this.TBmasp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sp";
            // 
            // qlkhoDataSet4
            // 
            this.qlkhoDataSet4.DataSetName = "qlkhoDataSet4";
            this.qlkhoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "kho";
            this.khoBindingSource.DataSource = this.qlkhoDataSet4;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // qlykho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1364, 545);
            this.Controls.Add(this.thêm);
            this.Controls.Add(this.dgvsanpham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "qlykho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.thêm.ResumeLayout(false);
            this.thêm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlkhoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.GroupBox thêm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBtinhtrang;
        private System.Windows.Forms.TextBox TBsoluong;
        private System.Windows.Forms.TextBox TBtensp;
        private System.Windows.Forms.TextBox TBmasp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private qlkhoDataSet4 qlkhoDataSet4;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private qlkhoDataSet4TableAdapters.khoTableAdapter khoTableAdapter;
    }
}
