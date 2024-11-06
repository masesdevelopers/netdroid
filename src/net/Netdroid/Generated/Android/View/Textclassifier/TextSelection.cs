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

namespace Android.View.Textclassifier
{
    #region TextSelection declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html"/>
    /// </summary>
    public partial class TextSelection : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.view.textclassifier.TextSelection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TextSelection() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TextSelection(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.textclassifier.TextSelection$Builder";
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

        #region Request declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html"/>
        /// </summary>
        public partial class Request : Android.Os.Parcelable
        {
            const string _bridgeClassName = "android.view.textclassifier.TextSelection$Request";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Request() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Request(params object[] args) : base(args) { }
        
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
            #region Builder declaration
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html"/>
            /// </summary>
            public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
            {
                const string _bridgeClassName = "android.view.textclassifier.TextSelection$Request$Builder";
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

    
    }
    #endregion

    #region TextSelection implementation
    public partial class TextSelection
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getTextClassification()"/>
        /// </summary>
        /// <returns><see cref="Android.View.Textclassifier.TextClassification"/></returns>
        public Android.View.Textclassifier.TextClassification GetTextClassification()
        {
            return IExecute<Android.View.Textclassifier.TextClassification>("getTextClassification");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getConfidenceScore(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetConfidenceScore(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<float>("getConfidenceScore", "(Ljava/lang/String;)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getEntityCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEntityCount()
        {
            return IExecuteWithSignature<int>("getEntityCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getSelectionEndIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionEndIndex()
        {
            return IExecuteWithSignature<int>("getSelectionEndIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getSelectionStartIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionStartIndex()
        {
            return IExecuteWithSignature<int>("getSelectionStartIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getEntity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetEntity(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getEntity", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public Builder(int arg0, int arg1)
                : base(arg0, arg1)
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
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Textclassifier.TextSelection"/></returns>
            public Android.View.Textclassifier.TextSelection Build()
            {
                return IExecute<Android.View.Textclassifier.TextSelection>("build");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#setEntityType(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextSelection.Builder"/></returns>
            public Android.View.Textclassifier.TextSelection.Builder SetEntityType(Java.Lang.String arg0, float arg1)
            {
                return IExecute<Android.View.Textclassifier.TextSelection.Builder>("setEntityType", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextSelection.Builder"/></returns>
            public Android.View.Textclassifier.TextSelection.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecute<Android.View.Textclassifier.TextSelection.Builder>("setExtras", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#setId(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextSelection.Builder"/></returns>
            public Android.View.Textclassifier.TextSelection.Builder SetId(Java.Lang.String arg0)
            {
                return IExecute<Android.View.Textclassifier.TextSelection.Builder>("setId", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Builder.html#setTextClassification(android.view.textclassifier.TextClassification)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.Textclassifier.TextClassification"/></param>
            /// <returns><see cref="Android.View.Textclassifier.TextSelection.Builder"/></returns>
            public Android.View.Textclassifier.TextSelection.Builder SetTextClassification(Android.View.Textclassifier.TextClassification arg0)
            {
                return IExecute<Android.View.Textclassifier.TextSelection.Builder>("setTextClassification", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Request implementation
        public partial class Request
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#CREATOR"/>
            /// </summary>
            public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
            private static Android.Os.Parcelable.Creator _CREATORContent = default;
            private static bool _CREATORReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getExtras()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.Bundle"/></returns>
            public Android.Os.Bundle GetExtras()
            {
                return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getDefaultLocales()"/>
            /// </summary>
            /// <returns><see cref="Android.Os.LocaleList"/></returns>
            public Android.Os.LocaleList GetDefaultLocales()
            {
                return IExecuteWithSignature<Android.Os.LocaleList>("getDefaultLocales", "()Landroid/os/LocaleList;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#shouldIncludeTextClassification()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool ShouldIncludeTextClassification()
            {
                return IExecuteWithSignature<bool>("shouldIncludeTextClassification", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#describeContents()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int DescribeContents()
            {
                return IExecuteWithSignature<int>("describeContents", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getEndIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetEndIndex()
            {
                return IExecuteWithSignature<int>("getEndIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getStartIndex()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStartIndex()
            {
                return IExecuteWithSignature<int>("getStartIndex", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getText()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence GetText()
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("getText", "()Ljava/lang/CharSequence;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#getCallingPackageName()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String GetCallingPackageName()
            {
                return IExecuteWithSignature<Java.Lang.String>("getCallingPackageName", "()Ljava/lang/String;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.html#writeToParcel(android.os.Parcel,int)"/>
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html#%3Cinit%3E(java.lang.CharSequence,int,int)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
                /// <param name="arg1"><see cref="int"/></param>
                /// <param name="arg2"><see cref="int"/></param>
                public Builder(Java.Lang.CharSequence arg0, int arg1, int arg2)
                    : base(arg0, arg1, arg2)
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
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.Textclassifier.TextSelection.Request"/></returns>
                public Android.View.Textclassifier.TextSelection.Request Build()
                {
                    return IExecute<Android.View.Textclassifier.TextSelection.Request>("build");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html#setDefaultLocales(android.os.LocaleList)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.LocaleList"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextSelection.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextSelection.Request.Builder SetDefaultLocales(Android.Os.LocaleList arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextSelection.Request.Builder>("setDefaultLocales", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html#setExtras(android.os.Bundle)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextSelection.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextSelection.Request.Builder SetExtras(Android.Os.Bundle arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextSelection.Request.Builder>("setExtras", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/textclassifier/TextSelection.Request.Builder.html#setIncludeTextClassification(boolean)"/>
                /// </summary>
                /// <param name="arg0"><see cref="bool"/></param>
                /// <returns><see cref="Android.View.Textclassifier.TextSelection.Request.Builder"/></returns>
                public Android.View.Textclassifier.TextSelection.Request.Builder SetIncludeTextClassification(bool arg0)
                {
                    return IExecute<Android.View.Textclassifier.TextSelection.Request.Builder>("setIncludeTextClassification", arg0);
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

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}