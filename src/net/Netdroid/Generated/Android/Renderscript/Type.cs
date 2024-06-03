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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Renderscript
{
    #region Type
    public partial class Type
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#createX(android.renderscript.RenderScript,android.renderscript.Element,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Renderscript.Type"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.Type CreateX(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1, int arg2)
        {
            return SExecute<Android.Renderscript.Type>(LocalBridgeClazz, "createX", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#createXY(android.renderscript.RenderScript,android.renderscript.Element,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Renderscript.Type"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.Type CreateXY(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1, int arg2, int arg3)
        {
            return SExecute<Android.Renderscript.Type>(LocalBridgeClazz, "createXY", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#createXYZ(android.renderscript.RenderScript,android.renderscript.Element,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Renderscript.Type"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.Type CreateXYZ(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1, int arg2, int arg3, int arg4)
        {
            return SExecute<Android.Renderscript.Type>(LocalBridgeClazz, "createXYZ", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getElement()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Element"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Element GetElement()
        {
            return IExecuteWithSignature<Android.Renderscript.Element>("getElement", "()Landroid/renderscript/Element;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#hasFaces()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasFaces()
        {
            return IExecuteWithSignature<bool>("hasFaces", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#hasMipmaps()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool HasMipmaps()
        {
            return IExecuteWithSignature<bool>("hasMipmaps", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetCount()
        {
            return IExecuteWithSignature<int>("getCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetX()
        {
            return IExecuteWithSignature<int>("getX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetY()
        {
            return IExecuteWithSignature<int>("getY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getYuv()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetYuv()
        {
            return IExecuteWithSignature<int>("getYuv", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Type.html#getZ()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int GetZ()
        {
            return IExecuteWithSignature<int>("getZ", "()I");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#%3Cinit%3E(android.renderscript.RenderScript,android.renderscript.Element)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
            /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
            [global::System.Obsolete()]
            public Builder(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1)
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
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#create()"/>
            /// </summary>
            /// <returns><see cref="Android.Renderscript.Type"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type Create()
            {
                return IExecuteWithSignature<Android.Renderscript.Type>("create", "()Landroid/renderscript/Type;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setFaces(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetFaces(bool arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setFaces", "(Z)Landroid/renderscript/Type$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setMipmaps(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetMipmaps(bool arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setMipmaps", "(Z)Landroid/renderscript/Type$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setX(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetX(int arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setX", "(I)Landroid/renderscript/Type$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setY(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetY(int arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setY", "(I)Landroid/renderscript/Type$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setYuvFormat(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetYuvFormat(int arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setYuvFormat", "(I)Landroid/renderscript/Type$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.Builder.html#setZ(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Renderscript.Type.Builder"/></returns>
            [global::System.Obsolete()]
            public Android.Renderscript.Type.Builder SetZ(int arg0)
            {
                return IExecuteWithSignature<Android.Renderscript.Type.Builder>("setZ", "(I)Landroid/renderscript/Type$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CubemapFace
        public partial class CubemapFace
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#NEGATIVE_X"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace NEGATIVE_X { get { if (!_NEGATIVE_XReady) { _NEGATIVE_XContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "NEGATIVE_X"); _NEGATIVE_XReady = true; } return _NEGATIVE_XContent; } }
            private static Android.Renderscript.Type.CubemapFace _NEGATIVE_XContent = default;
            private static bool _NEGATIVE_XReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#NEGATIVE_Y"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace NEGATIVE_Y { get { if (!_NEGATIVE_YReady) { _NEGATIVE_YContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "NEGATIVE_Y"); _NEGATIVE_YReady = true; } return _NEGATIVE_YContent; } }
            private static Android.Renderscript.Type.CubemapFace _NEGATIVE_YContent = default;
            private static bool _NEGATIVE_YReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#NEGATIVE_Z"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace NEGATIVE_Z { get { if (!_NEGATIVE_ZReady) { _NEGATIVE_ZContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "NEGATIVE_Z"); _NEGATIVE_ZReady = true; } return _NEGATIVE_ZContent; } }
            private static Android.Renderscript.Type.CubemapFace _NEGATIVE_ZContent = default;
            private static bool _NEGATIVE_ZReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITIVE_X"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITIVE_X { get { if (!_POSITIVE_XReady) { _POSITIVE_XContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITIVE_X"); _POSITIVE_XReady = true; } return _POSITIVE_XContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITIVE_XContent = default;
            private static bool _POSITIVE_XReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITIVE_Y"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITIVE_Y { get { if (!_POSITIVE_YReady) { _POSITIVE_YContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITIVE_Y"); _POSITIVE_YReady = true; } return _POSITIVE_YContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITIVE_YContent = default;
            private static bool _POSITIVE_YReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITIVE_Z"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITIVE_Z { get { if (!_POSITIVE_ZReady) { _POSITIVE_ZContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITIVE_Z"); _POSITIVE_ZReady = true; } return _POSITIVE_ZContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITIVE_ZContent = default;
            private static bool _POSITIVE_ZReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITVE_X"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITVE_X { get { if (!_POSITVE_XReady) { _POSITVE_XContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITVE_X"); _POSITVE_XReady = true; } return _POSITVE_XContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITVE_XContent = default;
            private static bool _POSITVE_XReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITVE_Y"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITVE_Y { get { if (!_POSITVE_YReady) { _POSITVE_YContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITVE_Y"); _POSITVE_YReady = true; } return _POSITVE_YContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITVE_YContent = default;
            private static bool _POSITVE_YReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#POSITVE_Z"/>
            /// </summary>
            [global::System.Obsolete()]
            public static Android.Renderscript.Type.CubemapFace POSITVE_Z { get { if (!_POSITVE_ZReady) { _POSITVE_ZContent = SGetField<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "POSITVE_Z"); _POSITVE_ZReady = true; } return _POSITVE_ZContent; } }
            private static Android.Renderscript.Type.CubemapFace _POSITVE_ZContent = default;
            private static bool _POSITVE_ZReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Renderscript.Type.CubemapFace"/></returns>
            public static Android.Renderscript.Type.CubemapFace ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Landroid/renderscript/Type$CubemapFace;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/renderscript/Type.CubemapFace.html#values()"/>
            /// </summary>
            /// <returns><see cref="Android.Renderscript.Type.CubemapFace"/></returns>
            public static Android.Renderscript.Type.CubemapFace[] Values()
            {
                return SExecuteWithSignatureArray<Android.Renderscript.Type.CubemapFace>(LocalBridgeClazz, "values", "()[Landroid/renderscript/Type$CubemapFace;");
            }

            #endregion

            #region Instance methods

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