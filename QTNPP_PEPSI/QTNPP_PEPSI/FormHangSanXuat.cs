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
    public partial class FormHangSanXuat : Form
    {
        HangSanXuat_DALBLL hangsx = new HangSanXuat_DALBLL();

        public FormHangSanXuat()
        {
            InitializeComponent();
        }

        private void FormHangSanXuat_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnSua.Enabled = btnTaoMoi.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            }
            GVHangSX.DataSource = hangsx.load_HangSX();

            //chỉ định dòng đầu vào textbox
            txtMaHangSX.Text = GVHangSX.CurrentRow.Cells[1].Value.ToString();
            GVHangSX.Columns[1].HeaderText = "Mã hãng sản xuất";
            GVHangSX.Columns[1].Width = 150;

            txtTenHangSX.Text = GVHangSX.CurrentRow.Cells[2].Value.ToString();
            GVHangSX.Columns[2].HeaderText = "Tên hãng sản xuất";
            GVHangSX.Columns[2].Width = 250;

            btnThem.Enabled = false;
            txtMaHangSX.Enabled = false;
        }

        private void GVHangSX_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaHangSX.Text = GVHangSX.CurrentRow.Cells[1].Value.ToString();
                txtTenHangSX.Text = GVHangSX.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            { }
        }

        public void layMaTuDong_HSX()
        {
            List<HANGSANXUAT> lst = new List<HANGSANXUAT>();
            lst = hangsx.getHangSX();
            string a = GVHangSX.Rows[GVHangSX.Rows.Count - 1].Cells[1].Value.ToString();
            string mahsx = "";
            mahsx = "HSX";
            int ma = lst.Count;
            ma = ma + 1;
            if (lst.Count <= 9)
                mahsx = mahsx + "0";
            else
                mahsx = mahsx + "";

            mahsx += ma.ToString();

            txtMaHangSX.Text = mahsx;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            layMaTuDong_HSX();
            btnThem.Enabled = true;
            txtTenHangSX.Enabled = true;
            txtTenHangSX.Clear();
            txtTenHangSX.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                hangsx.them_HangSX(txtMaHangSX.Text, txtTenHangSX.Text);
                MessageBox.Show("Thêm dữ liệu  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVHangSX.DataSource = hangsx.load_HangSX();
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
                if (hangsx.xoa_HangSX(txtMaHangSX.Text) == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVHangSX.DataSource = hangsx.load_HangSX();
                    txtMaHangSX.Clear();
                    txtTenHangSX.Clear();
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
                if (hangsx.sua_HangSX(txtMaHangSX.Text, txtTenHangSX.Text) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVHangSX.DataSource = hangsx.load_HangSX();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                txtMaHangSX.Clear();
                txtTenHangSX.Clear();
                txtTenHangSX.Enabled = true;
                txtTenHangSX.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVHangSX.DataSource = hangsx.search_TenHSX(txtTenHangSX.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormHangSanXuat_Load(sender, e);
        }

        private void GVHangSX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVHangSX.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVHangSX.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
