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

namespace Android.Accessibilityservice
{
    #region AccessibilityServiceInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html"/>
    /// </summary>
    public partial class AccessibilityServiceInfo : Android.Os.Parcelable
    {
        const string _bridgeClassName = "android.accessibilityservice.AccessibilityServiceInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AccessibilityServiceInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AccessibilityServiceInfo(params object[] args) : base(args) { }
    
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

    #region AccessibilityServiceInfo implementation
    public partial class AccessibilityServiceInfo
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#eventTypes"/>
        /// </summary>
        public int eventTypes { get { return IGetField<int>("eventTypes"); } set { ISetField("eventTypes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#feedbackType"/>
        /// </summary>
        public int feedbackType { get { return IGetField<int>("feedbackType"); } set { ISetField("feedbackType", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#packageNames"/>
        /// </summary>
        public Java.Lang.String[] packageNames { get { return IGetFieldArray<Java.Lang.String>("packageNames"); } set { ISetField("packageNames", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#notificationTimeout"/>
        /// </summary>
        public long notificationTimeout { get { return IGetField<long>("notificationTimeout"); } set { ISetField("notificationTimeout", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_CONTROL_MAGNIFICATION"/>
        /// </summary>
        public static int CAPABILITY_CAN_CONTROL_MAGNIFICATION { get { if (!_CAPABILITY_CAN_CONTROL_MAGNIFICATIONReady) { _CAPABILITY_CAN_CONTROL_MAGNIFICATIONContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_CONTROL_MAGNIFICATION"); _CAPABILITY_CAN_CONTROL_MAGNIFICATIONReady = true; } return _CAPABILITY_CAN_CONTROL_MAGNIFICATIONContent; } }
        private static int _CAPABILITY_CAN_CONTROL_MAGNIFICATIONContent = default;
        private static bool _CAPABILITY_CAN_CONTROL_MAGNIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_PERFORM_GESTURES"/>
        /// </summary>
        public static int CAPABILITY_CAN_PERFORM_GESTURES { get { if (!_CAPABILITY_CAN_PERFORM_GESTURESReady) { _CAPABILITY_CAN_PERFORM_GESTURESContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_PERFORM_GESTURES"); _CAPABILITY_CAN_PERFORM_GESTURESReady = true; } return _CAPABILITY_CAN_PERFORM_GESTURESContent; } }
        private static int _CAPABILITY_CAN_PERFORM_GESTURESContent = default;
        private static bool _CAPABILITY_CAN_PERFORM_GESTURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITY { get { if (!_CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady) { _CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITY"); _CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady = true; } return _CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent; } }
        private static int _CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent = default;
        private static bool _CAPABILITY_CAN_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTS"/>
        /// </summary>
        public static int CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTS { get { if (!_CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSReady) { _CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTS"); _CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSReady = true; } return _CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSContent; } }
        private static int _CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSContent = default;
        private static bool _CAPABILITY_CAN_REQUEST_FILTER_KEY_EVENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURES"/>
        /// </summary>
        public static int CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURES { get { if (!_CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESReady) { _CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURES"); _CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESReady = true; } return _CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESContent; } }
        private static int _CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESContent = default;
        private static bool _CAPABILITY_CAN_REQUEST_FINGERPRINT_GESTURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATION"/>
        /// </summary>
        public static int CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATION { get { if (!_CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONReady) { _CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATION"); _CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONReady = true; } return _CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONContent; } }
        private static int _CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONContent = default;
        private static bool _CAPABILITY_CAN_REQUEST_TOUCH_EXPLORATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENT"/>
        /// </summary>
        public static int CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENT { get { if (!_CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTReady) { _CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENT"); _CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTReady = true; } return _CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTContent; } }
        private static int _CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTContent = default;
        private static bool _CAPABILITY_CAN_RETRIEVE_WINDOW_CONTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#CAPABILITY_CAN_TAKE_SCREENSHOT"/>
        /// </summary>
        public static int CAPABILITY_CAN_TAKE_SCREENSHOT { get { if (!_CAPABILITY_CAN_TAKE_SCREENSHOTReady) { _CAPABILITY_CAN_TAKE_SCREENSHOTContent = SGetField<int>(LocalBridgeClazz, "CAPABILITY_CAN_TAKE_SCREENSHOT"); _CAPABILITY_CAN_TAKE_SCREENSHOTReady = true; } return _CAPABILITY_CAN_TAKE_SCREENSHOTContent; } }
        private static int _CAPABILITY_CAN_TAKE_SCREENSHOTContent = default;
        private static bool _CAPABILITY_CAN_TAKE_SCREENSHOTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#DEFAULT"/>
        /// </summary>
        public static int DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<int>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static int _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_ALL_MASK"/>
        /// </summary>
        public static int FEEDBACK_ALL_MASK { get { if (!_FEEDBACK_ALL_MASKReady) { _FEEDBACK_ALL_MASKContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_ALL_MASK"); _FEEDBACK_ALL_MASKReady = true; } return _FEEDBACK_ALL_MASKContent; } }
        private static int _FEEDBACK_ALL_MASKContent = default;
        private static bool _FEEDBACK_ALL_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_AUDIBLE"/>
        /// </summary>
        public static int FEEDBACK_AUDIBLE { get { if (!_FEEDBACK_AUDIBLEReady) { _FEEDBACK_AUDIBLEContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_AUDIBLE"); _FEEDBACK_AUDIBLEReady = true; } return _FEEDBACK_AUDIBLEContent; } }
        private static int _FEEDBACK_AUDIBLEContent = default;
        private static bool _FEEDBACK_AUDIBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_BRAILLE"/>
        /// </summary>
        public static int FEEDBACK_BRAILLE { get { if (!_FEEDBACK_BRAILLEReady) { _FEEDBACK_BRAILLEContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_BRAILLE"); _FEEDBACK_BRAILLEReady = true; } return _FEEDBACK_BRAILLEContent; } }
        private static int _FEEDBACK_BRAILLEContent = default;
        private static bool _FEEDBACK_BRAILLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_GENERIC"/>
        /// </summary>
        public static int FEEDBACK_GENERIC { get { if (!_FEEDBACK_GENERICReady) { _FEEDBACK_GENERICContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_GENERIC"); _FEEDBACK_GENERICReady = true; } return _FEEDBACK_GENERICContent; } }
        private static int _FEEDBACK_GENERICContent = default;
        private static bool _FEEDBACK_GENERICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_HAPTIC"/>
        /// </summary>
        public static int FEEDBACK_HAPTIC { get { if (!_FEEDBACK_HAPTICReady) { _FEEDBACK_HAPTICContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_HAPTIC"); _FEEDBACK_HAPTICReady = true; } return _FEEDBACK_HAPTICContent; } }
        private static int _FEEDBACK_HAPTICContent = default;
        private static bool _FEEDBACK_HAPTICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_SPOKEN"/>
        /// </summary>
        public static int FEEDBACK_SPOKEN { get { if (!_FEEDBACK_SPOKENReady) { _FEEDBACK_SPOKENContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_SPOKEN"); _FEEDBACK_SPOKENReady = true; } return _FEEDBACK_SPOKENContent; } }
        private static int _FEEDBACK_SPOKENContent = default;
        private static bool _FEEDBACK_SPOKENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FEEDBACK_VISUAL"/>
        /// </summary>
        public static int FEEDBACK_VISUAL { get { if (!_FEEDBACK_VISUALReady) { _FEEDBACK_VISUALContent = SGetField<int>(LocalBridgeClazz, "FEEDBACK_VISUAL"); _FEEDBACK_VISUALReady = true; } return _FEEDBACK_VISUALContent; } }
        private static int _FEEDBACK_VISUALContent = default;
        private static bool _FEEDBACK_VISUALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_ENABLE_ACCESSIBILITY_VOLUME"/>
        /// </summary>
        public static int FLAG_ENABLE_ACCESSIBILITY_VOLUME { get { if (!_FLAG_ENABLE_ACCESSIBILITY_VOLUMEReady) { _FLAG_ENABLE_ACCESSIBILITY_VOLUMEContent = SGetField<int>(LocalBridgeClazz, "FLAG_ENABLE_ACCESSIBILITY_VOLUME"); _FLAG_ENABLE_ACCESSIBILITY_VOLUMEReady = true; } return _FLAG_ENABLE_ACCESSIBILITY_VOLUMEContent; } }
        private static int _FLAG_ENABLE_ACCESSIBILITY_VOLUMEContent = default;
        private static bool _FLAG_ENABLE_ACCESSIBILITY_VOLUMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_INCLUDE_NOT_IMPORTANT_VIEWS"/>
        /// </summary>
        public static int FLAG_INCLUDE_NOT_IMPORTANT_VIEWS { get { if (!_FLAG_INCLUDE_NOT_IMPORTANT_VIEWSReady) { _FLAG_INCLUDE_NOT_IMPORTANT_VIEWSContent = SGetField<int>(LocalBridgeClazz, "FLAG_INCLUDE_NOT_IMPORTANT_VIEWS"); _FLAG_INCLUDE_NOT_IMPORTANT_VIEWSReady = true; } return _FLAG_INCLUDE_NOT_IMPORTANT_VIEWSContent; } }
        private static int _FLAG_INCLUDE_NOT_IMPORTANT_VIEWSContent = default;
        private static bool _FLAG_INCLUDE_NOT_IMPORTANT_VIEWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_INPUT_METHOD_EDITOR"/>
        /// </summary>
        public static int FLAG_INPUT_METHOD_EDITOR { get { if (!_FLAG_INPUT_METHOD_EDITORReady) { _FLAG_INPUT_METHOD_EDITORContent = SGetField<int>(LocalBridgeClazz, "FLAG_INPUT_METHOD_EDITOR"); _FLAG_INPUT_METHOD_EDITORReady = true; } return _FLAG_INPUT_METHOD_EDITORContent; } }
        private static int _FLAG_INPUT_METHOD_EDITORContent = default;
        private static bool _FLAG_INPUT_METHOD_EDITORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REPORT_VIEW_IDS"/>
        /// </summary>
        public static int FLAG_REPORT_VIEW_IDS { get { if (!_FLAG_REPORT_VIEW_IDSReady) { _FLAG_REPORT_VIEW_IDSContent = SGetField<int>(LocalBridgeClazz, "FLAG_REPORT_VIEW_IDS"); _FLAG_REPORT_VIEW_IDSReady = true; } return _FLAG_REPORT_VIEW_IDSContent; } }
        private static int _FLAG_REPORT_VIEW_IDSContent = default;
        private static bool _FLAG_REPORT_VIEW_IDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_2_FINGER_PASSTHROUGH"/>
        /// </summary>
        public static int FLAG_REQUEST_2_FINGER_PASSTHROUGH { get { if (!_FLAG_REQUEST_2_FINGER_PASSTHROUGHReady) { _FLAG_REQUEST_2_FINGER_PASSTHROUGHContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_2_FINGER_PASSTHROUGH"); _FLAG_REQUEST_2_FINGER_PASSTHROUGHReady = true; } return _FLAG_REQUEST_2_FINGER_PASSTHROUGHContent; } }
        private static int _FLAG_REQUEST_2_FINGER_PASSTHROUGHContent = default;
        private static bool _FLAG_REQUEST_2_FINGER_PASSTHROUGHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_ACCESSIBILITY_BUTTON"/>
        /// </summary>
        public static int FLAG_REQUEST_ACCESSIBILITY_BUTTON { get { if (!_FLAG_REQUEST_ACCESSIBILITY_BUTTONReady) { _FLAG_REQUEST_ACCESSIBILITY_BUTTONContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_ACCESSIBILITY_BUTTON"); _FLAG_REQUEST_ACCESSIBILITY_BUTTONReady = true; } return _FLAG_REQUEST_ACCESSIBILITY_BUTTONContent; } }
        private static int _FLAG_REQUEST_ACCESSIBILITY_BUTTONContent = default;
        private static bool _FLAG_REQUEST_ACCESSIBILITY_BUTTONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY { get { if (!_FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady) { _FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY"); _FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady = true; } return _FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent; } }
        private static int _FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYContent = default;
        private static bool _FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_FILTER_KEY_EVENTS"/>
        /// </summary>
        public static int FLAG_REQUEST_FILTER_KEY_EVENTS { get { if (!_FLAG_REQUEST_FILTER_KEY_EVENTSReady) { _FLAG_REQUEST_FILTER_KEY_EVENTSContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_FILTER_KEY_EVENTS"); _FLAG_REQUEST_FILTER_KEY_EVENTSReady = true; } return _FLAG_REQUEST_FILTER_KEY_EVENTSContent; } }
        private static int _FLAG_REQUEST_FILTER_KEY_EVENTSContent = default;
        private static bool _FLAG_REQUEST_FILTER_KEY_EVENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_FINGERPRINT_GESTURES"/>
        /// </summary>
        public static int FLAG_REQUEST_FINGERPRINT_GESTURES { get { if (!_FLAG_REQUEST_FINGERPRINT_GESTURESReady) { _FLAG_REQUEST_FINGERPRINT_GESTURESContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_FINGERPRINT_GESTURES"); _FLAG_REQUEST_FINGERPRINT_GESTURESReady = true; } return _FLAG_REQUEST_FINGERPRINT_GESTURESContent; } }
        private static int _FLAG_REQUEST_FINGERPRINT_GESTURESContent = default;
        private static bool _FLAG_REQUEST_FINGERPRINT_GESTURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_MULTI_FINGER_GESTURES"/>
        /// </summary>
        public static int FLAG_REQUEST_MULTI_FINGER_GESTURES { get { if (!_FLAG_REQUEST_MULTI_FINGER_GESTURESReady) { _FLAG_REQUEST_MULTI_FINGER_GESTURESContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_MULTI_FINGER_GESTURES"); _FLAG_REQUEST_MULTI_FINGER_GESTURESReady = true; } return _FLAG_REQUEST_MULTI_FINGER_GESTURESContent; } }
        private static int _FLAG_REQUEST_MULTI_FINGER_GESTURESContent = default;
        private static bool _FLAG_REQUEST_MULTI_FINGER_GESTURESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACK"/>
        /// </summary>
        public static int FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACK { get { if (!_FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKReady) { _FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACK"); _FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKReady = true; } return _FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKContent; } }
        private static int _FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKContent = default;
        private static bool _FLAG_REQUEST_SHORTCUT_WARNING_DIALOG_SPOKEN_FEEDBACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_REQUEST_TOUCH_EXPLORATION_MODE"/>
        /// </summary>
        public static int FLAG_REQUEST_TOUCH_EXPLORATION_MODE { get { if (!_FLAG_REQUEST_TOUCH_EXPLORATION_MODEReady) { _FLAG_REQUEST_TOUCH_EXPLORATION_MODEContent = SGetField<int>(LocalBridgeClazz, "FLAG_REQUEST_TOUCH_EXPLORATION_MODE"); _FLAG_REQUEST_TOUCH_EXPLORATION_MODEReady = true; } return _FLAG_REQUEST_TOUCH_EXPLORATION_MODEContent; } }
        private static int _FLAG_REQUEST_TOUCH_EXPLORATION_MODEContent = default;
        private static bool _FLAG_REQUEST_TOUCH_EXPLORATION_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_RETRIEVE_INTERACTIVE_WINDOWS"/>
        /// </summary>
        public static int FLAG_RETRIEVE_INTERACTIVE_WINDOWS { get { if (!_FLAG_RETRIEVE_INTERACTIVE_WINDOWSReady) { _FLAG_RETRIEVE_INTERACTIVE_WINDOWSContent = SGetField<int>(LocalBridgeClazz, "FLAG_RETRIEVE_INTERACTIVE_WINDOWS"); _FLAG_RETRIEVE_INTERACTIVE_WINDOWSReady = true; } return _FLAG_RETRIEVE_INTERACTIVE_WINDOWSContent; } }
        private static int _FLAG_RETRIEVE_INTERACTIVE_WINDOWSContent = default;
        private static bool _FLAG_RETRIEVE_INTERACTIVE_WINDOWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_SEND_MOTION_EVENTS"/>
        /// </summary>
        public static int FLAG_SEND_MOTION_EVENTS { get { if (!_FLAG_SEND_MOTION_EVENTSReady) { _FLAG_SEND_MOTION_EVENTSContent = SGetField<int>(LocalBridgeClazz, "FLAG_SEND_MOTION_EVENTS"); _FLAG_SEND_MOTION_EVENTSReady = true; } return _FLAG_SEND_MOTION_EVENTSContent; } }
        private static int _FLAG_SEND_MOTION_EVENTSContent = default;
        private static bool _FLAG_SEND_MOTION_EVENTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#FLAG_SERVICE_HANDLES_DOUBLE_TAP"/>
        /// </summary>
        public static int FLAG_SERVICE_HANDLES_DOUBLE_TAP { get { if (!_FLAG_SERVICE_HANDLES_DOUBLE_TAPReady) { _FLAG_SERVICE_HANDLES_DOUBLE_TAPContent = SGetField<int>(LocalBridgeClazz, "FLAG_SERVICE_HANDLES_DOUBLE_TAP"); _FLAG_SERVICE_HANDLES_DOUBLE_TAPReady = true; } return _FLAG_SERVICE_HANDLES_DOUBLE_TAPContent; } }
        private static int _FLAG_SERVICE_HANDLES_DOUBLE_TAPContent = default;
        private static bool _FLAG_SERVICE_HANDLES_DOUBLE_TAPReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#capabilityToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String CapabilityToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "capabilityToString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#feedbackTypeToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FeedbackTypeToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "feedbackTypeToString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#flagToString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String FlagToString(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "flagToString", "(I)Ljava/lang/String;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getResolveInfo()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Pm.ResolveInfo"/></returns>
        public Android.Content.Pm.ResolveInfo GetResolveInfo()
        {
            return IExecuteWithSignature<Android.Content.Pm.ResolveInfo>("getResolveInfo", "()Landroid/content/pm/ResolveInfo;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getCanRetrieveWindowContent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool GetCanRetrieveWindowContent()
        {
            return IExecuteWithSignature<bool>("getCanRetrieveWindowContent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#isAccessibilityTool()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAccessibilityTool()
        {
            return IExecuteWithSignature<bool>("isAccessibilityTool", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getCapabilities()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCapabilities()
        {
            return IExecuteWithSignature<int>("getCapabilities", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getInteractiveUiTimeoutMillis()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInteractiveUiTimeoutMillis()
        {
            return IExecuteWithSignature<int>("getInteractiveUiTimeoutMillis", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getMotionEventSources()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMotionEventSources()
        {
            return IExecuteWithSignature<int>("getMotionEventSources", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getNonInteractiveUiTimeoutMillis()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetNonInteractiveUiTimeoutMillis()
        {
            return IExecuteWithSignature<int>("getNonInteractiveUiTimeoutMillis", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#loadIntro(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadIntro(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadIntro", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#loadSummary(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadSummary(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadSummary", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getDescription()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetDescription()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getSettingsActivityName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSettingsActivityName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSettingsActivityName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#getTileServiceName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTileServiceName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getTileServiceName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#loadDescription(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LoadDescription(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#setInteractiveUiTimeoutMillis(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInteractiveUiTimeoutMillis(int arg0)
        {
            IExecuteWithSignature("setInteractiveUiTimeoutMillis", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#setMotionEventSources(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMotionEventSources(int arg0)
        {
            IExecuteWithSignature("setMotionEventSources", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#setNonInteractiveUiTimeoutMillis(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetNonInteractiveUiTimeoutMillis(int arg0)
        {
            IExecuteWithSignature("setNonInteractiveUiTimeoutMillis", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/AccessibilityServiceInfo.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecuteWithSignature("writeToParcel", "(Landroid/os/Parcel;I)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}