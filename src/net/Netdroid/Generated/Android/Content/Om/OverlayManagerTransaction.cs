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

namespace Android.Content.Om
{
    #region OverlayManagerTransaction declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html"/>
    /// </summary>
    public partial class OverlayManagerTransaction : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.om.OverlayManagerTransaction";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public OverlayManagerTransaction() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public OverlayManagerTransaction(params object[] args) : base(args) { }
    
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

    #region OverlayManagerTransaction implementation
    public partial class OverlayManagerTransaction
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#newInstance()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Om.OverlayManagerTransaction"/></returns>
        public static Android.Content.Om.OverlayManagerTransaction NewInstance()
        {
            return SExecuteWithSignature<Android.Content.Om.OverlayManagerTransaction>(LocalBridgeClazz, "newInstance", "()Landroid/content/om/OverlayManagerTransaction;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#registerFabricatedOverlay(android.content.om.FabricatedOverlay)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Om.FabricatedOverlay"/></param>
        public void RegisterFabricatedOverlay(Android.Content.Om.FabricatedOverlay arg0)
        {
            IExecuteWithSignature("registerFabricatedOverlay", "(Landroid/content/om/FabricatedOverlay;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#unregisterFabricatedOverlay(android.content.om.OverlayIdentifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Om.OverlayIdentifier"/></param>
        public void UnregisterFabricatedOverlay(Android.Content.Om.OverlayIdentifier arg0)
        {
            IExecuteWithSignature("unregisterFabricatedOverlay", "(Landroid/content/om/OverlayIdentifier;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/om/OverlayManagerTransaction.html#writeToParcel(android.os.Parcel,int)"/>
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