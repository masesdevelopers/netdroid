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

namespace Android.Icu.Math
{
    #region MathContext declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html"/>
    /// </summary>
    public partial class MathContext : Java.Io.Serializable
    {
        const string _bridgeClassName = "android.icu.math.MathContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MathContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MathContext(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region MathContext implementation
    public partial class MathContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#%3Cinit%3E(int,int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public MathContext(int arg0, int arg1, bool arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#%3Cinit%3E(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public MathContext(int arg0, int arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public MathContext(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public MathContext(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#DEFAULT"/>
        /// </summary>
        public static Android.Icu.Math.MathContext DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Android.Icu.Math.MathContext>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Android.Icu.Math.MathContext _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ENGINEERING"/>
        /// </summary>
        public static int ENGINEERING { get { if (!_ENGINEERINGReady) { _ENGINEERINGContent = SGetField<int>(LocalBridgeClazz, "ENGINEERING"); _ENGINEERINGReady = true; } return _ENGINEERINGContent; } }
        private static int _ENGINEERINGContent = default;
        private static bool _ENGINEERINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#PLAIN"/>
        /// </summary>
        public static int PLAIN { get { if (!_PLAINReady) { _PLAINContent = SGetField<int>(LocalBridgeClazz, "PLAIN"); _PLAINReady = true; } return _PLAINContent; } }
        private static int _PLAINContent = default;
        private static bool _PLAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_CEILING"/>
        /// </summary>
        public static int ROUND_CEILING { get { if (!_ROUND_CEILINGReady) { _ROUND_CEILINGContent = SGetField<int>(LocalBridgeClazz, "ROUND_CEILING"); _ROUND_CEILINGReady = true; } return _ROUND_CEILINGContent; } }
        private static int _ROUND_CEILINGContent = default;
        private static bool _ROUND_CEILINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_DOWN"/>
        /// </summary>
        public static int ROUND_DOWN { get { if (!_ROUND_DOWNReady) { _ROUND_DOWNContent = SGetField<int>(LocalBridgeClazz, "ROUND_DOWN"); _ROUND_DOWNReady = true; } return _ROUND_DOWNContent; } }
        private static int _ROUND_DOWNContent = default;
        private static bool _ROUND_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_FLOOR"/>
        /// </summary>
        public static int ROUND_FLOOR { get { if (!_ROUND_FLOORReady) { _ROUND_FLOORContent = SGetField<int>(LocalBridgeClazz, "ROUND_FLOOR"); _ROUND_FLOORReady = true; } return _ROUND_FLOORContent; } }
        private static int _ROUND_FLOORContent = default;
        private static bool _ROUND_FLOORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_HALF_DOWN"/>
        /// </summary>
        public static int ROUND_HALF_DOWN { get { if (!_ROUND_HALF_DOWNReady) { _ROUND_HALF_DOWNContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_DOWN"); _ROUND_HALF_DOWNReady = true; } return _ROUND_HALF_DOWNContent; } }
        private static int _ROUND_HALF_DOWNContent = default;
        private static bool _ROUND_HALF_DOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_HALF_EVEN"/>
        /// </summary>
        public static int ROUND_HALF_EVEN { get { if (!_ROUND_HALF_EVENReady) { _ROUND_HALF_EVENContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_EVEN"); _ROUND_HALF_EVENReady = true; } return _ROUND_HALF_EVENContent; } }
        private static int _ROUND_HALF_EVENContent = default;
        private static bool _ROUND_HALF_EVENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_HALF_UP"/>
        /// </summary>
        public static int ROUND_HALF_UP { get { if (!_ROUND_HALF_UPReady) { _ROUND_HALF_UPContent = SGetField<int>(LocalBridgeClazz, "ROUND_HALF_UP"); _ROUND_HALF_UPReady = true; } return _ROUND_HALF_UPContent; } }
        private static int _ROUND_HALF_UPContent = default;
        private static bool _ROUND_HALF_UPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_UNNECESSARY"/>
        /// </summary>
        public static int ROUND_UNNECESSARY { get { if (!_ROUND_UNNECESSARYReady) { _ROUND_UNNECESSARYContent = SGetField<int>(LocalBridgeClazz, "ROUND_UNNECESSARY"); _ROUND_UNNECESSARYReady = true; } return _ROUND_UNNECESSARYContent; } }
        private static int _ROUND_UNNECESSARYContent = default;
        private static bool _ROUND_UNNECESSARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#ROUND_UP"/>
        /// </summary>
        public static int ROUND_UP { get { if (!_ROUND_UPReady) { _ROUND_UPContent = SGetField<int>(LocalBridgeClazz, "ROUND_UP"); _ROUND_UPReady = true; } return _ROUND_UPContent; } }
        private static int _ROUND_UPContent = default;
        private static bool _ROUND_UPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#SCIENTIFIC"/>
        /// </summary>
        public static int SCIENTIFIC { get { if (!_SCIENTIFICReady) { _SCIENTIFICContent = SGetField<int>(LocalBridgeClazz, "SCIENTIFIC"); _SCIENTIFICReady = true; } return _SCIENTIFICContent; } }
        private static int _SCIENTIFICContent = default;
        private static bool _SCIENTIFICReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#getLostDigits()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetLostDigits()
        {
            return IExecuteWithSignature<bool>("getLostDigits", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#getDigits()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDigits()
        {
            return IExecuteWithSignature<int>("getDigits", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#getForm()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetForm()
        {
            return IExecuteWithSignature<int>("getForm", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/math/MathContext.html#getRoundingMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRoundingMode()
        {
            return IExecuteWithSignature<int>("getRoundingMode", "()I");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}