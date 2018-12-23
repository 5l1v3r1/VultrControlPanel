namespace VultrControlPanel
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new CCWin.SkinControl.SkinTabControl();
            this.VPSTabPage = new CCWin.SkinControl.SkinTabPage();
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.DeployTabPage = new CCWin.SkinControl.SkinTabPage();
            this.AccountTabPage = new CCWin.SkinControl.SkinTabPage();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinListView1 = new CCWin.SkinControl.SkinListView();
            this.SubIDcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OScolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainPanel.SuspendLayout();
            this.VPSTabPage.SuspendLayout();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.MainPanel.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.MainPanel.Controls.Add(this.VPSTabPage);
            this.MainPanel.Controls.Add(this.DeployTabPage);
            this.MainPanel.Controls.Add(this.AccountTabPage);
            this.MainPanel.HeadBack = null;
            this.MainPanel.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.MainPanel.ItemSize = new System.Drawing.Size(70, 36);
            this.MainPanel.Location = new System.Drawing.Point(12, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageArrowDown")));
            this.MainPanel.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageArrowHover")));
            this.MainPanel.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageCloseHover")));
            this.MainPanel.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageCloseNormal")));
            this.MainPanel.PageDown = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageDown")));
            this.MainPanel.PageHover = ((System.Drawing.Image)(resources.GetObject("MainPanel.PageHover")));
            this.MainPanel.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.MainPanel.PageNorml = null;
            this.MainPanel.SelectedIndex = 0;
            this.MainPanel.Size = new System.Drawing.Size(776, 411);
            this.MainPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainPanel.TabIndex = 0;
            // 
            // VPSTabPage
            // 
            this.VPSTabPage.BackColor = System.Drawing.Color.White;
            this.VPSTabPage.Controls.Add(this.skinListView1);
            this.VPSTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VPSTabPage.Location = new System.Drawing.Point(0, 36);
            this.VPSTabPage.Name = "VPSTabPage";
            this.VPSTabPage.Size = new System.Drawing.Size(776, 375);
            this.VPSTabPage.TabIndex = 0;
            this.VPSTabPage.TabItemImage = null;
            this.VPSTabPage.Text = "VPS";
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 1;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // DeployTabPage
            // 
            this.DeployTabPage.BackColor = System.Drawing.Color.White;
            this.DeployTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeployTabPage.Location = new System.Drawing.Point(0, 36);
            this.DeployTabPage.Name = "DeployTabPage";
            this.DeployTabPage.Size = new System.Drawing.Size(200, 64);
            this.DeployTabPage.TabIndex = 1;
            this.DeployTabPage.TabItemImage = null;
            this.DeployTabPage.Text = "Deploy";
            // 
            // AccountTabPage
            // 
            this.AccountTabPage.BackColor = System.Drawing.Color.White;
            this.AccountTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountTabPage.Location = new System.Drawing.Point(0, 36);
            this.AccountTabPage.Name = "AccountTabPage";
            this.AccountTabPage.Size = new System.Drawing.Size(776, 375);
            this.AccountTabPage.TabIndex = 2;
            this.AccountTabPage.TabItemImage = null;
            this.AccountTabPage.Text = "Accounts";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // skinListView1
            // 
            this.skinListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubIDcolumnHeader,
            this.OScolumnHeader});
            this.skinListView1.Location = new System.Drawing.Point(4, 4);
            this.skinListView1.Name = "skinListView1";
            this.skinListView1.OwnerDraw = true;
            this.skinListView1.Size = new System.Drawing.Size(668, 368);
            this.skinListView1.TabIndex = 0;
            this.skinListView1.UseCompatibleStateImageBehavior = false;
            this.skinListView1.View = System.Windows.Forms.View.Details;
            // 
            // SubIDcolumnHeader
            // 
            this.SubIDcolumnHeader.Text = "SubID";
            // 
            // OScolumnHeader
            // 
            this.OScolumnHeader.Text = "OS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.skinMenuStrip1);
            this.MainMenuStrip = this.skinMenuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vultr Control Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.VPSTabPage.ResumeLayout(false);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl MainPanel;
        private CCWin.SkinControl.SkinTabPage VPSTabPage;
        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private CCWin.SkinControl.SkinTabPage DeployTabPage;
        private CCWin.SkinControl.SkinTabPage AccountTabPage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private CCWin.SkinControl.SkinListView skinListView1;
        private System.Windows.Forms.ColumnHeader SubIDcolumnHeader;
        private System.Windows.Forms.ColumnHeader OScolumnHeader;
    }
}

