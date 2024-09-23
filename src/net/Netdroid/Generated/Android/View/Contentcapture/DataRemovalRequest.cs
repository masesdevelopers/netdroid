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

namespace Android.View.Contentcapture
{
    #region DataRemovalRequest declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html"/>
    /// </summary>
    public partial class DataRemovalRequest : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.contentcapture.DataRemovalRequest";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DataRemovalRequest() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DataRemovalRequest(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.contentcapture.DataRemovalRequest$Builder";
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

        #region LocusIdRequest declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.LocusIdRequest.html"/>
        /// </summary>
        public partial class LocusIdRequest : MASES.JCOBridge.C2JBridge.JVMBridgeBase<LocusIdRequest>
        {
            const string _bridgeClassName = "android.view.contentcapture.DataRemovalRequest$LocusIdRequest";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LocusIdRequest() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LocusIdRequest(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region DataRemovalRequest implementation
    public partial class DataRemovalRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#FLAG_IS_PREFIX"/>
        /// </summary>
        public static int FLAG_IS_PREFIX { get { if (!_FLAG_IS_PREFIXReady) { _FLAG_IS_PREFIXContent = SGetField<int>(LocalBridgeClazz, "FLAG_IS_PREFIX"); _FLAG_IS_PREFIXReady = true; } return _FLAG_IS_PREFIXContent; } }
        private static int _FLAG_IS_PREFIXContent = default;
        private static bool _FLAG_IS_PREFIXReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#isForEverything()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForEverything()
        {
            return IExecuteWithSignature<bool>("isForEverything", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#getPackageName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPackageName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getPackageName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#getLocusIdRequests()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.View.Contentcapture.DataRemovalRequest.LocusIdRequest> GetLocusIdRequests()
        {
            return IExecuteWithSignature<Java.Util.List<Android.View.Contentcapture.DataRemovalRequest.LocusIdRequest>>("getLocusIdRequests", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
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
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Contentcapture.DataRemovalRequest"/></returns>
            public Android.View.Contentcapture.DataRemovalRequest Build()
            {
                return IExecuteWithSignature<Android.View.Contentcapture.DataRemovalRequest>("build", "()Landroid/view/contentcapture/DataRemovalRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.Builder.html#addLocusId(android.content.LocusId,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.LocusId"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Contentcapture.DataRemovalRequest.Builder"/></returns>
            public Android.View.Contentcapture.DataRemovalRequest.Builder AddLocusId(Android.Content.LocusId arg0, int arg1)
            {
                return IExecute<Android.View.Contentcapture.DataRemovalRequest.Builder>("addLocusId", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.Builder.html#forEverything()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Contentcapture.DataRemovalRequest.Builder"/></returns>
            public Android.View.Contentcapture.DataRemovalRequest.Builder ForEverything()
            {
                return IExecuteWithSignature<Android.View.Contentcapture.DataRemovalRequest.Builder>("forEverything", "()Landroid/view/contentcapture/DataRemovalRequest$Builder;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LocusIdRequest implementation
        public partial class LocusIdRequest
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
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.LocusIdRequest.html#getLocusId()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.LocusId"/></returns>
            public Android.Content.LocusId GetLocusId()
            {
                return IExecuteWithSignature<Android.Content.LocusId>("getLocusId", "()Landroid/content/LocusId;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/contentcapture/DataRemovalRequest.LocusIdRequest.html#getFlags()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetFlags()
            {
                return IExecuteWithSignature<int>("getFlags", "()I");
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