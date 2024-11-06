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

namespace Android.Graphics.Pdf.Models
{
    #region FormEditRecord declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html"/>
    /// </summary>
    public partial class FormEditRecord : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.graphics.pdf.models.FormEditRecord";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FormEditRecord() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FormEditRecord(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.graphics.pdf.models.FormEditRecord$Builder";
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

    #region FormEditRecord implementation
    public partial class FormEditRecord
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#EDIT_TYPE_CLICK"/>
        /// </summary>
        public static int EDIT_TYPE_CLICK { get { if (!_EDIT_TYPE_CLICKReady) { _EDIT_TYPE_CLICKContent = SGetField<int>(LocalBridgeClazz, "EDIT_TYPE_CLICK"); _EDIT_TYPE_CLICKReady = true; } return _EDIT_TYPE_CLICKContent; } }
        private static int _EDIT_TYPE_CLICKContent = default;
        private static bool _EDIT_TYPE_CLICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#EDIT_TYPE_SET_INDICES"/>
        /// </summary>
        public static int EDIT_TYPE_SET_INDICES { get { if (!_EDIT_TYPE_SET_INDICESReady) { _EDIT_TYPE_SET_INDICESContent = SGetField<int>(LocalBridgeClazz, "EDIT_TYPE_SET_INDICES"); _EDIT_TYPE_SET_INDICESReady = true; } return _EDIT_TYPE_SET_INDICESContent; } }
        private static int _EDIT_TYPE_SET_INDICESContent = default;
        private static bool _EDIT_TYPE_SET_INDICESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#EDIT_TYPE_SET_TEXT"/>
        /// </summary>
        public static int EDIT_TYPE_SET_TEXT { get { if (!_EDIT_TYPE_SET_TEXTReady) { _EDIT_TYPE_SET_TEXTContent = SGetField<int>(LocalBridgeClazz, "EDIT_TYPE_SET_TEXT"); _EDIT_TYPE_SET_TEXTReady = true; } return _EDIT_TYPE_SET_TEXTContent; } }
        private static int _EDIT_TYPE_SET_TEXTContent = default;
        private static bool _EDIT_TYPE_SET_TEXTReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getClickPoint()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Point"/></returns>
        public Android.Graphics.Point GetClickPoint()
        {
            return IExecuteWithSignature<Android.Graphics.Point>("getClickPoint", "()Landroid/graphics/Point;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getPageNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPageNumber()
        {
            return IExecuteWithSignature<int>("getPageNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetType()
        {
            return IExecuteWithSignature<int>("getType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getWidgetIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetWidgetIndex()
        {
            return IExecuteWithSignature<int>("getWidgetIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getSelectedIndices()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetSelectedIndices()
        {
            return IExecuteWithSignatureArray<int>("getSelectedIndices", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#getText()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetText()
        {
            return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html#%3Cinit%3E(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public Builder(int arg0, int arg1, int arg2)
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
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormEditRecord"/></returns>
            public Android.Graphics.Pdf.Models.FormEditRecord Build()
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.Models.FormEditRecord>("build", "()Landroid/graphics/pdf/models/FormEditRecord;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html#setClickPoint(android.graphics.Point)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.Point"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormEditRecord.Builder"/></returns>
            public Android.Graphics.Pdf.Models.FormEditRecord.Builder SetClickPoint(Android.Graphics.Point arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.Models.FormEditRecord.Builder>("setClickPoint", "(Landroid/graphics/Point;)Landroid/graphics/pdf/models/FormEditRecord$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html#setSelectedIndices(int[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormEditRecord.Builder"/></returns>
            public Android.Graphics.Pdf.Models.FormEditRecord.Builder SetSelectedIndices(int[] arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.Models.FormEditRecord.Builder>("setSelectedIndices", "([I)Landroid/graphics/pdf/models/FormEditRecord$Builder;", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/models/FormEditRecord.Builder.html#setText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.Models.FormEditRecord.Builder"/></returns>
            public Android.Graphics.Pdf.Models.FormEditRecord.Builder SetText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.Models.FormEditRecord.Builder>("setText", "(Ljava/lang/String;)Landroid/graphics/pdf/models/FormEditRecord$Builder;", arg0);
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