using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace QTNPP_PEPSI
{
    public partial class FormLoaiKhachHang : Form
    {
        public FormLoaiKhachHang()
        {
            InitializeComponent();
        }

        LoaiKhachHang_DALBLL loaikh = new LoaiKhachHang_DALBLL();

        private void FormLoaiKhachHang_Load(object sender, EventArgs e)
        {
            GVLoaiKH.DataSource = loaikh.load_LoaiKH();

            //chỉ định dòng đầu vào textbox
            txtMaLoaiKH.Text = GVLoaiKH.CurrentRow.Cells[1].Value.ToString();
            GVLoaiKH.Columns[1].HeaderText = "Mã loại khách hàng";
            GVLoaiKH.Columns[1].Width = 130;

            txtTenLoaiKH.Text = GVLoaiKH.CurrentRow.Cells[2].Value.ToString();
            GVLoaiKH.Columns[2].HeaderText = "Tên loại khách hàng";
            GVLoaiKH.Columns[2].Width = 130;

            btnThem.Enabled = false;
            txtMaLoaiKH.Enabled = false;
        }

        public void layMaTuDong_LoaiKH()
        {
            List<LOAIKHACHHANG> lst = new List<LOAIKHACHHANG>();
            lst = loaikh.getLoaiKH();
            string a = GVLoaiKH.Rows[GVLoaiKH.Rows.Count - 1].Cells[1].Value.ToString();
            string malkh = "";
            malkh = "LKH";
            int ma = lst.Count;
            ma = ma + 1;
            if (lst.Count <= 9)
                malkh = malkh + "0";
            else
                malkh = malkh + "";

            malkh += ma.ToString();

            txtMaLoaiKH.Text = malkh;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            layMaTuDong_LoaiKH();
            btnThem.Enabled = true;
            txtTenLoaiKH.Enabled = true;
            txtTenLoaiKH.Clear();
            txtTenLoaiKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                loaikh.insert_LoaiKH(txtMaLoaiKH.Text, txtTenLoaiKH.Text);

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVLoaiKH.DataSource = loaikh.load_LoaiKH();
                btnThem.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaikh.delete_LoaiKH(txtMaLoaiKH.Text) == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVLoaiKH.DataSource = loaikh.load_LoaiKH();
                    txtMaLoaiKH.Clear();
                    txtTenLoaiKH.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Xoá dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaikh.update_LoaiKH(txtMaLoaiKH.Text, txtTenLoaiKH.Text) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVLoaiKH.DataSource = loaikh.load_LoaiKH();
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GVLoaiKH_Click(object sender, EventArgs e)
        {
            txtMaLoaiKH.Text = GVLoaiKH.CurrentRow.Cells[1].Value.ToString();
            txtTenLoaiKH.Text = GVLoaiKH.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                txtMaLoaiKH.Clear();
                txtTenLoaiKH.Clear();
                txtTenLoaiKH.Enabled = true;
                txtTenLoaiKH.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVLoaiKH.DataSource = loaikh.search_TenLoaiKH(txtTenLoaiKH.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormLoaiKhachHang_Load(sender, e);
        }

        private void GVLoaiKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVLoaiKH.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVLoaiKH.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
