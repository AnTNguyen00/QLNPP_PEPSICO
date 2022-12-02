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
    public partial class FormDangKy_CTTL_CTTB : Form
    {
        DK_CTTB_CTTL_DALBLL DK_TBTL = new DK_CTTB_CTTL_DALBLL();
        CTTB_DALBLL TBTL = new CTTB_DALBLL();
        KhachHang_DALBLL KH = new KhachHang_DALBLL();       

        public FormDangKy_CTTL_CTTB()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FormCTTL_CTTB formNew = new FormCTTL_CTTB();
            formNew.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string kt = rdDaBatDau.Checked ? "Đã bắt đầu" : "Đã kết thúc";

            if (String.IsNullOrEmpty(cbMaCT.Text) || String.IsNullOrEmpty(cbbMaKH.Text) || String.IsNullOrEmpty(DTPNgayDK.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống!", "Thông báo");
                return;
            }
            try
            {
                DK_TBTL.insert_DK_CTTB(cbMaCT.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString(), DateTime.Parse(DTPNgayDK.Text), float.Parse(txtDiemTL.Text), kt);

                MessageBox.Show("Đăng ký chương trình thành công");
                GV_DK_CTTB.DataSource = DK_TBTL.load_DK_TBTL();
            }
            catch
            {
                MessageBox.Show("Đăng ký chương trình không thành công!");
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            FormKhachHang formNew = new FormKhachHang();
            formNew.Show();
        }

        private void FormDangKy_CTTL_CTTB_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                buttonX2.Enabled = false;
            }
            GV_DK_CTTB.DataSource = DK_TBTL.load_DK_TBTL();

            cbbMaKH.DataSource = KH.load_TenKH();
            cbbMaKH.DisplayMember = "HOTENKH";
            cbbMaKH.ValueMember = "MAKH";

            cbMaCT.DataSource = TBTL.load_TenTBTL();
            cbMaCT.DisplayMember = "TENCT";
            cbMaCT.ValueMember = "MACT";


            cbMaCT.SelectedValue = GV_DK_CTTB.CurrentRow.Cells[1].Value.ToString();
            GV_DK_CTTB.Columns[1].HeaderText = "Mã chương trình";
            GV_DK_CTTB.Columns[1].Width = 110;

            cbbMaKH.SelectedValue = GV_DK_CTTB.CurrentRow.Cells[2].Value.ToString();
            GV_DK_CTTB.Columns[2].HeaderText = "Mã khách hàng";
            GV_DK_CTTB.Columns[2].Width = 110;

            DTPNgayDK.Value = Convert.ToDateTime(GV_DK_CTTB.CurrentRow.Cells[3].Value.ToString());
            GV_DK_CTTB.Columns[3].HeaderText = "Ngày đăng ký";
            GV_DK_CTTB.Columns[3].Width = 100;

            txtDiemTL.Text = GV_DK_CTTB.CurrentRow.Cells[4].Value.ToString();
            GV_DK_CTTB.Columns[4].HeaderText = "Điểm tích lũy";
            GV_DK_CTTB.Columns[4].Width = 90;

            GV_DK_CTTB.Columns[5].HeaderText = "Trạng thái";
            GV_DK_CTTB.Columns[5].Width = 90;

            //không cho nhập dữ liệu vào combobox
            this.cbMaCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Tìm kiếm (ký tự sẽ xổ ra khi gõ vào ký tự gần giống)
            cbbMaKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbMaKH.AutoCompleteSource = AutoCompleteSource.ListItems;


            txtDiemTL.Enabled = true;
        }

        #region Load trạng thái theo dk TBTL

        List<string> lst_TrangThai;

        public string TrangThai(string maCT)
        {
            lst_TrangThai = new List<string>();
            string tt = "";
            lst_TrangThai = DK_TBTL.load_TrangThai(maCT);
            foreach (string ct in lst_TrangThai)
            {
                try
                {
                    tt = ct.ToString(); //tên cột trạng thái
                }
                catch
                {
                    return "";
                }
            }
            return tt;
        }

        public void checkTrangThai(string maCT)
        {
            if (TrangThai(maCT) == "Đã bắt đầu")
            {
                rdDaBatDau.Checked = true;
            }
            else
            {
                rdDaKetThuc.Checked = true;
            }
        }

        #endregion

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DK_TBTL.delete_DK_CTTB(cbMaCT.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString()) == 1)
                {
                    MessageBox.Show("Hủy đăng ký chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GV_DK_CTTB.DataSource = DK_TBTL.load_DK_TBTL();
                }
                else
                {
                    MessageBox.Show("Hủy đăng ký chương trình không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Hủy đăng ký chương trình không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            string kt = rdDaBatDau.Checked ? "Đã bắt đầu" : "Đã kết thúc";

            try
            {
                if (DK_TBTL.update_DK_CTTB(cbMaCT.SelectedValue.ToString(), cbbMaKH.SelectedValue.ToString(), DateTime.Parse(DTPNgayDK.Text), float.Parse(txtDiemTL.Text), kt) == 1)
                {
                    MessageBox.Show("Cập nhật đăng ký chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GV_DK_CTTB.DataSource = DK_TBTL.load_DK_TBTL();
                }
                else
                {
                    MessageBox.Show("Cập nhật đăng ký chương trình không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch 
            {
                MessageBox.Show("Cập nhật đăng ký chương trình không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GV_DK_CTTB_Click(object sender, EventArgs e)
        {
            try
            {
                string ct = GV_DK_CTTB.CurrentRow.Cells[1].Value.ToString();

                cbMaCT.SelectedValue = GV_DK_CTTB.CurrentRow.Cells[1].Value.ToString();
                cbbMaKH.SelectedValue = GV_DK_CTTB.CurrentRow.Cells[2].Value.ToString();
                DTPNgayDK.Value = Convert.ToDateTime(GV_DK_CTTB.CurrentRow.Cells[3].Value.ToString());
                txtDiemTL.Text = GV_DK_CTTB.CurrentRow.Cells[4].Value.ToString();

                checkTrangThai(ct);
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            cbMaCT.ResetText();
            cbbMaKH.ResetText();
            DTPNgayDK.ResetText();
            txtDiemTL.Clear();
        }

        private void GV_DK_CTTB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GV_DK_CTTB.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GV_DK_CTTB.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }
    }
}
