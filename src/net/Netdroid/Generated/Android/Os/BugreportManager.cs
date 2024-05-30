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

namespace Android.Os
{
    #region BugreportManager
    public partial class BugreportManager
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
        /// <see href="https://developer.android.com/reference/android/os/BugreportManager.html#cancelBugreport()"/>
        /// </summary>
        public void CancelBugreport()
        {
            IExecuteWithSignature("cancelBugreport", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/BugreportManager.html#startConnectivityBugreport(android.os.ParcelFileDescriptor,java.util.concurrent.Executor,android.os.BugreportManager.BugreportCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Os.BugreportManager.BugreportCallback"/></param>
        public void StartConnectivityBugreport(Android.Os.ParcelFileDescriptor arg0, Java.Util.Concurrent.Executor arg1, Android.Os.BugreportManager.BugreportCallback arg2)
        {
            IExecute("startConnectivityBugreport", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region BugreportCallback
        public partial class BugreportCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESS"/>
            /// </summary>
            public static int BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESS { get { if (!_BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSReady) { _BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESS"); _BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSReady = true; } return _BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSContent; } }
            private static int _BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSContent = default;
            private static bool _BUGREPORT_ERROR_ANOTHER_REPORT_IN_PROGRESSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_INVALID_INPUT"/>
            /// </summary>
            public static int BUGREPORT_ERROR_INVALID_INPUT { get { if (!_BUGREPORT_ERROR_INVALID_INPUTReady) { _BUGREPORT_ERROR_INVALID_INPUTContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_INVALID_INPUT"); _BUGREPORT_ERROR_INVALID_INPUTReady = true; } return _BUGREPORT_ERROR_INVALID_INPUTContent; } }
            private static int _BUGREPORT_ERROR_INVALID_INPUTContent = default;
            private static bool _BUGREPORT_ERROR_INVALID_INPUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVE"/>
            /// </summary>
            public static int BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVE { get { if (!_BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEReady) { _BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVE"); _BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEReady = true; } return _BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEContent; } }
            private static int _BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEContent = default;
            private static bool _BUGREPORT_ERROR_NO_BUGREPORT_TO_RETRIEVEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_RUNTIME"/>
            /// </summary>
            public static int BUGREPORT_ERROR_RUNTIME { get { if (!_BUGREPORT_ERROR_RUNTIMEReady) { _BUGREPORT_ERROR_RUNTIMEContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_RUNTIME"); _BUGREPORT_ERROR_RUNTIMEReady = true; } return _BUGREPORT_ERROR_RUNTIMEContent; } }
            private static int _BUGREPORT_ERROR_RUNTIMEContent = default;
            private static bool _BUGREPORT_ERROR_RUNTIMEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_USER_CONSENT_TIMED_OUT"/>
            /// </summary>
            public static int BUGREPORT_ERROR_USER_CONSENT_TIMED_OUT { get { if (!_BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTReady) { _BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_USER_CONSENT_TIMED_OUT"); _BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTReady = true; } return _BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTContent; } }
            private static int _BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTContent = default;
            private static bool _BUGREPORT_ERROR_USER_CONSENT_TIMED_OUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#BUGREPORT_ERROR_USER_DENIED_CONSENT"/>
            /// </summary>
            public static int BUGREPORT_ERROR_USER_DENIED_CONSENT { get { if (!_BUGREPORT_ERROR_USER_DENIED_CONSENTReady) { _BUGREPORT_ERROR_USER_DENIED_CONSENTContent = SGetField<int>(LocalBridgeClazz, "BUGREPORT_ERROR_USER_DENIED_CONSENT"); _BUGREPORT_ERROR_USER_DENIED_CONSENTReady = true; } return _BUGREPORT_ERROR_USER_DENIED_CONSENTContent; } }
            private static int _BUGREPORT_ERROR_USER_DENIED_CONSENTContent = default;
            private static bool _BUGREPORT_ERROR_USER_DENIED_CONSENTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#onEarlyReportFinished()"/>
            /// </summary>
            public void OnEarlyReportFinished()
            {
                IExecuteWithSignature("onEarlyReportFinished", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#onError(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnError(int arg0)
            {
                IExecuteWithSignature("onError", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#onFinished()"/>
            /// </summary>
            public void OnFinished()
            {
                IExecuteWithSignature("onFinished", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/BugreportManager.BugreportCallback.html#onProgress(float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            public void OnProgress(float arg0)
            {
                IExecuteWithSignature("onProgress", "(F)V", arg0);
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