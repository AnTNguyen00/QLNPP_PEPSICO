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
    public partial class FormTimKiemNhanVien : Form
    {
        NhanVien_DALBLL _NV = new NhanVien_DALBLL();

        public FormTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void FormTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            GvNhanVien.DataSource = _NV.load_NV1();

            cbbMaNhom.DataSource = _NV.load_NhomNV1();
            cbbMaNhom.DisplayMember = "TENNHOM";
            cbbMaNhom.ValueMember = "MANHOMNV";


            GvNhanVien.Columns[1].HeaderText = "Mã nhân viên";
            GvNhanVien.Columns[1].Width = 100;

            GvNhanVien.Columns[2].HeaderText = "Mã nhóm nhân viên";
            GvNhanVien.Columns[2].Width = 130;

            GvNhanVien.Columns[3].HeaderText = "Tên đăng nhập";
            GvNhanVien.Columns[3].Width = 110;

            GvNhanVien.Columns[4].HeaderText = "Mật khẩu";
            GvNhanVien.Columns[4].Width = 80;

            GvNhanVien.Columns[5].HeaderText = "Họ tên nhân viên";
            GvNhanVien.Columns[5].Width = 140;

            GvNhanVien.Columns[6].HeaderText = "Giới tính";
            GvNhanVien.Columns[6].Width = 80;

            GvNhanVien.Columns[7].HeaderText = "Ngày sinh";
            GvNhanVien.Columns[7].Width = 90;

            GvNhanVien.Columns[8].HeaderText = "Địa chỉ";
            GvNhanVien.Columns[8].Width = 100;

            GvNhanVien.Columns[9].HeaderText = "Số điện thoại";
            GvNhanVien.Columns[9].Width = 100;

            GvNhanVien.Columns[10].HeaderText = "CMND/CCCD";
            GvNhanVien.Columns[10].Width = 100;

            GvNhanVien.Columns[11].HeaderText = "Ngày bắt đầu làm";
            GvNhanVien.Columns[11].Width = 140;

            GvNhanVien.Columns[12].HeaderText = "Ngày kết thúc làm";
            GvNhanVien.Columns[12].Width = 140;

            GvNhanVien.Columns[13].HeaderText = "Trình độ";
            GvNhanVien.Columns[13].Width = 80;

            GvNhanVien.Columns[14].HeaderText = "Lương cơ bản";
            GvNhanVien.Columns[14].Width = 100;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Tìm theo mã nhân viên
            if (checkMaNhanVien.Value)
            {
                GvNhanVien.DataSource = _NV.search_MANV(txtMaNhanVien.Text);
            }

            //Tìm kiếm theo tên
            if (checkHoTen.Value)
            {
                GvNhanVien.DataSource = _NV.search_HoTen(txtHoTen.Text);
            }

            //Tìm kiếm theo ngày bắt đầu làm
            if (checkNgayBatDau.Value)
            {
                GvNhanVien.DataSource = _NV.search_NgayBDL(DTPNgayBD.Value);
            }

            //Tìm theo giới tính
            if (checkGioiTinh.Value)
            {
                GvNhanVien.DataSource = _NV.search_GioiTinh(cbbGioiTinh.SelectedItem.ToString());
            }

            //Tìm theo mã nhóm
            if (checkMaNhom.Value)
            {
                GvNhanVien.DataSource = _NV.search_MaNhom(cbbMaNhom.SelectedValue.ToString());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            checkMaNhanVien.Value = checkMaNhom.Value = checkNgayBatDau.Value = checkHoTen.Value = checkGioiTinh.Value = false;
            txtMaNhanVien.Text = cbbMaNhom.Text = DTPNgayBD.Text = txtHoTen.Text = cbbGioiTinh.Text = string.Empty;
            GvNhanVien.DataSource = _NV.load_NV1();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkMaNhanVien_ValueChanged(object sender, EventArgs e)
        {
            if (checkMaNhanVien.Value)
                txtMaNhanVien.Enabled = true;
            else
                txtMaNhanVien.Enabled = false;
        }

        private void checkHoTen_ValueChanged(object sender, EventArgs e)
        {
            if (checkHoTen.Value)
                txtHoTen.Enabled = true;
            else
                txtHoTen.Enabled = false;
        }

        private void checkMaNhom_ValueChanged(object sender, EventArgs e)
        {
            if (checkMaNhom.Value)
                cbbMaNhom.Enabled = true;
            else
                cbbMaNhom.Enabled = false;
        }

        private void checkNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (checkNgayBatDau.Value)
                DTPNgayBD.Enabled = true;
            else
                DTPNgayBD.Enabled = false;
        }

        private void checkGioiTinh_ValueChanged(object sender, EventArgs e)
        {
            if (checkGioiTinh.Value)
                cbbGioiTinh.Enabled = true;
            else
                cbbGioiTinh.Enabled = false;
        }

        private void GvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GvNhanVien.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GvNhanVien.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;

            if (e.ColumnIndex == this.GvNhanVien.Columns["MATKHAU"].Index && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
