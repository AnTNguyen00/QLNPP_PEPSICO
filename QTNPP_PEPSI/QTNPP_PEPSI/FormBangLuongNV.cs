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
    public partial class FormBangLuongNV : Form
    {
        NhanVien_DALBLL nhanvien = new NhanVien_DALBLL();
        BangLuong_DALBLL bangluong = new BangLuong_DALBLL();
        QLNPP_PEPSI1DataContext QLNPP_PS = new QLNPP_PEPSI1DataContext();

        public FormBangLuongNV()
        {
            InitializeComponent();
        }

        private void FormBangLuongNV_Load(object sender, EventArgs e)
        {
            GVBangLuong.DataSource = bangluong.load_BangLuong();

            //Khởi tạo combobox Nhân viên
            cbbMaNhanVien.DataSource = nhanvien.load_MANV();
            cbbMaNhanVien.DisplayMember = "MANV";
            cbbMaNhanVien.ValueMember = "MANV";

            //chỉ định dòng đầu vào textbox
            cbbMaLuong.Text = GVBangLuong.CurrentRow.Cells[1].Value.ToString();
            GVBangLuong.Columns[1].HeaderText = "Mã bảng lương";
            GVBangLuong.Columns[1].Width = 110;

            cbbMaNhanVien.Text = GVBangLuong.CurrentRow.Cells[2].Value.ToString();
            GVBangLuong.Columns[2].HeaderText = "Mã nhân viên";
            GVBangLuong.Columns[2].Width = 100;

            txtLuongThucTe.Text = GVBangLuong.CurrentRow.Cells[3].Value.ToString();
            GVBangLuong.Columns[3].HeaderText = "Lương thực tế";
            GVBangLuong.Columns[3].Width = 110;

            DTPNgayApDung.Text = GVBangLuong.CurrentRow.Cells[4].Value.ToString();
            GVBangLuong.Columns[4].HeaderText = "Ngày áp dụng";
            GVBangLuong.Columns[4].Width = 100;

            txtGhiChu.Text = GVBangLuong.CurrentRow.Cells[5].Value.ToString();
            GVBangLuong.Columns[5].HeaderText = "Ghi chú";
            GVBangLuong.Columns[5].Width = 100;

            //không cho nhập dữ liệu vào combobox
            this.cbbMaLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbMaNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnThem.Enabled = false;
            loadcbbbl();
        }

        private void loadcbbbl()
        {
            var mluong = (from c in QLNPP_PS.BANGLUONGs select new { c.MABANGLUONG }).Distinct().ToList();
            cbbMaLuong.DataSource = mluong;
            cbbMaLuong.DisplayMember = "MABANGLUONG";
            cbbMaLuong.ValueMember = "MABANGLUONG";
        }

        private void GVBangLuong_Click(object sender, EventArgs e)
        {
            try
            {
                cbbMaLuong.Text = GVBangLuong.CurrentRow.Cells[1].Value.ToString();
                cbbMaNhanVien.Text = GVBangLuong.CurrentRow.Cells[2].Value.ToString();
                txtLuongThucTe.Text = GVBangLuong.CurrentRow.Cells[3].Value.ToString();
                DTPNgayApDung.Text = GVBangLuong.CurrentRow.Cells[4].Value.ToString();
                txtGhiChu.Text = GVBangLuong.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            { }
        }

        private void cbbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var q in bangluong.load_Ten(cbbMaNhanVien.Text))
            {
                txtHoTenNhanVien.Text = q.ToString();
            }
            foreach (var q in bangluong.load_LuongCB(cbbMaNhanVien.Text))
            {
                txtMuccLuongCoBan.Text = q.ToString();
            }
            foreach (double q in bangluong.load_HeSoLuong(cbbMaNhanVien.Text))
            {
                txtHeSoLuong.Text = q.ToString();
            }

            foreach (var q in bangluong.load_TuNgay(cbbMaNhanVien.Text))
            {
                DTPTuNgay.Text = q.ToString();
            }
            foreach (var q in bangluong.load_DenNgay(cbbMaNhanVien.Text))
            {
                DTPDenNgay.Text = q.ToString();
            }

            try
            {
                decimal tinhtien;
                decimal luong = decimal.Parse(txtMuccLuongCoBan.Text);
                decimal hs = decimal.Parse(txtHeSoLuong.Text);
                tinhtien = hs * luong;
                txtLuongThucTe.Text = tinhtien.ToString();
            }
            catch
            { }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            clear();
            txtGhiChu.Enabled = true;
        }

        private void clear()
        {
            cbbMaLuong.ResetText();
            cbbMaNhanVien.ResetText();
            txtHoTenNhanVien.Clear();
            txtMuccLuongCoBan.Clear();
            DTPTuNgay.ResetText();
            DTPDenNgay.ResetText();
            txtHeSoLuong.Clear();
            DTPNgayApDung.ResetText();
            txtLuongThucTe.Clear();
            txtGhiChu.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bangluong.insert_BangLuong(cbbMaLuong.Text, cbbMaNhanVien.Text, decimal.Parse(txtLuongThucTe.Text), DateTime.Parse(DTPNgayApDung.Text), txtGhiChu.Text);
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVBangLuong.DataSource = bangluong.load_BangLuong();
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
                if (bangluong.delete_BangLuong(cbbMaLuong.Text) == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVBangLuong.DataSource = bangluong.load_BangLuong();
                    clear();
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
                if (bangluong.update_BangLuong(cbbMaLuong.Text, DateTime.Parse(DTPNgayApDung.Text), txtGhiChu.Text) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVBangLuong.DataSource = bangluong.load_BangLuong();
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

        private void txtHoTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMuccLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtHeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLuongThucTe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                clear();
                txtHoTenNhanVien.Enabled = true;
                txtHoTenNhanVien.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVBangLuong.DataSource = bangluong.search_TenNV(txtHoTenNhanVien.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormBangLuongNV_Load(sender, e);
        }

        private void GVBangLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVBangLuong.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVBangLuong.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }

    }
}
