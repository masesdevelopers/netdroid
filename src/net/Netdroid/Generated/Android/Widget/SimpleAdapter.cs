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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region SimpleAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html"/>
    /// </summary>
    public partial class SimpleAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SimpleAdapter>
    {
        const string _bridgeClassName = "android.widget.SimpleAdapter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleAdapter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleAdapter(params object[] args) : base(args) { }
    
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
        #region ViewBinder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.ViewBinder.html"/>
        /// </summary>
        public partial class ViewBinder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ViewBinder>
        {
            const string _bridgeClassName = "android.widget.SimpleAdapter$ViewBinder";
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

    #region SimpleAdapter implementation
    public partial class SimpleAdapter : Android.Widget.IFilterable, Android.Widget.IThemedSpinnerAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#%3Cinit%3E(android.content.Context,java.util.List,int,java.lang.String[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public SimpleAdapter(Android.Content.Context arg0, Java.Util.List arg1, int arg2, Java.Lang.String[] arg3, int[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.SimpleAdapter"/> to <see cref="Android.Widget.Filterable"/>
        /// </summary>
        public static implicit operator Android.Widget.Filterable(Android.Widget.SimpleAdapter t) => t.Cast<Android.Widget.Filterable>();
        /// <summary>
        /// Converter from <see cref="Android.Widget.SimpleAdapter"/> to <see cref="Android.Widget.ThemedSpinnerAdapter"/>
        /// </summary>
        public static implicit operator Android.Widget.ThemedSpinnerAdapter(Android.Widget.SimpleAdapter t) => t.Cast<Android.Widget.ThemedSpinnerAdapter>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return IExecuteWithSignature<Android.Content.Res.Resources.Theme>("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public Android.Widget.Filter GetFilter()
        {
            return IExecuteWithSignature<Android.Widget.Filter>("getFilter", "()Landroid/widget/Filter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#getViewBinder()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></returns>
        public Android.Widget.SimpleAdapter.ViewBinder GetViewBinder()
        {
            return IExecuteWithSignature<Android.Widget.SimpleAdapter.ViewBinder>("getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownViewResource(int arg0)
        {
            IExecuteWithSignature("setDropDownViewResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setDropDownViewTheme(android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public void SetDropDownViewTheme(Android.Content.Res.Resources.Theme arg0)
        {
            IExecuteWithSignature("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewBinder(android.widget.SimpleAdapter.ViewBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SimpleAdapter.ViewBinder"/></param>
        public void SetViewBinder(Android.Widget.SimpleAdapter.ViewBinder arg0)
        {
            IExecuteWithSignature("setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetViewImage(Android.Widget.ImageView arg0, int arg1)
        {
            IExecute("setViewImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewImage(android.widget.ImageView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.ImageView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetViewImage(Android.Widget.ImageView arg0, Java.Lang.String arg1)
        {
            IExecute("setViewImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.html#setViewText(android.widget.TextView,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.TextView"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetViewText(Android.Widget.TextView arg0, Java.Lang.String arg1)
        {
            IExecute("setViewText", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
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
            /// <see href="https://developer.android.com/reference/android/widget/SimpleAdapter.ViewBinder.html#setViewValue(android.view.View,java.lang.Object,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.View"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool SetViewValue(Android.View.View arg0, object arg1, Java.Lang.String arg2)
            {
                return IExecute<bool>("setViewValue", arg0, arg1, arg2);
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