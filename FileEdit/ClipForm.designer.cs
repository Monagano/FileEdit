namespace ClipMaster
{
    partial class ClipForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipForm));
            this.dgvBody = new System.Windows.Forms.DataGridView();
            this.ClmExec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.dollarCombo = new System.Windows.Forms.ComboBox();
            this.previewRichText = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBody
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBody.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmExec,
            this.ClmKey,
            this.ClmTitle,
            this.ClmBody});
            this.dgvBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBody.EnableHeadersVisualStyles = false;
            this.dgvBody.Location = new System.Drawing.Point(0, 0);
            this.dgvBody.Name = "dgvBody";
            this.dgvBody.RowHeadersWidth = 20;
            this.dgvBody.RowTemplate.Height = 21;
            this.dgvBody.Size = new System.Drawing.Size(614, 241);
            this.dgvBody.TabIndex = 0;
            this.dgvBody.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBody_CellContentClick);
            this.dgvBody.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBody_CellClick);
            this.dgvBody.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBody_CellValueChanged);
            this.dgvBody.SelectionChanged += new System.EventHandler(this.dgvBody_SelectionChanged);
            this.dgvBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBody_KeyDown);
            // 
            // ClmExec
            // 
            this.ClmExec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            this.ClmExec.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmExec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClmExec.HeaderText = "";
            this.ClmExec.MinimumWidth = 50;
            this.ClmExec.Name = "ClmExec";
            this.ClmExec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmExec.Text = "実行";
            this.ClmExec.ToolTipText = "実行";
            this.ClmExec.UseColumnTextForButtonValue = true;
            this.ClmExec.Width = 50;
            // 
            // ClmKey
            // 
            this.ClmKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmKey.HeaderText = "ｷｰ";
            this.ClmKey.MinimumWidth = 35;
            this.ClmKey.Name = "ClmKey";
            this.ClmKey.ReadOnly = true;
            this.ClmKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmKey.Width = 35;
            // 
            // ClmTitle
            // 
            this.ClmTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmTitle.FillWeight = 25F;
            this.ClmTitle.HeaderText = "タイトル";
            this.ClmTitle.Name = "ClmTitle";
            // 
            // ClmBody
            // 
            this.ClmBody.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmBody.FillWeight = 75F;
            this.ClmBody.HeaderText = "本文";
            this.ClmBody.Name = "ClmBody";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 50);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "$reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "$name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 344);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 19);
            this.nameTextBox.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Image = global::FileEdit.Properties.Resources.save16;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(478, 247);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(65, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Image = global::FileEdit.Properties.Resources.reload16;
            this.LoadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadBtn.Location = new System.Drawing.Point(549, 247);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(65, 23);
            this.LoadBtn.TabIndex = 4;
            this.LoadBtn.Text = "Reload";
            this.LoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // dollarCombo
            // 
            this.dollarCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dollarCombo.FormattingEnabled = true;
            this.dollarCombo.Location = new System.Drawing.Point(12, 343);
            this.dollarCombo.Name = "dollarCombo";
            this.dollarCombo.Size = new System.Drawing.Size(315, 20);
            this.dollarCombo.TabIndex = 5;
            this.dollarCombo.TextChanged += new System.EventHandler(this.dollarCombo_TextChanged);
            // 
            // previewRichText
            // 
            this.previewRichText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewRichText.Location = new System.Drawing.Point(0, 0);
            this.previewRichText.Name = "previewRichText";
            this.previewRichText.Size = new System.Drawing.Size(220, 241);
            this.previewRichText.TabIndex = 6;
            this.previewRichText.Text = "";
            this.previewRichText.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvBody);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previewRichText);
            this.splitContainer1.Size = new System.Drawing.Size(838, 241);
            this.splitContainer1.SplitterDistance = 614;
            this.splitContainer1.TabIndex = 7;
            // 
            // ClipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(838, 374);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dollarCombo);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipForm";
            this.Text = "クリップボード拡張ラボ♪";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBody)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBody;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ComboBox dollarCombo;
        private System.Windows.Forms.RichTextBox previewRichText;
        private System.Windows.Forms.DataGridViewButtonColumn ClmExec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmBody;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

