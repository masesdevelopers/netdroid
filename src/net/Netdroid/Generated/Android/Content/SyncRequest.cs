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

namespace Android.Content
{
    #region SyncRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/SyncRequest.html"/>
    /// </summary>
    public partial class SyncRequest : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.SyncRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SyncRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SyncRequest(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.content.SyncRequest$Builder";
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

    #region SyncRequest implementation
    public partial class SyncRequest
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SyncRequest.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.SyncRequest"/></returns>
            public Android.Content.SyncRequest Build()
            {
                return IExecuteWithSignature<Android.Content.SyncRequest>("build", "()Landroid/content/SyncRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setDisallowMetered(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetDisallowMetered(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setDisallowMetered", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setExpedited(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetExpedited(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setExpedited", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setExtras", "(Landroid/os/Bundle;)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setIgnoreBackoff(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetIgnoreBackoff(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setIgnoreBackoff", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setIgnoreSettings(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetIgnoreSettings(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setIgnoreSettings", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setManual(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetManual(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setManual", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setNoRetry(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetNoRetry(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setNoRetry", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setRequiresCharging(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetRequiresCharging(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setRequiresCharging", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setScheduleAsExpeditedJob(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetScheduleAsExpeditedJob(bool arg0)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setScheduleAsExpeditedJob", "(Z)Landroid/content/SyncRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#setSyncAdapter(android.accounts.Account,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Accounts.Account"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SetSyncAdapter(Android.Accounts.Account arg0, Java.Lang.String arg1)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("setSyncAdapter", "(Landroid/accounts/Account;Ljava/lang/String;)Landroid/content/SyncRequest$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#syncOnce()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SyncOnce()
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("syncOnce", "()Landroid/content/SyncRequest$Builder;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SyncRequest.Builder.html#syncPeriodic(long,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Content.SyncRequest.Builder"/></returns>
            public Android.Content.SyncRequest.Builder SyncPeriodic(long arg0, long arg1)
            {
                return IExecuteWithSignature<Android.Content.SyncRequest.Builder>("syncPeriodic", "(JJ)Landroid/content/SyncRequest$Builder;", arg0, arg1);
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