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

namespace Android.Icu.Text
{
    #region CompactDecimalFormat declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.html"/>
    /// </summary>
    public partial class CompactDecimalFormat : Android.Icu.Text.DecimalFormat
    {
        const string _bridgeClassName = "android.icu.text.CompactDecimalFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CompactDecimalFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CompactDecimalFormat(params object[] args) : base(args) { }
    
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
        #region CompactStyle declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html"/>
        /// </summary>
        public partial class CompactStyle : Java.Lang.Enum<Android.Icu.Text.CompactDecimalFormat.CompactStyle>
        {
            const string _bridgeClassName = "android.icu.text.CompactDecimalFormat$CompactStyle";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CompactStyle() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CompactStyle(params object[] args) : base(args) { }
        
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

    #region CompactDecimalFormat implementation
    public partial class CompactDecimalFormat
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.html#getInstance(android.icu.util.ULocale,android.icu.text.CompactDecimalFormat.CompactStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></param>
        /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat"/></returns>
        public static Android.Icu.Text.CompactDecimalFormat GetInstance(Android.Icu.Util.ULocale arg0, Android.Icu.Text.CompactDecimalFormat.CompactStyle arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.CompactDecimalFormat>(LocalBridgeClazz, "getInstance", "(Landroid/icu/util/ULocale;Landroid/icu/text/CompactDecimalFormat$CompactStyle;)Landroid/icu/text/CompactDecimalFormat;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.html#getInstance(java.util.Locale,android.icu.text.CompactDecimalFormat.CompactStyle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></param>
        /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat"/></returns>
        public static Android.Icu.Text.CompactDecimalFormat GetInstance(Java.Util.Locale arg0, Android.Icu.Text.CompactDecimalFormat.CompactStyle arg1)
        {
            return SExecuteWithSignature<Android.Icu.Text.CompactDecimalFormat>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;Landroid/icu/text/CompactDecimalFormat$CompactStyle;)Landroid/icu/text/CompactDecimalFormat;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
    
        #endregion
    
        #region Nested classes
        #region CompactStyle implementation
        public partial class CompactStyle
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#LONG"/>
            /// </summary>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle LONG { get { if (!_LONGReady) { _LONGContent = SGetField<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "LONG"); _LONGReady = true; } return _LONGContent; } }
            private static Android.Icu.Text.CompactDecimalFormat.CompactStyle _LONGContent = default;
            private static bool _LONGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#SHORT"/>
            /// </summary>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle SHORT { get { if (!_SHORTReady) { _SHORTContent = SGetField<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "SHORT"); _SHORTReady = true; } return _SHORTContent; } }
            private static Android.Icu.Text.CompactDecimalFormat.CompactStyle _SHORTContent = default;
            private static bool _SHORTReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></returns>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/icu/text/CompactDecimalFormat$CompactStyle;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/CompactDecimalFormat.CompactStyle.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Icu.Text.CompactDecimalFormat.CompactStyle"/></returns>
            public static Android.Icu.Text.CompactDecimalFormat.CompactStyle[] Values()
            {
                return SExecuteWithSignatureArray<Android.Icu.Text.CompactDecimalFormat.CompactStyle>(LocalBridgeClazz, "values", "()[Landroid/icu/text/CompactDecimalFormat$CompactStyle;");
            }
        
            #endregion
        
            #region Instance methods
        
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