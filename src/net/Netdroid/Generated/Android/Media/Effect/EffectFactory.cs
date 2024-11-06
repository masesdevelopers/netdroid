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

namespace Android.Media.Effect
{
    #region EffectFactory declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html"/>
    /// </summary>
    public partial class EffectFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EffectFactory>
    {
        const string _bridgeClassName = "android.media.effect.EffectFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EffectFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EffectFactory(params object[] args) : base(args) { }
    
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

    #region EffectFactory implementation
    public partial class EffectFactory
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_AUTOFIX"/>
        /// </summary>
        public static Java.Lang.String EFFECT_AUTOFIX { get { if (!_EFFECT_AUTOFIXReady) { _EFFECT_AUTOFIXContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_AUTOFIX"); _EFFECT_AUTOFIXReady = true; } return _EFFECT_AUTOFIXContent; } }
        private static Java.Lang.String _EFFECT_AUTOFIXContent = default;
        private static bool _EFFECT_AUTOFIXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_BACKDROPPER"/>
        /// </summary>
        public static Java.Lang.String EFFECT_BACKDROPPER { get { if (!_EFFECT_BACKDROPPERReady) { _EFFECT_BACKDROPPERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_BACKDROPPER"); _EFFECT_BACKDROPPERReady = true; } return _EFFECT_BACKDROPPERContent; } }
        private static Java.Lang.String _EFFECT_BACKDROPPERContent = default;
        private static bool _EFFECT_BACKDROPPERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_BITMAPOVERLAY"/>
        /// </summary>
        public static Java.Lang.String EFFECT_BITMAPOVERLAY { get { if (!_EFFECT_BITMAPOVERLAYReady) { _EFFECT_BITMAPOVERLAYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_BITMAPOVERLAY"); _EFFECT_BITMAPOVERLAYReady = true; } return _EFFECT_BITMAPOVERLAYContent; } }
        private static Java.Lang.String _EFFECT_BITMAPOVERLAYContent = default;
        private static bool _EFFECT_BITMAPOVERLAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_BLACKWHITE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_BLACKWHITE { get { if (!_EFFECT_BLACKWHITEReady) { _EFFECT_BLACKWHITEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_BLACKWHITE"); _EFFECT_BLACKWHITEReady = true; } return _EFFECT_BLACKWHITEContent; } }
        private static Java.Lang.String _EFFECT_BLACKWHITEContent = default;
        private static bool _EFFECT_BLACKWHITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_BRIGHTNESS"/>
        /// </summary>
        public static Java.Lang.String EFFECT_BRIGHTNESS { get { if (!_EFFECT_BRIGHTNESSReady) { _EFFECT_BRIGHTNESSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_BRIGHTNESS"); _EFFECT_BRIGHTNESSReady = true; } return _EFFECT_BRIGHTNESSContent; } }
        private static Java.Lang.String _EFFECT_BRIGHTNESSContent = default;
        private static bool _EFFECT_BRIGHTNESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_CONTRAST"/>
        /// </summary>
        public static Java.Lang.String EFFECT_CONTRAST { get { if (!_EFFECT_CONTRASTReady) { _EFFECT_CONTRASTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_CONTRAST"); _EFFECT_CONTRASTReady = true; } return _EFFECT_CONTRASTContent; } }
        private static Java.Lang.String _EFFECT_CONTRASTContent = default;
        private static bool _EFFECT_CONTRASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_CROP"/>
        /// </summary>
        public static Java.Lang.String EFFECT_CROP { get { if (!_EFFECT_CROPReady) { _EFFECT_CROPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_CROP"); _EFFECT_CROPReady = true; } return _EFFECT_CROPContent; } }
        private static Java.Lang.String _EFFECT_CROPContent = default;
        private static bool _EFFECT_CROPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_CROSSPROCESS"/>
        /// </summary>
        public static Java.Lang.String EFFECT_CROSSPROCESS { get { if (!_EFFECT_CROSSPROCESSReady) { _EFFECT_CROSSPROCESSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_CROSSPROCESS"); _EFFECT_CROSSPROCESSReady = true; } return _EFFECT_CROSSPROCESSContent; } }
        private static Java.Lang.String _EFFECT_CROSSPROCESSContent = default;
        private static bool _EFFECT_CROSSPROCESSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_DOCUMENTARY"/>
        /// </summary>
        public static Java.Lang.String EFFECT_DOCUMENTARY { get { if (!_EFFECT_DOCUMENTARYReady) { _EFFECT_DOCUMENTARYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_DOCUMENTARY"); _EFFECT_DOCUMENTARYReady = true; } return _EFFECT_DOCUMENTARYContent; } }
        private static Java.Lang.String _EFFECT_DOCUMENTARYContent = default;
        private static bool _EFFECT_DOCUMENTARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_DUOTONE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_DUOTONE { get { if (!_EFFECT_DUOTONEReady) { _EFFECT_DUOTONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_DUOTONE"); _EFFECT_DUOTONEReady = true; } return _EFFECT_DUOTONEContent; } }
        private static Java.Lang.String _EFFECT_DUOTONEContent = default;
        private static bool _EFFECT_DUOTONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_FILLLIGHT"/>
        /// </summary>
        public static Java.Lang.String EFFECT_FILLLIGHT { get { if (!_EFFECT_FILLLIGHTReady) { _EFFECT_FILLLIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_FILLLIGHT"); _EFFECT_FILLLIGHTReady = true; } return _EFFECT_FILLLIGHTContent; } }
        private static Java.Lang.String _EFFECT_FILLLIGHTContent = default;
        private static bool _EFFECT_FILLLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_FISHEYE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_FISHEYE { get { if (!_EFFECT_FISHEYEReady) { _EFFECT_FISHEYEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_FISHEYE"); _EFFECT_FISHEYEReady = true; } return _EFFECT_FISHEYEContent; } }
        private static Java.Lang.String _EFFECT_FISHEYEContent = default;
        private static bool _EFFECT_FISHEYEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_FLIP"/>
        /// </summary>
        public static Java.Lang.String EFFECT_FLIP { get { if (!_EFFECT_FLIPReady) { _EFFECT_FLIPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_FLIP"); _EFFECT_FLIPReady = true; } return _EFFECT_FLIPContent; } }
        private static Java.Lang.String _EFFECT_FLIPContent = default;
        private static bool _EFFECT_FLIPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_GRAIN"/>
        /// </summary>
        public static Java.Lang.String EFFECT_GRAIN { get { if (!_EFFECT_GRAINReady) { _EFFECT_GRAINContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_GRAIN"); _EFFECT_GRAINReady = true; } return _EFFECT_GRAINContent; } }
        private static Java.Lang.String _EFFECT_GRAINContent = default;
        private static bool _EFFECT_GRAINReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_GRAYSCALE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_GRAYSCALE { get { if (!_EFFECT_GRAYSCALEReady) { _EFFECT_GRAYSCALEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_GRAYSCALE"); _EFFECT_GRAYSCALEReady = true; } return _EFFECT_GRAYSCALEContent; } }
        private static Java.Lang.String _EFFECT_GRAYSCALEContent = default;
        private static bool _EFFECT_GRAYSCALEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_LOMOISH"/>
        /// </summary>
        public static Java.Lang.String EFFECT_LOMOISH { get { if (!_EFFECT_LOMOISHReady) { _EFFECT_LOMOISHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_LOMOISH"); _EFFECT_LOMOISHReady = true; } return _EFFECT_LOMOISHContent; } }
        private static Java.Lang.String _EFFECT_LOMOISHContent = default;
        private static bool _EFFECT_LOMOISHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_NEGATIVE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_NEGATIVE { get { if (!_EFFECT_NEGATIVEReady) { _EFFECT_NEGATIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_NEGATIVE"); _EFFECT_NEGATIVEReady = true; } return _EFFECT_NEGATIVEContent; } }
        private static Java.Lang.String _EFFECT_NEGATIVEContent = default;
        private static bool _EFFECT_NEGATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_POSTERIZE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_POSTERIZE { get { if (!_EFFECT_POSTERIZEReady) { _EFFECT_POSTERIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_POSTERIZE"); _EFFECT_POSTERIZEReady = true; } return _EFFECT_POSTERIZEContent; } }
        private static Java.Lang.String _EFFECT_POSTERIZEContent = default;
        private static bool _EFFECT_POSTERIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_REDEYE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_REDEYE { get { if (!_EFFECT_REDEYEReady) { _EFFECT_REDEYEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_REDEYE"); _EFFECT_REDEYEReady = true; } return _EFFECT_REDEYEContent; } }
        private static Java.Lang.String _EFFECT_REDEYEContent = default;
        private static bool _EFFECT_REDEYEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_ROTATE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_ROTATE { get { if (!_EFFECT_ROTATEReady) { _EFFECT_ROTATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_ROTATE"); _EFFECT_ROTATEReady = true; } return _EFFECT_ROTATEContent; } }
        private static Java.Lang.String _EFFECT_ROTATEContent = default;
        private static bool _EFFECT_ROTATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_SATURATE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_SATURATE { get { if (!_EFFECT_SATURATEReady) { _EFFECT_SATURATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_SATURATE"); _EFFECT_SATURATEReady = true; } return _EFFECT_SATURATEContent; } }
        private static Java.Lang.String _EFFECT_SATURATEContent = default;
        private static bool _EFFECT_SATURATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_SEPIA"/>
        /// </summary>
        public static Java.Lang.String EFFECT_SEPIA { get { if (!_EFFECT_SEPIAReady) { _EFFECT_SEPIAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_SEPIA"); _EFFECT_SEPIAReady = true; } return _EFFECT_SEPIAContent; } }
        private static Java.Lang.String _EFFECT_SEPIAContent = default;
        private static bool _EFFECT_SEPIAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_SHARPEN"/>
        /// </summary>
        public static Java.Lang.String EFFECT_SHARPEN { get { if (!_EFFECT_SHARPENReady) { _EFFECT_SHARPENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_SHARPEN"); _EFFECT_SHARPENReady = true; } return _EFFECT_SHARPENContent; } }
        private static Java.Lang.String _EFFECT_SHARPENContent = default;
        private static bool _EFFECT_SHARPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_STRAIGHTEN"/>
        /// </summary>
        public static Java.Lang.String EFFECT_STRAIGHTEN { get { if (!_EFFECT_STRAIGHTENReady) { _EFFECT_STRAIGHTENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_STRAIGHTEN"); _EFFECT_STRAIGHTENReady = true; } return _EFFECT_STRAIGHTENContent; } }
        private static Java.Lang.String _EFFECT_STRAIGHTENContent = default;
        private static bool _EFFECT_STRAIGHTENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_TEMPERATURE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_TEMPERATURE { get { if (!_EFFECT_TEMPERATUREReady) { _EFFECT_TEMPERATUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_TEMPERATURE"); _EFFECT_TEMPERATUREReady = true; } return _EFFECT_TEMPERATUREContent; } }
        private static Java.Lang.String _EFFECT_TEMPERATUREContent = default;
        private static bool _EFFECT_TEMPERATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_TINT"/>
        /// </summary>
        public static Java.Lang.String EFFECT_TINT { get { if (!_EFFECT_TINTReady) { _EFFECT_TINTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_TINT"); _EFFECT_TINTReady = true; } return _EFFECT_TINTContent; } }
        private static Java.Lang.String _EFFECT_TINTContent = default;
        private static bool _EFFECT_TINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#EFFECT_VIGNETTE"/>
        /// </summary>
        public static Java.Lang.String EFFECT_VIGNETTE { get { if (!_EFFECT_VIGNETTEReady) { _EFFECT_VIGNETTEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EFFECT_VIGNETTE"); _EFFECT_VIGNETTEReady = true; } return _EFFECT_VIGNETTEContent; } }
        private static Java.Lang.String _EFFECT_VIGNETTEContent = default;
        private static bool _EFFECT_VIGNETTEReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#isEffectSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsEffectSupported(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isEffectSupported", "(Ljava/lang/String;)Z", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/effect/EffectFactory.html#createEffect(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Media.Effect.Effect"/></returns>
        public Android.Media.Effect.Effect CreateEffect(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Media.Effect.Effect>("createEffect", "(Ljava/lang/String;)Landroid/media/effect/Effect;", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}