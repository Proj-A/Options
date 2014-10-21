using System;
using System.Windows.Forms;

namespace SourceproStudio.Csharp.Toolkits
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region HandleCreateNewButtonClickEvent
        /// <summary>
        /// 创建新GUID按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCreateNewButtonClickEvent(object sender, EventArgs e)
        {
            this.CtrlGuidValue.Text = Guid.NewGuid().ToString();
        }
        #endregion

        #region HandleGenerateEmptyButtonClickEvent
        /// <summary>
        /// 生成空GUID按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleGenerateEmptyButtonClickEvent(object sender, EventArgs e)
        {
            this.CtrlGuidValue.Text = Guid.Empty.ToString();
        }
        #endregion

        #region HandleCopytoButtonClickEvent
        /// <summary>
        /// 复制到剪贴板按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCopytoButtonClickEvent(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.CtrlGuidValue.Text))
            {
                MessageBox.Show("没有发现GUID！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clipboard.SetText(this.CtrlGuidValue.Text, TextDataFormat.Text);
            }
        }
        #endregion

        #region HandleGuidDisplayControlClickEvent
        /// <summary>
        /// GUID显示控件单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleGuidDisplayControlClickEvent(object sender, EventArgs e)
        {
            this.CtrlGuidValue.SelectAll();
        }
        #endregion
    }
}
