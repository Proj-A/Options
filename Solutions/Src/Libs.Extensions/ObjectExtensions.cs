#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-20 13:37:01
 * 
 * Machine Name : GLCHQWYCWINW7
 * 
 * Current User : GUOCOLAND/wangyucai
 * 
 * CLR Version : 4.0.30319.18444
 * 
 * Target Framework : This type is available for 4.0 and above versions of .NET Framework.
 */

#endregion

using System;

namespace SourceproStudio.Csharp.Practices.Library
{
    /// <summary>
    /// <para>
    /// 类型名称：<see cref="ObjectExtensions"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="SourceproStudio.Csharp.Practices.Library"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 为<see cref="Object"/>提供的扩展方法集。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    public static class ObjectExtensions
    {
        #region Nothing
        /// <summary>
        /// 验证对象<paramref name="me"/>是否为null。
        /// </summary>
        /// <param name="me"><see cref="object"/>对象实例。</param>
        /// <returns>如果<paramref name="me"/>为null值，则返回true；否则返回false。</returns>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// class Prgram
        /// {
        ///     state void Main(string[] args)
        ///     {
        ///         if(!args.Nothing() &amp;&amp; args.Length > 0)
        ///         {
        ///             Console.WriteLine("Startup argument array is not empty!");
        ///         }
        ///     }
        /// }       
        /// </code>
        /// </example>
        static public bool Nothing(this object me)
        {
            return object.ReferenceEquals(me, null);
        }
        #endregion

        #region NotNothing
        /// <summary>
        /// 验证对象<paramref name="me"/>是否不为null。
        /// </summary>
        /// <param name="me"><see cref="object"/>对象实例。</param>
        /// <returns>如果<paramref name="me"/>为null值，则返回false；否则返回true。</returns>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// class Prgram
        /// {
        ///     state void Main(string[] args)
        ///     {
        ///         if(args.NotNothing() &amp;&amp; args.Length > 0)
        ///         {
        ///             Console.WriteLine("Startup argument array is not empty!");
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        static public bool NotNothing(this object me)
        {
            return !me.Nothing();
        }
        #endregion

        #region Is
        /// <summary>
        /// 验证<paramref name="me"/>是否为<typeparamref name="T"/>类型。
        /// </summary>
        /// <typeparam name="T">目标的类型。</typeparam>
        /// <param name="me"><see cref="object"/>对象实例。</param>
        /// <param name="nullValue">当<paramref name="me"/>为null值时，返回的布尔类型值。</param>
        /// <returns>
        /// <para>
        /// 如果<paramref name="me"/>为<typeparamref name="T"/>类型或者派生自<typeparamref name="T"/>类型，则返回true；否则返回false。
        /// </para>
        /// <para>
        /// 如果<paramref name="me"/>为null值时，则返回<paramref name="nullValue"/>。
        /// </para>
        /// </returns>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// class Program
        /// {
        ///     static void Main(string[] args)
        ///     {
        ///         var str = "Wang Yucai";
        ///         if (str.Is&lt;string&gt;())
        ///         {
        ///             Console.WriteLine("The variable s is string!");
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        static public bool Is<T>(this object me, bool nullValue = true)
        {
            if (me.Nothing())
                return nullValue;
            else
                return me is T;
        }
        #endregion

        #region To
        /// <summary>
        /// 将<paramref name="me"/>强制转换为<typeparamref name="T"/>类型。
        /// </summary>
        /// <typeparam name="T">目标类型。</typeparam>
        /// <param name="me"><see cref="object"/>对象实例。</param>
        /// <returns>
        /// <para>
        /// 如果<paramref name="me"/>为null值，则返回<typeparamref name="T"/>类型的默认值。
        /// </para>
        /// <para>
        /// 强制转换成<typeparamref name="T"/>类型。
        /// </para>
        /// </returns>
        /// <exception cref="InvalidCastException">
        /// 当<paramref name="me"/>不为null，且不是<typeparamref name="T"/>类型或其派生类型，则抛出此异常。
        /// </exception>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// class Program
        /// {
        ///     static void Main(string[] args)
        ///     {
        ///         object obj = args[0];
        ///         
        ///         string s = obj.To&lt;string&gt;();
        ///     }
        /// }
        /// </code>
        /// </example>
        static public T To<T>(this object me)
        {
            T value = default(T);
            if (me.NotNothing())
            {
                if (me.Is<T>())
                {
                    value = (T)me;
                }
                else throw new InvalidCastException();
            }
            return value;
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