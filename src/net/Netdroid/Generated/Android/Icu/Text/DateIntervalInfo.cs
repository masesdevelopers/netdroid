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

namespace Android.Icu.Text
{
    #region DateIntervalInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html"/>
    /// </summary>
    public partial class DateIntervalInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DateIntervalInfo>
    {
        const string _bridgeClassName = "android.icu.text.DateIntervalInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DateIntervalInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DateIntervalInfo(params object[] args) : base(args) { }

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
        #region PatternInfo declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html"/>
        /// </summary>
        public partial class PatternInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PatternInfo>
        {
            const string _bridgeClassName = "android.icu.text.DateIntervalInfo$PatternInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public PatternInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public PatternInfo(params object[] args) : base(args) { }

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

    #region DateIntervalInfo implementation
    public partial class DateIntervalInfo : Java.Lang.ICloneable, Android.Icu.Util.IFreezable<Android.Icu.Text.DateIntervalInfo>, Java.Io.ISerializable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public DateIntervalInfo(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public DateIntervalInfo(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Android.Icu.Util.Freezable"/>
        /// </summary>
        public static implicit operator Android.Icu.Util.Freezable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Android.Icu.Util.Freezable>();
        /// <summary>
        /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Android.Icu.Text.DateIntervalInfo t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getIntervalPattern(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/></returns>
        public Android.Icu.Text.DateIntervalInfo.PatternInfo GetIntervalPattern(Java.Lang.String arg0, int arg1)
        {
            return IExecuteWithSignature<Android.Icu.Text.DateIntervalInfo.PatternInfo>("getIntervalPattern", "(Ljava/lang/String;I)Landroid/icu/text/DateIntervalInfo$PatternInfo;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getDefaultOrder()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetDefaultOrder()
        {
            return IExecuteWithSignature<bool>("getDefaultOrder", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#isFrozen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFrozen()
        {
            return IExecuteWithSignature<bool>("isFrozen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#cloneAsThawed()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object CloneAsThawed()
        {
            return IExecuteWithSignature("cloneAsThawed", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#freeze()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Freeze()
        {
            return IExecuteWithSignature("freeze", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#getFallbackIntervalPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetFallbackIntervalPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("getFallbackIntervalPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#setFallbackIntervalPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetFallbackIntervalPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setFallbackIntervalPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.html#setIntervalPattern(java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void SetIntervalPattern(Java.Lang.String arg0, int arg1, Java.Lang.String arg2)
        {
            IExecuteWithSignature("setIntervalPattern", "(Ljava/lang/String;ILjava/lang/String;)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region PatternInfo implementation
        public partial class PatternInfo : Java.Lang.ICloneable, Java.Io.ISerializable
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            public PatternInfo(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/> to <see cref="Java.Lang.Cloneable"/>
            /// </summary>
            public static implicit operator Java.Lang.Cloneable(Android.Icu.Text.DateIntervalInfo.PatternInfo t) => t.Cast<Java.Lang.Cloneable>();
            /// <summary>
            /// Converter from <see cref="Android.Icu.Text.DateIntervalInfo.PatternInfo"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Android.Icu.Text.DateIntervalInfo.PatternInfo t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#firstDateInPtnIsLaterDate()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool FirstDateInPtnIsLaterDate()
            {
                return IExecuteWithSignature<bool>("firstDateInPtnIsLaterDate", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#getFirstPart()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetFirstPart()
            {
                return IExecuteWithSignature<Java.Lang.String>("getFirstPart", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/icu/text/DateIntervalInfo.PatternInfo.html#getSecondPart()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetSecondPart()
            {
                return IExecuteWithSignature<Java.Lang.String>("getSecondPart", "()Ljava/lang/String;");
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