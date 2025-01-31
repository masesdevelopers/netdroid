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

namespace Android.Graphics
{
    #region Color declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/graphics/Color.html"/>
    /// </summary>
    public partial class Color : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Color>
    {
        const string _bridgeClassName = "android.graphics.Color";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Color() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Color(params object[] args) : base(args) { }
    
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

    #region Color implementation
    public partial class Color
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#BLACK"/>
        /// </summary>
        public static int BLACK { get { if (!_BLACKReady) { _BLACKContent = SGetField<int>(LocalBridgeClazz, "BLACK"); _BLACKReady = true; } return _BLACKContent; } }
        private static int _BLACKContent = default;
        private static bool _BLACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#BLUE"/>
        /// </summary>
        public static int BLUE { get { if (!_BLUEReady) { _BLUEContent = SGetField<int>(LocalBridgeClazz, "BLUE"); _BLUEReady = true; } return _BLUEContent; } }
        private static int _BLUEContent = default;
        private static bool _BLUEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#CYAN"/>
        /// </summary>
        public static int CYAN { get { if (!_CYANReady) { _CYANContent = SGetField<int>(LocalBridgeClazz, "CYAN"); _CYANReady = true; } return _CYANContent; } }
        private static int _CYANContent = default;
        private static bool _CYANReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#DKGRAY"/>
        /// </summary>
        public static int DKGRAY { get { if (!_DKGRAYReady) { _DKGRAYContent = SGetField<int>(LocalBridgeClazz, "DKGRAY"); _DKGRAYReady = true; } return _DKGRAYContent; } }
        private static int _DKGRAYContent = default;
        private static bool _DKGRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#GRAY"/>
        /// </summary>
        public static int GRAY { get { if (!_GRAYReady) { _GRAYContent = SGetField<int>(LocalBridgeClazz, "GRAY"); _GRAYReady = true; } return _GRAYContent; } }
        private static int _GRAYContent = default;
        private static bool _GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#GREEN"/>
        /// </summary>
        public static int GREEN { get { if (!_GREENReady) { _GREENContent = SGetField<int>(LocalBridgeClazz, "GREEN"); _GREENReady = true; } return _GREENContent; } }
        private static int _GREENContent = default;
        private static bool _GREENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#LTGRAY"/>
        /// </summary>
        public static int LTGRAY { get { if (!_LTGRAYReady) { _LTGRAYContent = SGetField<int>(LocalBridgeClazz, "LTGRAY"); _LTGRAYReady = true; } return _LTGRAYContent; } }
        private static int _LTGRAYContent = default;
        private static bool _LTGRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#MAGENTA"/>
        /// </summary>
        public static int MAGENTA { get { if (!_MAGENTAReady) { _MAGENTAContent = SGetField<int>(LocalBridgeClazz, "MAGENTA"); _MAGENTAReady = true; } return _MAGENTAContent; } }
        private static int _MAGENTAContent = default;
        private static bool _MAGENTAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#RED"/>
        /// </summary>
        public static int RED { get { if (!_REDReady) { _REDContent = SGetField<int>(LocalBridgeClazz, "RED"); _REDReady = true; } return _REDContent; } }
        private static int _REDContent = default;
        private static bool _REDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#TRANSPARENT"/>
        /// </summary>
        public static int TRANSPARENT { get { if (!_TRANSPARENTReady) { _TRANSPARENTContent = SGetField<int>(LocalBridgeClazz, "TRANSPARENT"); _TRANSPARENTReady = true; } return _TRANSPARENTContent; } }
        private static int _TRANSPARENTContent = default;
        private static bool _TRANSPARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#WHITE"/>
        /// </summary>
        public static int WHITE { get { if (!_WHITEReady) { _WHITEContent = SGetField<int>(LocalBridgeClazz, "WHITE"); _WHITEReady = true; } return _WHITEContent; } }
        private static int _WHITEContent = default;
        private static bool _WHITEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#YELLOW"/>
        /// </summary>
        public static int YELLOW { get { if (!_YELLOWReady) { _YELLOWContent = SGetField<int>(LocalBridgeClazz, "YELLOW"); _YELLOWReady = true; } return _YELLOWContent; } }
        private static int _YELLOWContent = default;
        private static bool _YELLOWReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(float,float,float,float,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(float arg0, float arg1, float arg2, float arg3, Android.Graphics.ColorSpace arg4)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "(FFFFLandroid/graphics/ColorSpace;)Landroid/graphics/Color;", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(float arg0, float arg1, float arg2, float arg3)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "(FFFF)Landroid/graphics/Color;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(float arg0, float arg1, float arg2)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "(FFF)Landroid/graphics/Color;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(float[],android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(float[] arg0, Android.Graphics.ColorSpace arg1)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "([FLandroid/graphics/ColorSpace;)Landroid/graphics/Color;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(int arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "(I)Landroid/graphics/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#valueOf(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public static Android.Graphics.Color ValueOf(long arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Color>(LocalBridgeClazz, "valueOf", "(J)Landroid/graphics/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#colorSpace(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Graphics.ColorSpace"/></returns>
        public static Android.Graphics.ColorSpace ColorSpace(long arg0)
        {
            return SExecuteWithSignature<Android.Graphics.ColorSpace>(LocalBridgeClazz, "colorSpace", "(J)Landroid/graphics/ColorSpace;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#isInColorSpace(long,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInColorSpace(long arg0, Android.Graphics.ColorSpace arg1)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isInColorSpace", "(JLandroid/graphics/ColorSpace;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#isSrgb(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSrgb(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSrgb", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#isWideGamut(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWideGamut(long arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isWideGamut", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#alpha(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Alpha(long arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "alpha", "(J)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#blue(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Blue(long arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "blue", "(J)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#green(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Green(long arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "green", "(J)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#luminance(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Luminance(int arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "luminance", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#luminance(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Luminance(long arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "luminance", "(J)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#red(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Red(long arg0)
        {
            return SExecuteWithSignature<float>(LocalBridgeClazz, "red", "(J)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#alpha(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Alpha(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "alpha", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#argb(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Argb(float arg0, float arg1, float arg2, float arg3)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "argb", "(FFFF)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#argb(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Argb(int arg0, int arg1, int arg2, int arg3)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "argb", "(IIII)I", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#blue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Blue(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "blue", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#green(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Green(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "green", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#HSVToColor(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HSVToColor(float[] arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "HSVToColor", "([F)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#HSVToColor(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int HSVToColor(int arg0, float[] arg1)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "HSVToColor", "(I[F)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#parseColor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ParseColor(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "parseColor", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#red(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Red(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "red", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#rgb(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Rgb(float arg0, float arg1, float arg2)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "rgb", "(FFF)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#rgb(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Rgb(int arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "rgb", "(III)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#toArgb(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int ToArgb(long arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "toArgb", "(J)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(float,float,float,float,android.graphics.ColorSpace,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <param name="arg5"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Convert(float arg0, float arg1, float arg2, float arg3, Android.Graphics.ColorSpace arg4, Android.Graphics.ColorSpace arg5)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "convert", "(FFFFLandroid/graphics/ColorSpace;Landroid/graphics/ColorSpace;)J", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(float,float,float,float,android.graphics.ColorSpace.Connector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.ColorSpace.Connector"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Convert(float arg0, float arg1, float arg2, float arg3, Android.Graphics.ColorSpace.Connector arg4)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "convert", "(FFFFLandroid/graphics/ColorSpace$Connector;)J", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(int,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Convert(int arg0, Android.Graphics.ColorSpace arg1)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "convert", "(ILandroid/graphics/ColorSpace;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(long,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Convert(long arg0, Android.Graphics.ColorSpace arg1)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "convert", "(JLandroid/graphics/ColorSpace;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(long,android.graphics.ColorSpace.Connector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.ColorSpace.Connector"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Convert(long arg0, Android.Graphics.ColorSpace.Connector arg1)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "convert", "(JLandroid/graphics/ColorSpace$Connector;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#pack(float,float,float,float,android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Pack(float arg0, float arg1, float arg2, float arg3, Android.Graphics.ColorSpace arg4)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "pack", "(FFFFLandroid/graphics/ColorSpace;)J", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#pack(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Pack(float arg0, float arg1, float arg2, float arg3)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "pack", "(FFFF)J", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#pack(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Pack(float arg0, float arg1, float arg2)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "pack", "(FFF)J", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#pack(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public static long Pack(int arg0)
        {
            return SExecuteWithSignature<long>(LocalBridgeClazz, "pack", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#colorToHSV(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public static void ColorToHSV(int arg0, float[] arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "colorToHSV", "(I[F)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#RGBToHSV(int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public static void RGBToHSV(int arg0, int arg1, int arg2, float[] arg3)
        {
            SExecuteWithSignature(LocalBridgeClazz, "RGBToHSV", "(III[F)V", arg0, arg1, arg2, arg3);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#convert(android.graphics.ColorSpace)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.ColorSpace"/></param>
        /// <returns><see cref="Android.Graphics.Color"/></returns>
        public Android.Graphics.Color Convert(Android.Graphics.ColorSpace arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Color>("convert", "(Landroid/graphics/ColorSpace;)Landroid/graphics/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getColorSpace()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.ColorSpace"/></returns>
        public Android.Graphics.ColorSpace GetColorSpace()
        {
            return IExecuteWithSignature<Android.Graphics.ColorSpace>("getColorSpace", "()Landroid/graphics/ColorSpace;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getModel()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.ColorSpace.Model"/></returns>
        public Android.Graphics.ColorSpace.Model GetModel()
        {
            return IExecuteWithSignature<Android.Graphics.ColorSpace.Model>("getModel", "()Landroid/graphics/ColorSpace$Model;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#isSrgb()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSrgb()
        {
            return IExecuteWithSignature<bool>("isSrgb", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#isWideGamut()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWideGamut()
        {
            return IExecuteWithSignature<bool>("isWideGamut", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#alpha()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Alpha()
        {
            return IExecuteWithSignature<float>("alpha", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#blue()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Blue()
        {
            return IExecuteWithSignature<float>("blue", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getComponent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetComponent(int arg0)
        {
            return IExecuteWithSignature<float>("getComponent", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#green()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Green()
        {
            return IExecuteWithSignature<float>("green", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#luminance()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Luminance()
        {
            return IExecuteWithSignature<float>("luminance", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#red()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float Red()
        {
            return IExecuteWithSignature<float>("red", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getComponents()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents()
        {
            return IExecuteWithSignatureArray<float>("getComponents", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getComponents(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetComponents(float[] arg0)
        {
            return IExecuteWithSignatureArray<float>("getComponents", "([F)[F", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#getComponentCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetComponentCount()
        {
            return IExecuteWithSignature<int>("getComponentCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#toArgb()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ToArgb()
        {
            return IExecuteWithSignature<int>("toArgb", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Color.html#pack()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Pack()
        {
            return IExecuteWithSignature<long>("pack", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}