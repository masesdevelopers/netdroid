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

namespace Android.Drm
{
    #region DrmSupportInfo
    public partial class DrmSupportInfo
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
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#getDescriprition()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Descriprition
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescriprition", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#getDescription()"/> <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#setDescription(java.lang.String)"/>
        /// </summary>
        [System.Obsolete()]
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDescription", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#getFileSuffixIterator()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Util.Iterator<Java.Lang.String> FileSuffixIterator
        {
            get { return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("getFileSuffixIterator", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#getMimeTypeIterator()"/> 
        /// </summary>
        [System.Obsolete()]
        public Java.Util.Iterator<Java.Lang.String> MimeTypeIterator
        {
            get { return IExecuteWithSignature<Java.Util.Iterator<Java.Lang.String>>("getMimeTypeIterator", "()Ljava/util/Iterator;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#addFileSuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public void AddFileSuffix(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addFileSuffix", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmSupportInfo.html#addMimeType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [System.Obsolete()]
        public void AddMimeType(Java.Lang.String arg0)
        {
            IExecuteWithSignature("addMimeType", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}