#region ------------------------------------------------Header Description-------------------------------------------------------------

/*
 * .NET Programmer's Name : Wang Yucai
 * 
 * Development Tool : Microsoft Visual Studio 2010
 * 
 * Create Time : 2014-10-20 14:25:58
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
    /// 类型名称：<see cref="TypeExtensions"/>
    /// </para>
    /// <para>
    /// 命名空间：<see cref="SourceproStudio.Csharp.Practices.Library"/>
    /// </para>
    /// <para>
    /// 适用的.NET Framework版本：4.0
    /// </para>
    /// <para>
    /// 为<see cref="Type"/>提供的扩展方法。
    /// </para>
    /// </summary>
    /// <remarks>
    /// 此类型适用于4.0及其以上版本的.NET Framework。
    /// </remarks>
    public static class TypeExtensions
    {
        #region BaseOn
        /// <summary>
        /// 验证类型<paramref name="me"/>是否为<paramref name="target"/>或派生自<paramref name="target"/>类型。
        /// </summary>
        /// <param name="me"><see cref="Type"/>对象实例。</param>
        /// <param name="target"><see cref="Type"/>对象实例。</param>
        /// <param name="nullValue">当<paramref name="me"/>或者<paramref name="target"/>为null值时的默认返回值。</param>
        /// <returns>
        /// <para>
        /// 如果<paramref name="me"/>等于<paramref name="target"/>或者派生自<paramref name="target"/>则返回true；否则返回false。
        /// </para>
        /// <para>
        /// 如果<paramref name="me"/>或者<paramref name="target"/>为null值，则返回<paramref name="nullValue"/>。
        /// </para>
        /// </returns>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// public class People
        /// {
        ///     private string name;
        ///     
        ///     public string Name
        ///     {
        ///         get { return this.name; }
        ///         set { this.name = value; }
        ///     }
        /// }
        /// 
        /// public class WangYucai : People
        /// {
        ///     public WangYucai()
        ///     {
        ///         base.Name = "Wang Yucai";
        ///     }
        /// }
        /// 
        /// class Program
        /// {
        ///     static void Main(string[] args)
        ///     {
        ///         var me = new WangYucai();
        ///         if(me.GetType().BaseOn(typeof(People)))
        ///         {
        ///             Console.WriteLine(me.Name);
        ///         }
        ///     }
        /// }        
        /// </code>
        /// </example>
        static public bool BaseOn(this Type me, Type target, bool nullValue = true)
        {
            if (target.Nothing() || me.Nothing())
            {
                return nullValue;
            }
            else
            {
                return RecursiveCheck(me, target);
            }
        }
        #endregion

        #region RecursiveCheck
        /// <summary>
        /// 递归检测类型的继承关系。
        /// </summary>
        /// <param name="source">需要验证的源类型。</param>
        /// <param name="target">目标类型。</param>
        /// <returns>true or false。</returns>
        static private bool RecursiveCheck(Type source, Type target)
        {
            bool isInherited = source.Equals(target);
            if (!isInherited && source.BaseType.NotNothing())
            {
                isInherited = RecursiveCheck(source.BaseType, target);
            }
            return isInherited;
        }
        #endregion

        #region GetCustomAttributes
        /// <summary>
        /// 获取类型<paramref name="me"/>所罕有的<typeparamref name="T"/>类型的<see cref="Attribute"/>对象实例数组。
        /// </summary>
        /// <typeparam name="T">派生自<see cref="Attribute"/>的类型。</typeparam>
        /// <param name="me"><see cref="Type"/>对象实例。</param>
        /// <returns><typeparamref name="T"/>类型的<see cref="Attribute"/>对象实例数组。</returns>
        /// <exception cref="NullReferenceException">
        /// 当<paramref name="me"/>为null值时抛出此异常。
        /// </exception>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// [<see cref="SerializableAttribute"/>]
        /// class Person
        /// {
        ///     string name = string.Empty;
        ///     
        ///     public string Name
        ///     {
        ///         get { return this.name; }
        ///         set { this.name = value; }
        ///     }
        /// }
        /// 
        /// class Program
        /// {
        ///     static void Main(string[] args)
        ///     {
        ///         Person p = new Person() { Name = "Wang Yucai" };
        ///         Attribute[] attr = p.GetType().GetAttributes&lt;SerializableAttribute&gt;();
        ///     }
        /// }
        /// </code>
        /// </example>
        static public Attribute[] GetCustomAttributes<T>(this Type me)
            where T : Attribute
        {
            if (me.Nothing())
                throw new NullReferenceException();
            return Attribute.GetCustomAttributes(me, typeof(T));
        }
        #endregion

        #region GetCustomAttribute
        /// <summary>
        /// 获取类型<paramref name="me"/>所罕有的<typeparamref name="T"/>类型的<see cref="Attribute"/>对象实例。
        /// </summary>
        /// <typeparam name="T">派生自<see cref="Attribute"/>的类型。</typeparam>
        /// <param name="me"><see cref="Type"/>对象实例。</param>
        /// <returns><typeparamref name="T"/>类型的<see cref="Attribute"/>对象实例。</returns>
        /// <exception cref="NullReferenceException">
        /// 当<paramref name="me"/>为null值时抛出此异常。
        /// </exception>
        /// <example>
        /// <code>
        /// using System;
        /// using SourceproStudio.Csharp.Practices.Library;
        /// 
        /// [<see cref="SerializableAttribute"/>]
        /// class Person
        /// {
        ///     string name = string.Empty;
        ///     
        ///     public string Name
        ///     {
        ///         get { return this.name; }
        ///         set { this.name = value; }
        ///     }
        /// }
        /// 
        /// class Program
        /// {
        ///     static void Main(string[] args)
        ///     {
        ///         Person p = new Person() { Name = "Wang Yucai" };
        ///         Attribute attr = p.GetType().GetAttribute&lt;SerializableAttribute&gt;();
        ///     }
        /// }
        /// </code>
        /// </example>
        static public Attribute GetCustomAttribute<T>(this Type me)
            where T : Attribute
        {
            if (me.Nothing()) throw new NullReferenceException();
            return Attribute.GetCustomAttribute(me, typeof(T));
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