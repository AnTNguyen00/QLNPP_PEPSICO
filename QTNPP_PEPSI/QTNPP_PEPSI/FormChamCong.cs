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
    public partial class FormChamCong : Form
    {
        QLNPP_PEPSI1DataContext QLNPP_PS = new QLNPP_PEPSI1DataContext();
        ChamCong_DALBLL chamcong = new ChamCong_DALBLL();
        NhanVien_DALBLL nv = new NhanVien_DALBLL();

        public FormChamCong()
        {
            InitializeComponent();
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                GvChamCong.DataSource = chamcong.load_ChamCongNV(FormDangNhap.nv.MANV);

                txtMaChamCong.Clear();
                txtMaChamCong.Focus();
                panelEx1.Visible = false;
                panelEx2.Visible = false;

                txtMaChamCong.Text = GvChamCong.Rows[GvChamCong.Rows.Count - 1].Cells[1].Value.ToString();
                GvChamCong.Columns[1].HeaderText = "Mã chấm công";
                GvChamCong.Columns[1].Width = 150;

                cbbMaNhanVien.Text = GvChamCong.CurrentRow.Cells[2].Value.ToString();
                GvChamCong.Columns[2].HeaderText = "Mã nhân viên";
                GvChamCong.Columns[2].Width = 150;

                txtThang.Text = GvChamCong.CurrentRow.Cells[3].Value.ToString();
                GvChamCong.Columns[3].HeaderText = "Tháng";
                GvChamCong.Columns[3].Width = 150;

                txtNam.Text = GvChamCong.CurrentRow.Cells[4].Value.ToString();
                GvChamCong.Columns[4].HeaderText = "Năm";
                GvChamCong.Columns[4].Width = 150;

                txtSoNgayLam.Text = GvChamCong.CurrentRow.Cells[5].Value.ToString();
                GvChamCong.Columns[5].HeaderText = "Số ngày làm";
                GvChamCong.Columns[5].Width = 150;
            }
            else
            {
                GvChamCong.DataSource = chamcong.load_ChamCong();
                cbbMaNhanVien.DataSource = nv.load_TenNV();
                cbbMaNhanVien.ValueMember = "MANV";
                cbbMaNhanVien.DisplayMember = "HOTENNV";


                cbbMaNhanVien.Text = GvChamCong.CurrentRow.Cells[1].Value.ToString();
                GvChamCong.Columns[1].HeaderText = "Mã nhân viên";
                GvChamCong.Columns[1].Width = 150;

                txtMaCC2.Text = GvChamCong.CurrentRow.Cells[2].Value.ToString();
                GvChamCong.Columns[2].HeaderText = "Mã chấm công";
                GvChamCong.Columns[2].Width = 150;

                GvChamCong.CurrentRow.Cells[3].Value.ToString();
                GvChamCong.Columns[3].HeaderText = "Tên nhân viên";
                GvChamCong.Columns[3].Width = 150;

                txtThang.Text = GvChamCong.CurrentRow.Cells[4].Value.ToString();
                GvChamCong.Columns[4].HeaderText = "Tháng";
                GvChamCong.Columns[4].Width = 150;

                txtNam.Text = GvChamCong.CurrentRow.Cells[5].Value.ToString();
                GvChamCong.Columns[5].HeaderText = "Năm";
                GvChamCong.Columns[5].Width = 150;

                txtSoNgayLam.Text = GvChamCong.CurrentRow.Cells[6].Value.ToString();
                GvChamCong.Columns[6].HeaderText = "Số ngày làm";
                GvChamCong.Columns[6].Width = 150;
            }

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbMaNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void GvChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                cbbMaNhanVien.Text = GvChamCong.CurrentRow.Cells[1].Value.ToString();
                txtMaCC2.Text = GvChamCong.CurrentRow.Cells[2].Value.ToString();
                txtThang.Text = GvChamCong.CurrentRow.Cells[4].Value.ToString();
                txtNam.Text = GvChamCong.CurrentRow.Cells[5].Value.ToString();
                txtSoNgayLam.Text = GvChamCong.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }
        }

        

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                int soNgayLam = Int32.Parse(GvChamCong.CurrentRow.Cells[5].Value.ToString());
                chamcong.chamCong(txtMaChamCong.Text, FormDangNhap.nv.MANV, soNgayLam);
                GvChamCong.DataSource = chamcong.load_ChamCongNV(FormDangNhap.nv.MANV);

                MessageBox.Show("Thực hiện chấm công thành công", "Thông báo");
                btnThoat_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Thực hiện chấm công không thành công!", "Thông báo");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaChamCong.Text = string.Empty;
            cbbMaNhanVien.Text = string.Empty;
            txtMaCC2.Text = string.Empty;
            txtThang.Text = string.Empty;
            txtNam.Text = string.Empty;
            txtSoNgayLam.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCC2.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbMCC.Text.ToLower());
                this.txtMaChamCong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbbMaNhanVien.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbMNV.Text.ToLower());
                this.cbbMaNhanVien.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtThang.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbThang.Text.ToLower());
                this.txtMaChamCong.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNam.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbNam.Text.ToLower());
                this.txtMaChamCong.Focus();
                return;
            }

            CHAMCONG cc = QLNPP_PS.CHAMCONGs.Where(t => t.MANV == cbbMaNhanVien.SelectedValue.ToString() && t.MACHAMCONG == txtMaCC2.Text).FirstOrDefault();
            if (cc == null)
            {
                chamcong.insert_ChamCong(txtMaCC2.Text, cbbMaNhanVien.SelectedValue.ToString(), Int32.Parse(txtThang.Text), Int32.Parse(txtNam.Text), Int32.Parse(txtSoNgayLam.Text));
                GvChamCong.DataSource = chamcong.load_ChamCong();

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
            }
            else
            {
                cc.SONGAYLAMVIEC = Int32.Parse(txtSoNgayLam.Text);
                QLNPP_PS.SubmitChanges();
                GvChamCong.DataSource = chamcong.load_ChamCong();

                MessageBox.Show("Giá trị đã có, sửa thành công", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Muốn xóa bảng chấm công này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string manv = GvChamCong.CurrentRow.Cells[0].Value.ToString();
                    string macc = GvChamCong.CurrentRow.Cells[1].Value.ToString(); 
                    chamcong.delete_ChamCong(macc, manv);

                    MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GvChamCong.DataSource = chamcong.load_ChamCong();
                }
            }
            catch
            {
                MessageBox.Show("Xoá dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoNgayLam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GvChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GvChamCong.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GvChamCong.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
