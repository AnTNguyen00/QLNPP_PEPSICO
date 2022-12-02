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
    public partial class FormSanPham : Form
    {
        SP_DALBLL SP = new SP_DALBLL();
        LoaiSP_DALBLL LoaiSP = new LoaiSP_DALBLL();
        XuatXu_DALBLL XX = new XuatXu_DALBLL();
        HangSanXuat_DALBLL HSX = new HangSanXuat_DALBLL();

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnLoadAnh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnTaoMoi.Enabled = btnSua.Enabled = false;
            }

            //đổi link
            Bitmap anh = new Bitmap(@"C:\Users\Admin\OneDrive\Desktop\QTNPP_PEPSI\HinhAnhSP\7upChai.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)anh;
            GVSP.DataSource = SP.load_SP();

            cbbHangSX.DataSource = HSX.load_TenHSX();
            cbbHangSX.DisplayMember = "TenHSX";
            cbbHangSX.ValueMember = "MaHSX";

            cbbMaLoai.DataSource = LoaiSP.load_TenLoaiSP();
            cbbMaLoai.DisplayMember = "TENLOAISANPHAM";
            cbbMaLoai.ValueMember = "MALOAISANPHAM";

            cbbMaXuatXu.DataSource = XX.load_TenXuatXu();
            cbbMaXuatXu.DisplayMember = "tenxuatxu";
            cbbMaXuatXu.ValueMember = "Maxuatxu";

            cbbDonViTinh.DataSource = SP.load_DVT();
            cbbDonViTinh.DisplayMember = "DVT";
            cbbDonViTinh.ValueMember = "DVT";


            txtMaSP.Text = GVSP.CurrentRow.Cells[1].Value.ToString();
            GVSP.Columns[1].HeaderText = "Mã sản phẩm";
            GVSP.Columns[1].Width = 100;

            cbbMaLoai.Text = GVSP.CurrentRow.Cells[2].Value.ToString();
            GVSP.Columns[2].HeaderText = "Mã loại sản phẩm";
            GVSP.Columns[2].Width = 120;

            cbbHangSX.Text = GVSP.CurrentRow.Cells[3].Value.ToString();
            GVSP.Columns[3].HeaderText = "Mã hãng sản xuất";
            GVSP.Columns[3].Width = 120;

            cbbMaXuatXu.Text = GVSP.CurrentRow.Cells[4].Value.ToString();
            GVSP.Columns[4].HeaderText = "Mã xuất xứ";
            GVSP.Columns[4].Width = 90;

            txtTenSP.Text = GVSP.CurrentRow.Cells[5].Value.ToString();
            GVSP.Columns[5].HeaderText = "Tên sản phẩm";
            GVSP.Columns[5].Width = 150;

            txthinhanh.Text = GVSP.CurrentRow.Cells[6].Value.ToString();
            GVSP.Columns[6].HeaderText = "Hình ảnh";
            GVSP.Columns[6].Width = 100;

            txtThanhPhan.Text = GVSP.CurrentRow.Cells[7].Value.ToString();
            GVSP.Columns[7].HeaderText = "Thành phần";
            GVSP.Columns[7].Width = 150;

            txtCongDung.Text = GVSP.CurrentRow.Cells[8].Value.ToString();
            GVSP.Columns[8].HeaderText = "Công dụng";
            GVSP.Columns[8].Width = 100;

            txtBaoQuan.Text = GVSP.CurrentRow.Cells[9].Value.ToString();
            GVSP.Columns[9].HeaderText = "Bảo quản";
            GVSP.Columns[9].Width = 150;

            txtGhiChu.Text = GVSP.CurrentRow.Cells[10].Value.ToString();
            GVSP.Columns[10].HeaderText = "Ghi chú";
            GVSP.Columns[10].Width = 150;

            cbbDonViTinh.Text = GVSP.CurrentRow.Cells[11].Value.ToString();
            GVSP.Columns[11].HeaderText = "Đơn vị tính";
            GVSP.Columns[11].Width = 90;

            txtSoLo.Text = GVSP.CurrentRow.Cells[12].Value.ToString();
            GVSP.Columns[12].HeaderText = "Số lô";
            GVSP.Columns[12].Width = 60;

            DTPSanXuat.Text = GVSP.CurrentRow.Cells[13].Value.ToString();
            GVSP.Columns[13].HeaderText = "Ngày sản xuất";
            GVSP.Columns[13].Width = 100;

            DTPHanSD.Text = GVSP.CurrentRow.Cells[14].Value.ToString();
            GVSP.Columns[14].HeaderText = "Hạn sử dụng";
            GVSP.Columns[14].Width = 100;

            txtDonGia.Text = GVSP.CurrentRow.Cells[15].Value.ToString();
            GVSP.Columns[15].HeaderText = "Đơn giá";
            GVSP.Columns[15].Width = 80;

            txtSoLuongTon.Text = GVSP.CurrentRow.Cells[16].Value.ToString();
            GVSP.Columns[16].HeaderText = "Số lượng tồn";
            GVSP.Columns[16].Width = 100;


            //không cho nhập dữ liệu vào combobox
            this.cbbDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbHangSX.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbHangSX.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbbMaLoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaLoai.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbbMaXuatXu.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaXuatXu.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GVSP_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaSP.Text = GVSP.CurrentRow.Cells[1].Value.ToString();
                cbbMaLoai.Text = GVSP.CurrentRow.Cells[2].Value.ToString();
                cbbHangSX.Text = GVSP.CurrentRow.Cells[3].Value.ToString();
                cbbMaXuatXu.Text = GVSP.CurrentRow.Cells[4].Value.ToString();
                txtTenSP.Text = GVSP.CurrentRow.Cells[5].Value.ToString();
                txthinhanh.Text = GVSP.CurrentRow.Cells[6].Value.ToString();
                txtThanhPhan.Text = GVSP.CurrentRow.Cells[7].Value.ToString();
                txtCongDung.Text = GVSP.CurrentRow.Cells[8].Value.ToString();
                txtBaoQuan.Text = GVSP.CurrentRow.Cells[9].Value.ToString();
                txtGhiChu.Text = GVSP.CurrentRow.Cells[10].Value.ToString();
                cbbDonViTinh.Text = GVSP.CurrentRow.Cells[11].Value.ToString();
                txtSoLo.Text = GVSP.CurrentRow.Cells[12].Value.ToString();
                DTPSanXuat.Text = GVSP.CurrentRow.Cells[13].Value.ToString();
                DTPHanSD.Text = GVSP.CurrentRow.Cells[14].Value.ToString();
                txtDonGia.Text = GVSP.CurrentRow.Cells[15].Value.ToString();
                txtSoLuongTon.Text = GVSP.CurrentRow.Cells[16].Value.ToString();

                Bitmap anh = new Bitmap(@"C:\Users\Admin\OneDrive\Desktop\QTNPP_PEPSI\HinhAnhSP\" + txthinhanh.Text);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = (Image)anh;
            }
            catch
            { }
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                txthinhanh.Text = oFile.FileName.Substring(oFile.FileName.LastIndexOf("\\") + 1);
            }
        }

        public void LayMaTuDong_SP()
        {
            List<SANPHAM> lst = new List<SANPHAM>();
            lst = SP.getSanPham();
            string a = GVSP.Rows[GVSP.Rows.Count - 1].Cells[1].Value.ToString();
            string masp = "SP";
            string b = a.Substring(2, 2);
            int ma = Convert.ToInt32(b);
            ma = ma + 1;
            if (lst.Count < 9)
                masp = masp + "0";
            else
                masp = masp + "";
            masp += ma;

            txtMaSP.Text = masp;
        }

        private void clear()
        {
            cbbHangSX.Text = string.Empty;
            cbbHangSX.Text = string.Empty;
            cbbMaXuatXu.Text = string.Empty;
            cbbMaLoai.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtThanhPhan.Text = "";
            txtCongDung.Text = "";

            txtBaoQuan.Text = "";
            txtGhiChu.Text = "";
            cbbDonViTinh.Text = "";
            txtSoLo.Text = "";
            txtSoLuongTon.Text = "0";
            txtDonGia.Text = "";
            DTPSanXuat.Text = "";
            DTPHanSD.Text = "";
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            LayMaTuDong_SP();
            clear();
            txtTenSP.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenSP.Text) || String.IsNullOrEmpty(txtSoLo.Text) || String.IsNullOrEmpty(txtDonGia.Text) || String.IsNullOrEmpty(txtThanhPhan.Text) || String.IsNullOrEmpty(txtCongDung.Text) || String.IsNullOrEmpty(txtGhiChu.Text) || String.IsNullOrEmpty(cbbDonViTinh.Text) || String.IsNullOrEmpty(cbbHangSX.Text) || String.IsNullOrEmpty(cbbMaLoai.Text) || String.IsNullOrEmpty(cbbMaXuatXu.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }
            try
            {
                SP.them_SP(txtMaSP.Text, cbbMaLoai.SelectedValue.ToString(), cbbHangSX.SelectedValue.ToString(), cbbMaXuatXu.SelectedValue.ToString(),
                    txtTenSP.Text, txthinhanh.Text, txtThanhPhan.Text, txtCongDung.Text, txtBaoQuan.Text, txtGhiChu.Text, cbbDonViTinh.SelectedValue.ToString(),
                    int.Parse(txtSoLo.Text), DateTime.Parse(DTPSanXuat.Text), DateTime.Parse(DTPHanSD.Text), decimal.Parse(txtDonGia.Text),
                    int.Parse(txtSoLuongTon.Text));

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVSP.DataSource = SP.load_SP();
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
                if (SP.xoa_SP(txtMaSP.Text) == 1 && txtSoLuongTon.Text == "0")
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVSP.DataSource = SP.load_SP();
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
                if (SP.sua_SP(txtMaSP.Text, cbbMaLoai.SelectedValue.ToString(), cbbHangSX.SelectedValue.ToString(), cbbMaXuatXu.SelectedValue.ToString(),
                    txtTenSP.Text, txthinhanh.Text, txtThanhPhan.Text, txtCongDung.Text, txtBaoQuan.Text, txtGhiChu.Text, cbbDonViTinh.SelectedValue.ToString(),
                    int.Parse(txtSoLo.Text), DateTime.Parse(DTPSanXuat.Text), DateTime.Parse(DTPHanSD.Text), decimal.Parse(txtDonGia.Text)
                    ) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVSP.DataSource = SP.load_SP();
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FormLoaiSanPham formNew = new FormLoaiSanPham();
            formNew.Show();
        }

        private void txtSoLo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
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
            FormTimKiemSanPham formNew = new FormTimKiemSanPham();
            formNew.Show();
        }

        private void GVSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVSP.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVSP.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
