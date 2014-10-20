using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SourceproStudio.Csharp.Toolkits
{
    public partial class MainForm : Form
    {
        private static readonly decimal Max = decimal.MaxValue;
        private static readonly DateTime _2000 = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        private static readonly DateTime Today = DateTime.Today;
        private static readonly DateTime _0 = new DateTime(Today.Year, Today.Month, Today.Day, 0, 0, 0, 0);
        private static readonly string Regex1 = ConfigurationManager.AppSettings["REGEX_ASSVER"];
        private static readonly string Regex2 = ConfigurationManager.AppSettings["REGEX_ASSFVER"];

        public MainForm()
        {
            InitializeComponent();
            Trace.Listeners.Add(new AppBehaviorTraceListener() { LogViewerControl = this.CtrlLogViewer });
        }

        #region InitAllControls
        /// <summary>
        /// 初始化所有的控件。
        /// </summary>
        private void InitAllControls()
        {
            this.CtrlBuildVersionValue.Maximum = MainForm.Max;
            this.CtrlInnerVersionValue.Maximum = MainForm.Max;
            this.CtrlAppVersionDisplayLabel.Text = string.Format("版本：{0}", typeof(MainForm).Assembly.GetName().Version);
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
            Trace.Write(string.Format("生成了新的内部版本号{0}", this.CtrlInnerVersionValue.Value));
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
            this.CtrlBuildVersionValue.Value = new decimal((int)timeSpace.TotalSeconds);
            Trace.Write(string.Format("生成了新的修正版本号{0}", (int)this.CtrlBuildVersionValue.Value));
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
            Trace.Write(string.Format("已将版本号{0}复制到剪贴板。", versionStr));
            MessageBox.Show(string.Format("版本号：“{0}”已经复制到剪贴板！", versionStr), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region HandleRewriteCSFileButtonClickEvent
        /// <summary>
        /// 处理覆写CS文件按钮单击事件处理函数。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleRewriteCSFileButtonClickEvent(object sender, EventArgs e)
        {
            if (this.CtrlOpenCSFile.ShowDialog() == DialogResult.OK)
            {
                if (!object.ReferenceEquals(this.CtrlOpenCSFile.FileNames, null) && this.CtrlOpenCSFile.FileNames.Length > 0)
                {
                    foreach (string item in this.CtrlOpenCSFile.FileNames)
                    {
                        string text = this.ReadCsharpFile(item);
                        text = this.MatchAndReplace(text);
                        this.RewriteCsharpFile(item, text);
                    }
                }
            }
        }
        #endregion

        #region ReadCsharpFile
        /// <summary>
        /// 读取指定的C#文件。
        /// </summary>
        /// <param name="fileName">文件名称。</param>
        /// <returns>文件内容。</returns>
        private string ReadCsharpFile(string fileName)
        {
            string text = string.Empty;
            using (Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Trace.Write(string.Format("开始获取文件{0}的内容。", fileName));
                    try
                    {
                        text = reader.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        Trace.Write(string.Format("读取文件异常！"));
                        Trace.Write(ex.Message);
                    }
                    finally
                    {
                        reader.Close();
                        fileStream.Close();
                    }
                }
            }
            return text;
        }
        #endregion

        #region MatchAndReplace
        /// <summary>
        /// 匹配并替换。
        /// </summary>
        /// <param name="text">需要匹配的内容。</param>
        /// <returns>匹配后的文本。</returns>
        private string MatchAndReplace(string text)
        {
            string versionStr = string.Format("{0}.{1}.{2}.{3}",
              this.CtrlMajorVersionValue.Value,
              this.CtrlMinorVersionValue.Value,
              this.CtrlInnerVersionValue.Value,
              (int)this.CtrlBuildVersionValue.Value);
            if (Regex.IsMatch(text, Regex1))
            {
                Trace.Write("发现了AssemblyVersion。");
                text = Regex.Replace(text, Regex1, string.Format("AssemblyVersion(\"{0}\")", versionStr));
                Trace.Write("已经替换了AssemblyVersion。");
            }
            if (this.CtrlUpdateFileVersion.Checked && Regex.IsMatch(text, Regex2))
            {
                Trace.Write("发现了AssemblyFileVersion。");
                text = Regex.Replace(text, Regex2, string.Format("AssemblyFileVersion(\"{0}\")", versionStr));
                Trace.Write("已经替换了AssemblyFileVersion。");
            }
            return text;
        }
        #endregion

        #region RewriteCsharpFile
        /// <summary>
        /// 覆写C#文件。
        /// </summary>
        /// <param name="fileName">文件名称。</param>
        /// <param name="text">已经替换了文本内容。</param>
        private void RewriteCsharpFile(string fileName, string text)
        {
            using (Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    try
                    {
                        Trace.Write(string.Format("正在覆写文件", fileName));
                        writer.Write(text);
                        Trace.Write("文件已经覆写成功。");
                    }
                    catch (Exception ex)
                    {
                        Trace.Write("覆写文件失败。");
                        Trace.Write(ex.Message);

                    }
                    finally
                    {
                        writer.Close();
                        fileStream.Close();
                    }

                }
            }
        }
        #endregion
    }
}
