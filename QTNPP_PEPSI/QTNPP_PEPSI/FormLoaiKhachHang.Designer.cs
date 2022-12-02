
namespace QTNPP_PEPSI
{
    partial class FormLoaiKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVLoaiKH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txtTenLoaiKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMaLoaiKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnTaoMoi = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btnShow = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatLoaiKH = new DevComponents.DotNetBar.ButtonX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GVLoaiKH)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVLoaiKH
            // 
            this.GVLoaiKH.BackgroundColor = System.Drawing.Color.White;
            this.GVLoaiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVLoaiKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVLoaiKH.DefaultCellStyle = dataGridViewCellStyle1;
            this.GVLoaiKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.GVLoaiKH.Location = new System.Drawing.Point(11, 3);
            this.GVLoaiKH.Name = "GVLoaiKH";
            this.GVLoaiKH.RowHeadersWidth = 51;
            this.GVLoaiKH.RowTemplate.Height = 24;
            this.GVLoaiKH.Size = new System.Drawing.Size(868, 244);
            this.GVLoaiKH.TabIndex = 46;
            this.GVLoaiKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GVLoaiKH_CellFormatting);
            this.GVLoaiKH.Click += new System.EventHandler(this.GVLoaiKH_Click);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 64;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.panelEx1);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(11, 10);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(896, 163);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 73;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txtTenLoaiKH);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.txtMaLoaiKH);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(11, 10);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(868, 136);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 81;
            // 
            // txtTenLoaiKH
            // 
            // 
            // 
            // 
            this.txtTenLoaiKH.Border.Class = "TextBoxBorder";
            this.txtTenLoaiKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiKH.Enabled = false;
            this.txtTenLoaiKH.Location = new System.Drawing.Point(407, 93);
            this.txtTenLoaiKH.Name = "txtTenLoaiKH";
            this.txtTenLoaiKH.PreventEnterBeep = true;
            this.txtTenLoaiKH.Size = new System.Drawing.Size(195, 22);
            this.txtTenLoaiKH.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(226, 93);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(168, 22);
            this.labelX2.TabIndex = 59;
            this.labelX2.Text = "Tên Loại Khách hàng:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(231, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(163, 22);
            this.labelX1.TabIndex = 31;
            this.labelX1.Text = "Mã Loại Khách hàng:";
            // 
            // txtMaLoaiKH
            // 
            // 
            // 
            // 
            this.txtMaLoaiKH.Border.Class = "TextBoxBorder";
            this.txtMaLoaiKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLoaiKH.Enabled = false;
            this.txtMaLoaiKH.Location = new System.Drawing.Point(406, 25);
            this.txtMaLoaiKH.Name = "txtMaLoaiKH";
            this.txtMaLoaiKH.PreventEnterBeep = true;
            this.txtMaLoaiKH.Size = new System.Drawing.Size(196, 22);
            this.txtMaLoaiKH.TabIndex = 0;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.GVLoaiKH);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(11, 264);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(896, 283);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 72;
            this.groupPanel3.Text = "Danh sách loại khách hàng";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThem.Location = new System.Drawing.Point(131, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaoMoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTaoMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnTaoMoi.Location = new System.Drawing.Point(23, 19);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 31);
            this.btnTaoMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTaoMoi.TabIndex = 6;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.TextColor = System.Drawing.Color.White;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSua.Location = new System.Drawing.Point(350, 19);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThoat.Location = new System.Drawing.Point(790, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btnShow);
            this.panelEx2.Controls.Add(this.btnXuatLoaiKH);
            this.panelEx2.Controls.Add(this.btnTimKiem);
            this.panelEx2.Controls.Add(this.btnSua);
            this.panelEx2.Controls.Add(this.btnThoat);
            this.panelEx2.Controls.Add(this.btnXoa);
            this.panelEx2.Controls.Add(this.btnThem);
            this.panelEx2.Controls.Add(this.btnTaoMoi);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(17, 185);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(890, 65);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 77;
            // 
            // btnShow
            // 
            this.btnShow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShow.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShow.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnShow.Location = new System.Drawing.Point(567, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Show";
            this.btnShow.TextColor = System.Drawing.Color.White;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnXuatLoaiKH
            // 
            this.btnXuatLoaiKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatLoaiKH.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXuatLoaiKH.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXuatLoaiKH.Location = new System.Drawing.Point(675, 19);
            this.btnXuatLoaiKH.Name = "btnXuatLoaiKH";
            this.btnXuatLoaiKH.Size = new System.Drawing.Size(75, 31);
            this.btnXuatLoaiKH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatLoaiKH.TabIndex = 17;
            this.btnXuatLoaiKH.Text = "Report";
            this.btnXuatLoaiKH.TextColor = System.Drawing.Color.White;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(459, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 31);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Clear";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnXoa.Location = new System.Drawing.Point(240, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelEx2);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(924, 578);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Loại Khách Hàng";
            // 
            // FormLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 586);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoaiKhachHang";
            this.Load += new System.EventHandler(this.FormLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVLoaiKH)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX GVLoaiKH;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiKH;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiKH;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnTaoMoi;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnShow;
        private DevComponents.DotNetBar.ButtonX btnXuatLoaiKH;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}