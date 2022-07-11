namespace MediaPlayer
{
    partial class mediaWin
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
            this.funcMenu = new System.Windows.Forms.MenuStrip();
            this.musicMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mvMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.musicPanel = new System.Windows.Forms.Panel();
            this.ctrlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picLast = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picMode = new System.Windows.Forms.PictureBox();
            this.btnList = new System.Windows.Forms.Button();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.labelVol = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelBegin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ctrlBar = new System.Windows.Forms.HScrollBar();
            this.musicName = new System.Windows.Forms.Label();
            this.funcMenu.SuspendLayout();
            this.musicPanel.SuspendLayout();
            this.ctrlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcMenu
            // 
            this.funcMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.funcMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicMenu,
            this.mvMenu});
            this.funcMenu.Location = new System.Drawing.Point(0, 0);
            this.funcMenu.Name = "funcMenu";
            this.funcMenu.Size = new System.Drawing.Size(614, 30);
            this.funcMenu.TabIndex = 0;
            this.funcMenu.Text = "menuStrip1";
            // 
            // musicMenu
            // 
            this.musicMenu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicMenu.Name = "musicMenu";
            this.musicMenu.Size = new System.Drawing.Size(76, 22);
            this.musicMenu.Text = "听音乐";
            this.musicMenu.Click += new System.EventHandler(this.musicMenu_Click);
            // 
            // mvMenu
            // 
            this.mvMenu.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mvMenu.Name = "mvMenu";
            this.mvMenu.Size = new System.Drawing.Size(76, 22);
            this.mvMenu.Text = "看视频";
            this.mvMenu.Click += new System.EventHandler(this.mvMenu_Click);
            // 
            // musicPanel
            // 
            this.musicPanel.Controls.Add(this.ctrlPanel);
            this.musicPanel.Controls.Add(this.labelEnd);
            this.musicPanel.Controls.Add(this.labelBegin);
            this.musicPanel.Controls.Add(this.tableLayoutPanel1);
            this.musicPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicPanel.Location = new System.Drawing.Point(0, 351);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(614, 130);
            this.musicPanel.TabIndex = 1;
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.ColumnCount = 7;
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.75244F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38437F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.68404F));
            this.ctrlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ctrlPanel.Controls.Add(this.picLast, 0, 0);
            this.ctrlPanel.Controls.Add(this.picPlay, 1, 0);
            this.ctrlPanel.Controls.Add(this.picNext, 2, 0);
            this.ctrlPanel.Controls.Add(this.picMode, 6, 0);
            this.ctrlPanel.Controls.Add(this.btnList, 5, 0);
            this.ctrlPanel.Controls.Add(this.volBar, 4, 0);
            this.ctrlPanel.Controls.Add(this.labelVol, 3, 0);
            this.ctrlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlPanel.Location = new System.Drawing.Point(0, 68);
            this.ctrlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.RowCount = 1;
            this.ctrlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ctrlPanel.Size = new System.Drawing.Size(614, 62);
            this.ctrlPanel.TabIndex = 3;
            // 
            // picLast
            // 
            this.picLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLast.Image = global::MediaPlayer.Properties.Resources.icon_last;
            this.picLast.Location = new System.Drawing.Point(3, 3);
            this.picLast.Name = "picLast";
            this.picLast.Size = new System.Drawing.Size(55, 56);
            this.picLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLast.TabIndex = 0;
            this.picLast.TabStop = false;
            this.picLast.Click += new System.EventHandler(this.picLast_Click);
            // 
            // picPlay
            // 
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlay.Image = global::MediaPlayer.Properties.Resources.icon_play;
            this.picPlay.Location = new System.Drawing.Point(64, 3);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(55, 56);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay.TabIndex = 1;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picNext
            // 
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNext.Image = global::MediaPlayer.Properties.Resources.icon_next;
            this.picNext.Location = new System.Drawing.Point(125, 3);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(55, 56);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNext.TabIndex = 2;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picMode
            // 
            this.picMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMode.Image = global::MediaPlayer.Properties.Resources.icon_sequence;
            this.picMode.Location = new System.Drawing.Point(584, 3);
            this.picMode.Name = "picMode";
            this.picMode.Size = new System.Drawing.Size(27, 56);
            this.picMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMode.TabIndex = 3;
            this.picMode.TabStop = false;
            this.picMode.Click += new System.EventHandler(this.picMode_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnList.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnList.Location = new System.Drawing.Point(462, 7);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(116, 47);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "播放列表";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // volBar
            // 
            this.volBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volBar.LargeChange = 50;
            this.volBar.Location = new System.Drawing.Point(295, 3);
            this.volBar.Maximum = 1000;
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(156, 56);
            this.volBar.SmallChange = 50;
            this.volBar.TabIndex = 5;
            this.volBar.Value = 1000;
            this.volBar.ValueChanged += new System.EventHandler(this.volBar_ValueChanged);
            // 
            // labelVol
            // 
            this.labelVol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVol.AutoSize = true;
            this.labelVol.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVol.Location = new System.Drawing.Point(183, 0);
            this.labelVol.Margin = new System.Windows.Forms.Padding(0);
            this.labelVol.Name = "labelVol";
            this.labelVol.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.labelVol.Size = new System.Drawing.Size(82, 62);
            this.labelVol.TabIndex = 6;
            this.labelVol.Text = "音量：";
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEnd.Location = new System.Drawing.Point(549, 42);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(53, 18);
            this.labelEnd.TabIndex = 2;
            this.labelEnd.Text = "--:--";
            // 
            // labelBegin
            // 
            this.labelBegin.AutoSize = true;
            this.labelBegin.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBegin.Location = new System.Drawing.Point(13, 42);
            this.labelBegin.Name = "labelBegin";
            this.labelBegin.Size = new System.Drawing.Size(53, 18);
            this.labelBegin.TabIndex = 1;
            this.labelBegin.Text = "00:00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ctrlBar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.88591F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.1141F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(608, 5);
            this.progressBar.TabIndex = 0;
            // 
            // ctrlBar
            // 
            this.ctrlBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlBar.LargeChange = 1;
            this.ctrlBar.Location = new System.Drawing.Point(0, 11);
            this.ctrlBar.Name = "ctrlBar";
            this.ctrlBar.Size = new System.Drawing.Size(614, 24);
            this.ctrlBar.TabIndex = 1;
            this.ctrlBar.MouseCaptureChanged += new System.EventHandler(this.ctrlBar_ValueChanged);
            // 
            // musicName
            // 
            this.musicName.AutoSize = true;
            this.musicName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicName.Location = new System.Drawing.Point(0, 333);
            this.musicName.Name = "musicName";
            this.musicName.Size = new System.Drawing.Size(17, 18);
            this.musicName.TabIndex = 2;
            this.musicName.Text = " ";
            // 
            // mediaWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 481);
            this.Controls.Add(this.musicName);
            this.Controls.Add(this.musicPanel);
            this.Controls.Add(this.funcMenu);
            this.Name = "mediaWin";
            this.Text = "媒体播放器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mediaWin_FormClosed);
            this.funcMenu.ResumeLayout(false);
            this.funcMenu.PerformLayout();
            this.musicPanel.ResumeLayout(false);
            this.musicPanel.PerformLayout();
            this.ctrlPanel.ResumeLayout(false);
            this.ctrlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip funcMenu;
        private System.Windows.Forms.ToolStripMenuItem musicMenu;
        private System.Windows.Forms.ToolStripMenuItem mvMenu;
        private System.Windows.Forms.Panel musicPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.HScrollBar ctrlBar;
        private System.Windows.Forms.Label labelBegin;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.TableLayoutPanel ctrlPanel;
        private System.Windows.Forms.PictureBox picLast;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picMode;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label musicName;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.Label labelVol;
    }
}

