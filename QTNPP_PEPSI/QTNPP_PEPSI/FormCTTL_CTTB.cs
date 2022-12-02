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
    public partial class FormCTTL_CTTB : Form
    {
        CTTB_DALBLL TBTL = new CTTB_DALBLL();
        SP_DALBLL SP = new SP_DALBLL();

        public FormCTTL_CTTB()
        {
            InitializeComponent();
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Text = oFile.FileName.Substring(oFile.FileName.LastIndexOf("\\") + 1);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void layMaTuDong_TBTL()
        {
            List<CTTB_CTTL> lst = new List<CTTB_CTTL>();
            lst = TBTL.getTBTL();
            string a = GVCTTB.Rows[GVCTTB.Rows.Count - 1].Cells[1].Value.ToString();
            string matbtl = "CT";
            string b = a.Substring(2, 2);
            int ma = Convert.ToInt32(b);
            ma = ma + 1;
            if (lst.Count < 9)
                matbtl = matbtl + "0";
            else
                matbtl = matbtl + "";
            matbtl += ma;

            txtMaCT.Text = matbtl;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            layMaTuDong_TBTL();
            txtTenCT.Clear();
            cbbMaSP.Text = "";
            txtDiemDat.Clear();
            integerInput_SoSuat.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaCT.Text) || String.IsNullOrEmpty(txtTenCT.Text) || String.IsNullOrEmpty(txtHinhAnh.Text) || String.IsNullOrEmpty(integerInput_SoSuat.Text) || String.IsNullOrEmpty(cbbMaSP.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }
            try
            {
                TBTL.insert_CTTB(txtMaCT.Text, txtTenCT.Text,integerInput_SoSuat.Value, cbbMaSP.SelectedValue.ToString(), DateTime.Parse(DTPNgayBD.Text), DateTime.Parse(DTPNgayKT.Text), decimal.Parse(txtDiemDat.Text),txtHinhAnh.Text);

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GVCTTB.DataSource = TBTL.load_TBTL();
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCTTL_CTTB_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnLoadAnh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnTaoMoi.Enabled = btnSua.Enabled = false;
            }

            //đổi link
            Bitmap anh = new Bitmap(@"C:\Users\Admin\OneDrive\Desktop\KLTN\QTNPP_PEPSI\hinhnew\1080-x-540-go-v-central-retail.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = (Image)anh;

            GVCTTB.DataSource = TBTL.load_TBTL();

            cbbMaSP.DataSource = SP.load_TenSP();
            cbbMaSP.DisplayMember = "TENSANPHAM";
            cbbMaSP.ValueMember = "MASP";

            txtMaCT.Text = GVCTTB.CurrentRow.Cells[1].Value.ToString();
            GVCTTB.Columns[1].HeaderText = "Mã chương trình";
            GVCTTB.Columns[1].Width = 110;

            txtTenCT.Text = GVCTTB.CurrentRow.Cells[2].Value.ToString();
            GVCTTB.Columns[2].HeaderText = "Tên chương trình";
            GVCTTB.Columns[2].Width = 200;

            integerInput_SoSuat.Text = GVCTTB.CurrentRow.Cells[3].Value.ToString();
            GVCTTB.Columns[3].HeaderText = "Số suất";
            GVCTTB.Columns[3].Width = 70;

            cbbMaSP.Text = GVCTTB.CurrentRow.Cells[4].Value.ToString();
            GVCTTB.Columns[4].HeaderText = "Mã sản phẩm";
            GVCTTB.Columns[4].Width = 100;

            DTPNgayBD.Text = GVCTTB.CurrentRow.Cells[5].Value.ToString();
            GVCTTB.Columns[5].HeaderText = "Ngày bắt đầu";
            GVCTTB.Columns[5].Width = 100;

            DTPNgayKT.Text = GVCTTB.CurrentRow.Cells[6].Value.ToString();
            GVCTTB.Columns[6].HeaderText = "Ngày kết thúc";
            GVCTTB.Columns[6].Width = 100;

            txtDiemDat.Text = GVCTTB.CurrentRow.Cells[7].Value.ToString();
            GVCTTB.Columns[7].HeaderText = "Điểm đạt";
            GVCTTB.Columns[7].Width = 80;

            txtHinhAnh.Text = GVCTTB.CurrentRow.Cells[8].Value.ToString();
            GVCTTB.Columns[8].HeaderText = "Hình Ảnh";
            GVCTTB.Columns[8].Width = 100;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtTenCT.Enabled = true;
        }

        private void GVCTTB_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaCT.Text = GVCTTB.CurrentRow.Cells[1].Value.ToString();
                txtTenCT.Text = GVCTTB.CurrentRow.Cells[2].Value.ToString();
                integerInput_SoSuat.Text = GVCTTB.CurrentRow.Cells[3].Value.ToString();
                cbbMaSP.Text = GVCTTB.CurrentRow.Cells[4].Value.ToString();
                DTPNgayBD.Text = GVCTTB.CurrentRow.Cells[5].Value.ToString();
                DTPNgayKT.Text = GVCTTB.CurrentRow.Cells[6].Value.ToString();
                txtDiemDat.Text = GVCTTB.CurrentRow.Cells[7].Value.ToString();
                txtHinhAnh.Text= GVCTTB.CurrentRow.Cells[8].Value.ToString();

                Bitmap anh = new Bitmap(@"C:\Users\Admin\OneDrive\Desktop\KLTN\QTNPP_PEPSI\hinhnew\1080-x-540-go-v-central-retail.jpg");

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = (Image)anh;
            }
            catch
            { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBTL.delete_CTTB(txtMaCT.Text) == 1)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVCTTB.DataSource = TBTL.load_TBTL();
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
                if (TBTL.update_CTTB(txtMaCT.Text, txtTenCT.Text, integerInput_SoSuat.Value, cbbMaSP.SelectedValue.ToString(), DateTime.Parse(DTPNgayBD.Text), DateTime.Parse(DTPNgayKT.Text), decimal.Parse(txtDiemDat.Text), txtHinhAnh.Text) == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GVCTTB.DataSource = TBTL.load_TBTL();
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

        private void txtDiemDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void clear()
        {
            txtMaCT.Clear();
            cbbMaSP.ResetText();
            txtTenCT.Clear();
            integerInput_SoSuat.ResetText();
            DTPNgayBD.ResetText();
            DTPNgayKT.ResetText();
            txtDiemDat.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (btnTimKiem.Text == "Clear")
            {
                clear();
                txtTenCT.Enabled = true;
                txtTenCT.Focus();
                btnTimKiem.Text = "Search";
            }
            else
            {
                GVCTTB.DataSource = TBTL.search_TenCT(txtTenCT.Text);
                btnTimKiem.Text = "Clear";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormCTTL_CTTB_Load(sender, e);
        }

        private void GVCTTB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVCTTB.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVCTTB.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
