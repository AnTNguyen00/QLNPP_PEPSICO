using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DAL_BLL;

namespace QTNPP_PEPSI
{
    public partial class FormNhanVien : Form
    {
        NhanVien_DALBLL nv = new NhanVien_DALBLL();
        public FormNhanVien()
        {
            InitializeComponent();
        }


        public void layMaTuDong_NV()
        {
            List<NHANVIEN> lst = new List<NHANVIEN>();
            lst = nv.getNhanVien();
            string a = GVNhanVien.Rows[GVNhanVien.Rows.Count - 1].Cells[1].Value.ToString();
            string manv = "NV";
            string b = a.Substring(2, 2);
            int ma = Convert.ToInt32(b);
            ma = ma + 1;
            if (lst.Count < 9)
                manv = manv + "0";
            else
                manv = manv + "";
            manv += ma;

            txtMaNV.Text = manv;
        }

        private void clear()
        {
            txtTenDN.Clear();
            txtTenDN.Focus();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtHoTen.Clear();
            dTNgaySinh.ResetText();
            txtDiaChi.Clear();
            txtLuongCoBan.Clear();
            txtCMND.Clear();
            dTNgayBDL.ResetText();
            dTNgayKTL.ResetText();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            layMaTuDong_NV();
            clear();
            txtTenDN.Focus();
            cbbTrinhDo.SelectedIndex = 0;

            txtTenDN.Enabled = true;
            txtSDT.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMatKhau.Enabled = true;
            btnThem.Enabled = true;   
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnLuu.Enabled =btnSua.Enabled = btnTaoMoi.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            }
            GVNhanVien.DataSource = nv.load_NV();

            cbbMaNhomNV.DataSource = nv.Load_NhomNV();
            cbbMaNhomNV.ValueMember = "MANHOMNV";
            cbbMaNhomNV.DisplayMember = "TENNHOM";

            //================================================//

            txtMaNV.Text = GVNhanVien.CurrentRow.Cells[1].Value.ToString();
            GVNhanVien.Columns[1].HeaderText = "Mã nhân viên";
            GVNhanVien.Columns[1].Width = 100;

            cbbMaNhomNV.SelectedValue = GVNhanVien.CurrentRow.Cells[2].Value.ToString();
            GVNhanVien.Columns[2].HeaderText = "Mã nhóm nhân viên";
            GVNhanVien.Columns[2].Width = 130;
            

            txtTenDN.Text = GVNhanVien.CurrentRow.Cells[3].Value.ToString();
            GVNhanVien.Columns[3].HeaderText = "Tên đăng nhập";
            GVNhanVien.Columns[3].Width = 110;

            txtMatKhau.Text = GVNhanVien.CurrentRow.Cells[4].Value.ToString();
            GVNhanVien.Columns[4].HeaderText = "Mật khẩu";
            GVNhanVien.Columns[4].Width = 80;

            txtHoTen.Text = GVNhanVien.CurrentRow.Cells[5].Value.ToString();
            GVNhanVien.Columns[5].HeaderText = "Họ tên nhân viên";
            GVNhanVien.Columns[5].Width = 140;

            GVNhanVien.Columns[6].HeaderText = "Giới tính";
            GVNhanVien.Columns[6].Width = 70;

            dTNgaySinh.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[7].Value.ToString());
            GVNhanVien.Columns[7].HeaderText = "Ngày sinh";
            GVNhanVien.Columns[7].Width = 90;

            txtDiaChi.Text = GVNhanVien.CurrentRow.Cells[8].Value.ToString();
            GVNhanVien.Columns[8].HeaderText = "Địa chỉ";
            GVNhanVien.Columns[8].Width = 100;

            txtSDT.Text = GVNhanVien.CurrentRow.Cells[9].Value.ToString();
            GVNhanVien.Columns[9].HeaderText = "Số điện thoại";
            GVNhanVien.Columns[9].Width = 100;

            txtCMND.Text = GVNhanVien.CurrentRow.Cells[10].Value.ToString();
            GVNhanVien.Columns[10].HeaderText = "CMND/CCCD";
            GVNhanVien.Columns[10].Width = 100;

            dTNgayBDL.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[11].Value.ToString());
            GVNhanVien.Columns[11].HeaderText = "Ngày bắt đầu làm";
            GVNhanVien.Columns[11].Width = 140;

            dTNgayKTL.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[12].Value.ToString());
            GVNhanVien.Columns[12].HeaderText = "Ngày kết thúc làm";
            GVNhanVien.Columns[12].Width = 140;

            GVNhanVien.Columns[13].HeaderText = "Trình độ";
            GVNhanVien.Columns[13].Width = 80;

            //Load combobox trinh do học vấn
            for (int i = 0; i < cbbTrinhDo.Items.Count; i++)
            {
                if (GVNhanVien.CurrentRow.Cells[13].Value.ToString() == "Trung cấp")
                {
                    cbbTrinhDo.SelectedIndex = 0;
                    break;
                }
                else if (GVNhanVien.CurrentRow.Cells[13].Value.ToString() == "Cao đẳng")
                {
                    cbbTrinhDo.SelectedIndex = 1;
                    break;
                }
                else if (GVNhanVien.CurrentRow.Cells[13].Value.ToString() == "Đại học")
                {
                    cbbTrinhDo.SelectedIndex = 2;
                    break;
                }
                else
                {
                    cbbTrinhDo.SelectedIndex = 3;
                    break;
                }
            }


            cbbTrinhDo.DisplayMember = "T";
            cbbTrinhDo.ValueMember = "V";
            cbbTrinhDo.Items.Add(new { T = "Trung cấp", V = "0" });
            cbbTrinhDo.Items.Add(new { T = "Cao đẳng", V = "1" });
            cbbTrinhDo.Items.Add(new { T = "Đại học", V = "2" });
            cbbTrinhDo.Items.Add(new { T = "Thạc sĩ", V = "3" });
            cbbTrinhDo.SelectedIndex = 0;


            txtLuongCoBan.Text = GVNhanVien.CurrentRow.Cells[14].Value.ToString();
            GVNhanVien.Columns[14].HeaderText = "Lương cơ bản";
            GVNhanVien.Columns[14].Width = 100;

            //không cho nhập dữ liệu vào combobox
            this.cbbMaNhomNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            txtLuongCoBan.Enabled = true;
            btnThem.Enabled = false;
            txtMaNV.Enabled = false;
        }

        #region Load giới tính theo NV

        List<string> lst_GioiTinh;

        public string GioiTinh(string maNV)
        {
            lst_GioiTinh = new List<string>();
            string gt = "";
            lst_GioiTinh = nv.Load_GioiTinh(maNV);
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

        public void checkGioiTinh(string maNV)
        {
            if (GioiTinh(maNV) == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
        }

        #endregion

        private void GVNhanVien_Click(object sender, EventArgs e)
        {
            try 
            {
                string nv = GVNhanVien.CurrentRow.Cells[1].Value.ToString();

                txtMaNV.Text = GVNhanVien.CurrentRow.Cells[1].Value.ToString();
                cbbMaNhomNV.SelectedValue = GVNhanVien.CurrentRow.Cells[2].Value.ToString();
                txtTenDN.Text = GVNhanVien.CurrentRow.Cells[3].Value.ToString();
                txtMatKhau.Text = GVNhanVien.CurrentRow.Cells[4].Value.ToString();   
                txtHoTen.Text = GVNhanVien.CurrentRow.Cells[5].Value.ToString();
                
                dTNgaySinh.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[7].Value.ToString());
                txtDiaChi.Text = GVNhanVien.CurrentRow.Cells[8].Value.ToString();
                txtSDT.Text = GVNhanVien.CurrentRow.Cells[9].Value.ToString();
                txtCMND.Text = GVNhanVien.CurrentRow.Cells[10].Value.ToString();
                dTNgayBDL.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[11].Value.ToString());
                dTNgayKTL.Value = Convert.ToDateTime(GVNhanVien.CurrentRow.Cells[12].Value.ToString());

                txtLuongCoBan.Text = GVNhanVien.CurrentRow.Cells[14].Value.ToString();
               
                checkGioiTinh(nv);
            }
            catch
            { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNV.Text) || String.IsNullOrEmpty(txtTenDN.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtLuongCoBan.Text) || String.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }

            //================================================//
            //Kiểm tra ngày vào phải lớn hơn ngày nghỉ
            if (dTNgayBDL.Value.Date > dTNgayKTL.Value.Date)
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày kết thúc làm!", "Thông báo");
                return;
            }

            //================================================//
            //Lấy dữ liệu để chuẩn bị nhập
            string maNV = txtMaNV.Text;
            string tenDN = txtTenDN.Text;
            string matKH = txtMatKhau.Text;
            string sdt = txtSDT.Text;
            string maNhomNV = cbbMaNhomNV.SelectedValue.ToString();
            string hoTen = txtHoTen.Text;

            string kt = rdNam.Checked ? "Nam" : "Nữ";

            string ngaySinh = dTNgaySinh.Value.ToString();
            string diaChi = txtDiaChi.Text;
            string luongCoBan = txtLuongCoBan.Text;
            string cmnd = txtCMND.Text;
            string ngayBDL = dTNgayBDL.Value.ToString();
            string ngayKTL = dTNgayKTL.Value.ToString();

            string trinhDo;
            if (cbbTrinhDo.SelectedIndex == 0)
                trinhDo = "Trung cấp";
            else if (cbbTrinhDo.SelectedIndex == 1)
                trinhDo = "Cao đẳng";
            else if (cbbTrinhDo.SelectedIndex == 2)
                trinhDo = "Đại học";
            else
                trinhDo = "Thạc sĩ";

            //================================================//
            if (Convert.ToInt32(luongCoBan) < 2000000)
            {
                MessageBox.Show("Lương cơ bản phải lớn hơn 2000000!", "Thông báo");
                return;

            }

            //================================================//
            //Thêm dữ liệu
            if (nv.insert_NhanVien(maNV, tenDN, matKH, sdt, maNhomNV, hoTen, kt, ngaySinh, diaChi, luongCoBan, cmnd, ngayBDL, ngayKTL, trinhDo) == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = GVNhanVien.CurrentRow.Cells[1].Value.ToString();
            if (nv.delete_NhanVien(maNV) == true)
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công!", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                FormNhanVien_Load(sender, e);
                btnLuu.Enabled = true;
                btnSua.Text = "Hủy";
            }
            else
            {
                FormNhanVien_Load(sender, e);
                btnSua.Text = "Sửa";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaNV.Text) || String.IsNullOrEmpty(txtTenDN.Text) || String.IsNullOrEmpty(txtMatKhau.Text) || String.IsNullOrEmpty(txtSDT.Text) || String.IsNullOrEmpty(txtHoTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtLuongCoBan.Text) || String.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }
            //================================================//
            //Kiểm tra ngày vào phải lớn hơn ngày nghỉ
            if (dTNgayBDL.Value.Date > dTNgayKTL.Value.Date)
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày kết thúc làm!", "Thông báo");
                return;
            }
            //================================================//
            //Lấy dữ liệu để chuẩn bị nhập
            string maNV = txtMaNV.Text;
            string tenDN = txtTenDN.Text;
            string matKH = txtMatKhau.Text;
            string sdt = txtSDT.Text;
            string maNhomNV = cbbMaNhomNV.SelectedValue.ToString();
            string hoTen = txtHoTen.Text;

            string kt = rdNam.Checked ? "Nam" : "Nữ";

            string ngaySinh = dTNgaySinh.Value.ToString();
            string diaChi = txtDiaChi.Text;
            string luongCoBan = txtLuongCoBan.Text;
            string cmnd = txtCMND.Text;
            string ngayBDL = dTNgayBDL.Value.ToString();
            string ngayKTL = dTNgayKTL.Value.ToString();

            string trinhDo;
            if (cbbTrinhDo.SelectedIndex == 0)
                trinhDo = "Trung cấp";
            else if (cbbTrinhDo.SelectedIndex == 1)
                trinhDo = "Cao đẳng";
            else if (cbbTrinhDo.SelectedIndex == 2)
                trinhDo = "Đại học";
            else
                trinhDo = "Thạc sĩ";

            //================================================//
            if (Convert.ToInt32(luongCoBan) < 2000000)
            {
                MessageBox.Show("Lương cơ bản phải lớn hơn 2000000!", "Thông báo");
                txtLuongCoBan.Text = GVNhanVien.CurrentRow.Cells[14].Value.ToString();
                return;

            }
            int checkcmnd = int.Parse(cmnd.Length.ToString());
            if (checkcmnd > 13)
            {
                MessageBox.Show("Số CMND không được lớn hơn 12!", "Thông báo");
                txtCMND.Text = GVNhanVien.CurrentRow.Cells[10].Value.ToString();
                return;
            }

            //================================================//
            //Cập nhập dữ liệu
            if (nv.update_NhanVien(maNV, tenDN, matKH, sdt, maNhomNV, hoTen, kt, ngaySinh, diaChi, luongCoBan, cmnd, ngayBDL, ngayKTL, trinhDo) == true)
            {
                MessageBox.Show("Cập nhập dữ liệu thành công", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhập dữ liệu không thành công!", "Thông báo");
                FormNhanVien_Load(sender, e);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FormTimKiemNhanVien formNew = new FormTimKiemNhanVien();
            formNew.Show();
        }

        private void GVNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVNhanVien.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVNhanVien.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;

            if (e.ColumnIndex == this.GVNhanVien.Columns["MATKHAU"].Index && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

    }
}
