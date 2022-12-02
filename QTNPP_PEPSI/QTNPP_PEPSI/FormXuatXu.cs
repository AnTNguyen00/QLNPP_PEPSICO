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
    public partial class FormXuatXu : Form
    {
        XuatXu_DALBLL xuatxu = new XuatXu_DALBLL();

        public FormXuatXu()
        {
            InitializeComponent();
        }

        private void FormXuatXu_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnSua.Enabled = btnTaoMoi.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            }
            GVXuatXu.DataSource = xuatxu.load_XuatXu();

            //chỉ định dòng đầu vào textbox
            txtMaXuatXu.Text = GVXuatXu.CurrentRow.Cells[1].Value.ToString();
            GVXuatXu.Columns[1].HeaderText = "Mã xuất xứ";
            GVXuatXu.Columns[1].Width = 150;

            txtTenXuatXu.Text = GVXuatXu.CurrentRow.Cells[2].Value.ToString();
            GVXuatXu.Columns[2].HeaderText = "Tên xuất xứ";
            GVXuatXu.Columns[2].Width = 150;

            txtLoaiXuatXu.Text = GVXuatXu.CurrentRow.Cells[3].Value.ToString();
            GVXuatXu.Columns[3].HeaderText = "Loại xuất xứ";
            GVXuatXu.Columns[3].Width = 150;

            btnThem.Enabled = false;
            txtMaXuatXu.Enabled = false;
        }

        private void GVXuatXu_Click(object sender, EventArgs e)
        {
            try
            {

                txtMaXuatXu.Text = GVXuatXu.CurrentRow.Cells[1].Value.ToString();
                txtTenXuatXu.Text = GVXuatXu.CurrentRow.Cells[2].Value.ToString();
                txtLoaiXuatXu.Text = GVXuatXu.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            { }
        }


        public void LayMaTuDong_XX()
        {
            List<XUATXU> lst = new List<XUATXU>();
            lst = xuatxu.getXuatXu();
            string a = GVXuatXu.Rows[GVXuatXu.Rows.Count - 1].Cells[1].Value.ToString();
            string maxx = "";
            maxx = "XX";
            int ma = lst.Count;
            ma = ma + 1;
            if (lst.Count <= 9)
                maxx = maxx + "0";
            else
                maxx = maxx + "";

            maxx += ma.ToString();

            txtMaXuatXu.Text = maxx;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LayMaTuDong_XX();
            btnThem.Enabled = true;
            txtTenXuatXu.Enabled = true;
            txtLoaiXuatXu.Enabled = true;
            txtTenXuatXu.Clear();
            txtLoaiXuatXu.Clear();
            txtTenXuatXu.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                xuatxu.them_XuatXu(txtMaXuatXu.Text, txtTenXuatXu.Text, txtLoaiXuatXu.Text);
                MessageBox.Show("Thêm dữ liệu  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVXuatXu.DataSource = xuatxu.load_XuatXu();
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
                if (xuatxu.xoa_XuatXu(txtMaXuatXu.Text) == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVXuatXu.DataSource = xuatxu.load_XuatXu();
                    txtMaXuatXu.Clear();
                    txtTenXuatXu.Clear();
                    txtLoaiXuatXu.Clear();
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
                if (xuatxu.sua_XuatXu(txtMaXuatXu.Text, txtTenXuatXu.Text, txtLoaiXuatXu.Text) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVXuatXu.DataSource = xuatxu.load_XuatXu();
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

        private void txtTenXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLoaiXuatXu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                txtMaXuatXu.Clear();
                txtTenXuatXu.Clear();
                txtLoaiXuatXu.Clear();
                txtTenXuatXu.Enabled = true;
                txtTenXuatXu.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVXuatXu.DataSource = xuatxu.search_TenXX(txtTenXuatXu.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormXuatXu_Load(sender, e);
        }

        private void GVXuatXu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVXuatXu.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVXuatXu.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
