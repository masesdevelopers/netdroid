/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region ArrayAdapter
    public partial class ArrayAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, int arg2, Java.Util.List arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, Java.Util.List arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.ArrayAdapter"/> to <see cref="Android.Widget.Filterable"/>
        /// </summary>
        public static implicit operator Android.Widget.Filterable(Android.Widget.ArrayAdapter t) => t.Cast<Android.Widget.Filterable>();
        /// <summary>
        /// Converter from <see cref="Android.Widget.ArrayAdapter"/> to <see cref="Android.Widget.ThemedSpinnerAdapter"/>
        /// </summary>
        public static implicit operator Android.Widget.ThemedSpinnerAdapter(Android.Widget.ArrayAdapter t) => t.Cast<Android.Widget.ThemedSpinnerAdapter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#createFromResource(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Widget.ArrayAdapter"/></returns>
        public static Android.Widget.ArrayAdapter CreateFromResource(Android.Content.Context arg0, int arg1, int arg2)
        {
            return SExecute<Android.Widget.ArrayAdapter>(LocalBridgeClazz, "createFromResource", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Context"/></returns>
        public Android.Content.Context GetContext()
        {
            return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return IExecuteWithSignature<Android.Content.Res.Resources.Theme>("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getPosition(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPosition(object arg0)
        {
            return IExecuteWithSignature<int>("getPosition", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Add(object arg0)
        {
            IExecuteWithSignature("add", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void AddAll(Java.Util.Collection arg0)
        {
            IExecuteWithSignature("addAll", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#addAll(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddAll(params object[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("addAll", "([Ljava/lang/Object;)V"); else IExecuteWithSignature("addAll", "([Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#insert(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(object arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Remove(object arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownViewResource(int arg0)
        {
            IExecuteWithSignature("setDropDownViewResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public void SetDropDownViewTheme(Android.Content.Res.Resources.Theme arg0)
        {
            IExecuteWithSignature("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setNotifyOnChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNotifyOnChange(bool arg0)
        {
            IExecuteWithSignature("setNotifyOnChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#sort(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public void Sort(Java.Util.Comparator arg0)
        {
            IExecuteWithSignature("sort", "(Ljava/util/Comparator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ArrayAdapter<T>
    public partial class ArrayAdapter<T> : Android.Widget.IFilterable, Android.Widget.IThemedSpinnerAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.List"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, int arg2, Java.Util.List<T> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,int,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><typeparamref name="T"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, int arg2, T[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, Java.Util.List<T> arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><typeparamref name="T"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1, T[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#%3Cinit%3E(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ArrayAdapter(Android.Content.Context arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.ArrayAdapter{T}"/> to <see cref="Android.Widget.Filterable"/>
        /// </summary>
        public static implicit operator Android.Widget.Filterable(Android.Widget.ArrayAdapter<T> t) => t.Cast<Android.Widget.Filterable>();
        /// <summary>
        /// Converter from <see cref="Android.Widget.ArrayAdapter{T}"/> to <see cref="Android.Widget.ThemedSpinnerAdapter"/>
        /// </summary>
        public static implicit operator Android.Widget.ThemedSpinnerAdapter(Android.Widget.ArrayAdapter<T> t) => t.Cast<Android.Widget.ThemedSpinnerAdapter>();
        /// <summary>
        /// Converter from <see cref="Android.Widget.ArrayAdapter{T}"/> to <see cref="Android.Widget.ArrayAdapter"/>
        /// </summary>
        public static implicit operator Android.Widget.ArrayAdapter(Android.Widget.ArrayAdapter<T> t) => t.Cast<Android.Widget.ArrayAdapter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#createFromResource(android.content.Context,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Widget.ArrayAdapter"/></returns>
        public static Android.Widget.ArrayAdapter<Java.Lang.CharSequence> CreateFromResource(Android.Content.Context arg0, int arg1, int arg2)
        {
            return SExecute<Android.Widget.ArrayAdapter<Java.Lang.CharSequence>>(LocalBridgeClazz, "createFromResource", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getContext()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Context"/></returns>
        public Android.Content.Context GetContext()
        {
            return IExecuteWithSignature<Android.Content.Context>("getContext", "()Landroid/content/Context;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return IExecuteWithSignature<Android.Content.Res.Resources.Theme>("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#getPosition(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPosition(T arg0)
        {
            return IExecuteWithSignature<int>("getPosition", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void Add(T arg0)
        {
            IExecuteWithSignature("add", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        public void AddAll<Arg0ExtendsT>(Java.Util.Collection<Arg0ExtendsT> arg0) where Arg0ExtendsT : T
        {
            IExecuteWithSignature("addAll", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#addAll(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void AddAll(params T[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("addAll", "([Ljava/lang/Object;)V"); else IExecuteWithSignature("addAll", "([Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#insert(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(T arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void Remove(T arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownViewResource(int arg0)
        {
            IExecuteWithSignature("setDropDownViewResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public void SetDropDownViewTheme(Android.Content.Res.Resources.Theme arg0)
        {
            IExecuteWithSignature("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#setNotifyOnChange(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNotifyOnChange(bool arg0)
        {
            IExecuteWithSignature("setNotifyOnChange", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ArrayAdapter.html#sort(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        public void Sort<Arg0objectSuperT>(Java.Util.Comparator<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            IExecuteWithSignature("sort", "(Ljava/util/Comparator;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}