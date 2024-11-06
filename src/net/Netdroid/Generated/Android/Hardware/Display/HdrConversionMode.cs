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

namespace Android.Hardware.Display
{
    #region HdrConversionMode declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html"/>
    /// </summary>
    public partial class HdrConversionMode : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.hardware.display.HdrConversionMode";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HdrConversionMode() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HdrConversionMode(params object[] args) : base(args) { }
    
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

    #region HdrConversionMode implementation
    public partial class HdrConversionMode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public HdrConversionMode(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public HdrConversionMode(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#HDR_CONVERSION_FORCE"/>
        /// </summary>
        public static int HDR_CONVERSION_FORCE { get { if (!_HDR_CONVERSION_FORCEReady) { _HDR_CONVERSION_FORCEContent = SGetField<int>(LocalBridgeClazz, "HDR_CONVERSION_FORCE"); _HDR_CONVERSION_FORCEReady = true; } return _HDR_CONVERSION_FORCEContent; } }
        private static int _HDR_CONVERSION_FORCEContent = default;
        private static bool _HDR_CONVERSION_FORCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#HDR_CONVERSION_PASSTHROUGH"/>
        /// </summary>
        public static int HDR_CONVERSION_PASSTHROUGH { get { if (!_HDR_CONVERSION_PASSTHROUGHReady) { _HDR_CONVERSION_PASSTHROUGHContent = SGetField<int>(LocalBridgeClazz, "HDR_CONVERSION_PASSTHROUGH"); _HDR_CONVERSION_PASSTHROUGHReady = true; } return _HDR_CONVERSION_PASSTHROUGHContent; } }
        private static int _HDR_CONVERSION_PASSTHROUGHContent = default;
        private static bool _HDR_CONVERSION_PASSTHROUGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#HDR_CONVERSION_SYSTEM"/>
        /// </summary>
        public static int HDR_CONVERSION_SYSTEM { get { if (!_HDR_CONVERSION_SYSTEMReady) { _HDR_CONVERSION_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "HDR_CONVERSION_SYSTEM"); _HDR_CONVERSION_SYSTEMReady = true; } return _HDR_CONVERSION_SYSTEMContent; } }
        private static int _HDR_CONVERSION_SYSTEMContent = default;
        private static bool _HDR_CONVERSION_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#HDR_CONVERSION_UNSUPPORTED"/>
        /// </summary>
        public static int HDR_CONVERSION_UNSUPPORTED { get { if (!_HDR_CONVERSION_UNSUPPORTEDReady) { _HDR_CONVERSION_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "HDR_CONVERSION_UNSUPPORTED"); _HDR_CONVERSION_UNSUPPORTEDReady = true; } return _HDR_CONVERSION_UNSUPPORTEDContent; } }
        private static int _HDR_CONVERSION_UNSUPPORTEDContent = default;
        private static bool _HDR_CONVERSION_UNSUPPORTEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#getConversionMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetConversionMode()
        {
            return IExecuteWithSignature<int>("getConversionMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#getPreferredHdrOutputType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPreferredHdrOutputType()
        {
            return IExecuteWithSignature<int>("getPreferredHdrOutputType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/HdrConversionMode.html#writeToParcel(android.os.Parcel,int)"/>
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
}