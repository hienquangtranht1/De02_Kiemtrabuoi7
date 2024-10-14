using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using De02.Models;
using System.Data.Entity.Migrations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace De02
{
    public partial class Form1 : Form
    {
        SanphamModel mdsanpham = new SanphamModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sanpham> listsanpham = mdsanpham.Sanphams.ToList();
            List<LoaiSP> listloaisp = mdsanpham.LoaiSPs.ToList();

            FillDataCBB(listloaisp);
            FillDataDGV(listsanpham);
        }

        private void FillDataDGV(List<Sanpham> listsanpham)
        {
            dgvqlsp.Rows.Clear();
            foreach (var sp in listsanpham)
            {
                int RowNew = dgvqlsp.Rows.Add(sp);
                dgvqlsp.Rows[RowNew].Cells[0].Value = sp.MaSP;
                dgvqlsp.Rows[RowNew].Cells[1].Value = sp.TenSP;
                dgvqlsp.Rows[RowNew].Cells[2].Value = sp.Ngaynhap;
                dgvqlsp.Rows[RowNew].Cells[3].Value = sp.LoaiSP?.TenLoai;



            }
        }

        private void FillDataCBB(List<LoaiSP> listloaisp)
        {
            cmbloaisp.DataSource = listloaisp;
            cmbloaisp.DisplayMember = "TenLoai"; 
            cmbloaisp.ValueMember = "MaLoai";
        }
        private int CheckID(string idnewsp)
        {
            int length = dgvqlsp.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvqlsp.Rows[i].Cells[0].Value != null)
                    if (dgvqlsp.Rows[i].Cells[0].Value.ToString() == idnewsp)
                        return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtmasp.Text == "" || txttensp.Text == "" )
            {
                MessageBox.Show("Bạn chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtmasp.TextLength < 6 || txtmasp.TextLength > 6)
            {
                MessageBox.Show("Mã số sản phầm chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckID(txtmasp.Text) == -1)
                {

                    Sanpham newsp = new Sanpham();
                    newsp.MaSP = txtmasp.Text;
                    newsp.TenSP= txttensp.Text;
                    newsp.Ngaynhap = datatimengaynhap.Value;
                    newsp.MaLoai = cmbloaisp.SelectedValue.ToString();

                    mdsanpham.Sanphams.AddOrUpdate(newsp);
                    mdsanpham.SaveChanges();

                    loadDGV();
                    loadForm();
                    MessageBox.Show($"Thêm sản phẩm {newsp.TenSP} vào danh sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show($"Sản phẩm có mã {txtmasp.Text} đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void loadForm()
        {
            txtmasp.Clear();
            txttensp.Clear();
         
        }

        private void loadDGV()
        {
            List<Sanpham> newlistsp = mdsanpham.Sanphams.ToList();
            FillDataDGV(newlistsp);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                Sanpham update = mdsanpham.Sanphams.FirstOrDefault(p => p.MaSP == txtmasp.Text);
                if (update != null)
                {

                    update.TenSP = txttensp.Text;
                    update.Ngaynhap= datatimengaynhap.Value;
                    update.MaLoai = cmbloaisp.SelectedValue.ToString() ;
                  


                    mdsanpham.Sanphams.AddOrUpdate(update);
                    mdsanpham.SaveChanges();


                    loadDGV();
                    loadForm();

                    MessageBox.Show($"Sửa thông tin sản phầm {update.TenSP} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvqlsp_CellClicks(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvqlsp.Rows[e.RowIndex];
                txtmasp.Text = Row.Cells[0].Value.ToString();
                txttensp.Text = Row.Cells[1].Value.ToString();
                datatimengaynhap.Text = Row.Cells[2].Value.ToString();
                cmbloaisp.Text = Row.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sanpham delete = mdsanpham.Sanphams.FirstOrDefault(p => p.MaSP == txtmasp.Text);
            if (delete != null)
            {
                DialogResult result = MessageBox.Show($"Bạn có đồng ý xóa sản phẩm {delete.TenSP}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mdsanpham.Sanphams.Remove(delete);
                    mdsanpham.SaveChanges();
                    loadForm();
                    loadDGV();
                    MessageBox.Show($"Xóa sản phẩm {delete.TenSP} thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
                return;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string ten = txttk.Text.Trim();

            List<Sanpham> listsp = mdsanpham.Sanphams.ToList();


            var filteredsp = listsp.Where(s => (string.IsNullOrEmpty(hoten) || s.TenSP.ToString().Contains(ten)));
            var filteredList = filteredsp.ToList();
            FillDataDGV(filteredList);

            if (!filteredList.Any())
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try{
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt).txt Rich Text Format (*.rtf)|*.rtf"; 
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName).ToLower();
                        if (fileExtension == ".txt")
                        {
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8))
                            {
                                dgvqlsp.Text = sr.ReadToEnd();
                            }
                        }
                        else if (fileExtension == ".rtf")
                        {
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8))
                            {
                                dgvqlsp.Text = sr.ReadToEnd();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Định dạng tệp không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void btnkluu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
