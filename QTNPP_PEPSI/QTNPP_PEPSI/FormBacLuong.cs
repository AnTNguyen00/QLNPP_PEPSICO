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
using DTO;

namespace QTNPP_PEPSI
{
    public partial class FormBacLuong : Form
    {
        QLNPP_PEPSI1DataContext QLNPP_PS = new QLNPP_PEPSI1DataContext();
        BacLuong_DALBLL bacluong = new BacLuong_DALBLL();
        NhanVien_DALBLL nv = new NhanVien_DALBLL();

        public FormBacLuong()
        {
            InitializeComponent();
        }

        private void FormBacLuong_Load(object sender, EventArgs e)
        {
            GVBacLuong.DataSource = bacluong.load_BacLuong();

            //Khởi tạo combobox Nhân viên
            cbbNhanVien.DataSource = nv.load_TenNV1();
            cbbNhanVien.DisplayMember = "HOTENNV";
            cbbNhanVien.ValueMember = "MANV";

            //chỉ định dòng đầu vào textbox
            txtMaBacLuong.Text = GVBacLuong.CurrentRow.Cells[1].Value.ToString();
            GVBacLuong.Columns[1].HeaderText = "Mã bậc lương";
            GVBacLuong.Columns[1].Width = 100;

            txtTenBacLuong.Text = GVBacLuong.CurrentRow.Cells[2].Value.ToString();
            GVBacLuong.Columns[2].HeaderText = "Tên bậc lương";
            GVBacLuong.Columns[2].Width = 110;

            txtHeSoLuong.Text = GVBacLuong.CurrentRow.Cells[3].Value.ToString();
            GVBacLuong.Columns[3].HeaderText = "Hệ số lương";
            GVBacLuong.Columns[3].Width = 90;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnThem.Enabled = false;
        }

        private void GVBacLuong_Click(object sender, EventArgs e)
        {
            txtMaBacLuong.Text = GVBacLuong.CurrentRow.Cells[1].Value.ToString();
            txtTenBacLuong.Text = GVBacLuong.CurrentRow.Cells[2].Value.ToString();
            txtHeSoLuong.Text = GVBacLuong.CurrentRow.Cells[3].Value.ToString();

            GVChiTietBacLuong.DataSource = bacluong.load_CTBacLuong(GVBacLuong.CurrentRow.Cells[1].Value.ToString());

            //cbbNhanVien.Text = GVChiTietBacLuong.CurrentRow.Cells[2].Value.ToString();
            //GVChiTietBacLuong.Columns[2].HeaderText = "Mã nhân viên";
            //GVChiTietBacLuong.Columns[2].Width = 100;

            //DTPTuNgay.Text = GVChiTietBacLuong.CurrentRow.Cells[3].Value.ToString();
            //GVChiTietBacLuong.Columns[3].HeaderText = "Từ ngày";
            //GVChiTietBacLuong.Columns[3].Width = 90;

            //DTPDenNgay.Text = GVChiTietBacLuong.CurrentRow.Cells[4].Value.ToString();
            //GVChiTietBacLuong.Columns[4].HeaderText = "Đến ngày";
            //GVChiTietBacLuong.Columns[4].Width = 90;
        }

        private void GVChiTietBacLuong_Click(object sender, EventArgs e)
        {
            txtMaBacLuong.Text = GVBacLuong.CurrentRow.Cells[1].Value.ToString();
            cbbNhanVien.Text = GVChiTietBacLuong.CurrentRow.Cells[2].Value.ToString();
            DTPTuNgay.Text = GVChiTietBacLuong.CurrentRow.Cells[3].Value.ToString();
            DTPDenNgay.Text = GVChiTietBacLuong.CurrentRow.Cells[4].Value.ToString();
        }

        public void LayMaTuDong_BL()
        {
            List<BACLUONG> lst = new List<BACLUONG>();
            lst = bacluong.getBacLuong();
            string a = GVBacLuong.Rows[GVBacLuong.Rows.Count - 1].Cells[1].Value.ToString();
            string mabac = "B";
            int ma = lst.Count;
            ma = ma + 1;
            if (lst.Count <= 9)
                mabac = mabac + "0";
            else
                mabac = mabac + "";

            mabac += ma.ToString();

            txtMaBacLuong.Text = mabac;
        }

        private void clear()
        {
            txtTenBacLuong.Clear();
            txtHeSoLuong.Clear();
            DTPTuNgay.ResetText();
            DTPDenNgay.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)//       Y
        {
            try
            {
                string str = txtMaBacLuong.Text;
                if (bacluong.update_CTBL(txtMaBacLuong.Text, cbbNhanVien.Text, DateTime.Parse(DTPTuNgay.Text), DateTime.Parse(DTPDenNgay.Text)) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVChiTietBacLuong.DataSource = bacluong.load_CTBacLuong(txtMaBacLuong.Text);
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

        private void btnTimKiemCTBL_Click(object sender, EventArgs e)
        {
           
        }

        private void btnShowCTBL_Click(object sender, EventArgs e)
        {
            FormBacLuong_Load(sender, e);
        }

        private void GVBacLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVBacLuong.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVBacLuong.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }

        private void GVChiTietBacLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVChiTietBacLuong.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVChiTietBacLuong.Columns["STT_"].Index)
                e.Value = e.RowIndex + 1;
        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)//        Y
        {
            LayMaTuDong_BL();
            btnThemCT.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

            txtTenBacLuong.Clear();
            txtHeSoLuong.Clear();
            txtMaBacLuong.Focus();

            cbbNhanVien.DataSource = nv.load_TenNV2();
            cbbNhanVien.DisplayMember = "HOTENNV";
            cbbNhanVien.ValueMember = "MANV";
        }

        private void btnThemCT_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str = txtMaBacLuong.Text;
                bacluong.insert_CTBac(txtMaBacLuong.Text, cbbNhanVien.SelectedValue.ToString(), DateTime.Parse(DTPTuNgay.Text), DateTime.Parse(DTPDenNgay.Text));
                //MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //GVChiTietBacLuong.DataSource = bacluong.load_CTBacLuong(txtMaBacLuong.Text);
                //btnThem.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Xoá dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bacluong.delete_Bac(txtMaBacLuong.Text) == 1)
                {
                    MessageBox.Show("Xoá dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVBacLuong.DataSource = bacluong.load_BacLuong();
                    btnThem.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Xoá dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
