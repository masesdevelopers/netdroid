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

namespace Android.Hardware
{
    #region SyncFence declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html"/>
    /// </summary>
    public partial class SyncFence : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SyncFence>
    {
        const string _bridgeClassName = "android.hardware.SyncFence";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncFence() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncFence(params object[] args) : base(args) { }
    
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

    #region SyncFence implementation
    public partial class SyncFence : Java.Lang.IAutoCloseable, Android.Os.IParcelable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#%3Cinit%3E(android.hardware.SyncFence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.SyncFence"/></param>
        public SyncFence(Android.Hardware.SyncFence arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Hardware.SyncFence"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Android.Hardware.SyncFence t) => t.Cast<Java.Lang.AutoCloseable>();
        /// <summary>
        /// Converter from <see cref="Android.Hardware.SyncFence"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Hardware.SyncFence t) => t.Cast<Android.Os.Parcelable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#SIGNAL_TIME_INVALID"/>
        /// </summary>
        public static long SIGNAL_TIME_INVALID { get { if (!_SIGNAL_TIME_INVALIDReady) { _SIGNAL_TIME_INVALIDContent = SGetField<long>(LocalBridgeClazz, "SIGNAL_TIME_INVALID"); _SIGNAL_TIME_INVALIDReady = true; } return _SIGNAL_TIME_INVALIDContent; } }
        private static long _SIGNAL_TIME_INVALIDContent = default;
        private static bool _SIGNAL_TIME_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#SIGNAL_TIME_PENDING"/>
        /// </summary>
        public static long SIGNAL_TIME_PENDING { get { if (!_SIGNAL_TIME_PENDINGReady) { _SIGNAL_TIME_PENDINGContent = SGetField<long>(LocalBridgeClazz, "SIGNAL_TIME_PENDING"); _SIGNAL_TIME_PENDINGReady = true; } return _SIGNAL_TIME_PENDINGContent; } }
        private static long _SIGNAL_TIME_PENDINGContent = default;
        private static bool _SIGNAL_TIME_PENDINGReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#await(java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Await(Java.Time.Duration arg0)
        {
            return IExecuteWithSignature<bool>("await", "(Ljava/time/Duration;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#awaitForever()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool AwaitForever()
        {
            return IExecuteWithSignature<bool>("awaitForever", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#getSignalTime()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSignalTime()
        {
            return IExecuteWithSignature<long>("getSignalTime", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SyncFence.html#writeToParcel(android.os.Parcel,int)"/>
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