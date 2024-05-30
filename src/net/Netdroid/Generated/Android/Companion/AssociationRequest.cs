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

namespace Android.Companion
{
    #region AssociationRequest
    public partial class AssociationRequest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_APP_STREAMING"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_APP_STREAMING { get { if (!_DEVICE_PROFILE_APP_STREAMINGReady) { _DEVICE_PROFILE_APP_STREAMINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_APP_STREAMING"); _DEVICE_PROFILE_APP_STREAMINGReady = true; } return _DEVICE_PROFILE_APP_STREAMINGContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_APP_STREAMINGContent = default;
        private static bool _DEVICE_PROFILE_APP_STREAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_AUTOMOTIVE_PROJECTION"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_AUTOMOTIVE_PROJECTION { get { if (!_DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONReady) { _DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_AUTOMOTIVE_PROJECTION"); _DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONReady = true; } return _DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONContent = default;
        private static bool _DEVICE_PROFILE_AUTOMOTIVE_PROJECTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_COMPUTER"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_COMPUTER { get { if (!_DEVICE_PROFILE_COMPUTERReady) { _DEVICE_PROFILE_COMPUTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_COMPUTER"); _DEVICE_PROFILE_COMPUTERReady = true; } return _DEVICE_PROFILE_COMPUTERContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_COMPUTERContent = default;
        private static bool _DEVICE_PROFILE_COMPUTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_GLASSES"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_GLASSES { get { if (!_DEVICE_PROFILE_GLASSESReady) { _DEVICE_PROFILE_GLASSESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_GLASSES"); _DEVICE_PROFILE_GLASSESReady = true; } return _DEVICE_PROFILE_GLASSESContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_GLASSESContent = default;
        private static bool _DEVICE_PROFILE_GLASSESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_NEARBY_DEVICE_STREAMING"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_NEARBY_DEVICE_STREAMING { get { if (!_DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGReady) { _DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_NEARBY_DEVICE_STREAMING"); _DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGReady = true; } return _DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGContent = default;
        private static bool _DEVICE_PROFILE_NEARBY_DEVICE_STREAMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#DEVICE_PROFILE_WATCH"/>
        /// </summary>
        public static Java.Lang.String DEVICE_PROFILE_WATCH { get { if (!_DEVICE_PROFILE_WATCHReady) { _DEVICE_PROFILE_WATCHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEVICE_PROFILE_WATCH"); _DEVICE_PROFILE_WATCHReady = true; } return _DEVICE_PROFILE_WATCHContent; } }
        private static Java.Lang.String _DEVICE_PROFILE_WATCHContent = default;
        private static bool _DEVICE_PROFILE_WATCHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#getDeviceProfile()"/> 
        /// </summary>
        public Java.Lang.String DeviceProfile
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDeviceProfile", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#getDisplayName()"/> 
        /// </summary>
        public Java.Lang.CharSequence DisplayName
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getDisplayName", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#isForceConfirmation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsForceConfirmation()
        {
            return IExecuteWithSignature<bool>("isForceConfirmation", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#isSelfManaged()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelfManaged()
        {
            return IExecuteWithSignature<bool>("isSelfManaged", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#isSingleDevice()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSingleDevice()
        {
            return IExecuteWithSignature<bool>("isSingleDevice", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Builder
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
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Companion.AssociationRequest"/></returns>
            public Android.Companion.AssociationRequest Build()
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest>("build", "()Landroid/companion/AssociationRequest;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#addDeviceFilter(android.companion.DeviceFilter)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Companion.DeviceFilter"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder AddDeviceFilter(Android.Companion.DeviceFilter arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("addDeviceFilter", "(Landroid/companion/DeviceFilter;)Landroid/companion/AssociationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#setDeviceProfile(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder SetDeviceProfile(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("setDeviceProfile", "(Ljava/lang/String;)Landroid/companion/AssociationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#setDisplayName(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder SetDisplayName(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("setDisplayName", "(Ljava/lang/CharSequence;)Landroid/companion/AssociationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#setForceConfirmation(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder SetForceConfirmation(bool arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("setForceConfirmation", "(Z)Landroid/companion/AssociationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#setSelfManaged(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder SetSelfManaged(bool arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("setSelfManaged", "(Z)Landroid/companion/AssociationRequest$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/companion/AssociationRequest.Builder.html#setSingleDevice(boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <returns><see cref="Android.Companion.AssociationRequest.Builder"/></returns>
            public Android.Companion.AssociationRequest.Builder SetSingleDevice(bool arg0)
            {
                return IExecuteWithSignature<Android.Companion.AssociationRequest.Builder>("setSingleDevice", "(Z)Landroid/companion/AssociationRequest$Builder;", arg0);
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