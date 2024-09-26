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

namespace Android.Graphics.Pdf
{
    #region RenderParams declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html"/>
    /// </summary>
    public partial class RenderParams : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RenderParams>
    {
        const string _bridgeClassName = "android.graphics.pdf.RenderParams";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RenderParams() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RenderParams(params object[] args) : base(args) { }

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
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.graphics.pdf.RenderParams$Builder";
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

    #region RenderParams implementation
    public partial class RenderParams
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#FLAG_RENDER_HIGHLIGHT_ANNOTATIONS"/>
        /// </summary>
        public static int FLAG_RENDER_HIGHLIGHT_ANNOTATIONS { get { if (!_FLAG_RENDER_HIGHLIGHT_ANNOTATIONSReady) { _FLAG_RENDER_HIGHLIGHT_ANNOTATIONSContent = SGetField<int>(LocalBridgeClazz, "FLAG_RENDER_HIGHLIGHT_ANNOTATIONS"); _FLAG_RENDER_HIGHLIGHT_ANNOTATIONSReady = true; } return _FLAG_RENDER_HIGHLIGHT_ANNOTATIONSContent; } }
        private static int _FLAG_RENDER_HIGHLIGHT_ANNOTATIONSContent = default;
        private static bool _FLAG_RENDER_HIGHLIGHT_ANNOTATIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#FLAG_RENDER_TEXT_ANNOTATIONS"/>
        /// </summary>
        public static int FLAG_RENDER_TEXT_ANNOTATIONS { get { if (!_FLAG_RENDER_TEXT_ANNOTATIONSReady) { _FLAG_RENDER_TEXT_ANNOTATIONSContent = SGetField<int>(LocalBridgeClazz, "FLAG_RENDER_TEXT_ANNOTATIONS"); _FLAG_RENDER_TEXT_ANNOTATIONSReady = true; } return _FLAG_RENDER_TEXT_ANNOTATIONSContent; } }
        private static int _FLAG_RENDER_TEXT_ANNOTATIONSContent = default;
        private static bool _FLAG_RENDER_TEXT_ANNOTATIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#RENDER_MODE_FOR_DISPLAY"/>
        /// </summary>
        public static int RENDER_MODE_FOR_DISPLAY { get { if (!_RENDER_MODE_FOR_DISPLAYReady) { _RENDER_MODE_FOR_DISPLAYContent = SGetField<int>(LocalBridgeClazz, "RENDER_MODE_FOR_DISPLAY"); _RENDER_MODE_FOR_DISPLAYReady = true; } return _RENDER_MODE_FOR_DISPLAYContent; } }
        private static int _RENDER_MODE_FOR_DISPLAYContent = default;
        private static bool _RENDER_MODE_FOR_DISPLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#RENDER_MODE_FOR_PRINT"/>
        /// </summary>
        public static int RENDER_MODE_FOR_PRINT { get { if (!_RENDER_MODE_FOR_PRINTReady) { _RENDER_MODE_FOR_PRINTContent = SGetField<int>(LocalBridgeClazz, "RENDER_MODE_FOR_PRINT"); _RENDER_MODE_FOR_PRINTReady = true; } return _RENDER_MODE_FOR_PRINTContent; } }
        private static int _RENDER_MODE_FOR_PRINTContent = default;
        private static bool _RENDER_MODE_FOR_PRINTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#getRenderFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRenderFlags()
        {
            return IExecuteWithSignature<int>("getRenderFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.html#getRenderMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRenderMode()
        {
            return IExecuteWithSignature<int>("getRenderMode", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.Builder.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Builder(int arg0)
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
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Pdf.RenderParams"/></returns>
            public Android.Graphics.Pdf.RenderParams Build()
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.RenderParams>("build", "()Landroid/graphics/pdf/RenderParams;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.Builder.html#setRenderFlags(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.RenderParams.Builder"/></returns>
            public Android.Graphics.Pdf.RenderParams.Builder SetRenderFlags(int arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.RenderParams.Builder>("setRenderFlags", "(II)Landroid/graphics/pdf/RenderParams$Builder;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/graphics/pdf/RenderParams.Builder.html#setRenderFlags(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Graphics.Pdf.RenderParams.Builder"/></returns>
            public Android.Graphics.Pdf.RenderParams.Builder SetRenderFlags(int arg0)
            {
                return IExecuteWithSignature<Android.Graphics.Pdf.RenderParams.Builder>("setRenderFlags", "(I)Landroid/graphics/pdf/RenderParams$Builder;", arg0);
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