namespace ConvertSql2Upper
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.cbAutoOprate = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSource.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSource.Location = new System.Drawing.Point(12, 13);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(632, 613);
            this.txtSource.TabIndex = 0;
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtTarget.Location = new System.Drawing.Point(775, 12);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(616, 613);
            this.txtTarget.TabIndex = 1;
            this.txtTarget.Text = "欢迎使用\r\n\r\n作者：Robin 44215 \r\n\r\n在 Initial.int 文件中添加关键字\r\n不区分大小写";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(670, 242);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "转换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(670, 160);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(670, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(670, 377);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "撤销";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(670, 201);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(670, 286);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "清空全部";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(670, 420);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 8;
            this.btnRock.Text = "998套餐";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // cbAutoOprate
            // 
            this.cbAutoOprate.AutoSize = true;
            this.cbAutoOprate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoOprate.ForeColor = System.Drawing.Color.Red;
            this.cbAutoOprate.Location = new System.Drawing.Point(660, 478);
            this.cbAutoOprate.Name = "cbAutoOprate";
            this.cbAutoOprate.Size = new System.Drawing.Size(108, 16);
            this.cbAutoOprate.TabIndex = 9;
            this.cbAutoOprate.Text = "9998全自动套餐";
            this.cbAutoOprate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConvertSql2Upper.Properties.Resources.ding;
            this.pictureBox1.Location = new System.Drawing.Point(650, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbAutoOprate);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Name = "MainForm";
            this.Text = "SQL语句转换大写";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.CheckBox cbAutoOprate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

