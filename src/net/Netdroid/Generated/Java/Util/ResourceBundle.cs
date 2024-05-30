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

namespace Java.Util
{
    #region ResourceBundle
    public partial class ResourceBundle
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Util.ResourceBundle.Control arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.ResourceBundle.Control arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#clearCache()"/>
        /// </summary>
        public static void ClearCache()
        {
            SExecuteWithSignature(LocalBridgeClazz, "clearCache", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#clearCache(java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ClassLoader"/></param>
        public static void ClearCache(Java.Lang.ClassLoader arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "clearCache", "(Ljava/lang/ClassLoader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Lang.Module arg1)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.ClassLoader,java.util.ResourceBundle.Control)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg3"><see cref="Java.Util.ResourceBundle.Control"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Lang.ClassLoader arg2, Java.Util.ResourceBundle.Control arg3)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBundle(java.lang.String,java.util.Locale,java.lang.Module)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Module"/></param>
        /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
        public static Java.Util.ResourceBundle GetBundle(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Lang.Module arg2)
        {
            return SExecute<Java.Util.ResourceBundle>(LocalBridgeClazz, "getBundle", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getBaseBundleName()"/> 
        /// </summary>
        public Java.Lang.String BaseBundleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBaseBundleName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getKeys()"/> 
        /// </summary>
        public Java.Util.Enumeration<Java.Lang.String> Keys
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getKeys", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#containsKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("containsKey", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getObject(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetObject(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getObject", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#getStringArray(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetStringArray(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("keySet", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes
        #region Control
        public partial class Control
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#FORMAT_CLASS"/>
            /// </summary>
            public static Java.Util.List FORMAT_CLASS { get { if (!_FORMAT_CLASSReady) { _FORMAT_CLASSContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_CLASS"); _FORMAT_CLASSReady = true; } return _FORMAT_CLASSContent; } }
            private static Java.Util.List _FORMAT_CLASSContent = default;
            private static bool _FORMAT_CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#FORMAT_DEFAULT"/>
            /// </summary>
            public static Java.Util.List FORMAT_DEFAULT { get { if (!_FORMAT_DEFAULTReady) { _FORMAT_DEFAULTContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_DEFAULT"); _FORMAT_DEFAULTReady = true; } return _FORMAT_DEFAULTContent; } }
            private static Java.Util.List _FORMAT_DEFAULTContent = default;
            private static bool _FORMAT_DEFAULTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#FORMAT_PROPERTIES"/>
            /// </summary>
            public static Java.Util.List FORMAT_PROPERTIES { get { if (!_FORMAT_PROPERTIESReady) { _FORMAT_PROPERTIESContent = SGetField<Java.Util.List>(LocalBridgeClazz, "FORMAT_PROPERTIES"); _FORMAT_PROPERTIESReady = true; } return _FORMAT_PROPERTIESContent; } }
            private static Java.Util.List _FORMAT_PROPERTIESContent = default;
            private static bool _FORMAT_PROPERTIESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#TTL_DONT_CACHE"/>
            /// </summary>
            public static long TTL_DONT_CACHE { get { if (!_TTL_DONT_CACHEReady) { _TTL_DONT_CACHEContent = SGetField<long>(LocalBridgeClazz, "TTL_DONT_CACHE"); _TTL_DONT_CACHEReady = true; } return _TTL_DONT_CACHEContent; } }
            private static long _TTL_DONT_CACHEContent = default;
            private static bool _TTL_DONT_CACHEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#TTL_NO_EXPIRATION_CONTROL"/>
            /// </summary>
            public static long TTL_NO_EXPIRATION_CONTROL { get { if (!_TTL_NO_EXPIRATION_CONTROLReady) { _TTL_NO_EXPIRATION_CONTROLContent = SGetField<long>(LocalBridgeClazz, "TTL_NO_EXPIRATION_CONTROL"); _TTL_NO_EXPIRATION_CONTROLReady = true; } return _TTL_NO_EXPIRATION_CONTROLContent; } }
            private static long _TTL_NO_EXPIRATION_CONTROLContent = default;
            private static bool _TTL_NO_EXPIRATION_CONTROLReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getControl(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle.Control"/></returns>
            public static Java.Util.ResourceBundle.Control GetControl(Java.Util.List<Java.Lang.String> arg0)
            {
                return SExecuteWithSignature<Java.Util.ResourceBundle.Control>(LocalBridgeClazz, "getControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getNoFallbackControl(java.util.List)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.List"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle.Control"/></returns>
            public static Java.Util.ResourceBundle.Control GetNoFallbackControl(Java.Util.List<Java.Lang.String> arg0)
            {
                return SExecuteWithSignature<Java.Util.ResourceBundle.Control>(LocalBridgeClazz, "getNoFallbackControl", "(Ljava/util/List;)Ljava/util/ResourceBundle$Control;", arg0);
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#needsReload(java.lang.String,java.util.Locale,java.lang.String,java.lang.ClassLoader,java.util.ResourceBundle,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.ClassLoader"/></param>
            /// <param name="arg4"><see cref="Java.Util.ResourceBundle"/></param>
            /// <param name="arg5"><see cref="long"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool NeedsReload(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Lang.String arg2, Java.Lang.ClassLoader arg3, Java.Util.ResourceBundle arg4, long arg5)
            {
                return IExecute<bool>("needsReload", arg0, arg1, arg2, arg3, arg4, arg5);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#toResourceName(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ToResourceName(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecute<Java.Lang.String>("toResourceName", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#toBundleName(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String ToBundleName(Java.Lang.String arg0, Java.Util.Locale arg1)
            {
                return IExecute<Java.Lang.String>("toBundleName", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getFormats(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Lang.String> GetFormats(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getFormats", "(Ljava/lang/String;)Ljava/util/List;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getCandidateLocales(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="Java.Util.List"/></returns>
            public Java.Util.List<Java.Util.Locale> GetCandidateLocales(Java.Lang.String arg0, Java.Util.Locale arg1)
            {
                return IExecute<Java.Util.List<Java.Util.Locale>>("getCandidateLocales", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getFallbackLocale(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="Java.Util.Locale"/></returns>
            public Java.Util.Locale GetFallbackLocale(Java.Lang.String arg0, Java.Util.Locale arg1)
            {
                return IExecute<Java.Util.Locale>("getFallbackLocale", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#newBundle(java.lang.String,java.util.Locale,java.lang.String,java.lang.ClassLoader,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <param name="arg2"><see cref="Java.Lang.String"/></param>
            /// <param name="arg3"><see cref="Java.Lang.ClassLoader"/></param>
            /// <param name="arg4"><see cref="bool"/></param>
            /// <returns><see cref="Java.Util.ResourceBundle"/></returns>
            /// <exception cref="Java.Lang.IllegalAccessException"/>
            /// <exception cref="Java.Lang.InstantiationException"/>
            /// <exception cref="Java.Io.IOException"/>
            public Java.Util.ResourceBundle NewBundle(Java.Lang.String arg0, Java.Util.Locale arg1, Java.Lang.String arg2, Java.Lang.ClassLoader arg3, bool arg4)
            {
                return IExecute<Java.Util.ResourceBundle>("newBundle", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/java.base/java/util/ResourceBundle.Control.html#getTimeToLive(java.lang.String,java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
            /// <returns><see cref="long"/></returns>
            public long GetTimeToLive(Java.Lang.String arg0, Java.Util.Locale arg1)
            {
                return IExecute<long>("getTimeToLive", arg0, arg1);
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