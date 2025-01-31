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

namespace Android.Accessibilityservice
{
    #region MagnificationConfig declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html"/>
    /// </summary>
    public partial class MagnificationConfig : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.accessibilityservice.MagnificationConfig";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MagnificationConfig() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MagnificationConfig(params object[] args) : base(args) { }
    
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
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.accessibilityservice.MagnificationConfig$Builder";
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

    #region MagnificationConfig implementation
    public partial class MagnificationConfig
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#MAGNIFICATION_MODE_DEFAULT"/>
        /// </summary>
        public static int MAGNIFICATION_MODE_DEFAULT { get { if (!_MAGNIFICATION_MODE_DEFAULTReady) { _MAGNIFICATION_MODE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "MAGNIFICATION_MODE_DEFAULT"); _MAGNIFICATION_MODE_DEFAULTReady = true; } return _MAGNIFICATION_MODE_DEFAULTContent; } }
        private static int _MAGNIFICATION_MODE_DEFAULTContent = default;
        private static bool _MAGNIFICATION_MODE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#MAGNIFICATION_MODE_FULLSCREEN"/>
        /// </summary>
        public static int MAGNIFICATION_MODE_FULLSCREEN { get { if (!_MAGNIFICATION_MODE_FULLSCREENReady) { _MAGNIFICATION_MODE_FULLSCREENContent = SGetField<int>(LocalBridgeClazz, "MAGNIFICATION_MODE_FULLSCREEN"); _MAGNIFICATION_MODE_FULLSCREENReady = true; } return _MAGNIFICATION_MODE_FULLSCREENContent; } }
        private static int _MAGNIFICATION_MODE_FULLSCREENContent = default;
        private static bool _MAGNIFICATION_MODE_FULLSCREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#MAGNIFICATION_MODE_WINDOW"/>
        /// </summary>
        public static int MAGNIFICATION_MODE_WINDOW { get { if (!_MAGNIFICATION_MODE_WINDOWReady) { _MAGNIFICATION_MODE_WINDOWContent = SGetField<int>(LocalBridgeClazz, "MAGNIFICATION_MODE_WINDOW"); _MAGNIFICATION_MODE_WINDOWReady = true; } return _MAGNIFICATION_MODE_WINDOWContent; } }
        private static int _MAGNIFICATION_MODE_WINDOWContent = default;
        private static bool _MAGNIFICATION_MODE_WINDOWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#isActivated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActivated()
        {
            return IExecuteWithSignature<bool>("isActivated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#getCenterX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCenterX()
        {
            return IExecuteWithSignature<float>("getCenterX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#getCenterY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetCenterY()
        {
            return IExecuteWithSignature<float>("getCenterY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#getScale()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetScale()
        {
            return IExecuteWithSignature<float>("getScale", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#getMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMode()
        {
            return IExecuteWithSignature<int>("getMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig"/></returns>
            public Android.Accessibilityservice.MagnificationConfig Build()
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig>("build", "()Landroid/accessibilityservice/MagnificationConfig;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#setActivated(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig.Builder"/></returns>
            public Android.Accessibilityservice.MagnificationConfig.Builder SetActivated(bool arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig.Builder>("setActivated", "(Z)Landroid/accessibilityservice/MagnificationConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#setCenterX(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig.Builder"/></returns>
            public Android.Accessibilityservice.MagnificationConfig.Builder SetCenterX(float arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig.Builder>("setCenterX", "(F)Landroid/accessibilityservice/MagnificationConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#setCenterY(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig.Builder"/></returns>
            public Android.Accessibilityservice.MagnificationConfig.Builder SetCenterY(float arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig.Builder>("setCenterY", "(F)Landroid/accessibilityservice/MagnificationConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#setMode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig.Builder"/></returns>
            public Android.Accessibilityservice.MagnificationConfig.Builder SetMode(int arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig.Builder>("setMode", "(I)Landroid/accessibilityservice/MagnificationConfig$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/MagnificationConfig.Builder.html#setScale(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.Accessibilityservice.MagnificationConfig.Builder"/></returns>
            public Android.Accessibilityservice.MagnificationConfig.Builder SetScale(float arg0)
            {
                return IExecuteWithSignature<Android.Accessibilityservice.MagnificationConfig.Builder>("setScale", "(F)Landroid/accessibilityservice/MagnificationConfig$Builder;", arg0);
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