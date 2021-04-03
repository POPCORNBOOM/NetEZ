
namespace NetEZ
{
    partial class MusicNetEZ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicNetEZ));
            this.t_songid = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.l_songid = new System.Windows.Forms.Label();
            this.t_path = new System.Windows.Forms.TextBox();
            this.l_path = new System.Windows.Forms.Label();
            this.l_tail = new System.Windows.Forms.Label();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_quest = new System.Windows.Forms.Button();
            this.ll_email = new System.Windows.Forms.LinkLabel();
            this.btn_search = new System.Windows.Forms.Button();
            this.t_search = new System.Windows.Forms.TextBox();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_search = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.ProgressBar();
            this.t_downpath = new System.Windows.Forms.TextBox();
            this.l_pathset = new System.Windows.Forms.Label();
            this.btn_pathset = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.pan_down = new System.Windows.Forms.Panel();
            this.pan_search = new System.Windows.Forms.Panel();
            this.pan_fil = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.cms_copy.SuspendLayout();
            this.pan_down.SuspendLayout();
            this.pan_search.SuspendLayout();
            this.pan_fil.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_songid
            // 
            this.t_songid.Font = new System.Drawing.Font("等线", 10F);
            this.t_songid.Location = new System.Drawing.Point(7, 25);
            this.t_songid.Name = "t_songid";
            this.t_songid.Size = new System.Drawing.Size(168, 21);
            this.t_songid.TabIndex = 0;
            this.t_songid.TabStop = false;
            // 
            // btn_download
            // 
            this.btn_download.Font = new System.Drawing.Font("张海山锐线体简", 12F);
            this.btn_download.Location = new System.Drawing.Point(6, 211);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(195, 35);
            this.btn_download.TabIndex = 2;
            this.btn_download.Text = "下载";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // l_songid
            // 
            this.l_songid.AutoSize = true;
            this.l_songid.Font = new System.Drawing.Font("张海山锐线体简", 12F);
            this.l_songid.Location = new System.Drawing.Point(6, 2);
            this.l_songid.Name = "l_songid";
            this.l_songid.Size = new System.Drawing.Size(199, 20);
            this.l_songid.TabIndex = 2;
            this.l_songid.Text = "请输入您想下载的歌曲的id";
            // 
            // t_path
            // 
            this.t_path.Font = new System.Drawing.Font("等线", 10F);
            this.t_path.Location = new System.Drawing.Point(6, 139);
            this.t_path.Name = "t_path";
            this.t_path.Size = new System.Drawing.Size(151, 21);
            this.t_path.TabIndex = 0;
            this.t_path.TabStop = false;
            this.t_path.Text = "newNetEZsong";
            // 
            // l_path
            // 
            this.l_path.AutoSize = true;
            this.l_path.Font = new System.Drawing.Font("张海山锐线体简", 12F);
            this.l_path.Location = new System.Drawing.Point(6, 116);
            this.l_path.Name = "l_path";
            this.l_path.Size = new System.Drawing.Size(185, 20);
            this.l_path.TabIndex = 2;
            this.l_path.Text = "请输入您想保存的歌曲名";
            // 
            // l_tail
            // 
            this.l_tail.AutoSize = true;
            this.l_tail.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_tail.Location = new System.Drawing.Point(163, 140);
            this.l_tail.Name = "l_tail";
            this.l_tail.Size = new System.Drawing.Size(42, 20);
            this.l_tail.TabIndex = 2;
            this.l_tail.Text = ".mp3";
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.White;
            this.btn_up.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_up.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_up.Location = new System.Drawing.Point(171, 0);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(64, 25);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "置顶窗口";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_quest
            // 
            this.btn_quest.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_quest.Location = new System.Drawing.Point(181, 25);
            this.btn_quest.Name = "btn_quest";
            this.btn_quest.Size = new System.Drawing.Size(21, 21);
            this.btn_quest.TabIndex = 4;
            this.btn_quest.Text = "?";
            this.btn_quest.UseVisualStyleBackColor = true;
            this.btn_quest.Click += new System.EventHandler(this.btn_quest_Click);
            // 
            // ll_email
            // 
            this.ll_email.ActiveLinkColor = System.Drawing.Color.Peru;
            this.ll_email.AutoSize = true;
            this.ll_email.BackColor = System.Drawing.Color.Transparent;
            this.ll_email.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_email.LinkColor = System.Drawing.Color.PeachPuff;
            this.ll_email.Location = new System.Drawing.Point(314, 258);
            this.ll_email.Name = "ll_email";
            this.ll_email.Size = new System.Drawing.Size(137, 12);
            this.ll_email.TabIndex = 5;
            this.ll_email.TabStop = true;
            this.ll_email.Text = "popcornboom_137@qq.com";
            this.ll_email.VisitedLinkColor = System.Drawing.Color.LightSalmon;
            this.ll_email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_email_LinkClicked);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(171, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 21);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_searchfor);
            // 
            // t_search
            // 
            this.t_search.Font = new System.Drawing.Font("等线", 10F);
            this.t_search.Location = new System.Drawing.Point(0, 31);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(168, 21);
            this.t_search.TabIndex = 0;
            this.t_search.TabStop = false;
            // 
            // dgv_search
            // 
            this.dgv_search.AllowUserToAddRows = false;
            this.dgv_search.AllowUserToDeleteRows = false;
            this.dgv_search.AllowUserToOrderColumns = true;
            this.dgv_search.AllowUserToResizeColumns = false;
            this.dgv_search.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            this.dgv_search.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_search.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_search.ColumnHeadersHeight = 30;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.artist,
            this.id});
            this.dgv_search.ContextMenuStrip = this.cms_copy;
            this.dgv_search.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_search.Location = new System.Drawing.Point(0, 63);
            this.dgv_search.MultiSelect = false;
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.ReadOnly = true;
            this.dgv_search.RowHeadersVisible = false;
            this.dgv_search.RowTemplate.Height = 23;
            this.dgv_search.Size = new System.Drawing.Size(235, 189);
            this.dgv_search.TabIndex = 7;
            this.dgv_search.TabStop = false;
            this.dgv_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "曲名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 80;
            // 
            // artist
            // 
            this.artist.HeaderText = "艺人";
            this.artist.Name = "artist";
            this.artist.ReadOnly = true;
            this.artist.Width = 60;
            // 
            // id
            // 
            this.id.HeaderText = "歌曲id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 94;
            // 
            // cms_copy
            // 
            this.cms_copy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.搜索ToolStripMenuItem});
            this.cms_copy.Name = "cms_copy";
            this.cms_copy.Size = new System.Drawing.Size(101, 48);
            this.cms_copy.Text = "CMS";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.搜索ToolStripMenuItem.Text = "填入";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.搜索ToolStripMenuItem_Click);
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.Font = new System.Drawing.Font("张海山锐线体简", 12F);
            this.l_search.Location = new System.Drawing.Point(0, 8);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(112, 20);
            this.l_search.TabIndex = 2;
            this.l_search.Text = "搜索歌曲/艺人";
            // 
            // pb_down
            // 
            this.pb_down.Location = new System.Drawing.Point(7, 182);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(194, 23);
            this.pb_down.TabIndex = 0;
            this.pb_down.Visible = false;
            // 
            // t_downpath
            // 
            this.t_downpath.Font = new System.Drawing.Font("等线", 10F);
            this.t_downpath.Location = new System.Drawing.Point(6, 94);
            this.t_downpath.Name = "t_downpath";
            this.t_downpath.ReadOnly = true;
            this.t_downpath.Size = new System.Drawing.Size(169, 21);
            this.t_downpath.TabIndex = 0;
            this.t_downpath.TabStop = false;
            // 
            // l_pathset
            // 
            this.l_pathset.AutoSize = true;
            this.l_pathset.Font = new System.Drawing.Font("张海山锐线体简", 12F);
            this.l_pathset.Location = new System.Drawing.Point(6, 71);
            this.l_pathset.Name = "l_pathset";
            this.l_pathset.Size = new System.Drawing.Size(188, 20);
            this.l_pathset.TabIndex = 2;
            this.l_pathset.Text = "请输入您想下载到的路径";
            // 
            // btn_pathset
            // 
            this.btn_pathset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_pathset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pathset.BackgroundImage")));
            this.btn_pathset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pathset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pathset.FlatAppearance.BorderSize = 0;
            this.btn_pathset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pathset.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_pathset.Location = new System.Drawing.Point(181, 94);
            this.btn_pathset.Name = "btn_pathset";
            this.btn_pathset.Size = new System.Drawing.Size(21, 21);
            this.btn_pathset.TabIndex = 4;
            this.btn_pathset.UseVisualStyleBackColor = false;
            this.btn_pathset.Click += new System.EventHandler(this.btn_pathset_Click);
            // 
            // pan_down
            // 
            this.pan_down.BackColor = System.Drawing.Color.Transparent;
            this.pan_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_down.BackgroundImage")));
            this.pan_down.Controls.Add(this.pb_down);
            this.pan_down.Controls.Add(this.btn_pathset);
            this.pan_down.Controls.Add(this.btn_quest);
            this.pan_down.Controls.Add(this.l_tail);
            this.pan_down.Controls.Add(this.l_path);
            this.pan_down.Controls.Add(this.l_pathset);
            this.pan_down.Controls.Add(this.l_songid);
            this.pan_down.Controls.Add(this.t_path);
            this.pan_down.Controls.Add(this.btn_download);
            this.pan_down.Controls.Add(this.t_downpath);
            this.pan_down.Controls.Add(this.t_songid);
            this.pan_down.Location = new System.Drawing.Point(1, 5);
            this.pan_down.Name = "pan_down";
            this.pan_down.Size = new System.Drawing.Size(215, 251);
            this.pan_down.TabIndex = 8;
            // 
            // pan_search
            // 
            this.pan_search.BackColor = System.Drawing.Color.Transparent;
            this.pan_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_search.BackgroundImage")));
            this.pan_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_search.Controls.Add(this.dgv_search);
            this.pan_search.Controls.Add(this.btn_search);
            this.pan_search.Controls.Add(this.l_search);
            this.pan_search.Controls.Add(this.btn_up);
            this.pan_search.Controls.Add(this.t_search);
            this.pan_search.Location = new System.Drawing.Point(222, 5);
            this.pan_search.Name = "pan_search";
            this.pan_search.Size = new System.Drawing.Size(236, 251);
            this.pan_search.TabIndex = 9;
            // 
            // pan_fil
            // 
            this.pan_fil.BackColor = System.Drawing.Color.Transparent;
            this.pan_fil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_fil.BackgroundImage")));
            this.pan_fil.Controls.Add(this.pan_search);
            this.pan_fil.Controls.Add(this.pan_down);
            this.pan_fil.Controls.Add(this.ll_email);
            this.pan_fil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_fil.Location = new System.Drawing.Point(0, 0);
            this.pan_fil.Name = "pan_fil";
            this.pan_fil.Size = new System.Drawing.Size(464, 281);
            this.pan_fil.TabIndex = 10;
            // 
            // MusicNetEZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.pan_fil);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "MusicNetEZ";
            this.Text = "MusicNetEZ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.cms_copy.ResumeLayout(false);
            this.pan_down.ResumeLayout(false);
            this.pan_down.PerformLayout();
            this.pan_search.ResumeLayout(false);
            this.pan_search.PerformLayout();
            this.pan_fil.ResumeLayout(false);
            this.pan_fil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox t_songid;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label l_songid;
        private System.Windows.Forms.TextBox t_path;
        private System.Windows.Forms.Label l_path;
        private System.Windows.Forms.Label l_tail;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_quest;
        private System.Windows.Forms.LinkLabel ll_email;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Label l_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ContextMenuStrip cms_copy;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pb_down;
        private System.Windows.Forms.TextBox t_downpath;
        private System.Windows.Forms.Label l_pathset;
        private System.Windows.Forms.Button btn_pathset;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Panel pan_down;
        private System.Windows.Forms.Panel pan_search;
        private System.Windows.Forms.Panel pan_fil;
    }
}

