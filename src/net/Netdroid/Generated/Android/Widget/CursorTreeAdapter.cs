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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region CursorTreeAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html"/>
    /// </summary>
    public partial class CursorTreeAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CursorTreeAdapter>
    {
        const string _bridgeClassName = "android.widget.CursorTreeAdapter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CursorTreeAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CursorTreeAdapter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CursorTreeAdapter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CursorTreeAdapter(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region CursorTreeAdapter implementation
    public partial class CursorTreeAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#%3Cinit%3E(android.database.Cursor,android.content.Context,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg1"><see cref="Android.Content.Context"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public CursorTreeAdapter(Android.Database.Cursor arg0, Android.Content.Context arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#%3Cinit%3E(android.database.Cursor,android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg1"><see cref="Android.Content.Context"/></param>
        public CursorTreeAdapter(Android.Database.Cursor arg0, Android.Content.Context arg1)
            : base(arg0, arg1)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.CursorTreeAdapter"/> to <see cref="Android.Widget.Filterable"/>
        /// </summary>
        public static implicit operator Android.Widget.Filterable(Android.Widget.CursorTreeAdapter t) => t.Cast<Android.Widget.Filterable>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getCursor()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor GetCursor()
        {
            return IExecuteWithSignature<Android.Database.Cursor>("getCursor", "()Landroid/database/Cursor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor RunQueryOnBackgroundThread(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Android.Database.Cursor>("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#getFilterQueryProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.FilterQueryProvider"/></returns>
        public Android.Widget.FilterQueryProvider GetFilterQueryProvider()
        {
            return IExecuteWithSignature<Android.Widget.FilterQueryProvider>("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ConvertToString(Android.Database.Cursor arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public void ChangeCursor(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("changeCursor", "(Landroid/database/Cursor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#notifyDataSetChanged(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void NotifyDataSetChanged(bool arg0)
        {
            IExecuteWithSignature("notifyDataSetChanged", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setChildrenCursor(int,android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        public void SetChildrenCursor(int arg0, Android.Database.Cursor arg1)
        {
            IExecuteWithSignature("setChildrenCursor", "(ILandroid/database/Cursor;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.FilterQueryProvider"/></param>
        public void SetFilterQueryProvider(Android.Widget.FilterQueryProvider arg0)
        {
            IExecuteWithSignature("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorTreeAdapter.html#setGroupCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public void SetGroupCursor(Android.Database.Cursor arg0)
        {
            IExecuteWithSignature("setGroupCursor", "(Landroid/database/Cursor;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}