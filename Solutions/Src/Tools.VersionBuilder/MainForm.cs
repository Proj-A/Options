using System;
using System.Windows.Forms;

namespace SourceproStudio.Csharp.Toolkits
{
    public partial class MainForm : Form
    {
        private static readonly decimal Max = decimal.MaxValue;
        private static readonly DateTime _2000 = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        private static readonly DateTime Today = DateTime.Today;
        private static readonly DateTime _0 = new DateTime(Today.Year, Today.Month, Today.Day, 0, 0, 0, 0);

        public MainForm()
        {
            InitializeComponent();
        }

        #region InitAllControls
        /// <summary>
        /// 初始化所有的控件。
        /// </summary>
        private void InitAllControls()
        {
            this.CtrlBuildVersionValue.Maximum = MainForm.Max;
            this.CtrlInnerVersionValue.Maximum = MainForm.Max;
        }
        #endregion

        #region HandleMainFormLoadEvent
        /// <summary>
        /// 主窗体初次加载事件处理方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleMainFormLoadEvent(object sender, EventArgs e)
        {
            this.InitAllControls();
        }
        #endregion

        #region HandleCreateNewInnerVersionButtonClickEvent
        /// <summary>
        /// 创建新的内部版本号按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCreateNewInnerVersionButtonClickEvent(object sender, EventArgs e)
        {
            TimeSpan timeSpace = (DateTime.Now - _2000);
            this.CtrlInnerVersionValue.Value = timeSpace.Days;
        }
        #endregion

        #region HandleCreateNewBuildVersionButtonClickEvent
        /// <summary>
        /// 创建新的修正版本号按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCreateNewBuildVersionButtonClickEvent(object sender, EventArgs e)
        {
            TimeSpan timeSpace = DateTime.Now - _0;
            this.CtrlBuildVersionValue.Value = new decimal(timeSpace.TotalSeconds);
        }
        #endregion

        #region HandleCopytoClipboardButtonClickEvent
        /// <summary>
        /// 复制到剪切板按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleCopytoClipboardButtonClickEvent(object sender, EventArgs e)
        {
            string versionStr = string.Format("{0}.{1}.{2}.{3}", 
                this.CtrlMajorVersionValue.Value, 
                this.CtrlMinorVersionValue.Value, 
                this.CtrlInnerVersionValue.Value, 
                (int)this.CtrlBuildVersionValue.Value);
            Clipboard.SetData(DataFormats.StringFormat, versionStr);
            MessageBox.Show(string.Format("版本号：“{0}”已经复制到剪贴板！", versionStr), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
