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

namespace Android.Net
{
    #region IpSecTransformState declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html"/>
    /// </summary>
    public partial class IpSecTransformState : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.net.IpSecTransformState";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IpSecTransformState() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IpSecTransformState(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.IpSecTransformState$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region IpSecTransformState implementation
    public partial class IpSecTransformState
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getReplayBitmap()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetReplayBitmap()
        {
            return IExecuteWithSignatureArray<byte>("getReplayBitmap", "()[B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getByteCount()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetByteCount()
        {
            return IExecuteWithSignature<long>("getByteCount", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getPacketCount()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetPacketCount()
        {
            return IExecuteWithSignature<long>("getPacketCount", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getRxHighestSequenceNumber()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetRxHighestSequenceNumber()
        {
            return IExecuteWithSignature<long>("getRxHighestSequenceNumber", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getTimestampMillis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTimestampMillis()
        {
            return IExecuteWithSignature<long>("getTimestampMillis", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#getTxHighestSequenceNumber()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetTxHighestSequenceNumber()
        {
            return IExecuteWithSignature<long>("getTxHighestSequenceNumber", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.IpSecTransformState"/></returns>
            public Android.Net.IpSecTransformState Build()
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState>("build", "()Landroid/net/IpSecTransformState;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setByteCount(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetByteCount(long arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setByteCount", "(J)Landroid/net/IpSecTransformState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setPacketCount(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetPacketCount(long arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setPacketCount", "(J)Landroid/net/IpSecTransformState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setReplayBitmap(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetReplayBitmap(byte[] arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setReplayBitmap", "([B)Landroid/net/IpSecTransformState$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setRxHighestSequenceNumber(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetRxHighestSequenceNumber(long arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setRxHighestSequenceNumber", "(J)Landroid/net/IpSecTransformState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setTimestampMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetTimestampMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setTimestampMillis", "(J)Landroid/net/IpSecTransformState$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/IpSecTransformState.Builder.html#setTxHighestSequenceNumber(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Net.IpSecTransformState.Builder"/></returns>
            public Android.Net.IpSecTransformState.Builder SetTxHighestSequenceNumber(long arg0)
            {
                return IExecuteWithSignature<Android.Net.IpSecTransformState.Builder>("setTxHighestSequenceNumber", "(J)Landroid/net/IpSecTransformState$Builder;", arg0);
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