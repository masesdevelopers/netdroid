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
    #region SimpleCursorAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html"/>
    /// </summary>
    public partial class SimpleCursorAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SimpleCursorAdapter>
    {
        const string _bridgeClassName = "android.widget.SimpleCursorAdapter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleCursorAdapter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleCursorAdapter(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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
        #region CursorToStringConverter declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.CursorToStringConverter.html"/>
        /// </summary>
        public partial class CursorToStringConverter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CursorToStringConverter>
        {
            const string _bridgeClassName = "android.widget.SimpleCursorAdapter$CursorToStringConverter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("CursorToStringConverter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CursorToStringConverter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("CursorToStringConverter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public CursorToStringConverter(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region ViewBinder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.ViewBinder.html"/>
        /// </summary>
        public partial class ViewBinder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ViewBinder>
        {
            const string _bridgeClassName = "android.widget.SimpleCursorAdapter$ViewBinder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("ViewBinder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ViewBinder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("ViewBinder class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public ViewBinder(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SimpleCursorAdapter implementation
    public partial class SimpleCursorAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#%3Cinit%3E(android.content.Context,int,android.database.Cursor,java.lang.String[],int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public SimpleCursorAdapter(Android.Content.Context arg0, int arg1, Android.Database.Cursor arg2, Java.Lang.String[] arg3, int[] arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#%3Cinit%3E(android.content.Context,int,android.database.Cursor,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        [global::System.Obsolete()]
        public SimpleCursorAdapter(Android.Content.Context arg0, int arg1, Android.Database.Cursor arg2, Java.Lang.String[] arg3, int[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#getCursorToStringConverter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleCursorAdapter.CursorToStringConverter"/></returns>
        public Android.Widget.SimpleCursorAdapter.CursorToStringConverter GetCursorToStringConverter()
        {
            return IExecuteWithSignature<Android.Widget.SimpleCursorAdapter.CursorToStringConverter>("getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleCursorAdapter.ViewBinder"/></returns>
        public Android.Widget.SimpleCursorAdapter.ViewBinder GetViewBinder()
        {
            return IExecuteWithSignature<Android.Widget.SimpleCursorAdapter.ViewBinder>("getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#getStringConversionColumn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStringConversionColumn()
        {
            return IExecuteWithSignature<int>("getStringConversionColumn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#changeCursorAndColumns(android.database.Cursor,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void ChangeCursorAndColumns(Android.Database.Cursor arg0, Java.Lang.String[] arg1, int[] arg2)
        {
            IExecuteWithSignature("changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#setCursorToStringConverter(android.widget.SimpleCursorAdapter.CursorToStringConverter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleCursorAdapter.CursorToStringConverter"/></param>
        public void SetCursorToStringConverter(Android.Widget.SimpleCursorAdapter.CursorToStringConverter arg0)
        {
            IExecuteWithSignature("setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#setStringConversionColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStringConversionColumn(int arg0)
        {
            IExecuteWithSignature("setStringConversionColumn", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#setViewBinder(android.widget.SimpleCursorAdapter.ViewBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleCursorAdapter.ViewBinder"/></param>
        public void SetViewBinder(Android.Widget.SimpleCursorAdapter.ViewBinder arg0)
        {
            IExecuteWithSignature("setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#setViewImage(android.widget.ImageView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetViewImage(Android.Widget.ImageView arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetViewText(Android.Widget.TextView arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region CursorToStringConverter implementation
        public partial class CursorToStringConverter
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.CursorToStringConverter.html#convertToString(android.database.Cursor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence ConvertToString(Android.Database.Cursor arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region ViewBinder implementation
        public partial class ViewBinder
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/SimpleCursorAdapter.ViewBinder.html#setViewValue(android.view.View,android.database.Cursor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool SetViewValue(Android.View.View arg0, Android.Database.Cursor arg1, int arg2)
            {
                return IExecuteWithSignature<bool>("setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", arg0, arg1, arg2);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}