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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Annotation
{
    #region RetentionPolicy
    public partial class RetentionPolicy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/annotation/RetentionPolicy.html#CLASS"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy CLASS { get { if (!_CLASSReady) { _CLASSContent = SGetField<Java.Lang.Annotation.RetentionPolicy>(LocalBridgeClazz, "CLASS"); _CLASSReady = true; } return _CLASSContent; } }
        private static Java.Lang.Annotation.RetentionPolicy _CLASSContent = default;
        private static bool _CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/annotation/RetentionPolicy.html#RUNTIME"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy RUNTIME { get { if (!_RUNTIMEReady) { _RUNTIMEContent = SGetField<Java.Lang.Annotation.RetentionPolicy>(LocalBridgeClazz, "RUNTIME"); _RUNTIMEReady = true; } return _RUNTIMEContent; } }
        private static Java.Lang.Annotation.RetentionPolicy _RUNTIMEContent = default;
        private static bool _RUNTIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/annotation/RetentionPolicy.html#SOURCE"/>
        /// </summary>
        public static Java.Lang.Annotation.RetentionPolicy SOURCE { get { if (!_SOURCEReady) { _SOURCEContent = SGetField<Java.Lang.Annotation.RetentionPolicy>(LocalBridgeClazz, "SOURCE"); _SOURCEReady = true; } return _SOURCEContent; } }
        private static Java.Lang.Annotation.RetentionPolicy _SOURCEContent = default;
        private static bool _SOURCEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/annotation/RetentionPolicy.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Annotation.RetentionPolicy"/></returns>
        public static Java.Lang.Annotation.RetentionPolicy ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Annotation.RetentionPolicy>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/annotation/RetentionPolicy.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.RetentionPolicy"/></returns>
        public static Java.Lang.Annotation.RetentionPolicy[] Values()
        {
            return SExecuteWithSignatureArray<Java.Lang.Annotation.RetentionPolicy>(LocalBridgeClazz, "values", "()[Ljava/lang/annotation/RetentionPolicy;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}