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

namespace Android.Icu.Util
{
    #region EthiopicCalendar declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html"/>
    /// </summary>
    public partial class EthiopicCalendar : Android.Icu.Util.Calendar
    {
        const string _bridgeClassName = "android.icu.util.EthiopicCalendar";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EthiopicCalendar() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EthiopicCalendar(params object[] args) : base(args) { }
    
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

    #region EthiopicCalendar implementation
    public partial class EthiopicCalendar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Android.Icu.Util.ULocale"/></param>
        public EthiopicCalendar(Android.Icu.Util.TimeZone arg0, Android.Icu.Util.ULocale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public EthiopicCalendar(Android.Icu.Util.TimeZone arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(android.icu.util.TimeZone)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.TimeZone"/></param>
        public EthiopicCalendar(Android.Icu.Util.TimeZone arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(android.icu.util.ULocale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Icu.Util.ULocale"/></param>
        public EthiopicCalendar(Android.Icu.Util.ULocale arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public EthiopicCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public EthiopicCalendar(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        public EthiopicCalendar(Java.Util.Date arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public EthiopicCalendar(Java.Util.Locale arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#GENBOT"/>
        /// </summary>
        public static int GENBOT { get { if (!_GENBOTReady) { _GENBOTContent = SGetField<int>(LocalBridgeClazz, "GENBOT"); _GENBOTReady = true; } return _GENBOTContent; } }
        private static int _GENBOTContent = default;
        private static bool _GENBOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#HAMLE"/>
        /// </summary>
        public static int HAMLE { get { if (!_HAMLEReady) { _HAMLEContent = SGetField<int>(LocalBridgeClazz, "HAMLE"); _HAMLEReady = true; } return _HAMLEContent; } }
        private static int _HAMLEContent = default;
        private static bool _HAMLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#HEDAR"/>
        /// </summary>
        public static int HEDAR { get { if (!_HEDARReady) { _HEDARContent = SGetField<int>(LocalBridgeClazz, "HEDAR"); _HEDARReady = true; } return _HEDARContent; } }
        private static int _HEDARContent = default;
        private static bool _HEDARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#MEGABIT"/>
        /// </summary>
        public static int MEGABIT { get { if (!_MEGABITReady) { _MEGABITContent = SGetField<int>(LocalBridgeClazz, "MEGABIT"); _MEGABITReady = true; } return _MEGABITContent; } }
        private static int _MEGABITContent = default;
        private static bool _MEGABITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#MESKEREM"/>
        /// </summary>
        public static int MESKEREM { get { if (!_MESKEREMReady) { _MESKEREMContent = SGetField<int>(LocalBridgeClazz, "MESKEREM"); _MESKEREMReady = true; } return _MESKEREMContent; } }
        private static int _MESKEREMContent = default;
        private static bool _MESKEREMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#MIAZIA"/>
        /// </summary>
        public static int MIAZIA { get { if (!_MIAZIAReady) { _MIAZIAContent = SGetField<int>(LocalBridgeClazz, "MIAZIA"); _MIAZIAReady = true; } return _MIAZIAContent; } }
        private static int _MIAZIAContent = default;
        private static bool _MIAZIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#NEHASSE"/>
        /// </summary>
        public static int NEHASSE { get { if (!_NEHASSEReady) { _NEHASSEContent = SGetField<int>(LocalBridgeClazz, "NEHASSE"); _NEHASSEReady = true; } return _NEHASSEContent; } }
        private static int _NEHASSEContent = default;
        private static bool _NEHASSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#PAGUMEN"/>
        /// </summary>
        public static int PAGUMEN { get { if (!_PAGUMENReady) { _PAGUMENContent = SGetField<int>(LocalBridgeClazz, "PAGUMEN"); _PAGUMENReady = true; } return _PAGUMENContent; } }
        private static int _PAGUMENContent = default;
        private static bool _PAGUMENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#SENE"/>
        /// </summary>
        public static int SENE { get { if (!_SENEReady) { _SENEContent = SGetField<int>(LocalBridgeClazz, "SENE"); _SENEReady = true; } return _SENEContent; } }
        private static int _SENEContent = default;
        private static bool _SENEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#TAHSAS"/>
        /// </summary>
        public static int TAHSAS { get { if (!_TAHSASReady) { _TAHSASContent = SGetField<int>(LocalBridgeClazz, "TAHSAS"); _TAHSASReady = true; } return _TAHSASContent; } }
        private static int _TAHSASContent = default;
        private static bool _TAHSASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#TEKEMT"/>
        /// </summary>
        public static int TEKEMT { get { if (!_TEKEMTReady) { _TEKEMTContent = SGetField<int>(LocalBridgeClazz, "TEKEMT"); _TEKEMTReady = true; } return _TEKEMTContent; } }
        private static int _TEKEMTContent = default;
        private static bool _TEKEMTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#TER"/>
        /// </summary>
        public static int TER { get { if (!_TERReady) { _TERContent = SGetField<int>(LocalBridgeClazz, "TER"); _TERReady = true; } return _TERContent; } }
        private static int _TERContent = default;
        private static bool _TERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#YEKATIT"/>
        /// </summary>
        public static int YEKATIT { get { if (!_YEKATITReady) { _YEKATITContent = SGetField<int>(LocalBridgeClazz, "YEKATIT"); _YEKATITReady = true; } return _YEKATITContent; } }
        private static int _YEKATITContent = default;
        private static bool _YEKATITReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#isAmeteAlemEra()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAmeteAlemEra()
        {
            return IExecuteWithSignature<bool>("isAmeteAlemEra", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/icu/util/EthiopicCalendar.html#setAmeteAlemEra(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAmeteAlemEra(bool arg0)
        {
            IExecuteWithSignature("setAmeteAlemEra", "(Z)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}