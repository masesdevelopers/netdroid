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

namespace Android.Media.Metrics
{
    #region PlaybackErrorEvent
    public partial class PlaybackErrorEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Media.Metrics.PlaybackErrorEvent"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Media.Metrics.PlaybackErrorEvent t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_AUDIO_TRACK_INIT_FAILED"/>
        /// </summary>
        public static int ERROR_AUDIO_TRACK_INIT_FAILED { get { if (!_ERROR_AUDIO_TRACK_INIT_FAILEDReady) { _ERROR_AUDIO_TRACK_INIT_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_AUDIO_TRACK_INIT_FAILED"); _ERROR_AUDIO_TRACK_INIT_FAILEDReady = true; } return _ERROR_AUDIO_TRACK_INIT_FAILEDContent; } }
        private static int _ERROR_AUDIO_TRACK_INIT_FAILEDContent = default;
        private static bool _ERROR_AUDIO_TRACK_INIT_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_AUDIO_TRACK_OTHER"/>
        /// </summary>
        public static int ERROR_AUDIO_TRACK_OTHER { get { if (!_ERROR_AUDIO_TRACK_OTHERReady) { _ERROR_AUDIO_TRACK_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_AUDIO_TRACK_OTHER"); _ERROR_AUDIO_TRACK_OTHERReady = true; } return _ERROR_AUDIO_TRACK_OTHERContent; } }
        private static int _ERROR_AUDIO_TRACK_OTHERContent = default;
        private static bool _ERROR_AUDIO_TRACK_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_AUDIO_TRACK_WRITE_FAILED"/>
        /// </summary>
        public static int ERROR_AUDIO_TRACK_WRITE_FAILED { get { if (!_ERROR_AUDIO_TRACK_WRITE_FAILEDReady) { _ERROR_AUDIO_TRACK_WRITE_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_AUDIO_TRACK_WRITE_FAILED"); _ERROR_AUDIO_TRACK_WRITE_FAILEDReady = true; } return _ERROR_AUDIO_TRACK_WRITE_FAILEDContent; } }
        private static int _ERROR_AUDIO_TRACK_WRITE_FAILEDContent = default;
        private static bool _ERROR_AUDIO_TRACK_WRITE_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DECODER_INIT_FAILED"/>
        /// </summary>
        public static int ERROR_DECODER_INIT_FAILED { get { if (!_ERROR_DECODER_INIT_FAILEDReady) { _ERROR_DECODER_INIT_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DECODER_INIT_FAILED"); _ERROR_DECODER_INIT_FAILEDReady = true; } return _ERROR_DECODER_INIT_FAILEDContent; } }
        private static int _ERROR_DECODER_INIT_FAILEDContent = default;
        private static bool _ERROR_DECODER_INIT_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DECODING_FAILED"/>
        /// </summary>
        public static int ERROR_DECODING_FAILED { get { if (!_ERROR_DECODING_FAILEDReady) { _ERROR_DECODING_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DECODING_FAILED"); _ERROR_DECODING_FAILEDReady = true; } return _ERROR_DECODING_FAILEDContent; } }
        private static int _ERROR_DECODING_FAILEDContent = default;
        private static bool _ERROR_DECODING_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIES"/>
        /// </summary>
        public static int ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIES { get { if (!_ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESReady) { _ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESContent = SGetField<int>(LocalBridgeClazz, "ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIES"); _ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESReady = true; } return _ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESContent; } }
        private static int _ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESContent = default;
        private static bool _ERROR_DECODING_FORMAT_EXCEEDS_CAPABILITIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DECODING_FORMAT_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_DECODING_FORMAT_UNSUPPORTED { get { if (!_ERROR_DECODING_FORMAT_UNSUPPORTEDReady) { _ERROR_DECODING_FORMAT_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DECODING_FORMAT_UNSUPPORTED"); _ERROR_DECODING_FORMAT_UNSUPPORTEDReady = true; } return _ERROR_DECODING_FORMAT_UNSUPPORTEDContent; } }
        private static int _ERROR_DECODING_FORMAT_UNSUPPORTEDContent = default;
        private static bool _ERROR_DECODING_FORMAT_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DECODING_OTHER"/>
        /// </summary>
        public static int ERROR_DECODING_OTHER { get { if (!_ERROR_DECODING_OTHERReady) { _ERROR_DECODING_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_DECODING_OTHER"); _ERROR_DECODING_OTHERReady = true; } return _ERROR_DECODING_OTHERContent; } }
        private static int _ERROR_DECODING_OTHERContent = default;
        private static bool _ERROR_DECODING_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_CONTENT_ERROR"/>
        /// </summary>
        public static int ERROR_DRM_CONTENT_ERROR { get { if (!_ERROR_DRM_CONTENT_ERRORReady) { _ERROR_DRM_CONTENT_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_CONTENT_ERROR"); _ERROR_DRM_CONTENT_ERRORReady = true; } return _ERROR_DRM_CONTENT_ERRORContent; } }
        private static int _ERROR_DRM_CONTENT_ERRORContent = default;
        private static bool _ERROR_DRM_CONTENT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_DEVICE_REVOKED"/>
        /// </summary>
        public static int ERROR_DRM_DEVICE_REVOKED { get { if (!_ERROR_DRM_DEVICE_REVOKEDReady) { _ERROR_DRM_DEVICE_REVOKEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_DEVICE_REVOKED"); _ERROR_DRM_DEVICE_REVOKEDReady = true; } return _ERROR_DRM_DEVICE_REVOKEDContent; } }
        private static int _ERROR_DRM_DEVICE_REVOKEDContent = default;
        private static bool _ERROR_DRM_DEVICE_REVOKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_DISALLOWED_OPERATION"/>
        /// </summary>
        public static int ERROR_DRM_DISALLOWED_OPERATION { get { if (!_ERROR_DRM_DISALLOWED_OPERATIONReady) { _ERROR_DRM_DISALLOWED_OPERATIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_DISALLOWED_OPERATION"); _ERROR_DRM_DISALLOWED_OPERATIONReady = true; } return _ERROR_DRM_DISALLOWED_OPERATIONContent; } }
        private static int _ERROR_DRM_DISALLOWED_OPERATIONContent = default;
        private static bool _ERROR_DRM_DISALLOWED_OPERATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_LICENSE_ACQUISITION_FAILED"/>
        /// </summary>
        public static int ERROR_DRM_LICENSE_ACQUISITION_FAILED { get { if (!_ERROR_DRM_LICENSE_ACQUISITION_FAILEDReady) { _ERROR_DRM_LICENSE_ACQUISITION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_LICENSE_ACQUISITION_FAILED"); _ERROR_DRM_LICENSE_ACQUISITION_FAILEDReady = true; } return _ERROR_DRM_LICENSE_ACQUISITION_FAILEDContent; } }
        private static int _ERROR_DRM_LICENSE_ACQUISITION_FAILEDContent = default;
        private static bool _ERROR_DRM_LICENSE_ACQUISITION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_OTHER"/>
        /// </summary>
        public static int ERROR_DRM_OTHER { get { if (!_ERROR_DRM_OTHERReady) { _ERROR_DRM_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_OTHER"); _ERROR_DRM_OTHERReady = true; } return _ERROR_DRM_OTHERContent; } }
        private static int _ERROR_DRM_OTHERContent = default;
        private static bool _ERROR_DRM_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_PROVISIONING_FAILED"/>
        /// </summary>
        public static int ERROR_DRM_PROVISIONING_FAILED { get { if (!_ERROR_DRM_PROVISIONING_FAILEDReady) { _ERROR_DRM_PROVISIONING_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_PROVISIONING_FAILED"); _ERROR_DRM_PROVISIONING_FAILEDReady = true; } return _ERROR_DRM_PROVISIONING_FAILEDContent; } }
        private static int _ERROR_DRM_PROVISIONING_FAILEDContent = default;
        private static bool _ERROR_DRM_PROVISIONING_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_SCHEME_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_DRM_SCHEME_UNSUPPORTED { get { if (!_ERROR_DRM_SCHEME_UNSUPPORTEDReady) { _ERROR_DRM_SCHEME_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_SCHEME_UNSUPPORTED"); _ERROR_DRM_SCHEME_UNSUPPORTEDReady = true; } return _ERROR_DRM_SCHEME_UNSUPPORTEDContent; } }
        private static int _ERROR_DRM_SCHEME_UNSUPPORTEDContent = default;
        private static bool _ERROR_DRM_SCHEME_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_DRM_SYSTEM_ERROR"/>
        /// </summary>
        public static int ERROR_DRM_SYSTEM_ERROR { get { if (!_ERROR_DRM_SYSTEM_ERRORReady) { _ERROR_DRM_SYSTEM_ERRORContent = SGetField<int>(LocalBridgeClazz, "ERROR_DRM_SYSTEM_ERROR"); _ERROR_DRM_SYSTEM_ERRORReady = true; } return _ERROR_DRM_SYSTEM_ERRORContent; } }
        private static int _ERROR_DRM_SYSTEM_ERRORContent = default;
        private static bool _ERROR_DRM_SYSTEM_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_BAD_HTTP_STATUS"/>
        /// </summary>
        public static int ERROR_IO_BAD_HTTP_STATUS { get { if (!_ERROR_IO_BAD_HTTP_STATUSReady) { _ERROR_IO_BAD_HTTP_STATUSContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_BAD_HTTP_STATUS"); _ERROR_IO_BAD_HTTP_STATUSReady = true; } return _ERROR_IO_BAD_HTTP_STATUSContent; } }
        private static int _ERROR_IO_BAD_HTTP_STATUSContent = default;
        private static bool _ERROR_IO_BAD_HTTP_STATUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_CONNECTION_CLOSED"/>
        /// </summary>
        public static int ERROR_IO_CONNECTION_CLOSED { get { if (!_ERROR_IO_CONNECTION_CLOSEDReady) { _ERROR_IO_CONNECTION_CLOSEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_CONNECTION_CLOSED"); _ERROR_IO_CONNECTION_CLOSEDReady = true; } return _ERROR_IO_CONNECTION_CLOSEDContent; } }
        private static int _ERROR_IO_CONNECTION_CLOSEDContent = default;
        private static bool _ERROR_IO_CONNECTION_CLOSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_CONNECTION_TIMEOUT"/>
        /// </summary>
        public static int ERROR_IO_CONNECTION_TIMEOUT { get { if (!_ERROR_IO_CONNECTION_TIMEOUTReady) { _ERROR_IO_CONNECTION_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_CONNECTION_TIMEOUT"); _ERROR_IO_CONNECTION_TIMEOUTReady = true; } return _ERROR_IO_CONNECTION_TIMEOUTContent; } }
        private static int _ERROR_IO_CONNECTION_TIMEOUTContent = default;
        private static bool _ERROR_IO_CONNECTION_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_DNS_FAILED"/>
        /// </summary>
        public static int ERROR_IO_DNS_FAILED { get { if (!_ERROR_IO_DNS_FAILEDReady) { _ERROR_IO_DNS_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_DNS_FAILED"); _ERROR_IO_DNS_FAILEDReady = true; } return _ERROR_IO_DNS_FAILEDContent; } }
        private static int _ERROR_IO_DNS_FAILEDContent = default;
        private static bool _ERROR_IO_DNS_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_FILE_NOT_FOUND"/>
        /// </summary>
        public static int ERROR_IO_FILE_NOT_FOUND { get { if (!_ERROR_IO_FILE_NOT_FOUNDReady) { _ERROR_IO_FILE_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_FILE_NOT_FOUND"); _ERROR_IO_FILE_NOT_FOUNDReady = true; } return _ERROR_IO_FILE_NOT_FOUNDContent; } }
        private static int _ERROR_IO_FILE_NOT_FOUNDContent = default;
        private static bool _ERROR_IO_FILE_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_NETWORK_CONNECTION_FAILED"/>
        /// </summary>
        public static int ERROR_IO_NETWORK_CONNECTION_FAILED { get { if (!_ERROR_IO_NETWORK_CONNECTION_FAILEDReady) { _ERROR_IO_NETWORK_CONNECTION_FAILEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_NETWORK_CONNECTION_FAILED"); _ERROR_IO_NETWORK_CONNECTION_FAILEDReady = true; } return _ERROR_IO_NETWORK_CONNECTION_FAILEDContent; } }
        private static int _ERROR_IO_NETWORK_CONNECTION_FAILEDContent = default;
        private static bool _ERROR_IO_NETWORK_CONNECTION_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_NETWORK_UNAVAILABLE"/>
        /// </summary>
        public static int ERROR_IO_NETWORK_UNAVAILABLE { get { if (!_ERROR_IO_NETWORK_UNAVAILABLEReady) { _ERROR_IO_NETWORK_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_NETWORK_UNAVAILABLE"); _ERROR_IO_NETWORK_UNAVAILABLEReady = true; } return _ERROR_IO_NETWORK_UNAVAILABLEContent; } }
        private static int _ERROR_IO_NETWORK_UNAVAILABLEContent = default;
        private static bool _ERROR_IO_NETWORK_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_NO_PERMISSION"/>
        /// </summary>
        public static int ERROR_IO_NO_PERMISSION { get { if (!_ERROR_IO_NO_PERMISSIONReady) { _ERROR_IO_NO_PERMISSIONContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_NO_PERMISSION"); _ERROR_IO_NO_PERMISSIONReady = true; } return _ERROR_IO_NO_PERMISSIONContent; } }
        private static int _ERROR_IO_NO_PERMISSIONContent = default;
        private static bool _ERROR_IO_NO_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_IO_OTHER"/>
        /// </summary>
        public static int ERROR_IO_OTHER { get { if (!_ERROR_IO_OTHERReady) { _ERROR_IO_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_IO_OTHER"); _ERROR_IO_OTHERReady = true; } return _ERROR_IO_OTHERContent; } }
        private static int _ERROR_IO_OTHERContent = default;
        private static bool _ERROR_IO_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_OTHER"/>
        /// </summary>
        public static int ERROR_OTHER { get { if (!_ERROR_OTHERReady) { _ERROR_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_OTHER"); _ERROR_OTHERReady = true; } return _ERROR_OTHERContent; } }
        private static int _ERROR_OTHERContent = default;
        private static bool _ERROR_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PARSING_CONTAINER_MALFORMED"/>
        /// </summary>
        public static int ERROR_PARSING_CONTAINER_MALFORMED { get { if (!_ERROR_PARSING_CONTAINER_MALFORMEDReady) { _ERROR_PARSING_CONTAINER_MALFORMEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSING_CONTAINER_MALFORMED"); _ERROR_PARSING_CONTAINER_MALFORMEDReady = true; } return _ERROR_PARSING_CONTAINER_MALFORMEDContent; } }
        private static int _ERROR_PARSING_CONTAINER_MALFORMEDContent = default;
        private static bool _ERROR_PARSING_CONTAINER_MALFORMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PARSING_CONTAINER_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_PARSING_CONTAINER_UNSUPPORTED { get { if (!_ERROR_PARSING_CONTAINER_UNSUPPORTEDReady) { _ERROR_PARSING_CONTAINER_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSING_CONTAINER_UNSUPPORTED"); _ERROR_PARSING_CONTAINER_UNSUPPORTEDReady = true; } return _ERROR_PARSING_CONTAINER_UNSUPPORTEDContent; } }
        private static int _ERROR_PARSING_CONTAINER_UNSUPPORTEDContent = default;
        private static bool _ERROR_PARSING_CONTAINER_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PARSING_MANIFEST_MALFORMED"/>
        /// </summary>
        public static int ERROR_PARSING_MANIFEST_MALFORMED { get { if (!_ERROR_PARSING_MANIFEST_MALFORMEDReady) { _ERROR_PARSING_MANIFEST_MALFORMEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSING_MANIFEST_MALFORMED"); _ERROR_PARSING_MANIFEST_MALFORMEDReady = true; } return _ERROR_PARSING_MANIFEST_MALFORMEDContent; } }
        private static int _ERROR_PARSING_MANIFEST_MALFORMEDContent = default;
        private static bool _ERROR_PARSING_MANIFEST_MALFORMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PARSING_MANIFEST_UNSUPPORTED"/>
        /// </summary>
        public static int ERROR_PARSING_MANIFEST_UNSUPPORTED { get { if (!_ERROR_PARSING_MANIFEST_UNSUPPORTEDReady) { _ERROR_PARSING_MANIFEST_UNSUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSING_MANIFEST_UNSUPPORTED"); _ERROR_PARSING_MANIFEST_UNSUPPORTEDReady = true; } return _ERROR_PARSING_MANIFEST_UNSUPPORTEDContent; } }
        private static int _ERROR_PARSING_MANIFEST_UNSUPPORTEDContent = default;
        private static bool _ERROR_PARSING_MANIFEST_UNSUPPORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PARSING_OTHER"/>
        /// </summary>
        public static int ERROR_PARSING_OTHER { get { if (!_ERROR_PARSING_OTHERReady) { _ERROR_PARSING_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_PARSING_OTHER"); _ERROR_PARSING_OTHERReady = true; } return _ERROR_PARSING_OTHERContent; } }
        private static int _ERROR_PARSING_OTHERContent = default;
        private static bool _ERROR_PARSING_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PLAYER_BEHIND_LIVE_WINDOW"/>
        /// </summary>
        public static int ERROR_PLAYER_BEHIND_LIVE_WINDOW { get { if (!_ERROR_PLAYER_BEHIND_LIVE_WINDOWReady) { _ERROR_PLAYER_BEHIND_LIVE_WINDOWContent = SGetField<int>(LocalBridgeClazz, "ERROR_PLAYER_BEHIND_LIVE_WINDOW"); _ERROR_PLAYER_BEHIND_LIVE_WINDOWReady = true; } return _ERROR_PLAYER_BEHIND_LIVE_WINDOWContent; } }
        private static int _ERROR_PLAYER_BEHIND_LIVE_WINDOWContent = default;
        private static bool _ERROR_PLAYER_BEHIND_LIVE_WINDOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PLAYER_OTHER"/>
        /// </summary>
        public static int ERROR_PLAYER_OTHER { get { if (!_ERROR_PLAYER_OTHERReady) { _ERROR_PLAYER_OTHERContent = SGetField<int>(LocalBridgeClazz, "ERROR_PLAYER_OTHER"); _ERROR_PLAYER_OTHERReady = true; } return _ERROR_PLAYER_OTHERContent; } }
        private static int _ERROR_PLAYER_OTHERContent = default;
        private static bool _ERROR_PLAYER_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_PLAYER_REMOTE"/>
        /// </summary>
        public static int ERROR_PLAYER_REMOTE { get { if (!_ERROR_PLAYER_REMOTEReady) { _ERROR_PLAYER_REMOTEContent = SGetField<int>(LocalBridgeClazz, "ERROR_PLAYER_REMOTE"); _ERROR_PLAYER_REMOTEReady = true; } return _ERROR_PLAYER_REMOTEContent; } }
        private static int _ERROR_PLAYER_REMOTEContent = default;
        private static bool _ERROR_PLAYER_REMOTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_RUNTIME"/>
        /// </summary>
        public static int ERROR_RUNTIME { get { if (!_ERROR_RUNTIMEReady) { _ERROR_RUNTIMEContent = SGetField<int>(LocalBridgeClazz, "ERROR_RUNTIME"); _ERROR_RUNTIMEReady = true; } return _ERROR_RUNTIMEContent; } }
        private static int _ERROR_RUNTIMEContent = default;
        private static bool _ERROR_RUNTIMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#ERROR_UNKNOWN"/>
        /// </summary>
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#getErrorCode()"/> 
        /// </summary>
        public int ErrorCode
        {
            get { return IExecuteWithSignature<int>("getErrorCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#getSubErrorCode()"/> 
        /// </summary>
        public int SubErrorCode
        {
            get { return IExecuteWithSignature<int>("getSubErrorCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent Build()
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent>("build", "()Landroid/media/metrics/PlaybackErrorEvent;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#setErrorCode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent.Builder SetErrorCode(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent.Builder>("setErrorCode", "(I)Landroid/media/metrics/PlaybackErrorEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#setException(java.lang.Exception)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent.Builder SetException(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent.Builder>("setException", "(Ljava/lang/Exception;)Landroid/media/metrics/PlaybackErrorEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#setMetricsBundle(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent.Builder SetMetricsBundle(Android.Os.Bundle arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent.Builder>("setMetricsBundle", "(Landroid/os/Bundle;)Landroid/media/metrics/PlaybackErrorEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#setSubErrorCode(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent.Builder SetSubErrorCode(int arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent.Builder>("setSubErrorCode", "(I)Landroid/media/metrics/PlaybackErrorEvent$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/metrics/PlaybackErrorEvent.Builder.html#setTimeSinceCreatedMillis(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Media.Metrics.PlaybackErrorEvent.Builder"/></returns>
            public Android.Media.Metrics.PlaybackErrorEvent.Builder SetTimeSinceCreatedMillis(long arg0)
            {
                return IExecuteWithSignature<Android.Media.Metrics.PlaybackErrorEvent.Builder>("setTimeSinceCreatedMillis", "(J)Landroid/media/metrics/PlaybackErrorEvent$Builder;", arg0);
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