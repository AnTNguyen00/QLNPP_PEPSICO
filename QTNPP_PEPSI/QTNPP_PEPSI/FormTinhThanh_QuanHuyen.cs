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
    public partial class FormTinhThanh_QuanHuyen : Form
    {
        TinhThanh_DALBLL tinhthanh = new TinhThanh_DALBLL();
        QuanHuyen_DALBLL quanhuyen = new QuanHuyen_DALBLL();

        public FormTinhThanh_QuanHuyen()
        {
            InitializeComponent();
        }

        private void FormTinhThanh_QuanHuyen_Load(object sender, EventArgs e)
        {
            if (FormDangNhap.nv.MANHOMNV == "NV")
            {
                btnTaoMoiTT.Enabled = btnThemTT.Enabled = btnXoaTT.Enabled = false;
                btnTaoMoiQH.Enabled = btnThemQH.Enabled = btnXoaQH.Enabled = false;
            }
            GvTinhThanh.DataSource = tinhthanh.load_TinhThanh();

            //Khởi tạo combobox Tỉnh thành
            cbbTinhThanh.DataSource = tinhthanh.load_TinhThanh();
            cbbTinhThanh.DisplayMember = "MATINHTHANH";
            cbbTinhThanh.ValueMember = "MATINHTHANH";

            //chỉ định dòng đầu vào textbox của tỉnh thành
            txtMaTinhThanh.Text = GvTinhThanh.CurrentRow.Cells[1].Value.ToString();
            GvTinhThanh.Columns[1].HeaderText = "Mã tỉnh thành";
            GvTinhThanh.Columns[1].Width = 140;

            txtTenTinhThanh.Text = GvTinhThanh.CurrentRow.Cells[2].Value.ToString();
            GvTinhThanh.Columns[2].HeaderText = "Tên tỉnh thành";
            GvTinhThanh.Columns[2].Width = 170;

            btnThemTT.Enabled = false;
            btnThemQH.Enabled = false;
            txtMaTinhThanh.Enabled = false;
            txtTenTinhThanh.Enabled = false;
            txtMaQuanHuyen.Enabled = false;
            txtTenQuanHuyen.Enabled = false;
            cbbTinhThanh.Enabled = false;
        }

        private void GVQuanHuyen_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaQuanHuyen.Text = GVQuanHuyen.CurrentRow.Cells[1].Value.ToString();
                cbbTinhThanh.Text = GVQuanHuyen.CurrentRow.Cells[2].Value.ToString();
                txtTenQuanHuyen.Text = GVQuanHuyen.CurrentRow.Cells[3].Value.ToString();

                List<TINHTHANH> lstTinhThanh = new List<TINHTHANH>();
                lstTinhThanh = tinhthanh.load_TinhThanh();

                //Binding giá trị mã tỉnh thành sang combobox Tinh thanh
                foreach (TINHTHANH i in lstTinhThanh)
                {
                    if (i.MATINHTHANH == GVQuanHuyen.CurrentRow.Cells[2].Value.ToString())
                    {
                        cbbTinhThanh.SelectedItem = i;
                        break;
                    }
                }
            }
            catch
            { }
        }

        private void GvTinhThanh_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaTinhThanh.Text = GvTinhThanh.CurrentRow.Cells[1].Value.ToString();
                txtTenTinhThanh.Text = GvTinhThanh.CurrentRow.Cells[2].Value.ToString();

                GVQuanHuyen.DataSource = quanhuyen.getQuanHuyen1(GvTinhThanh.CurrentRow.Cells[1].Value.ToString());

                txtMaQuanHuyen.Text = GVQuanHuyen.CurrentRow.Cells[1].Value.ToString();
                GVQuanHuyen.Columns[1].HeaderText = "Mã quận huyện";
                GVQuanHuyen.Columns[1].Width = 110;

                cbbTinhThanh.Text = GVQuanHuyen.CurrentRow.Cells[2].Value.ToString();
                GVQuanHuyen.Columns[2].HeaderText = "Mã tỉnh thành";
                GVQuanHuyen.Columns[2].Width = 100;

                txtTenQuanHuyen.Text = GVQuanHuyen.CurrentRow.Cells[3].Value.ToString();
                GVQuanHuyen.Columns[3].HeaderText = "Tên quận huyện";
                GVQuanHuyen.Columns[3].Width = 120;
            }
            catch
            { }
        }

        private void btnTaoMoiQH_Click(object sender, EventArgs e)
        {
            btnThemQH.Enabled = true;
            txtMaQuanHuyen.Enabled = true;
            txtTenQuanHuyen.Enabled = true;
            cbbTinhThanh.Enabled = true;

            //================================================//
            txtMaQuanHuyen.Clear();
            txtTenQuanHuyen.Clear();
        }

        private void btnThemQH_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu rỗng
            if (String.IsNullOrEmpty(txtMaQuanHuyen.Text) || String.IsNullOrEmpty(txtTenQuanHuyen.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo");
                return;
            }

            //Kiểm tra tên quận huyện đã tồn tại hay chưa
            List<QUANHUYEN> lstQuanHuyen = new List<QUANHUYEN>();
            lstQuanHuyen = quanhuyen.getQuanHuyenLst();
            foreach (QUANHUYEN i in lstQuanHuyen)
            {
                if (i.TENQUANHUYEN == txtTenQuanHuyen.Text)
                {
                    MessageBox.Show("Quận Huyện đã tồn tại", "Thông báo");
                    FormTinhThanh_QuanHuyen_Load(sender, e);
                    return;
                }
            }

            //Thêm dữ liệu
            if (quanhuyen.insertQuanHuyen(txtMaQuanHuyen.Text, cbbTinhThanh.SelectedValue.ToString(), txtTenQuanHuyen.Text) == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
        }

        private void btnXoaQH_Click(object sender, EventArgs e)
        {
            if (quanhuyen.deleteQuanHuyen(txtMaQuanHuyen.Text) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
        }

        private void btnTaoMoiTT_Click(object sender, EventArgs e)
        {
            btnThemTT.Enabled = true;
            txtMaTinhThanh.Enabled = true;
            txtTenTinhThanh.Enabled = true;

            //================================================//
            txtMaTinhThanh.Clear();
            txtTenTinhThanh.Clear();
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu rỗng
            if (String.IsNullOrEmpty(txtMaTinhThanh.Text) || String.IsNullOrEmpty(txtTenTinhThanh.Text))
            {
                MessageBox.Show("Dữ liệu không được để trống", "Thông báo");
                return;
            }

            //Kiểm tra tên tỉnh thành đã tồn tại hay chưa
            List<TINHTHANH> lstTinhThanh = new List<TINHTHANH>();
            lstTinhThanh = tinhthanh.load_TinhThanh();
            foreach (TINHTHANH i in lstTinhThanh)
            {
                if (i.TENTINHTHANH == txtTenTinhThanh.Text)
                {
                    MessageBox.Show("Tỉnh Thành đã tồn tại", "Thông báo");
                    FormTinhThanh_QuanHuyen_Load(sender, e);
                    return;
                }
            }

            //Thêm dữ liệu
            if (tinhthanh.them_TinhThanh(txtMaTinhThanh.Text, txtTenTinhThanh.Text) == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            if (tinhthanh.xoa_TinhThanh(txtMaTinhThanh.Text) == true)
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
                FormTinhThanh_QuanHuyen_Load(sender, e);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemQH_Click(object sender, EventArgs e)
        {
            if (btnTimKiemQH.Text == "Clear")
            {
                txtMaQuanHuyen.Clear();
                cbbTinhThanh.ResetText();
                txtTenQuanHuyen.Clear();
                txtTenQuanHuyen.Enabled = true;
                cbbTinhThanh.Enabled = true;
                txtTenQuanHuyen.Focus();
                btnTimKiemQH.Text = "Search";
            }
            else
            {
                GVQuanHuyen.DataSource = quanhuyen.search_MATT(cbbTinhThanh.Text);
                GVQuanHuyen.DataSource = quanhuyen.search_TenQH(txtTenQuanHuyen.Text, GvTinhThanh.CurrentRow.Cells[1].Value.ToString());
                btnTimKiemQH.Text = "Clear";
            }
        }

        private void btnShowQH_Click(object sender, EventArgs e)
        {
            GVQuanHuyen.DataSource = quanhuyen.getQuanHuyen1(GvTinhThanh.CurrentRow.Cells[1].Value.ToString());
        }

        private void btnTimKiemTT_Click(object sender, EventArgs e)
        {
            if (btnTimKiemTT.Text == "Clear")
            {
                txtMaTinhThanh.Clear();
                txtTenTinhThanh.Clear();
                txtTenTinhThanh.Enabled = true;
                txtTenTinhThanh.Focus();
                btnTimKiemTT.Text = "Search";
            }
            else
            {
                GvTinhThanh.DataSource = tinhthanh.search_TenTT(txtTenTinhThanh.Text);
                btnTimKiemTT.Text = "Clear";
            }
        }

        private void btnShowTT_Click(object sender, EventArgs e)
        {
            FormTinhThanh_QuanHuyen_Load(sender, e);
        }

        private void GVQuanHuyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GVQuanHuyen.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GVQuanHuyen.Columns["STT"].Index)
                e.Value = e.RowIndex + 1;
        }

        private void GvTinhThanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == this.GvTinhThanh.NewRowIndex)
                return;

            if (e.ColumnIndex == this.GvTinhThanh.Columns["STT_"].Index)
                e.Value = e.RowIndex + 1;
        }

        private void btnXuatTT_Click(object sender, EventArgs e)
        {
            rptXuatPNH rpt = new rptXuatPNH();
            rpt.SetDatabaseLogon("sa", "sa2012", "DESKTOP-COHHIDH", "QL_QTNPP_PEPSI");

            FormXuatBaoCao fm = new FormXuatBaoCao();

            fm.crystalReportViewer1.ReportSource = rpt;
            fm.crystalReportViewer1.DisplayStatusBar = false;
            fm.crystalReportViewer1.DisplayToolbar = true;

            rpt.SetParameterValue("LocTinh", txtMaTinhThanh.Text.ToString());
            fm.ShowDialog();

        }
    }
}
