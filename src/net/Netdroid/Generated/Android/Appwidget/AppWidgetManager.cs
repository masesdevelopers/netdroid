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

namespace Android.Appwidget
{
    #region AppWidgetManager
    public partial class AppWidgetManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#INVALID_APPWIDGET_ID"/>
        /// </summary>
        public static int INVALID_APPWIDGET_ID { get { if (!_INVALID_APPWIDGET_IDReady) { _INVALID_APPWIDGET_IDContent = SGetField<int>(LocalBridgeClazz, "INVALID_APPWIDGET_ID"); _INVALID_APPWIDGET_IDReady = true; } return _INVALID_APPWIDGET_IDContent; } }
        private static int _INVALID_APPWIDGET_IDContent = default;
        private static bool _INVALID_APPWIDGET_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_BIND"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_BIND { get { if (!_ACTION_APPWIDGET_BINDReady) { _ACTION_APPWIDGET_BINDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_BIND"); _ACTION_APPWIDGET_BINDReady = true; } return _ACTION_APPWIDGET_BINDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_BINDContent = default;
        private static bool _ACTION_APPWIDGET_BINDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_CONFIGURE"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_CONFIGURE { get { if (!_ACTION_APPWIDGET_CONFIGUREReady) { _ACTION_APPWIDGET_CONFIGUREContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_CONFIGURE"); _ACTION_APPWIDGET_CONFIGUREReady = true; } return _ACTION_APPWIDGET_CONFIGUREContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_CONFIGUREContent = default;
        private static bool _ACTION_APPWIDGET_CONFIGUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_DELETED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_DELETED { get { if (!_ACTION_APPWIDGET_DELETEDReady) { _ACTION_APPWIDGET_DELETEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_DELETED"); _ACTION_APPWIDGET_DELETEDReady = true; } return _ACTION_APPWIDGET_DELETEDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_DELETEDContent = default;
        private static bool _ACTION_APPWIDGET_DELETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_DISABLED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_DISABLED { get { if (!_ACTION_APPWIDGET_DISABLEDReady) { _ACTION_APPWIDGET_DISABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_DISABLED"); _ACTION_APPWIDGET_DISABLEDReady = true; } return _ACTION_APPWIDGET_DISABLEDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_DISABLEDContent = default;
        private static bool _ACTION_APPWIDGET_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_ENABLED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_ENABLED { get { if (!_ACTION_APPWIDGET_ENABLEDReady) { _ACTION_APPWIDGET_ENABLEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_ENABLED"); _ACTION_APPWIDGET_ENABLEDReady = true; } return _ACTION_APPWIDGET_ENABLEDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_ENABLEDContent = default;
        private static bool _ACTION_APPWIDGET_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_HOST_RESTORED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_HOST_RESTORED { get { if (!_ACTION_APPWIDGET_HOST_RESTOREDReady) { _ACTION_APPWIDGET_HOST_RESTOREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_HOST_RESTORED"); _ACTION_APPWIDGET_HOST_RESTOREDReady = true; } return _ACTION_APPWIDGET_HOST_RESTOREDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_HOST_RESTOREDContent = default;
        private static bool _ACTION_APPWIDGET_HOST_RESTOREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_OPTIONS_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_OPTIONS_CHANGED { get { if (!_ACTION_APPWIDGET_OPTIONS_CHANGEDReady) { _ACTION_APPWIDGET_OPTIONS_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_OPTIONS_CHANGED"); _ACTION_APPWIDGET_OPTIONS_CHANGEDReady = true; } return _ACTION_APPWIDGET_OPTIONS_CHANGEDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_OPTIONS_CHANGEDContent = default;
        private static bool _ACTION_APPWIDGET_OPTIONS_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_PICK"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_PICK { get { if (!_ACTION_APPWIDGET_PICKReady) { _ACTION_APPWIDGET_PICKContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_PICK"); _ACTION_APPWIDGET_PICKReady = true; } return _ACTION_APPWIDGET_PICKContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_PICKContent = default;
        private static bool _ACTION_APPWIDGET_PICKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_RESTORED"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_RESTORED { get { if (!_ACTION_APPWIDGET_RESTOREDReady) { _ACTION_APPWIDGET_RESTOREDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_RESTORED"); _ACTION_APPWIDGET_RESTOREDReady = true; } return _ACTION_APPWIDGET_RESTOREDContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_RESTOREDContent = default;
        private static bool _ACTION_APPWIDGET_RESTOREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#ACTION_APPWIDGET_UPDATE"/>
        /// </summary>
        public static Java.Lang.String ACTION_APPWIDGET_UPDATE { get { if (!_ACTION_APPWIDGET_UPDATEReady) { _ACTION_APPWIDGET_UPDATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACTION_APPWIDGET_UPDATE"); _ACTION_APPWIDGET_UPDATEReady = true; } return _ACTION_APPWIDGET_UPDATEContent; } }
        private static Java.Lang.String _ACTION_APPWIDGET_UPDATEContent = default;
        private static bool _ACTION_APPWIDGET_UPDATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_ID { get { if (!_EXTRA_APPWIDGET_IDReady) { _EXTRA_APPWIDGET_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_ID"); _EXTRA_APPWIDGET_IDReady = true; } return _EXTRA_APPWIDGET_IDContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_IDContent = default;
        private static bool _EXTRA_APPWIDGET_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_IDS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_IDS { get { if (!_EXTRA_APPWIDGET_IDSReady) { _EXTRA_APPWIDGET_IDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_IDS"); _EXTRA_APPWIDGET_IDSReady = true; } return _EXTRA_APPWIDGET_IDSContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_IDSContent = default;
        private static bool _EXTRA_APPWIDGET_IDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_OLD_IDS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_OLD_IDS { get { if (!_EXTRA_APPWIDGET_OLD_IDSReady) { _EXTRA_APPWIDGET_OLD_IDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_OLD_IDS"); _EXTRA_APPWIDGET_OLD_IDSReady = true; } return _EXTRA_APPWIDGET_OLD_IDSContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_OLD_IDSContent = default;
        private static bool _EXTRA_APPWIDGET_OLD_IDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_OPTIONS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_OPTIONS { get { if (!_EXTRA_APPWIDGET_OPTIONSReady) { _EXTRA_APPWIDGET_OPTIONSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_OPTIONS"); _EXTRA_APPWIDGET_OPTIONSReady = true; } return _EXTRA_APPWIDGET_OPTIONSContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_OPTIONSContent = default;
        private static bool _EXTRA_APPWIDGET_OPTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_PREVIEW"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_PREVIEW { get { if (!_EXTRA_APPWIDGET_PREVIEWReady) { _EXTRA_APPWIDGET_PREVIEWContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_PREVIEW"); _EXTRA_APPWIDGET_PREVIEWReady = true; } return _EXTRA_APPWIDGET_PREVIEWContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_PREVIEWContent = default;
        private static bool _EXTRA_APPWIDGET_PREVIEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_PROVIDER"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_PROVIDER { get { if (!_EXTRA_APPWIDGET_PROVIDERReady) { _EXTRA_APPWIDGET_PROVIDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_PROVIDER"); _EXTRA_APPWIDGET_PROVIDERReady = true; } return _EXTRA_APPWIDGET_PROVIDERContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_PROVIDERContent = default;
        private static bool _EXTRA_APPWIDGET_PROVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_APPWIDGET_PROVIDER_PROFILE"/>
        /// </summary>
        public static Java.Lang.String EXTRA_APPWIDGET_PROVIDER_PROFILE { get { if (!_EXTRA_APPWIDGET_PROVIDER_PROFILEReady) { _EXTRA_APPWIDGET_PROVIDER_PROFILEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_APPWIDGET_PROVIDER_PROFILE"); _EXTRA_APPWIDGET_PROVIDER_PROFILEReady = true; } return _EXTRA_APPWIDGET_PROVIDER_PROFILEContent; } }
        private static Java.Lang.String _EXTRA_APPWIDGET_PROVIDER_PROFILEContent = default;
        private static bool _EXTRA_APPWIDGET_PROVIDER_PROFILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_CUSTOM_EXTRAS"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CUSTOM_EXTRAS { get { if (!_EXTRA_CUSTOM_EXTRASReady) { _EXTRA_CUSTOM_EXTRASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CUSTOM_EXTRAS"); _EXTRA_CUSTOM_EXTRASReady = true; } return _EXTRA_CUSTOM_EXTRASContent; } }
        private static Java.Lang.String _EXTRA_CUSTOM_EXTRASContent = default;
        private static bool _EXTRA_CUSTOM_EXTRASReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_CUSTOM_INFO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CUSTOM_INFO { get { if (!_EXTRA_CUSTOM_INFOReady) { _EXTRA_CUSTOM_INFOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CUSTOM_INFO"); _EXTRA_CUSTOM_INFOReady = true; } return _EXTRA_CUSTOM_INFOContent; } }
        private static Java.Lang.String _EXTRA_CUSTOM_INFOContent = default;
        private static bool _EXTRA_CUSTOM_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#EXTRA_HOST_ID"/>
        /// </summary>
        public static Java.Lang.String EXTRA_HOST_ID { get { if (!_EXTRA_HOST_IDReady) { _EXTRA_HOST_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_HOST_ID"); _EXTRA_HOST_IDReady = true; } return _EXTRA_HOST_IDContent; } }
        private static Java.Lang.String _EXTRA_HOST_IDContent = default;
        private static bool _EXTRA_HOST_IDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#META_DATA_APPWIDGET_PROVIDER"/>
        /// </summary>
        public static Java.Lang.String META_DATA_APPWIDGET_PROVIDER { get { if (!_META_DATA_APPWIDGET_PROVIDERReady) { _META_DATA_APPWIDGET_PROVIDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "META_DATA_APPWIDGET_PROVIDER"); _META_DATA_APPWIDGET_PROVIDERReady = true; } return _META_DATA_APPWIDGET_PROVIDERContent; } }
        private static Java.Lang.String _META_DATA_APPWIDGET_PROVIDERContent = default;
        private static bool _META_DATA_APPWIDGET_PROVIDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_HOST_CATEGORY"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_HOST_CATEGORY { get { if (!_OPTION_APPWIDGET_HOST_CATEGORYReady) { _OPTION_APPWIDGET_HOST_CATEGORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_HOST_CATEGORY"); _OPTION_APPWIDGET_HOST_CATEGORYReady = true; } return _OPTION_APPWIDGET_HOST_CATEGORYContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_HOST_CATEGORYContent = default;
        private static bool _OPTION_APPWIDGET_HOST_CATEGORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_MAX_HEIGHT"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_MAX_HEIGHT { get { if (!_OPTION_APPWIDGET_MAX_HEIGHTReady) { _OPTION_APPWIDGET_MAX_HEIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_MAX_HEIGHT"); _OPTION_APPWIDGET_MAX_HEIGHTReady = true; } return _OPTION_APPWIDGET_MAX_HEIGHTContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_MAX_HEIGHTContent = default;
        private static bool _OPTION_APPWIDGET_MAX_HEIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_MAX_WIDTH"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_MAX_WIDTH { get { if (!_OPTION_APPWIDGET_MAX_WIDTHReady) { _OPTION_APPWIDGET_MAX_WIDTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_MAX_WIDTH"); _OPTION_APPWIDGET_MAX_WIDTHReady = true; } return _OPTION_APPWIDGET_MAX_WIDTHContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_MAX_WIDTHContent = default;
        private static bool _OPTION_APPWIDGET_MAX_WIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_MIN_HEIGHT"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_MIN_HEIGHT { get { if (!_OPTION_APPWIDGET_MIN_HEIGHTReady) { _OPTION_APPWIDGET_MIN_HEIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_MIN_HEIGHT"); _OPTION_APPWIDGET_MIN_HEIGHTReady = true; } return _OPTION_APPWIDGET_MIN_HEIGHTContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_MIN_HEIGHTContent = default;
        private static bool _OPTION_APPWIDGET_MIN_HEIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_MIN_WIDTH"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_MIN_WIDTH { get { if (!_OPTION_APPWIDGET_MIN_WIDTHReady) { _OPTION_APPWIDGET_MIN_WIDTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_MIN_WIDTH"); _OPTION_APPWIDGET_MIN_WIDTHReady = true; } return _OPTION_APPWIDGET_MIN_WIDTHContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_MIN_WIDTHContent = default;
        private static bool _OPTION_APPWIDGET_MIN_WIDTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_RESTORE_COMPLETED"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_RESTORE_COMPLETED { get { if (!_OPTION_APPWIDGET_RESTORE_COMPLETEDReady) { _OPTION_APPWIDGET_RESTORE_COMPLETEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_RESTORE_COMPLETED"); _OPTION_APPWIDGET_RESTORE_COMPLETEDReady = true; } return _OPTION_APPWIDGET_RESTORE_COMPLETEDContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_RESTORE_COMPLETEDContent = default;
        private static bool _OPTION_APPWIDGET_RESTORE_COMPLETEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#OPTION_APPWIDGET_SIZES"/>
        /// </summary>
        public static Java.Lang.String OPTION_APPWIDGET_SIZES { get { if (!_OPTION_APPWIDGET_SIZESReady) { _OPTION_APPWIDGET_SIZESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OPTION_APPWIDGET_SIZES"); _OPTION_APPWIDGET_SIZESReady = true; } return _OPTION_APPWIDGET_SIZESContent; } }
        private static Java.Lang.String _OPTION_APPWIDGET_SIZESContent = default;
        private static bool _OPTION_APPWIDGET_SIZESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getInstance(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <returns><see cref="Android.Appwidget.AppWidgetManager"/></returns>
        public static Android.Appwidget.AppWidgetManager GetInstance(Android.Content.Context arg0)
        {
            return SExecuteWithSignature<Android.Appwidget.AppWidgetManager>(LocalBridgeClazz, "getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getAppWidgetInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Appwidget.AppWidgetProviderInfo"/></returns>
        public Android.Appwidget.AppWidgetProviderInfo GetAppWidgetInfo(int arg0)
        {
            return IExecuteWithSignature<Android.Appwidget.AppWidgetProviderInfo>("getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getAppWidgetOptions(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetAppWidgetOptions(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getAppWidgetOptions", "(I)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getWidgetPreview(android.content.ComponentName,android.os.UserHandle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Widget.RemoteViews"/></returns>
        public Android.Widget.RemoteViews GetWidgetPreview(Android.Content.ComponentName arg0, Android.Os.UserHandle arg1, int arg2)
        {
            return IExecute<Android.Widget.RemoteViews>("getWidgetPreview", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#bindAppWidgetIdIfAllowed(int,android.content.ComponentName,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg2"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool BindAppWidgetIdIfAllowed(int arg0, Android.Content.ComponentName arg1, Android.Os.Bundle arg2)
        {
            return IExecute<bool>("bindAppWidgetIdIfAllowed", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#bindAppWidgetIdIfAllowed(int,android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool BindAppWidgetIdIfAllowed(int arg0, Android.Content.ComponentName arg1)
        {
            return IExecute<bool>("bindAppWidgetIdIfAllowed", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#bindAppWidgetIdIfAllowed(int,android.os.UserHandle,android.content.ComponentName,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <param name="arg2"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg3"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool BindAppWidgetIdIfAllowed(int arg0, Android.Os.UserHandle arg1, Android.Content.ComponentName arg2, Android.Os.Bundle arg3)
        {
            return IExecute<bool>("bindAppWidgetIdIfAllowed", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#isRequestPinAppWidgetSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRequestPinAppWidgetSupported()
        {
            return IExecuteWithSignature<bool>("isRequestPinAppWidgetSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#requestPinAppWidget(android.content.ComponentName,android.os.Bundle,android.app.PendingIntent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        /// <param name="arg2"><see cref="Android.App.PendingIntent"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RequestPinAppWidget(Android.Content.ComponentName arg0, Android.Os.Bundle arg1, Android.App.PendingIntent arg2)
        {
            return IExecute<bool>("requestPinAppWidget", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#setWidgetPreview(android.content.ComponentName,int,android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Widget.RemoteViews"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetWidgetPreview(Android.Content.ComponentName arg0, int arg1, Android.Widget.RemoteViews arg2)
        {
            return IExecute<bool>("setWidgetPreview", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getAppWidgetIds(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetAppWidgetIds(Android.Content.ComponentName arg0)
        {
            return IExecuteWithSignatureArray<int>("getAppWidgetIds", "(Landroid/content/ComponentName;)[I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getInstalledProviders()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Appwidget.AppWidgetProviderInfo> GetInstalledProviders()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Appwidget.AppWidgetProviderInfo>>("getInstalledProviders", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getInstalledProvidersForPackage(java.lang.String,android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Appwidget.AppWidgetProviderInfo> GetInstalledProvidersForPackage(Java.Lang.String arg0, Android.Os.UserHandle arg1)
        {
            return IExecute<Java.Util.List<Android.Appwidget.AppWidgetProviderInfo>>("getInstalledProvidersForPackage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#getInstalledProvidersForProfile(android.os.UserHandle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.UserHandle"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Appwidget.AppWidgetProviderInfo> GetInstalledProvidersForProfile(Android.Os.UserHandle arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Android.Appwidget.AppWidgetProviderInfo>>("getInstalledProvidersForProfile", "(Landroid/os/UserHandle;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#notifyAppWidgetViewDataChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void NotifyAppWidgetViewDataChanged(int arg0, int arg1)
        {
            IExecute("notifyAppWidgetViewDataChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#notifyAppWidgetViewDataChanged(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void NotifyAppWidgetViewDataChanged(int[] arg0, int arg1)
        {
            IExecute("notifyAppWidgetViewDataChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#partiallyUpdateAppWidget(int,android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.RemoteViews"/></param>
        public void PartiallyUpdateAppWidget(int arg0, Android.Widget.RemoteViews arg1)
        {
            IExecute("partiallyUpdateAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#partiallyUpdateAppWidget(int[],android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.RemoteViews"/></param>
        public void PartiallyUpdateAppWidget(int[] arg0, Android.Widget.RemoteViews arg1)
        {
            IExecute("partiallyUpdateAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#removeWidgetPreview(android.content.ComponentName,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveWidgetPreview(Android.Content.ComponentName arg0, int arg1)
        {
            IExecute("removeWidgetPreview", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#updateAppWidget(android.content.ComponentName,android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Widget.RemoteViews"/></param>
        public void UpdateAppWidget(Android.Content.ComponentName arg0, Android.Widget.RemoteViews arg1)
        {
            IExecute("updateAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#updateAppWidget(int,android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.RemoteViews"/></param>
        public void UpdateAppWidget(int arg0, Android.Widget.RemoteViews arg1)
        {
            IExecute("updateAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#updateAppWidget(int[],android.widget.RemoteViews)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.RemoteViews"/></param>
        public void UpdateAppWidget(int[] arg0, Android.Widget.RemoteViews arg1)
        {
            IExecute("updateAppWidget", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#updateAppWidgetOptions(int,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Os.Bundle"/></param>
        public void UpdateAppWidgetOptions(int arg0, Android.Os.Bundle arg1)
        {
            IExecute("updateAppWidgetOptions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/appwidget/AppWidgetManager.html#updateAppWidgetProviderInfo(android.content.ComponentName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void UpdateAppWidgetProviderInfo(Android.Content.ComponentName arg0, Java.Lang.String arg1)
        {
            IExecute("updateAppWidgetProviderInfo", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}