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
    public partial class FormTimKiemSanPham : Form
    {
        SP_DALBLL sp = new SP_DALBLL();

        public FormTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void FormTimKiemSanPham_Load(object sender, EventArgs e)
        {
            GVSP.DataSource = sp.load_SP1();

            GVSP.Columns[1].HeaderText = "Mã sản phẩm";
            GVSP.Columns[1].Width = 100;

            GVSP.Columns[2].HeaderText = "Mã loại sản phẩm";
            GVSP.Columns[2].Width = 120;

            GVSP.Columns[3].HeaderText = "Mã hãng sản xuất";
            GVSP.Columns[3].Width = 120;

            GVSP.Columns[4].HeaderText = "Mã xuất xứ";
            GVSP.Columns[4].Width = 90;

            GVSP.Columns[5].HeaderText = "Tên sản phẩm";
            GVSP.Columns[5].Width = 150;

            GVSP.Columns[6].HeaderText = "Hình ảnh";
            GVSP.Columns[6].Width = 100;
;
            GVSP.Columns[7].HeaderText = "Thành phần";
            GVSP.Columns[7].Width = 150;

            GVSP.Columns[8].HeaderText = "Công dụng";
            GVSP.Columns[8].Width = 100;

            GVSP.Columns[9].HeaderText = "Bảo quản";
            GVSP.Columns[9].Width = 150;

            GVSP.Columns[10].HeaderText = "Ghi chú";
            GVSP.Columns[10].Width = 150;

            GVSP.Columns[11].HeaderText = "Đơn vị tính";
            GVSP.Columns[11].Width = 90;

            GVSP.Columns[12].HeaderText = "Số lô";
            GVSP.Columns[12].Width = 60;

            GVSP.Columns[13].HeaderText = "Ngày sản xuất";
            GVSP.Columns[13].Width = 100;

            GVSP.Columns[14].HeaderText = "Hạn sử dụng";
            GVSP.Columns[14].Width = 100;

            GVSP.Columns[15].HeaderText = "Đơn giá";
            GVSP.Columns[15].Width = 80;

            GVSP.Columns[16].HeaderText = "Số lượng tồn";
            GVSP.Columns[16].Width = 100;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Tìm theo mã sản phẩm
            if (ckma.Value)
            {
                GVSP.DataSource = sp.search_MASP(txtMaSP.Text);
            }

            //Tìm kiếm theo tên sản phẩm
            if (ckten.Value)
            {
                GVSP.DataSource = sp.search_TenSP(txtTenSP.Text);
            }

            //Tìm kiếm theo công dụng sản phẩm
            if (ckcongdung.Value)
            {
                GVSP.DataSource = sp.search_CongDung(txtCongDung.Text);
            }

            //Tìm kiếm theo ngày sản xuất
            if (ckngaysx.Value)
            {
                GVSP.DataSource = sp.search_NgaySX(DTPNgaySX.Value);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ckma.Value = ckten.Value = ckcongdung.Value = ckngaysx.Value = false;
            txtMaSP.Text = txtTenSP.Text = txtCongDung.Text = DTPNgaySX.Text = string.Empty;
            GVSP.DataSource = sp.load_SP1();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckma_ValueChanged(object sender, EventArgs e)
        {
            if (ckma.Value)
                txtMaSP.Enabled = true;
            else
                txtMaSP.Enabled = false;
        }

        private void ckten_ValueChanged(object sender, EventArgs e)
        {
            if (ckten.Value)
                txtTenSP.Enabled = true;
            else
                txtTenSP.Enabled = false;
        }

        private void ckcongdung_ValueChanged(object sender, EventArgs e)
        {
            if (ckcongdung.Value)
                txtCongDung.Enabled = true;
            else
                txtCongDung.Enabled = false;
        }

        private void ckngaysx_ValueChanged(object sender, EventArgs e)
        {
            if (ckngaysx.Value)
                DTPNgaySX.Enabled = true;
            else
                DTPNgaySX.Enabled = false;
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
