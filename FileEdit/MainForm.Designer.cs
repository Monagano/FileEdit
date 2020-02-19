namespace FileEdit
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DropBox = new System.Windows.Forms.ListBox();
            this.BodyBox = new System.Windows.Forms.RichTextBox();
            this.xmlSortBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DDlabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.xmlSortAltBtn = new System.Windows.Forms.Button();
            this.pdfbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClipBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DropBox
            // 
            this.DropBox.AllowDrop = true;
            this.DropBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropBox.FormattingEnabled = true;
            this.DropBox.ItemHeight = 12;
            this.DropBox.Location = new System.Drawing.Point(0, 0);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(223, 240);
            this.DropBox.TabIndex = 0;
            this.DropBox.SelectedIndexChanged += new System.EventHandler(this.DropBox_SelectedIndexChanged);
            this.DropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropBox_DragDrop);
            this.DropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropBox_DragEnter);
            this.DropBox.DragLeave += new System.EventHandler(this.DropBox_DragLeave);
            // 
            // BodyBox
            // 
            this.BodyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyBox.Location = new System.Drawing.Point(0, 0);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(444, 240);
            this.BodyBox.TabIndex = 1;
            this.BodyBox.Text = "";
            this.BodyBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BodyBox_LinkClicked);
            // 
            // xmlSortBtn
            // 
            this.xmlSortBtn.AutoEllipsis = true;
            this.xmlSortBtn.Location = new System.Drawing.Point(3, 3);
            this.xmlSortBtn.Name = "xmlSortBtn";
            this.xmlSortBtn.Size = new System.Drawing.Size(312, 27);
            this.xmlSortBtn.TabIndex = 2;
            this.xmlSortBtn.Text = "xmlをソートしてソースフォルダに保存";
            this.xmlSortBtn.UseVisualStyleBackColor = true;
            this.xmlSortBtn.Click += new System.EventHandler(this.xmlSortBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DDlabel);
            this.splitContainer1.Panel1.Controls.Add(this.DropBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BodyBox);
            this.splitContainer1.Size = new System.Drawing.Size(671, 240);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 3;
            // 
            // DDlabel
            // 
            this.DDlabel.AutoSize = true;
            this.DDlabel.Location = new System.Drawing.Point(38, 108);
            this.DDlabel.Name = "DDlabel";
            this.DDlabel.Size = new System.Drawing.Size(152, 12);
            this.DDlabel.TabIndex = 2;
            this.DDlabel.Text = "ここにファイルをドラッグ＆ドロップ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.xmlSortBtn);
            this.flowLayoutPanel1.Controls.Add(this.xmlSortAltBtn);
            this.flowLayoutPanel1.Controls.Add(this.pdfbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(671, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 240);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // xmlSortAltBtn
            // 
            this.xmlSortAltBtn.AutoEllipsis = true;
            this.xmlSortAltBtn.Location = new System.Drawing.Point(3, 36);
            this.xmlSortAltBtn.Name = "xmlSortAltBtn";
            this.xmlSortAltBtn.Size = new System.Drawing.Size(312, 27);
            this.xmlSortAltBtn.TabIndex = 3;
            this.xmlSortAltBtn.Text = "xmlをソートして別名で保存";
            this.xmlSortAltBtn.UseVisualStyleBackColor = true;
            this.xmlSortAltBtn.Click += new System.EventHandler(this.xmlSortAltBtn_Click);
            // 
            // pdfbutton
            // 
            this.pdfbutton.AutoEllipsis = true;
            this.pdfbutton.Location = new System.Drawing.Point(3, 69);
            this.pdfbutton.Name = "pdfbutton";
            this.pdfbutton.Size = new System.Drawing.Size(312, 27);
            this.pdfbutton.TabIndex = 3;
            this.pdfbutton.Text = "p";
            this.pdfbutton.UseVisualStyleBackColor = true;
            this.pdfbutton.Click += new System.EventHandler(this.pdfbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 240);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ClipBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(985, 32);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // ClipBtn
            // 
            this.ClipBtn.Location = new System.Drawing.Point(3, 3);
            this.ClipBtn.Name = "ClipBtn";
            this.ClipBtn.Size = new System.Drawing.Size(75, 23);
            this.ClipBtn.TabIndex = 0;
            this.ClipBtn.Text = "clip";
            this.ClipBtn.UseVisualStyleBackColor = true;
            this.ClipBtn.Click += new System.EventHandler(this.ClipMaster_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MyWork";
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.Form_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DropBox;
        private System.Windows.Forms.RichTextBox BodyBox;
        private System.Windows.Forms.Button xmlSortBtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button xmlSortAltBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ClipBtn;
        private System.Windows.Forms.Label DDlabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.Button pdfbutton;
    }
}

