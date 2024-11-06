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

namespace Android.App
{
    #region RemoteInput declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html"/>
    /// </summary>
    public partial class RemoteInput : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.app.RemoteInput";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RemoteInput() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RemoteInput(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.app.RemoteInput$Builder";
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

    #region RemoteInput implementation
    public partial class RemoteInput
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#EDIT_CHOICES_BEFORE_SENDING_AUTO"/>
        /// </summary>
        public static int EDIT_CHOICES_BEFORE_SENDING_AUTO { get { if (!_EDIT_CHOICES_BEFORE_SENDING_AUTOReady) { _EDIT_CHOICES_BEFORE_SENDING_AUTOContent = SGetField<int>(LocalBridgeClazz, "EDIT_CHOICES_BEFORE_SENDING_AUTO"); _EDIT_CHOICES_BEFORE_SENDING_AUTOReady = true; } return _EDIT_CHOICES_BEFORE_SENDING_AUTOContent; } }
        private static int _EDIT_CHOICES_BEFORE_SENDING_AUTOContent = default;
        private static bool _EDIT_CHOICES_BEFORE_SENDING_AUTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#EDIT_CHOICES_BEFORE_SENDING_DISABLED"/>
        /// </summary>
        public static int EDIT_CHOICES_BEFORE_SENDING_DISABLED { get { if (!_EDIT_CHOICES_BEFORE_SENDING_DISABLEDReady) { _EDIT_CHOICES_BEFORE_SENDING_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "EDIT_CHOICES_BEFORE_SENDING_DISABLED"); _EDIT_CHOICES_BEFORE_SENDING_DISABLEDReady = true; } return _EDIT_CHOICES_BEFORE_SENDING_DISABLEDContent; } }
        private static int _EDIT_CHOICES_BEFORE_SENDING_DISABLEDContent = default;
        private static bool _EDIT_CHOICES_BEFORE_SENDING_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#EDIT_CHOICES_BEFORE_SENDING_ENABLED"/>
        /// </summary>
        public static int EDIT_CHOICES_BEFORE_SENDING_ENABLED { get { if (!_EDIT_CHOICES_BEFORE_SENDING_ENABLEDReady) { _EDIT_CHOICES_BEFORE_SENDING_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "EDIT_CHOICES_BEFORE_SENDING_ENABLED"); _EDIT_CHOICES_BEFORE_SENDING_ENABLEDReady = true; } return _EDIT_CHOICES_BEFORE_SENDING_ENABLEDContent; } }
        private static int _EDIT_CHOICES_BEFORE_SENDING_ENABLEDContent = default;
        private static bool _EDIT_CHOICES_BEFORE_SENDING_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#SOURCE_CHOICE"/>
        /// </summary>
        public static int SOURCE_CHOICE { get { if (!_SOURCE_CHOICEReady) { _SOURCE_CHOICEContent = SGetField<int>(LocalBridgeClazz, "SOURCE_CHOICE"); _SOURCE_CHOICEReady = true; } return _SOURCE_CHOICEContent; } }
        private static int _SOURCE_CHOICEContent = default;
        private static bool _SOURCE_CHOICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#SOURCE_FREE_FORM_INPUT"/>
        /// </summary>
        public static int SOURCE_FREE_FORM_INPUT { get { if (!_SOURCE_FREE_FORM_INPUTReady) { _SOURCE_FREE_FORM_INPUTContent = SGetField<int>(LocalBridgeClazz, "SOURCE_FREE_FORM_INPUT"); _SOURCE_FREE_FORM_INPUTReady = true; } return _SOURCE_FREE_FORM_INPUTContent; } }
        private static int _SOURCE_FREE_FORM_INPUTContent = default;
        private static bool _SOURCE_FREE_FORM_INPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#EXTRA_RESULTS_DATA"/>
        /// </summary>
        public static Java.Lang.String EXTRA_RESULTS_DATA { get { if (!_EXTRA_RESULTS_DATAReady) { _EXTRA_RESULTS_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_RESULTS_DATA"); _EXTRA_RESULTS_DATAReady = true; } return _EXTRA_RESULTS_DATAContent; } }
        private static Java.Lang.String _EXTRA_RESULTS_DATAContent = default;
        private static bool _EXTRA_RESULTS_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#RESULTS_CLIP_LABEL"/>
        /// </summary>
        public static Java.Lang.String RESULTS_CLIP_LABEL { get { if (!_RESULTS_CLIP_LABELReady) { _RESULTS_CLIP_LABELContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RESULTS_CLIP_LABEL"); _RESULTS_CLIP_LABELReady = true; } return _RESULTS_CLIP_LABELContent; } }
        private static Java.Lang.String _RESULTS_CLIP_LABELContent = default;
        private static bool _RESULTS_CLIP_LABELReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getResultsFromIntent(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public static Android.Os.Bundle GetResultsFromIntent(Android.Content.Intent arg0)
        {
            return SExecuteWithSignature<Android.Os.Bundle>(LocalBridgeClazz, "getResultsFromIntent", "(Landroid/content/Intent;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getResultsSource(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetResultsSource(Android.Content.Intent arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getResultsSource", "(Landroid/content/Intent;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getDataResultsFromIntent(android.content.Intent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<Java.Lang.String, Android.Net.Uri> GetDataResultsFromIntent(Android.Content.Intent arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Util.Map<Java.Lang.String, Android.Net.Uri>>(LocalBridgeClazz, "getDataResultsFromIntent", "(Landroid/content/Intent;Ljava/lang/String;)Ljava/util/Map;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#addDataResultToIntent(android.app.RemoteInput,android.content.Intent,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.RemoteInput"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        public static void AddDataResultToIntent(Android.App.RemoteInput arg0, Android.Content.Intent arg1, Java.Util.Map<Java.Lang.String, Android.Net.Uri> arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addDataResultToIntent", "(Landroid/app/RemoteInput;Landroid/content/Intent;Ljava/util/Map;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#addResultsToIntent(android.app.RemoteInput[],android.content.Intent,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.App.RemoteInput"/></param>
        /// <param name="arg1"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        public static void AddResultsToIntent(Android.App.RemoteInput[] arg0, Android.Content.Intent arg1, Android.Os.Bundle arg2)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addResultsToIntent", "([Landroid/app/RemoteInput;Landroid/content/Intent;Landroid/os/Bundle;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#setResultsSource(android.content.Intent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void SetResultsSource(Android.Content.Intent arg0, int arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setResultsSource", "(Landroid/content/Intent;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getAllowFreeFormInput()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetAllowFreeFormInput()
        {
            return IExecuteWithSignature<bool>("getAllowFreeFormInput", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#isDataOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataOnly()
        {
            return IExecuteWithSignature<bool>("isDataOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getEditChoicesBeforeSending()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEditChoicesBeforeSending()
        {
            return IExecuteWithSignature<int>("getEditChoicesBeforeSending", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getLabel()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetLabel()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getLabel", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getChoices()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence[] GetChoices()
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getChoices", "()[Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getResultKey()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetResultKey()
        {
            return IExecuteWithSignature<Java.Lang.String>("getResultKey", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#getAllowedDataTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetAllowedDataTypes()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getAllowedDataTypes", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/RemoteInput.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.App.RemoteInput"/></returns>
            public Android.App.RemoteInput Build()
            {
                return IExecuteWithSignature<Android.App.RemoteInput>("build", "()Landroid/app/RemoteInput;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#addExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder AddExtras(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("addExtras", "(Landroid/os/Bundle;)Landroid/app/RemoteInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#setAllowDataType(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder SetAllowDataType(Java.Lang.String arg0, bool arg1)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("setAllowDataType", "(Ljava/lang/String;Z)Landroid/app/RemoteInput$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#setAllowFreeFormInput(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder SetAllowFreeFormInput(bool arg0)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("setAllowFreeFormInput", "(Z)Landroid/app/RemoteInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#setChoices(java.lang.CharSequence[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder SetChoices(Java.Lang.CharSequence[] arg0)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("setChoices", "([Ljava/lang/CharSequence;)Landroid/app/RemoteInput$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#setEditChoicesBeforeSending(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder SetEditChoicesBeforeSending(int arg0)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("setEditChoicesBeforeSending", "(I)Landroid/app/RemoteInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#setLabel(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.App.RemoteInput.Builder"/></returns>
            public Android.App.RemoteInput.Builder SetLabel(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.App.RemoteInput.Builder>("setLabel", "(Ljava/lang/CharSequence;)Landroid/app/RemoteInput$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/RemoteInput.Builder.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
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