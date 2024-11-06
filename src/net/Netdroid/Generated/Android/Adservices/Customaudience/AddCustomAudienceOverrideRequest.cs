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

namespace Android.Adservices.Customaudience
{
    #region AddCustomAudienceOverrideRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html"/>
    /// </summary>
    public partial class AddCustomAudienceOverrideRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AddCustomAudienceOverrideRequest>
    {
        const string _bridgeClassName = "android.adservices.customaudience.AddCustomAudienceOverrideRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AddCustomAudienceOverrideRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AddCustomAudienceOverrideRequest(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.adservices.customaudience.AddCustomAudienceOverrideRequest$Builder";
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

    #region AddCustomAudienceOverrideRequest implementation
    public partial class AddCustomAudienceOverrideRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#%3Cinit%3E(android.adservices.common.AdTechIdentifier,java.lang.String,java.lang.String,android.adservices.common.AdSelectionSignals)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
        public AddCustomAudienceOverrideRequest(Android.Adservices.Common.AdTechIdentifier arg0, Java.Lang.String arg1, Java.Lang.String arg2, Android.Adservices.Common.AdSelectionSignals arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#getTrustedBiddingSignals()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdSelectionSignals"/></returns>
        public Android.Adservices.Common.AdSelectionSignals GetTrustedBiddingSignals()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdSelectionSignals>("getTrustedBiddingSignals", "()Landroid/adservices/common/AdSelectionSignals;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#getBuyer()"/>
        /// </summary>
        /// <returns><see cref="Android.Adservices.Common.AdTechIdentifier"/></returns>
        public Android.Adservices.Common.AdTechIdentifier GetBuyer()
        {
            return IExecuteWithSignature<Android.Adservices.Common.AdTechIdentifier>("getBuyer", "()Landroid/adservices/common/AdTechIdentifier;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#getBiddingLogicJs()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetBiddingLogicJs()
        {
            return IExecuteWithSignature<Java.Lang.String>("getBiddingLogicJs", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.html#getBiddingLogicJsVersion()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBiddingLogicJsVersion()
        {
            return IExecuteWithSignature<long>("getBiddingLogicJsVersion", "()J");
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
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest Build()
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest>("build", "()Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#setBiddingLogicJs(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder SetBiddingLogicJs(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder>("setBiddingLogicJs", "(Ljava/lang/String;)Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#setBiddingLogicJsVersion(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder SetBiddingLogicJsVersion(long arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder>("setBiddingLogicJsVersion", "(J)Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#setBuyer(android.adservices.common.AdTechIdentifier)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdTechIdentifier"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder SetBuyer(Android.Adservices.Common.AdTechIdentifier arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder>("setBuyer", "(Landroid/adservices/common/AdTechIdentifier;)Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder SetName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder>("setName", "(Ljava/lang/String;)Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/adservices/customaudience/AddCustomAudienceOverrideRequest.Builder.html#setTrustedBiddingSignals(android.adservices.common.AdSelectionSignals)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
            /// <returns><see cref="Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder"/></returns>
            public Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder SetTrustedBiddingSignals(Android.Adservices.Common.AdSelectionSignals arg0)
            {
                return IExecuteWithSignature<Android.Adservices.Customaudience.AddCustomAudienceOverrideRequest.Builder>("setTrustedBiddingSignals", "(Landroid/adservices/common/AdSelectionSignals;)Landroid/adservices/customaudience/AddCustomAudienceOverrideRequest$Builder;", arg0);
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