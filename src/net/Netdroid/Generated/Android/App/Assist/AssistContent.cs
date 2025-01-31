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

namespace Android.App.Assist
{
    #region AssistContent declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html"/>
    /// </summary>
    public partial class AssistContent : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.assist.AssistContent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AssistContent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AssistContent(params object[] args) : base(args) { }
    
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

    #region AssistContent implementation
    public partial class AssistContent
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#getClipData()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ClipData"/></returns>
        public Android.Content.ClipData GetClipData()
        {
            return IExecuteWithSignature<Android.Content.ClipData>("getClipData", "()Landroid/content/ClipData;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#getIntent()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Intent"/></returns>
        public Android.Content.Intent GetIntent()
        {
            return IExecuteWithSignature<Android.Content.Intent>("getIntent", "()Landroid/content/Intent;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#getWebUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetWebUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getWebUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#isAppProvidedIntent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAppProvidedIntent()
        {
            return IExecuteWithSignature<bool>("isAppProvidedIntent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#isAppProvidedWebUri()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAppProvidedWebUri()
        {
            return IExecuteWithSignature<bool>("isAppProvidedWebUri", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#getStructuredData()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetStructuredData()
        {
            return IExecuteWithSignature<Java.Lang.String>("getStructuredData", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#setClipData(android.content.ClipData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ClipData"/></param>
        public void SetClipData(Android.Content.ClipData arg0)
        {
            IExecuteWithSignature("setClipData", "(Landroid/content/ClipData;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#setIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void SetIntent(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("setIntent", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#setStructuredData(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetStructuredData(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setStructuredData", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#setWebUri(android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        public void SetWebUri(Android.Net.Uri arg0)
        {
            IExecuteWithSignature("setWebUri", "(Landroid/net/Uri;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/assist/AssistContent.html#writeToParcel(android.os.Parcel,int)"/>
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