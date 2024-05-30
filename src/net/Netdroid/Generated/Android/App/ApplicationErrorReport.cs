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

namespace Android.App
{
    #region ApplicationErrorReport
    public partial class ApplicationErrorReport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#anrInfo"/>
        /// </summary>
        public Android.App.ApplicationErrorReport.AnrInfo anrInfo { get { return IGetField<Android.App.ApplicationErrorReport.AnrInfo>("anrInfo"); } set { ISetField("anrInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#batteryInfo"/>
        /// </summary>
        public Android.App.ApplicationErrorReport.BatteryInfo batteryInfo { get { return IGetField<Android.App.ApplicationErrorReport.BatteryInfo>("batteryInfo"); } set { ISetField("batteryInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#crashInfo"/>
        /// </summary>
        public Android.App.ApplicationErrorReport.CrashInfo crashInfo { get { return IGetField<Android.App.ApplicationErrorReport.CrashInfo>("crashInfo"); } set { ISetField("crashInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#runningServiceInfo"/>
        /// </summary>
        public Android.App.ApplicationErrorReport.RunningServiceInfo runningServiceInfo { get { return IGetField<Android.App.ApplicationErrorReport.RunningServiceInfo>("runningServiceInfo"); } set { ISetField("runningServiceInfo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#systemApp"/>
        /// </summary>
        public bool systemApp { get { return IGetField<bool>("systemApp"); } set { ISetField("systemApp", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#type"/>
        /// </summary>
        public int type { get { return IGetField<int>("type"); } set { ISetField("type", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#installerPackageName"/>
        /// </summary>
        public Java.Lang.String installerPackageName { get { return IGetField<Java.Lang.String>("installerPackageName"); } set { ISetField("installerPackageName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#packageName"/>
        /// </summary>
        public Java.Lang.String packageName { get { return IGetField<Java.Lang.String>("packageName"); } set { ISetField("packageName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#processName"/>
        /// </summary>
        public Java.Lang.String processName { get { return IGetField<Java.Lang.String>("processName"); } set { ISetField("processName", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#time"/>
        /// </summary>
        public long time { get { return IGetField<long>("time"); } set { ISetField("time", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#TYPE_ANR"/>
        /// </summary>
        public static int TYPE_ANR { get { if (!_TYPE_ANRReady) { _TYPE_ANRContent = SGetField<int>(LocalBridgeClazz, "TYPE_ANR"); _TYPE_ANRReady = true; } return _TYPE_ANRContent; } }
        private static int _TYPE_ANRContent = default;
        private static bool _TYPE_ANRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#TYPE_BATTERY"/>
        /// </summary>
        public static int TYPE_BATTERY { get { if (!_TYPE_BATTERYReady) { _TYPE_BATTERYContent = SGetField<int>(LocalBridgeClazz, "TYPE_BATTERY"); _TYPE_BATTERYReady = true; } return _TYPE_BATTERYContent; } }
        private static int _TYPE_BATTERYContent = default;
        private static bool _TYPE_BATTERYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#TYPE_CRASH"/>
        /// </summary>
        public static int TYPE_CRASH { get { if (!_TYPE_CRASHReady) { _TYPE_CRASHContent = SGetField<int>(LocalBridgeClazz, "TYPE_CRASH"); _TYPE_CRASHReady = true; } return _TYPE_CRASHContent; } }
        private static int _TYPE_CRASHContent = default;
        private static bool _TYPE_CRASHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#TYPE_NONE"/>
        /// </summary>
        public static int TYPE_NONE { get { if (!_TYPE_NONEReady) { _TYPE_NONEContent = SGetField<int>(LocalBridgeClazz, "TYPE_NONE"); _TYPE_NONEReady = true; } return _TYPE_NONEContent; } }
        private static int _TYPE_NONEContent = default;
        private static bool _TYPE_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#TYPE_RUNNING_SERVICE"/>
        /// </summary>
        public static int TYPE_RUNNING_SERVICE { get { if (!_TYPE_RUNNING_SERVICEReady) { _TYPE_RUNNING_SERVICEContent = SGetField<int>(LocalBridgeClazz, "TYPE_RUNNING_SERVICE"); _TYPE_RUNNING_SERVICEReady = true; } return _TYPE_RUNNING_SERVICEContent; } }
        private static int _TYPE_RUNNING_SERVICEContent = default;
        private static bool _TYPE_RUNNING_SERVICEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#getErrorReportReceiver(android.content.Context,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Android.Content.ComponentName"/></returns>
        public static Android.Content.ComponentName GetErrorReportReceiver(Android.Content.Context arg0, Java.Lang.String arg1, int arg2)
        {
            return SExecute<Android.Content.ComponentName>(LocalBridgeClazz, "getErrorReportReceiver", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#dump(android.util.Printer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
        {
            IExecute("dump", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public void ReadFromParcel(Android.Os.Parcel arg0)
        {
            IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region AnrInfo
        public partial class AnrInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public AnrInfo(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#activity"/>
            /// </summary>
            public Java.Lang.String activity { get { return IGetField<Java.Lang.String>("activity"); } set { ISetField("activity", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#cause"/>
            /// </summary>
            public Java.Lang.String cause { get { return IGetField<Java.Lang.String>("cause"); } set { ISetField("cause", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#info"/>
            /// </summary>
            public Java.Lang.String info { get { return IGetField<Java.Lang.String>("info"); } set { ISetField("info", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#dump(android.util.Printer,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
            {
                IExecute("dump", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.AnrInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BatteryInfo
        public partial class BatteryInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public BatteryInfo(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#usagePercent"/>
            /// </summary>
            public int usagePercent { get { return IGetField<int>("usagePercent"); } set { ISetField("usagePercent", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#checkinDetails"/>
            /// </summary>
            public Java.Lang.String checkinDetails { get { return IGetField<Java.Lang.String>("checkinDetails"); } set { ISetField("checkinDetails", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#usageDetails"/>
            /// </summary>
            public Java.Lang.String usageDetails { get { return IGetField<Java.Lang.String>("usageDetails"); } set { ISetField("usageDetails", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#durationMicros"/>
            /// </summary>
            public long durationMicros { get { return IGetField<long>("durationMicros"); } set { ISetField("durationMicros", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#dump(android.util.Printer,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
            {
                IExecute("dump", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.BatteryInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CrashInfo
        public partial class CrashInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public CrashInfo(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#%3Cinit%3E(java.lang.Throwable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
            public CrashInfo(Java.Lang.Throwable arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#throwLineNumber"/>
            /// </summary>
            public int throwLineNumber { get { return IGetField<int>("throwLineNumber"); } set { ISetField("throwLineNumber", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#exceptionClassName"/>
            /// </summary>
            public Java.Lang.String exceptionClassName { get { return IGetField<Java.Lang.String>("exceptionClassName"); } set { ISetField("exceptionClassName", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#exceptionMessage"/>
            /// </summary>
            public Java.Lang.String exceptionMessage { get { return IGetField<Java.Lang.String>("exceptionMessage"); } set { ISetField("exceptionMessage", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#stackTrace"/>
            /// </summary>
            public Java.Lang.String stackTrace { get { return IGetField<Java.Lang.String>("stackTrace"); } set { ISetField("stackTrace", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#throwClassName"/>
            /// </summary>
            public Java.Lang.String throwClassName { get { return IGetField<Java.Lang.String>("throwClassName"); } set { ISetField("throwClassName", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#throwFileName"/>
            /// </summary>
            public Java.Lang.String throwFileName { get { return IGetField<Java.Lang.String>("throwFileName"); } set { ISetField("throwFileName", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#throwMethodName"/>
            /// </summary>
            public Java.Lang.String throwMethodName { get { return IGetField<Java.Lang.String>("throwMethodName"); } set { ISetField("throwMethodName", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#dump(android.util.Printer,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
            {
                IExecute("dump", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.CrashInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region RunningServiceInfo
        public partial class RunningServiceInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.RunningServiceInfo.html#%3Cinit%3E(android.os.Parcel)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            public RunningServiceInfo(Android.Os.Parcel arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.RunningServiceInfo.html#serviceDetails"/>
            /// </summary>
            public Java.Lang.String serviceDetails { get { return IGetField<Java.Lang.String>("serviceDetails"); } set { ISetField("serviceDetails", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.RunningServiceInfo.html#durationMillis"/>
            /// </summary>
            public long durationMillis { get { return IGetField<long>("durationMillis"); } set { ISetField("durationMillis", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.RunningServiceInfo.html#dump(android.util.Printer,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Util.Printer"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public void Dump(Android.Util.Printer arg0, Java.Lang.String arg1)
            {
                IExecute("dump", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/app/ApplicationErrorReport.RunningServiceInfo.html#writeToParcel(android.os.Parcel,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
            {
                IExecute("writeToParcel", arg0, arg1);
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