#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-20 10:16:04
 * 
 * Machine Name : GLCHQWYCWINW7
 * 
 * Current User : GUOCOLAND/wangyucai
 * 
 * CLR Version : 4.0.30319.18444
 * 
 * Target Framework : This type is available for 2.0 and above versions of .NET Framework.
 */

#endregion

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SourceproStudio.Csharp.Toolkits
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="AppBehaviorTraceListener"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="SourceproStudio.Csharp.Toolkits"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：<see cref="2.0"/>
    /// </para>
    /// <para>
    /// 应用动作监听器。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于2.0及其以上版本的.NET Framework。
    /// <para>
    /// 不可从此类继承。
    /// </para>
    /// </remarks>
    public sealed class AppBehaviorTraceListener : TraceListener
    {
        private RichTextBox _logViewerControl;
        private const string LogTemplate = @"Trace {1} : {0}";
        private int _logIndex;

        #region LogIndex
        /// <summary>
        /// 设置或获取日志内容索引。
        /// </summary>
        private int LogIndex
        {
            get { return _logIndex; }
            set { _logIndex = value; }
        }
        #endregion

        #region LogViewerControl
        /// <summary>
        /// 设置或获取显示日志内容的控件。
        /// </summary>
        public RichTextBox LogViewerControl
        {
            get { return _logViewerControl; }
            set { _logViewerControl = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// 初始化一个<see cref="AppBehaviorTraceListener" />对象实例。
        /// </summary>
        /// <remarks>
        /// 不可从此类继承。
        /// </remarks>
        public AppBehaviorTraceListener()
        {
            this.LogIndex = 1;
        }

        #endregion

        #region Write
        /// <summary>
        /// 向日志显示控件写入消息。
        /// </summary>
        /// <param name="message">消息内容。</param>
        public override void Write(string message)
        {
            this.LogViewerControl.AppendText(string.Format(LogTemplate, message, this.LogIndex));
            this.LogViewerControl.AppendText(Environment.NewLine);
            this.LogIndex++;
        }
        #endregion

        #region WriteLine
        /// <summary>
        /// 尚未实现此方法。
        /// </summary>
        /// <param name="message"></param>
        public override void WriteLine(string message)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

#region Contact me

/*
 * E-mail Address : Masterduner@Yeah.net or Yucai.Wang-Public@Outlook.com
 * 
 * Mobile : +86 13621384677
 * 
 * QQ : 180261899
 */

#endregion

/* Copyright © 2014 Wang Yucai. All rights reserved. */