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

namespace Android.View.Inputmethod
{
    #region DeleteGesture declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html"/>
    /// </summary>
    public partial class DeleteGesture : Android.View.Inputmethod.PreviewableHandwritingGesture
    {
        const string _bridgeClassName = "android.view.inputmethod.DeleteGesture";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DeleteGesture() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DeleteGesture(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.view.inputmethod.DeleteGesture$Builder";
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

    #region DeleteGesture implementation
    public partial class DeleteGesture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.View.Inputmethod.DeleteGesture"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.View.Inputmethod.DeleteGesture t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html#getDeletionArea()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.RectF"/></returns>
        public Android.Graphics.RectF GetDeletionArea()
        {
            return IExecuteWithSignature<Android.Graphics.RectF>("getDeletionArea", "()Landroid/graphics/RectF;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html#getGranularity()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetGranularity()
        {
            return IExecuteWithSignature<int>("getGranularity", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Inputmethod.DeleteGesture"/></returns>
            public Android.View.Inputmethod.DeleteGesture Build()
            {
                return IExecuteWithSignature<Android.View.Inputmethod.DeleteGesture>("build", "()Landroid/view/inputmethod/DeleteGesture;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.Builder.html#setDeletionArea(android.graphics.RectF)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Graphics.RectF"/></param>
            /// <returns><see cref="Android.View.Inputmethod.DeleteGesture.Builder"/></returns>
            public Android.View.Inputmethod.DeleteGesture.Builder SetDeletionArea(Android.Graphics.RectF arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.DeleteGesture.Builder>("setDeletionArea", "(Landroid/graphics/RectF;)Landroid/view/inputmethod/DeleteGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.Builder.html#setFallbackText(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.View.Inputmethod.DeleteGesture.Builder"/></returns>
            public Android.View.Inputmethod.DeleteGesture.Builder SetFallbackText(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.DeleteGesture.Builder>("setFallbackText", "(Ljava/lang/String;)Landroid/view/inputmethod/DeleteGesture$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/inputmethod/DeleteGesture.Builder.html#setGranularity(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.View.Inputmethod.DeleteGesture.Builder"/></returns>
            public Android.View.Inputmethod.DeleteGesture.Builder SetGranularity(int arg0)
            {
                return IExecuteWithSignature<Android.View.Inputmethod.DeleteGesture.Builder>("setGranularity", "(I)Landroid/view/inputmethod/DeleteGesture$Builder;", arg0);
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