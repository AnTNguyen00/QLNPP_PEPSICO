
namespace QTNPP_PEPSI
{
    partial class FormTimKiemNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.GvNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel7 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkGioiTinh = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.cbbGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkMaNhanVien = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtMaNhanVien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkNgayBatDau = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.DTPNgayBD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkMaNhom = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.cbbMaNhom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkHoTen = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtHoTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvNhanVien)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupPanel7.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTPNgayBD)).BeginInit();
            this.groupPanel5.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.GvNhanVien);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(12, 289);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1617, 546);
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
            this.groupPanel3.TabIndex = 82;
            this.groupPanel3.Text = "Danh sách tìm kiếm";
            // 
            // GvNhanVien
            // 
            this.GvNhanVien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvNhanVien.EnableHeadersVisualStyles = false;
            this.GvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.GvNhanVien.Location = new System.Drawing.Point(11, 3);
            this.GvNhanVien.Name = "GvNhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GvNhanVien.RowHeadersWidth = 51;
            this.GvNhanVien.RowTemplate.Height = 24;
            this.GvNhanVien.Size = new System.Drawing.Size(1583, 517);
            this.GvNhanVien.TabIndex = 46;
            this.GvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GvNhanVien_CellFormatting);
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
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panelEx1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1617, 268);
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
            this.groupPanel1.TabIndex = 81;
            this.groupPanel1.Text = "Tìm kiếm nhân viên";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel7);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel6);
            this.panelEx1.Controls.Add(this.btnTimKiem);
            this.panelEx1.Controls.Add(this.groupPanel5);
            this.panelEx1.Controls.Add(this.btnLamMoi);
            this.panelEx1.Controls.Add(this.groupPanel4);
            this.panelEx1.Controls.Add(this.btnThoat);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(11, 3);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1583, 230);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 83;
            // 
            // groupPanel7
            // 
            this.groupPanel7.BackColor = System.Drawing.Color.White;
            this.groupPanel7.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel7.Controls.Add(this.checkGioiTinh);
            this.groupPanel7.Controls.Add(this.cbbGioiTinh);
            this.groupPanel7.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel7.Location = new System.Drawing.Point(509, 121);
            this.groupPanel7.Name = "groupPanel7";
            this.groupPanel7.Size = new System.Drawing.Size(249, 63);
            // 
            // 
            // 
            this.groupPanel7.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel7.Style.BackColorGradientAngle = 90;
            this.groupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderBottomWidth = 1;
            this.groupPanel7.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderLeftWidth = 1;
            this.groupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderRightWidth = 1;
            this.groupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel7.Style.BorderTopWidth = 1;
            this.groupPanel7.Style.CornerDiameter = 4;
            this.groupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel7.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel7.TabIndex = 83;
            this.groupPanel7.Text = "Theo giới tính";
            // 
            // checkGioiTinh
            // 
            // 
            // 
            // 
            this.checkGioiTinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkGioiTinh.Location = new System.Drawing.Point(-3, 8);
            this.checkGioiTinh.Name = "checkGioiTinh";
            this.checkGioiTinh.Size = new System.Drawing.Size(66, 22);
            this.checkGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkGioiTinh.TabIndex = 0;
            this.checkGioiTinh.ValueChanged += new System.EventHandler(this.checkGioiTinh_ValueChanged);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Text";
            this.cbbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGioiTinh.Enabled = false;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.ItemHeight = 16;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbbGioiTinh.Location = new System.Drawing.Point(75, 8);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(165, 22);
            this.cbbGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbGioiTinh.TabIndex = 63;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nam";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Nữ";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.checkMaNhanVien);
            this.groupPanel2.Controls.Add(this.txtMaNhanVien);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(100, 24);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(249, 63);
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
            this.groupPanel2.TabIndex = 79;
            this.groupPanel2.Text = "Theo mã nhân viên";
            // 
            // checkMaNhanVien
            // 
            // 
            // 
            // 
            this.checkMaNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkMaNhanVien.Location = new System.Drawing.Point(3, 8);
            this.checkMaNhanVien.Name = "checkMaNhanVien";
            this.checkMaNhanVien.Size = new System.Drawing.Size(66, 22);
            this.checkMaNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkMaNhanVien.TabIndex = 0;
            this.checkMaNhanVien.ValueChanged += new System.EventHandler(this.checkMaNhanVien_ValueChanged);
            // 
            // txtMaNhanVien
            // 
            // 
            // 
            // 
            this.txtMaNhanVien.Border.Class = "TextBoxBorder";
            this.txtMaNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(75, 8);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PreventEnterBeep = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(165, 22);
            this.txtMaNhanVien.TabIndex = 62;
            // 
            // groupPanel6
            // 
            this.groupPanel6.BackColor = System.Drawing.Color.White;
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel6.Controls.Add(this.checkNgayBatDau);
            this.groupPanel6.Controls.Add(this.DTPNgayBD);
            this.groupPanel6.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel6.Location = new System.Drawing.Point(928, 24);
            this.groupPanel6.Name = "groupPanel6";
            this.groupPanel6.Size = new System.Drawing.Size(249, 63);
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel6.TabIndex = 82;
            this.groupPanel6.Text = "Theo ngày bắt đầu làm việc";
            // 
            // checkNgayBatDau
            // 
            // 
            // 
            // 
            this.checkNgayBatDau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkNgayBatDau.Location = new System.Drawing.Point(3, 8);
            this.checkNgayBatDau.Name = "checkNgayBatDau";
            this.checkNgayBatDau.Size = new System.Drawing.Size(66, 22);
            this.checkNgayBatDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkNgayBatDau.TabIndex = 0;
            this.checkNgayBatDau.ValueChanged += new System.EventHandler(this.checkNgayBatDau_ValueChanged);
            // 
            // DTPNgayBD
            // 
            // 
            // 
            // 
            this.DTPNgayBD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTPNgayBD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTPNgayBD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTPNgayBD.ButtonDropDown.Visible = true;
            this.DTPNgayBD.Enabled = false;
            this.DTPNgayBD.IsPopupCalendarOpen = false;
            this.DTPNgayBD.Location = new System.Drawing.Point(75, 8);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DTPNgayBD.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTPNgayBD.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTPNgayBD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTPNgayBD.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTPNgayBD.MonthCalendar.DisplayMonth = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DTPNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTPNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTPNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTPNgayBD.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTPNgayBD.MonthCalendar.TodayButtonVisible = true;
            this.DTPNgayBD.Name = "DTPNgayBD";
            this.DTPNgayBD.Size = new System.Drawing.Size(165, 22);
            this.DTPNgayBD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTPNgayBD.TabIndex = 74;
            this.DTPNgayBD.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(1375, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(91, 31);
            this.btnTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimKiem.TabIndex = 64;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupPanel5
            // 
            this.groupPanel5.BackColor = System.Drawing.Color.White;
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.checkMaNhom);
            this.groupPanel5.Controls.Add(this.cbbMaNhom);
            this.groupPanel5.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel5.Location = new System.Drawing.Point(509, 24);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(249, 63);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 81;
            this.groupPanel5.Text = "Theo nhóm nhân viên";
            // 
            // checkMaNhom
            // 
            // 
            // 
            // 
            this.checkMaNhom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkMaNhom.Location = new System.Drawing.Point(3, 8);
            this.checkMaNhom.Name = "checkMaNhom";
            this.checkMaNhom.Size = new System.Drawing.Size(66, 22);
            this.checkMaNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkMaNhom.TabIndex = 0;
            this.checkMaNhom.ValueChanged += new System.EventHandler(this.checkMaNhom_ValueChanged);
            // 
            // cbbMaNhom
            // 
            this.cbbMaNhom.DisplayMember = "Text";
            this.cbbMaNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaNhom.Enabled = false;
            this.cbbMaNhom.FormattingEnabled = true;
            this.cbbMaNhom.ItemHeight = 16;
            this.cbbMaNhom.Location = new System.Drawing.Point(75, 8);
            this.cbbMaNhom.Name = "cbbMaNhom";
            this.cbbMaNhom.Size = new System.Drawing.Size(165, 22);
            this.cbbMaNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbMaNhom.TabIndex = 73;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLamMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLamMoi.Location = new System.Drawing.Point(1375, 99);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 32);
            this.btnLamMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamMoi.TabIndex = 71;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.White;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.White;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.checkHoTen);
            this.groupPanel4.Controls.Add(this.txtHoTen);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(106, 121);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(249, 63);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 80;
            this.groupPanel4.Text = "Theo họ tên nhân viên";
            // 
            // checkHoTen
            // 
            // 
            // 
            // 
            this.checkHoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkHoTen.Location = new System.Drawing.Point(3, 8);
            this.checkHoTen.Name = "checkHoTen";
            this.checkHoTen.Size = new System.Drawing.Size(66, 22);
            this.checkHoTen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkHoTen.TabIndex = 0;
            this.checkHoTen.ValueChanged += new System.EventHandler(this.checkHoTen_ValueChanged);
            // 
            // txtHoTen
            // 
            // 
            // 
            // 
            this.txtHoTen.Border.Class = "TextBoxBorder";
            this.txtHoTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(75, 8);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PreventEnterBeep = true;
            this.txtHoTen.Size = new System.Drawing.Size(165, 22);
            this.txtHoTen.TabIndex = 57;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnThoat.Location = new System.Drawing.Point(1375, 176);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 32);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 847);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FormTimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimKiemNhanVien";
            this.Load += new System.EventHandler(this.FormTimKiemNhanVien_Load);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvNhanVien)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel7.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTPNgayBD)).EndInit();
            this.groupPanel5.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX GvNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel7;
        private DevComponents.DotNetBar.Controls.SwitchButton checkGioiTinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbGioiTinh;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private DevComponents.DotNetBar.Controls.SwitchButton checkNgayBatDau;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTPNgayBD;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.SwitchButton checkMaNhom;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbMaNhom;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.SwitchButton checkHoTen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTen;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.SwitchButton checkMaNhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNhanVien;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLamMoi;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
    }
}