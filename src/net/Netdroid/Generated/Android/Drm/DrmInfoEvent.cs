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

namespace Android.Drm
{
    #region DrmInfoEvent
    public partial class DrmInfoEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#%3Cinit%3E(int,int,java.lang.String,java.util.HashMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Util.HashMap"/></param>
        [global::System.Obsolete()]
        public DrmInfoEvent(int arg0, int arg1, Java.Lang.String arg2, Java.Util.HashMap<Java.Lang.String, object> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#%3Cinit%3E(int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public DrmInfoEvent(int arg0, int arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_ACCOUNT_ALREADY_REGISTERED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_ACCOUNT_ALREADY_REGISTERED { get { if (!_TYPE_ACCOUNT_ALREADY_REGISTEREDReady) { _TYPE_ACCOUNT_ALREADY_REGISTEREDContent = SGetField<int>(LocalBridgeClazz, "TYPE_ACCOUNT_ALREADY_REGISTERED"); _TYPE_ACCOUNT_ALREADY_REGISTEREDReady = true; } return _TYPE_ACCOUNT_ALREADY_REGISTEREDContent; } }
        private static int _TYPE_ACCOUNT_ALREADY_REGISTEREDContent = default;
        private static bool _TYPE_ACCOUNT_ALREADY_REGISTEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT { get { if (!_TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTReady) { _TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTContent = SGetField<int>(LocalBridgeClazz, "TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNT"); _TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTReady = true; } return _TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTContent; } }
        private static int _TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTContent = default;
        private static bool _TYPE_ALREADY_REGISTERED_BY_ANOTHER_ACCOUNTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_REMOVE_RIGHTS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_REMOVE_RIGHTS { get { if (!_TYPE_REMOVE_RIGHTSReady) { _TYPE_REMOVE_RIGHTSContent = SGetField<int>(LocalBridgeClazz, "TYPE_REMOVE_RIGHTS"); _TYPE_REMOVE_RIGHTSReady = true; } return _TYPE_REMOVE_RIGHTSContent; } }
        private static int _TYPE_REMOVE_RIGHTSContent = default;
        private static bool _TYPE_REMOVE_RIGHTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_RIGHTS_INSTALLED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_RIGHTS_INSTALLED { get { if (!_TYPE_RIGHTS_INSTALLEDReady) { _TYPE_RIGHTS_INSTALLEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_INSTALLED"); _TYPE_RIGHTS_INSTALLEDReady = true; } return _TYPE_RIGHTS_INSTALLEDContent; } }
        private static int _TYPE_RIGHTS_INSTALLEDContent = default;
        private static bool _TYPE_RIGHTS_INSTALLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_RIGHTS_REMOVED"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_RIGHTS_REMOVED { get { if (!_TYPE_RIGHTS_REMOVEDReady) { _TYPE_RIGHTS_REMOVEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_RIGHTS_REMOVED"); _TYPE_RIGHTS_REMOVEDReady = true; } return _TYPE_RIGHTS_REMOVEDContent; } }
        private static int _TYPE_RIGHTS_REMOVEDContent = default;
        private static bool _TYPE_RIGHTS_REMOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/drm/DrmInfoEvent.html#TYPE_WAIT_FOR_RIGHTS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int TYPE_WAIT_FOR_RIGHTS { get { if (!_TYPE_WAIT_FOR_RIGHTSReady) { _TYPE_WAIT_FOR_RIGHTSContent = SGetField<int>(LocalBridgeClazz, "TYPE_WAIT_FOR_RIGHTS"); _TYPE_WAIT_FOR_RIGHTSReady = true; } return _TYPE_WAIT_FOR_RIGHTSContent; } }
        private static int _TYPE_WAIT_FOR_RIGHTSContent = default;
        private static bool _TYPE_WAIT_FOR_RIGHTSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}