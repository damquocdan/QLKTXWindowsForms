namespace QLKTXWindowsForms
{
    partial class AdminMainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinTứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýPhòngSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiThanhToánDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiThanhToánPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinhTếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(836, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(85, 24);
            this.menuItem1.Text = "Hệ thống";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.giườngToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.tinTứcToolStripMenuItem});
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(73, 24);
            this.menuItem2.Text = "Quản lý";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // giườngToolStripMenuItem
            // 
            this.giườngToolStripMenuItem.Name = "giườngToolStripMenuItem";
            this.giườngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giườngToolStripMenuItem.Text = "Giường";
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp đồng ";
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            // 
            // tinTứcToolStripMenuItem
            // 
            this.tinTứcToolStripMenuItem.Name = "tinTứcToolStripMenuItem";
            this.tinTứcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tinTứcToolStripMenuItem.Text = "Tin tức";
            // 
            // menuItem3
            // 
            this.menuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýPhòngSVToolStripMenuItem,
            this.gửiThanhToánDVToolStripMenuItem,
            this.gửiThanhToánPhòngToolStripMenuItem});
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(93, 24);
            this.menuItem3.Text = "Chức năng";
            // 
            // đăngKýPhòngSVToolStripMenuItem
            // 
            this.đăngKýPhòngSVToolStripMenuItem.Name = "đăngKýPhòngSVToolStripMenuItem";
            this.đăngKýPhòngSVToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.đăngKýPhòngSVToolStripMenuItem.Text = "Chọn phòng cho SV";
            // 
            // gửiThanhToánDVToolStripMenuItem
            // 
            this.gửiThanhToánDVToolStripMenuItem.Name = "gửiThanhToánDVToolStripMenuItem";
            this.gửiThanhToánDVToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gửiThanhToánDVToolStripMenuItem.Text = "Gửi thanh toán DV";
            // 
            // gửiThanhToánPhòngToolStripMenuItem
            // 
            this.gửiThanhToánPhòngToolStripMenuItem.Name = "gửiThanhToánPhòngToolStripMenuItem";
            this.gửiThanhToánPhòngToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.gửiThanhToánPhòngToolStripMenuItem.Text = "Gửi thanh toán phòng";
            // 
            // menuItem4
            // 
            this.menuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêSinhViênToolStripMenuItem,
            this.tToolStripMenuItem,
            this.kinhTếToolStripMenuItem});
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(84, 24);
            this.menuItem4.Text = "Thống kê";
            // 
            // thốngKêSinhViênToolStripMenuItem
            // 
            this.thốngKêSinhViênToolStripMenuItem.Name = "thốngKêSinhViênToolStripMenuItem";
            this.thốngKêSinhViênToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.thốngKêSinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.tToolStripMenuItem.Text = "Phòng";
            // 
            // kinhTếToolStripMenuItem
            // 
            this.kinhTếToolStripMenuItem.Name = "kinhTếToolStripMenuItem";
            this.kinhTếToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.kinhTếToolStripMenuItem.Text = "Kinh  tế";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(836, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 30);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(836, 496);
            this.panelMainContent.TabIndex = 2;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainForm";
            this.Text = "Trang Chính Admin";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItem4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinTứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýPhòngSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiThanhToánDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiThanhToánPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kinhTếToolStripMenuItem;
        
    }
}
