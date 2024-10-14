namespace De02
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
            this.lblsp = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.dgvqlsp = new System.Windows.Forms.DataGridView();
            this.dgvmasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvloaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkluu = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.datatimengaynhap = new System.Windows.Forms.DateTimePicker();
            this.cmbloaisp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsp.Location = new System.Drawing.Point(340, 44);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(333, 32);
            this.lblsp.TabIndex = 0;
            this.lblsp.Text = "DANH MỤC SẢN PHẨM";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(224, 77);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(76, 34);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(46, 83);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(172, 22);
            this.txttk.TabIndex = 2;
            // 
            // dgvqlsp
            // 
            this.dgvqlsp.AllowUserToAddRows = false;
            this.dgvqlsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvqlsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqlsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmasp,
            this.dgvtensp,
            this.dgvngaynhap,
            this.dgvloaisp});
            this.dgvqlsp.Location = new System.Drawing.Point(58, 134);
            this.dgvqlsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvqlsp.Name = "dgvqlsp";
            this.dgvqlsp.RowHeadersWidth = 51;
            this.dgvqlsp.RowTemplate.Height = 24;
            this.dgvqlsp.Size = new System.Drawing.Size(519, 226);
            this.dgvqlsp.TabIndex = 14;
            this.dgvqlsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqlsp_CellClicks);
            // 
            // dgvmasp
            // 
            this.dgvmasp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvmasp.HeaderText = "Mã SP";
            this.dgvmasp.MinimumWidth = 6;
            this.dgvmasp.Name = "dgvmasp";
            this.dgvmasp.Width = 76;
            // 
            // dgvtensp
            // 
            this.dgvtensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtensp.HeaderText = "Tên sản phẩm";
            this.dgvtensp.MinimumWidth = 6;
            this.dgvtensp.Name = "dgvtensp";
            this.dgvtensp.Width = 122;
            // 
            // dgvngaynhap
            // 
            this.dgvngaynhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvngaynhap.HeaderText = "Ngày nhập";
            this.dgvngaynhap.MinimumWidth = 6;
            this.dgvngaynhap.Name = "dgvngaynhap";
            this.dgvngaynhap.Width = 102;
            // 
            // dgvloaisp
            // 
            this.dgvloaisp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvloaisp.HeaderText = "Loại SP";
            this.dgvloaisp.MinimumWidth = 6;
            this.dgvloaisp.Name = "dgvloaisp";
            this.dgvloaisp.Width = 83;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(58, 388);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(178, 388);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(298, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(413, 388);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnkluu
            // 
            this.btnkluu.Location = new System.Drawing.Point(535, 388);
            this.btnkluu.Name = "btnkluu";
            this.btnkluu.Size = new System.Drawing.Size(75, 23);
            this.btnkluu.TabIndex = 19;
            this.btnkluu.Text = "K.Lưu";
            this.btnkluu.UseVisualStyleBackColor = true;
            this.btnkluu.Click += new System.EventHandler(this.btnkluu_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(657, 388);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 20;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Loại SP:";
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(754, 147);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(129, 22);
            this.txtmasp.TabIndex = 25;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(754, 187);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(165, 22);
            this.txttensp.TabIndex = 26;
            // 
            // datatimengaynhap
            // 
            this.datatimengaynhap.Location = new System.Drawing.Point(754, 223);
            this.datatimengaynhap.Name = "datatimengaynhap";
            this.datatimengaynhap.Size = new System.Drawing.Size(200, 22);
            this.datatimengaynhap.TabIndex = 27;
            // 
            // cmbloaisp
            // 
            this.cmbloaisp.FormattingEnabled = true;
            this.cmbloaisp.Location = new System.Drawing.Point(754, 262);
            this.cmbloaisp.Name = "cmbloaisp";
            this.cmbloaisp.Size = new System.Drawing.Size(200, 24);
            this.cmbloaisp.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.cmbloaisp);
            this.Controls.Add(this.datatimengaynhap);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnkluu);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvqlsp);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.lblsp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqlsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.DataGridView dgvqlsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloaisp;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnkluu;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.DateTimePicker datatimengaynhap;
        private System.Windows.Forms.ComboBox cmbloaisp;
    }
}

