namespace SourceproStudio.Csharp.Toolkits
{
    partial class MainForm
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
            this.CtrlVersionControlGroup = new System.Windows.Forms.GroupBox();
            this.CtrlCreateBuildVersion = new System.Windows.Forms.Button();
            this.CtrlCreateInnerVersion = new System.Windows.Forms.Button();
            this.CtrlBuildVersionValue = new System.Windows.Forms.NumericUpDown();
            this.CtrlInnerVersionValue = new System.Windows.Forms.NumericUpDown();
            this.CtrlMinorVersionValue = new System.Windows.Forms.NumericUpDown();
            this.CtrlMajorVersionValue = new System.Windows.Forms.NumericUpDown();
            this.CtrlBuildVersionLabel = new System.Windows.Forms.Label();
            this.CtrlInnerVersionLabel = new System.Windows.Forms.Label();
            this.CtrlMinorVersionLabel = new System.Windows.Forms.Label();
            this.CtrlMajorVersionLabel = new System.Windows.Forms.Label();
            this.CtrlCopytoClipboard = new System.Windows.Forms.Button();
            this.CtrlRewriteCSFile = new System.Windows.Forms.Button();
            this.CtrlOpenCSFile = new System.Windows.Forms.OpenFileDialog();
            this.CtrlUpdateFileVersion = new System.Windows.Forms.CheckBox();
            this.CtrlAppStatusBar = new System.Windows.Forms.StatusStrip();
            this.CtrlAppVersionDisplayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CtrlLogViewer = new System.Windows.Forms.RichTextBox();
            this.CtrlVersionControlGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlBuildVersionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlInnerVersionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlMinorVersionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlMajorVersionValue)).BeginInit();
            this.CtrlAppStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlVersionControlGroup
            // 
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlCreateBuildVersion);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlCreateInnerVersion);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlBuildVersionValue);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlInnerVersionValue);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlMinorVersionValue);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlMajorVersionValue);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlBuildVersionLabel);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlInnerVersionLabel);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlMinorVersionLabel);
            this.CtrlVersionControlGroup.Controls.Add(this.CtrlMajorVersionLabel);
            this.CtrlVersionControlGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.CtrlVersionControlGroup.Location = new System.Drawing.Point(0, 0);
            this.CtrlVersionControlGroup.Name = "CtrlVersionControlGroup";
            this.CtrlVersionControlGroup.Size = new System.Drawing.Size(702, 109);
            this.CtrlVersionControlGroup.TabIndex = 0;
            this.CtrlVersionControlGroup.TabStop = false;
            this.CtrlVersionControlGroup.Text = "版本号";
            // 
            // CtrlCreateBuildVersion
            // 
            this.CtrlCreateBuildVersion.Location = new System.Drawing.Point(582, 66);
            this.CtrlCreateBuildVersion.Name = "CtrlCreateBuildVersion";
            this.CtrlCreateBuildVersion.Size = new System.Drawing.Size(100, 30);
            this.CtrlCreateBuildVersion.TabIndex = 2;
            this.CtrlCreateBuildVersion.Text = "新修订版本";
            this.CtrlCreateBuildVersion.UseVisualStyleBackColor = true;
            this.CtrlCreateBuildVersion.Click += new System.EventHandler(this.HandleCreateNewBuildVersionButtonClickEvent);
            // 
            // CtrlCreateInnerVersion
            // 
            this.CtrlCreateInnerVersion.Location = new System.Drawing.Point(391, 66);
            this.CtrlCreateInnerVersion.Name = "CtrlCreateInnerVersion";
            this.CtrlCreateInnerVersion.Size = new System.Drawing.Size(100, 30);
            this.CtrlCreateInnerVersion.TabIndex = 2;
            this.CtrlCreateInnerVersion.Text = "新内部版本";
            this.CtrlCreateInnerVersion.UseVisualStyleBackColor = true;
            this.CtrlCreateInnerVersion.Click += new System.EventHandler(this.HandleCreateNewInnerVersionButtonClickEvent);
            // 
            // CtrlBuildVersionValue
            // 
            this.CtrlBuildVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlBuildVersionValue.Location = new System.Drawing.Point(582, 33);
            this.CtrlBuildVersionValue.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CtrlBuildVersionValue.Name = "CtrlBuildVersionValue";
            this.CtrlBuildVersionValue.Size = new System.Drawing.Size(100, 26);
            this.CtrlBuildVersionValue.TabIndex = 1;
            // 
            // CtrlInnerVersionValue
            // 
            this.CtrlInnerVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlInnerVersionValue.Location = new System.Drawing.Point(391, 33);
            this.CtrlInnerVersionValue.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CtrlInnerVersionValue.Name = "CtrlInnerVersionValue";
            this.CtrlInnerVersionValue.Size = new System.Drawing.Size(100, 26);
            this.CtrlInnerVersionValue.TabIndex = 1;
            // 
            // CtrlMinorVersionValue
            // 
            this.CtrlMinorVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlMinorVersionValue.Location = new System.Drawing.Point(225, 33);
            this.CtrlMinorVersionValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CtrlMinorVersionValue.Name = "CtrlMinorVersionValue";
            this.CtrlMinorVersionValue.Size = new System.Drawing.Size(75, 26);
            this.CtrlMinorVersionValue.TabIndex = 0;
            // 
            // CtrlMajorVersionValue
            // 
            this.CtrlMajorVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlMajorVersionValue.Location = new System.Drawing.Point(84, 33);
            this.CtrlMajorVersionValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlMajorVersionValue.Name = "CtrlMajorVersionValue";
            this.CtrlMajorVersionValue.Size = new System.Drawing.Size(50, 26);
            this.CtrlMajorVersionValue.TabIndex = 1;
            this.CtrlMajorVersionValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CtrlBuildVersionLabel
            // 
            this.CtrlBuildVersionLabel.AutoSize = true;
            this.CtrlBuildVersionLabel.Location = new System.Drawing.Point(497, 35);
            this.CtrlBuildVersionLabel.Name = "CtrlBuildVersionLabel";
            this.CtrlBuildVersionLabel.Size = new System.Drawing.Size(79, 20);
            this.CtrlBuildVersionLabel.TabIndex = 0;
            this.CtrlBuildVersionLabel.Text = "修订版本号";
            // 
            // CtrlInnerVersionLabel
            // 
            this.CtrlInnerVersionLabel.AutoSize = true;
            this.CtrlInnerVersionLabel.Location = new System.Drawing.Point(306, 35);
            this.CtrlInnerVersionLabel.Name = "CtrlInnerVersionLabel";
            this.CtrlInnerVersionLabel.Size = new System.Drawing.Size(79, 20);
            this.CtrlInnerVersionLabel.TabIndex = 0;
            this.CtrlInnerVersionLabel.Text = "内部版本号";
            // 
            // CtrlMinorVersionLabel
            // 
            this.CtrlMinorVersionLabel.AutoSize = true;
            this.CtrlMinorVersionLabel.Location = new System.Drawing.Point(140, 35);
            this.CtrlMinorVersionLabel.Name = "CtrlMinorVersionLabel";
            this.CtrlMinorVersionLabel.Size = new System.Drawing.Size(79, 20);
            this.CtrlMinorVersionLabel.TabIndex = 0;
            this.CtrlMinorVersionLabel.Text = "次要版本号";
            // 
            // CtrlMajorVersionLabel
            // 
            this.CtrlMajorVersionLabel.AutoSize = true;
            this.CtrlMajorVersionLabel.Location = new System.Drawing.Point(13, 35);
            this.CtrlMajorVersionLabel.Name = "CtrlMajorVersionLabel";
            this.CtrlMajorVersionLabel.Size = new System.Drawing.Size(65, 20);
            this.CtrlMajorVersionLabel.TabIndex = 0;
            this.CtrlMajorVersionLabel.Text = "主版本号";
            // 
            // CtrlCopytoClipboard
            // 
            this.CtrlCopytoClipboard.Location = new System.Drawing.Point(17, 127);
            this.CtrlCopytoClipboard.Name = "CtrlCopytoClipboard";
            this.CtrlCopytoClipboard.Size = new System.Drawing.Size(104, 30);
            this.CtrlCopytoClipboard.TabIndex = 1;
            this.CtrlCopytoClipboard.Text = "复制到剪切板";
            this.CtrlCopytoClipboard.UseVisualStyleBackColor = true;
            this.CtrlCopytoClipboard.Click += new System.EventHandler(this.HandleCopytoClipboardButtonClickEvent);
            // 
            // CtrlRewriteCSFile
            // 
            this.CtrlRewriteCSFile.Location = new System.Drawing.Point(127, 128);
            this.CtrlRewriteCSFile.Name = "CtrlRewriteCSFile";
            this.CtrlRewriteCSFile.Size = new System.Drawing.Size(104, 30);
            this.CtrlRewriteCSFile.TabIndex = 1;
            this.CtrlRewriteCSFile.Text = "更新到.cs文件";
            this.CtrlRewriteCSFile.UseVisualStyleBackColor = true;
            this.CtrlRewriteCSFile.Click += new System.EventHandler(this.HandleRewriteCSFileButtonClickEvent);
            // 
            // CtrlOpenCSFile
            // 
            this.CtrlOpenCSFile.DefaultExt = "cs";
            this.CtrlOpenCSFile.FileName = "C#代码文件";
            this.CtrlOpenCSFile.Filter = "C#代码文件|*.cs|所有文件|*.*";
            this.CtrlOpenCSFile.Multiselect = true;
            this.CtrlOpenCSFile.ShowHelp = true;
            this.CtrlOpenCSFile.SupportMultiDottedExtensions = true;
            this.CtrlOpenCSFile.Title = "打开指定的C#代码文件";
            // 
            // CtrlUpdateFileVersion
            // 
            this.CtrlUpdateFileVersion.AutoSize = true;
            this.CtrlUpdateFileVersion.Checked = true;
            this.CtrlUpdateFileVersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CtrlUpdateFileVersion.Location = new System.Drawing.Point(238, 131);
            this.CtrlUpdateFileVersion.Name = "CtrlUpdateFileVersion";
            this.CtrlUpdateFileVersion.Size = new System.Drawing.Size(196, 24);
            this.CtrlUpdateFileVersion.TabIndex = 2;
            this.CtrlUpdateFileVersion.Text = "同时更新程序集文件版本号";
            this.CtrlUpdateFileVersion.UseVisualStyleBackColor = true;
            // 
            // CtrlAppStatusBar
            // 
            this.CtrlAppStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtrlAppVersionDisplayLabel});
            this.CtrlAppStatusBar.Location = new System.Drawing.Point(0, 304);
            this.CtrlAppStatusBar.Name = "CtrlAppStatusBar";
            this.CtrlAppStatusBar.Size = new System.Drawing.Size(702, 22);
            this.CtrlAppStatusBar.TabIndex = 3;
            // 
            // CtrlAppVersionDisplayLabel
            // 
            this.CtrlAppVersionDisplayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CtrlAppVersionDisplayLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CtrlAppVersionDisplayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlAppVersionDisplayLabel.Name = "CtrlAppVersionDisplayLabel";
            this.CtrlAppVersionDisplayLabel.Size = new System.Drawing.Size(131, 17);
            this.CtrlAppVersionDisplayLabel.Text = "toolStripStatusLabel1";
            // 
            // CtrlLogViewer
            // 
            this.CtrlLogViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CtrlLogViewer.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CtrlLogViewer.ForeColor = System.Drawing.Color.Black;
            this.CtrlLogViewer.Location = new System.Drawing.Point(17, 174);
            this.CtrlLogViewer.Name = "CtrlLogViewer";
            this.CtrlLogViewer.ReadOnly = true;
            this.CtrlLogViewer.Size = new System.Drawing.Size(665, 114);
            this.CtrlLogViewer.TabIndex = 4;
            this.CtrlLogViewer.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 326);
            this.Controls.Add(this.CtrlLogViewer);
            this.Controls.Add(this.CtrlAppStatusBar);
            this.Controls.Add(this.CtrlUpdateFileVersion);
            this.Controls.Add(this.CtrlRewriteCSFile);
            this.Controls.Add(this.CtrlCopytoClipboard);
            this.Controls.Add(this.CtrlVersionControlGroup);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程序集版本号生成工具";
            this.Load += new System.EventHandler(this.HandleMainFormLoadEvent);
            this.CtrlVersionControlGroup.ResumeLayout(false);
            this.CtrlVersionControlGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlBuildVersionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlInnerVersionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlMinorVersionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlMajorVersionValue)).EndInit();
            this.CtrlAppStatusBar.ResumeLayout(false);
            this.CtrlAppStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CtrlVersionControlGroup;
        private System.Windows.Forms.Label CtrlMajorVersionLabel;
        private System.Windows.Forms.NumericUpDown CtrlMajorVersionValue;
        private System.Windows.Forms.NumericUpDown CtrlMinorVersionValue;
        private System.Windows.Forms.Label CtrlMinorVersionLabel;
        private System.Windows.Forms.Label CtrlInnerVersionLabel;
        private System.Windows.Forms.NumericUpDown CtrlInnerVersionValue;
        private System.Windows.Forms.Label CtrlBuildVersionLabel;
        private System.Windows.Forms.NumericUpDown CtrlBuildVersionValue;
        private System.Windows.Forms.Button CtrlCreateInnerVersion;
        private System.Windows.Forms.Button CtrlCreateBuildVersion;
        private System.Windows.Forms.Button CtrlCopytoClipboard;
        private System.Windows.Forms.Button CtrlRewriteCSFile;
        private System.Windows.Forms.OpenFileDialog CtrlOpenCSFile;
        private System.Windows.Forms.CheckBox CtrlUpdateFileVersion;
        private System.Windows.Forms.StatusStrip CtrlAppStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel CtrlAppVersionDisplayLabel;
        private System.Windows.Forms.RichTextBox CtrlLogViewer;

    }
}