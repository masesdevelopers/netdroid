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

namespace Android.View.Textclassifier
{
    #region ConversationAction
    public partial class ConversationAction
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_CALL_PHONE"/>
        /// </summary>
        public static Java.Lang.String TYPE_CALL_PHONE { get { if (!_TYPE_CALL_PHONEReady) { _TYPE_CALL_PHONEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_CALL_PHONE"); _TYPE_CALL_PHONEReady = true; } return _TYPE_CALL_PHONEContent; } }
        private static Java.Lang.String _TYPE_CALL_PHONEContent = default;
        private static bool _TYPE_CALL_PHONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_CREATE_REMINDER"/>
        /// </summary>
        public static Java.Lang.String TYPE_CREATE_REMINDER { get { if (!_TYPE_CREATE_REMINDERReady) { _TYPE_CREATE_REMINDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_CREATE_REMINDER"); _TYPE_CREATE_REMINDERReady = true; } return _TYPE_CREATE_REMINDERContent; } }
        private static Java.Lang.String _TYPE_CREATE_REMINDERContent = default;
        private static bool _TYPE_CREATE_REMINDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_OPEN_URL"/>
        /// </summary>
        public static Java.Lang.String TYPE_OPEN_URL { get { if (!_TYPE_OPEN_URLReady) { _TYPE_OPEN_URLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_OPEN_URL"); _TYPE_OPEN_URLReady = true; } return _TYPE_OPEN_URLContent; } }
        private static Java.Lang.String _TYPE_OPEN_URLContent = default;
        private static bool _TYPE_OPEN_URLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_SEND_EMAIL"/>
        /// </summary>
        public static Java.Lang.String TYPE_SEND_EMAIL { get { if (!_TYPE_SEND_EMAILReady) { _TYPE_SEND_EMAILContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_SEND_EMAIL"); _TYPE_SEND_EMAILReady = true; } return _TYPE_SEND_EMAILContent; } }
        private static Java.Lang.String _TYPE_SEND_EMAILContent = default;
        private static bool _TYPE_SEND_EMAILReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_SEND_SMS"/>
        /// </summary>
        public static Java.Lang.String TYPE_SEND_SMS { get { if (!_TYPE_SEND_SMSReady) { _TYPE_SEND_SMSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_SEND_SMS"); _TYPE_SEND_SMSReady = true; } return _TYPE_SEND_SMSContent; } }
        private static Java.Lang.String _TYPE_SEND_SMSContent = default;
        private static bool _TYPE_SEND_SMSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_SHARE_LOCATION"/>
        /// </summary>
        public static Java.Lang.String TYPE_SHARE_LOCATION { get { if (!_TYPE_SHARE_LOCATIONReady) { _TYPE_SHARE_LOCATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_SHARE_LOCATION"); _TYPE_SHARE_LOCATIONReady = true; } return _TYPE_SHARE_LOCATIONContent; } }
        private static Java.Lang.String _TYPE_SHARE_LOCATIONContent = default;
        private static bool _TYPE_SHARE_LOCATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_TEXT_REPLY"/>
        /// </summary>
        public static Java.Lang.String TYPE_TEXT_REPLY { get { if (!_TYPE_TEXT_REPLYReady) { _TYPE_TEXT_REPLYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_TEXT_REPLY"); _TYPE_TEXT_REPLYReady = true; } return _TYPE_TEXT_REPLYContent; } }
        private static Java.Lang.String _TYPE_TEXT_REPLYContent = default;
        private static bool _TYPE_TEXT_REPLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_TRACK_FLIGHT"/>
        /// </summary>
        public static Java.Lang.String TYPE_TRACK_FLIGHT { get { if (!_TYPE_TRACK_FLIGHTReady) { _TYPE_TRACK_FLIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_TRACK_FLIGHT"); _TYPE_TRACK_FLIGHTReady = true; } return _TYPE_TRACK_FLIGHTContent; } }
        private static Java.Lang.String _TYPE_TRACK_FLIGHTContent = default;
        private static bool _TYPE_TRACK_FLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_VIEW_CALENDAR"/>
        /// </summary>
        public static Java.Lang.String TYPE_VIEW_CALENDAR { get { if (!_TYPE_VIEW_CALENDARReady) { _TYPE_VIEW_CALENDARContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_VIEW_CALENDAR"); _TYPE_VIEW_CALENDARReady = true; } return _TYPE_VIEW_CALENDARContent; } }
        private static Java.Lang.String _TYPE_VIEW_CALENDARContent = default;
        private static bool _TYPE_VIEW_CALENDARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#TYPE_VIEW_MAP"/>
        /// </summary>
        public static Java.Lang.String TYPE_VIEW_MAP { get { if (!_TYPE_VIEW_MAPReady) { _TYPE_VIEW_MAPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TYPE_VIEW_MAP"); _TYPE_VIEW_MAPReady = true; } return _TYPE_VIEW_MAPContent; } }
        private static Java.Lang.String _TYPE_VIEW_MAPContent = default;
        private static bool _TYPE_VIEW_MAPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#getAction()"/> 
        /// </summary>
        public Android.App.RemoteAction Action
        {
            get { return IExecuteWithSignature<Android.App.RemoteAction>("getAction", "()Landroid/app/RemoteAction;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#getConfidenceScore()"/> 
        /// </summary>
        public float ConfidenceScore
        {
            get { return IExecuteWithSignature<float>("getConfidenceScore", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#getExtras()"/> 
        /// </summary>
        public Android.Os.Bundle Extras
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#getTextReply()"/> 
        /// </summary>
        public Java.Lang.CharSequence TextReply
        {
            get { return IExecuteWithSignature<Java.Lang.CharSequence>("getTextReply", "()Ljava/lang/CharSequence;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#getType()"/> 
        /// </summary>
        public Java.Lang.String Type
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.html#writeToParcel(android.os.Parcel,int)"/>
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
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Builder(Java.Lang.String arg0)
                : base(arg0)
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
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.View.Textclassifier.ConversationAction"/></returns>
            public Android.View.Textclassifier.ConversationAction Build()
            {
                return IExecute<Android.View.Textclassifier.ConversationAction>("build");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#setAction(android.app.RemoteAction)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.App.RemoteAction"/></param>
            /// <returns><see cref="Android.View.Textclassifier.ConversationAction.Builder"/></returns>
            public Android.View.Textclassifier.ConversationAction.Builder SetAction(Android.App.RemoteAction arg0)
            {
                return IExecute<Android.View.Textclassifier.ConversationAction.Builder>("setAction", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#setConfidenceScore(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <returns><see cref="Android.View.Textclassifier.ConversationAction.Builder"/></returns>
            public Android.View.Textclassifier.ConversationAction.Builder SetConfidenceScore(float arg0)
            {
                return IExecute<Android.View.Textclassifier.ConversationAction.Builder>("setConfidenceScore", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#setExtras(android.os.Bundle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
            /// <returns><see cref="Android.View.Textclassifier.ConversationAction.Builder"/></returns>
            public Android.View.Textclassifier.ConversationAction.Builder SetExtras(Android.Os.Bundle arg0)
            {
                return IExecute<Android.View.Textclassifier.ConversationAction.Builder>("setExtras", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/textclassifier/ConversationAction.Builder.html#setTextReply(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Android.View.Textclassifier.ConversationAction.Builder"/></returns>
            public Android.View.Textclassifier.ConversationAction.Builder SetTextReply(Java.Lang.CharSequence arg0)
            {
                return IExecute<Android.View.Textclassifier.ConversationAction.Builder>("setTextReply", arg0);
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