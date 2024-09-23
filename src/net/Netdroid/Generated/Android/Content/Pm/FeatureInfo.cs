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

namespace Android.Content.Pm
{
    #region FeatureInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html"/>
    /// </summary>
    public partial class FeatureInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.content.pm.FeatureInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FeatureInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FeatureInfo(params object[] args) : base(args) { }

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

    #region FeatureInfo implementation
    public partial class FeatureInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#%3Cinit%3E(android.content.pm.FeatureInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.FeatureInfo"/></param>
        public FeatureInfo(Android.Content.Pm.FeatureInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#reqGlEsVersion"/>
        /// </summary>
        public int reqGlEsVersion { get { return IGetField<int>("reqGlEsVersion"); } set { ISetField("reqGlEsVersion", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#version"/>
        /// </summary>
        public int version { get { return IGetField<int>("version"); } set { ISetField("version", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#name"/>
        /// </summary>
        public Java.Lang.String name { get { return IGetField<Java.Lang.String>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#FLAG_REQUIRED"/>
        /// </summary>
        public static int FLAG_REQUIRED { get { if (!_FLAG_REQUIREDReady) { _FLAG_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUIRED"); _FLAG_REQUIREDReady = true; } return _FLAG_REQUIREDContent; } }
        private static int _FLAG_REQUIREDContent = default;
        private static bool _FLAG_REQUIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#GL_ES_VERSION_UNDEFINED"/>
        /// </summary>
        public static int GL_ES_VERSION_UNDEFINED { get { if (!_GL_ES_VERSION_UNDEFINEDReady) { _GL_ES_VERSION_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "GL_ES_VERSION_UNDEFINED"); _GL_ES_VERSION_UNDEFINEDReady = true; } return _GL_ES_VERSION_UNDEFINEDContent; } }
        private static int _GL_ES_VERSION_UNDEFINEDContent = default;
        private static bool _GL_ES_VERSION_UNDEFINEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#getGlEsVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetGlEsVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getGlEsVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/FeatureInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}