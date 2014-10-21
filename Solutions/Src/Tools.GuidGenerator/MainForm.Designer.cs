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
            this.CtrlGuidValue = new System.Windows.Forms.TextBox();
            this.CtrlCreateNewGuid = new System.Windows.Forms.Button();
            this.CtrlGetEmptyGuid = new System.Windows.Forms.Button();
            this.CtrlCopytoClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CtrlGuidValue
            // 
            this.CtrlGuidValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CtrlGuidValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CtrlGuidValue.Location = new System.Drawing.Point(13, 13);
            this.CtrlGuidValue.Name = "CtrlGuidValue";
            this.CtrlGuidValue.ReadOnly = true;
            this.CtrlGuidValue.Size = new System.Drawing.Size(323, 26);
            this.CtrlGuidValue.TabIndex = 0;
            this.CtrlGuidValue.Click += new System.EventHandler(this.HandleGuidDisplayControlClickEvent);
            // 
            // CtrlCreateNewGuid
            // 
            this.CtrlCreateNewGuid.Location = new System.Drawing.Point(13, 58);
            this.CtrlCreateNewGuid.Name = "CtrlCreateNewGuid";
            this.CtrlCreateNewGuid.Size = new System.Drawing.Size(84, 30);
            this.CtrlCreateNewGuid.TabIndex = 1;
            this.CtrlCreateNewGuid.Text = "创建GUID";
            this.CtrlCreateNewGuid.UseVisualStyleBackColor = true;
            this.CtrlCreateNewGuid.Click += new System.EventHandler(this.HandleCreateNewButtonClickEvent);
            // 
            // CtrlGetEmptyGuid
            // 
            this.CtrlGetEmptyGuid.Location = new System.Drawing.Point(103, 58);
            this.CtrlGetEmptyGuid.Name = "CtrlGetEmptyGuid";
            this.CtrlGetEmptyGuid.Size = new System.Drawing.Size(84, 30);
            this.CtrlGetEmptyGuid.TabIndex = 1;
            this.CtrlGetEmptyGuid.Text = "空GUID";
            this.CtrlGetEmptyGuid.UseVisualStyleBackColor = true;
            this.CtrlGetEmptyGuid.Click += new System.EventHandler(this.HandleGenerateEmptyButtonClickEvent);
            // 
            // CtrlCopytoClipboard
            // 
            this.CtrlCopytoClipboard.Location = new System.Drawing.Point(193, 58);
            this.CtrlCopytoClipboard.Name = "CtrlCopytoClipboard";
            this.CtrlCopytoClipboard.Size = new System.Drawing.Size(143, 30);
            this.CtrlCopytoClipboard.TabIndex = 1;
            this.CtrlCopytoClipboard.Text = "复制到剪贴板(&C)";
            this.CtrlCopytoClipboard.UseVisualStyleBackColor = true;
            this.CtrlCopytoClipboard.Click += new System.EventHandler(this.HandleCopytoButtonClickEvent);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 105);
            this.Controls.Add(this.CtrlCopytoClipboard);
            this.Controls.Add(this.CtrlGetEmptyGuid);
            this.Controls.Add(this.CtrlCreateNewGuid);
            this.Controls.Add(this.CtrlGuidValue);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID生成工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CtrlGuidValue;
        private System.Windows.Forms.Button CtrlCreateNewGuid;
        private System.Windows.Forms.Button CtrlGetEmptyGuid;
        private System.Windows.Forms.Button CtrlCopytoClipboard;
    }
}