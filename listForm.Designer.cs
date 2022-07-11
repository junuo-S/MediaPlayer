namespace MediaPlayer
{
    partial class listForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listForm));
            this.playList = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addFile = new System.Windows.Forms.ToolStripMenuItem();
            this.addDir = new System.Windows.Forms.ToolStripMenuItem();
            this.delTool = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTool = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTool = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playList
            // 
            this.playList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.fileName,
            this.time});
            this.playList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playList.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playList.FullRowSelect = true;
            this.playList.GridLines = true;
            this.playList.HideSelection = false;
            this.playList.Location = new System.Drawing.Point(0, 0);
            this.playList.MultiSelect = false;
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(381, 510);
            this.playList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.playList.TabIndex = 0;
            this.playList.UseCompatibleStateImageBehavior = false;
            this.playList.View = System.Windows.Forms.View.Details;
            this.playList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playList_MouseDoubleClick);
            this.playList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playList_MouseUp);
            // 
            // num
            // 
            this.num.Text = "序号";
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num.Width = 156;
            // 
            // fileName
            // 
            this.fileName.Text = "文件名";
            // 
            // time
            // 
            this.time.Text = "时长";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTool,
            this.delTool,
            this.clearTool,
            this.searchTool});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(143, 108);
            // 
            // addTool
            // 
            this.addTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFile,
            this.addDir});
            this.addTool.Image = global::MediaPlayer.Properties.Resources.icon_add;
            this.addTool.Name = "addTool";
            this.addTool.Size = new System.Drawing.Size(142, 26);
            this.addTool.Text = "添加";
            // 
            // addFile
            // 
            this.addFile.Image = ((System.Drawing.Image)(resources.GetObject("addFile.Image")));
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(152, 26);
            this.addFile.Text = "添加文件";
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // addDir
            // 
            this.addDir.Image = global::MediaPlayer.Properties.Resources.icon_openDir;
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(152, 26);
            this.addDir.Text = "添加目录";
            this.addDir.Click += new System.EventHandler(this.addDir_Click);
            // 
            // delTool
            // 
            this.delTool.Image = global::MediaPlayer.Properties.Resources.icon_del;
            this.delTool.Name = "delTool";
            this.delTool.Size = new System.Drawing.Size(142, 26);
            this.delTool.Text = "移除";
            this.delTool.Click += new System.EventHandler(this.delTool_Click);
            // 
            // clearTool
            // 
            this.clearTool.Image = global::MediaPlayer.Properties.Resources.icon_clear;
            this.clearTool.Name = "clearTool";
            this.clearTool.Size = new System.Drawing.Size(142, 26);
            this.clearTool.Text = "清空列表";
            this.clearTool.Click += new System.EventHandler(this.clearTool_Click);
            // 
            // searchTool
            // 
            this.searchTool.Image = global::MediaPlayer.Properties.Resources.icon_search;
            this.searchTool.Name = "searchTool";
            this.searchTool.Size = new System.Drawing.Size(142, 26);
            this.searchTool.Text = "搜索";
            this.searchTool.Click += new System.EventHandler(this.searchTool_Click);
            // 
            // listForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 510);
            this.Controls.Add(this.playList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listForm";
            this.Text = "播放列表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listForm_FormClosing);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView playList;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ToolStripMenuItem addTool;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addFile;
        private System.Windows.Forms.ToolStripMenuItem addDir;
        private System.Windows.Forms.ToolStripMenuItem delTool;
        private System.Windows.Forms.ToolStripMenuItem clearTool;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ToolStripMenuItem searchTool;
    }
}