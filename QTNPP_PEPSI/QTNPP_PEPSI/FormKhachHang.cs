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
    public partial class FormKhachHang : Form
    {
        KhachHang_DALBLL kh = new KhachHang_DALBLL();
        QuanHuyen_DALBLL quanhuyen = new QuanHuyen_DALBLL();
        LoaiKhachHang_DALBLL loaikh = new LoaiKhachHang_DALBLL();

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            GVKhachHang.DataSource = kh.load_KhachHang();

            //Khởi tạo combobox Loại KH
            cbbLoaiKH.DataSource = loaikh.load_TenLoaiKH();
            cbbLoaiKH.DisplayMember = "TENLOAIKH";
            cbbLoaiKH.ValueMember = "LOAIKHACHHANG1";


            //Khởi tạo combobox Quận huyện
            cbbQuanHuyen.DataSource = quanhuyen.load_TenQuanHuyen();
            cbbQuanHuyen.DisplayMember = "TENQUANHUYEN";
            cbbQuanHuyen.ValueMember = "MAQUANHUYEN";

            //chỉ định dòng đầu vào textbox
            txtMaKhachHang.Text = GVKhachHang.CurrentRow.Cells[1].Value.ToString();
            GVKhachHang.Columns[1].HeaderText = "Mã khách hàng";
            GVKhachHang.Columns[1].Width = 130;

            cbbQuanHuyen.SelectedValue = GVKhachHang.CurrentRow.Cells[2].Value.ToString();
            GVKhachHang.Columns[2].HeaderText = "Mã quận huyện";
            GVKhachHang.Columns[2].Width = 130;

            txtHoTenKH.Text = GVKhachHang.CurrentRow.Cells[3].Value.ToString();
            GVKhachHang.Columns[3].HeaderText = "Họ tên khách hàng";
            GVKhachHang.Columns[3].Width = 150;

            cbbLoaiKH.SelectedValue = GVKhachHang.CurrentRow.Cells[4].Value.ToString();
            GVKhachHang.Columns[4].HeaderText = "Loại khách hàng";
            GVKhachHang.Columns[4].Width = 130;

            DTPNgaysinh.Value = Convert.ToDateTime(GVKhachHang.CurrentRow.Cells[5].Value.ToString());
            GVKhachHang.Columns[5].HeaderText = "Ngày sinh";
            GVKhachHang.Columns[5].Width = 130;

            GVKhachHang.Columns[6].HeaderText = "Giới tính";
            GVKhachHang.Columns[6].Width = 130;

            txtDiaChi.Text = GVKhachHang.CurrentRow.Cells[7].Value.ToString();
            GVKhachHang.Columns[7].HeaderText = "Địa chỉ";
            GVKhachHang.Columns[7].Width = 130;

            txtSDT.Text = GVKhachHang.CurrentRow.Cells[8].Value.ToString();
            GVKhachHang.Columns[8].HeaderText = "Số điện thoại";
            GVKhachHang.Columns[8].Width = 130;

            //không cho nhập dữ liệu vào combobox
            this.cbbLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbQuanHuyen.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbQuanHuyen.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnThem.Enabled = false;
            txtMaKhachHang.Enabled = false;
        }

        #region Load giới tính theo KH

        List<string> lst_GioiTinh;
        public string GioiTinh(string maKH)
        {
            lst_GioiTinh = new List<string>();
            string gt = "";
            lst_GioiTinh = kh.load_GioiTinh(maKH);
            foreach (string sp in lst_GioiTinh)
            {
                try
                {
                    gt = sp.ToString(); //tên cột giới tính
                }
                catch
                {
                    return "";
                }
            }
            return gt;
        }

        public void checkGioiTinh(string maKH)
        {
            if (GioiTinh(maKH) == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
        }

        #endregion

        private void GVKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string kh = GVKhachHang.CurrentRow.Cells[1].Value.ToString();

                txtMaKhachHang.Text = GVKhachHang.CurrentRow.Cells[1].Value.ToString();
                cbbQuanHuyen.SelectedValue = GVKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtHoTenKH.Text = GVKhachHang.CurrentRow.Cells[3].Value.ToString();
                cbbLoaiKH.SelectedValue = GVKhachHang.CurrentRow.Cells[4].Value.ToString();
                DTPNgaysinh.Value = Convert.ToDateTime(GVKhachHang.CurrentRow.Cells[5].Value.ToString());
                txtDiaChi.Text = GVKhachHang.CurrentRow.Cells[7].Value.ToString();
                txtSDT.Text = GVKhachHang.CurrentRow.Cells[8].Value.ToString();

                checkGioiTinh(kh);
            }
            catch
            { }
        }

        public void layMaTuDong_KH()
        {
            List<KHACHHANG> lst = new List<KHACHHANG>();
            lst = kh.getKhachHang();
            string a = GVKhachHang.Rows[GVKhachHang.Rows.Count - 1].Cells[1].Value.ToString();
            string makh = "KH";
            string b = a.Substring(2, 2);
            int ma = Convert.ToInt32(b);
            ma = ma + 1;
            if (lst.Count < 9)
                makh = makh + "0";
            else
                makh = makh + "";
            makh += ma;

            txtMaKhachHang.Text = makh;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            layMaTuDong_KH();
            
            txtHoTenKH.Clear();
            txtHoTenKH.Focus();
            DTPNgaysinh.ResetText();
            txtDiaChi.Clear();
            txtSDT.Clear();

            cbbLoaiKH.SelectedIndex = 0;
            cbbQuanHuyen.SelectedIndex = 0;

            txtDiaChi.Enabled = true;
            txtHoTenKH.Enabled = true;
            txtSDT.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaKhachHang.Text) || String.IsNullOrEmpty(txtHoTenKH.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }

            string maKH = txtMaKhachHang.Text;
            string tenKH = txtHoTenKH.Text;
            string ngaySinh = DTPNgaysinh.Value.ToString();
            string loaiKH= cbbLoaiKH.SelectedValue.ToString();
            string maQH = cbbQuanHuyen.SelectedValue.ToString();

            string kt = rdNam.Checked ? "Nam" : "Nữ";

            string diaChi = txtDiaChi.Text;
            string sdT = txtSDT.Text;

            if (kh.insert_KH(maKH, maQH, tenKH, loaiKH, ngaySinh, kt, diaChi, sdT) == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = GVKhachHang.CurrentRow.Cells[1].Value.ToString();
            if (kh.delete_KH(maKH) == true)
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công!", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                FormKhachHang_Load(sender, e);
                btnLuu.Enabled = true;
                btnSua.Text = "Hủy";
            }
            else
            {
                FormKhachHang_Load(sender, e);
                btnSua.Text = "Sửa";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaKhachHang.Text) || String.IsNullOrEmpty(txtHoTenKH.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }

            //================================================//

            string maKH = txtMaKhachHang.Text;
            string tenKH = txtHoTenKH.Text;
            string ngaySinh = DTPNgaysinh.Value.ToString();
            string loaiKH = cbbLoaiKH.SelectedValue.ToString();
            string maQH = cbbQuanHuyen.SelectedValue.ToString();

            string kt = rdNam.Checked ? "Nam" : "Nữ";

            string diaChi = txtDiaChi.Text;
            string sdT = txtSDT.Text;

            //================================================//

            //Cập nhập dữ liệu
            if (kh.update_KH(maKH, maQH, tenKH, loaiKH, ngaySinh, kt, diaChi, sdT) == true)
            {
                MessageBox.Show("Cập nhập dữ liệu thành công", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
            {
                MessageBox.Show("Cập nhập dữ liệu không thành công!", "Thông báo");
                FormKhachHang_Load(sender, e);
                return;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FormLoaiKhachHang formNew = new FormLoaiKhachHang();
            formNew.Show();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtHoTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void clear()
        {
            txtMaKhachHang.Clear();
            txtHoTenKH.Clear();
            DTPNgaysinh.ResetText();
            rdNam.ResetText();
            rdNu.ResetText();
            pnlGioiTinh.ResetText();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                clear();
                txtHoTenKH.Enabled = true;
                txtHoTenKH.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVKhachHang.DataSource = kh.search_TenKH(txtHoTenKH.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormKhachHang_Load(sender, e);
        }

        private void GVKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVKhachHang.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVKhachHang.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
