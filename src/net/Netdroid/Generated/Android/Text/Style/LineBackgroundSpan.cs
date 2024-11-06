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

namespace Android.Text.Style
{
    #region LineBackgroundSpan declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.html"/>
    /// </summary>
    public partial class LineBackgroundSpan : Android.Text.Style.ParagraphStyle
    {
        const string _bridgeClassName = "android.text.style.LineBackgroundSpan";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("LineBackgroundSpan class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LineBackgroundSpan() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("LineBackgroundSpan class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public LineBackgroundSpan(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region Standard declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html"/>
        /// </summary>
        public partial class Standard : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Standard>
        {
            const string _bridgeClassName = "android.text.style.LineBackgroundSpan$Standard";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Standard() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Standard(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region ILineBackgroundSpan
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILineBackgroundSpan : Android.Text.Style.IParagraphStyle
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region LineBackgroundSpan implementation
    public partial class LineBackgroundSpan : Android.Text.Style.ILineBackgroundSpan
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
        /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.html#drawBackground(android.graphics.Canvas,android.graphics.Paint,int,int,int,int,int,java.lang.CharSequence,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public void DrawBackground(Android.Graphics.Canvas arg0, Android.Graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Lang.CharSequence arg7, int arg8, int arg9, int arg10)
        {
            IExecuteWithSignature("drawBackground", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;III)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
    
        #endregion
    
        #region Nested classes
        #region Standard implementation
        public partial class Standard : Android.Text.Style.ILineBackgroundSpan, Android.Text.IParcelableSpan
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public Standard(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Standard(int arg0)
                : base(arg0)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.LineBackgroundSpan.Standard"/> to <see cref="Android.Text.Style.LineBackgroundSpan"/>
            /// </summary>
            public static implicit operator Android.Text.Style.LineBackgroundSpan(Android.Text.Style.LineBackgroundSpan.Standard t) => t.Cast<Android.Text.Style.LineBackgroundSpan>();
            /// <summary>
            /// Converter from <see cref="Android.Text.Style.LineBackgroundSpan.Standard"/> to <see cref="Android.Text.ParcelableSpan"/>
            /// </summary>
            public static implicit operator Android.Text.ParcelableSpan(Android.Text.Style.LineBackgroundSpan.Standard t) => t.Cast<Android.Text.ParcelableSpan>();
        
            #endregion
        
            #region Fields
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#getColor()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetColor()
            {
                return IExecuteWithSignature<int>("getColor", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#getSpanTypeId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetSpanTypeId()
            {
                return IExecuteWithSignature<int>("getSpanTypeId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#drawBackground(android.graphics.Canvas,android.graphics.Paint,int,int,int,int,int,java.lang.CharSequence,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Canvas"/></param>
            /// <param name="arg1"><see cref="Android.Graphics.Paint"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <param name="arg5"><see cref="int"/></param>
            /// <param name="arg6"><see cref="int"/></param>
            /// <param name="arg7"><see cref="Java.Lang.CharSequence"/></param>
            /// <param name="arg8"><see cref="int"/></param>
            /// <param name="arg9"><see cref="int"/></param>
            /// <param name="arg10"><see cref="int"/></param>
            public void DrawBackground(Android.Graphics.Canvas arg0, Android.Graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Java.Lang.CharSequence arg7, int arg8, int arg9, int arg10)
            {
                IExecuteWithSignature("drawBackground", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;III)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/text/style/LineBackgroundSpan.Standard.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
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