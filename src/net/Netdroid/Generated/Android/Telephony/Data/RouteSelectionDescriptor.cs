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

namespace Android.Telephony.Data
{
    #region RouteSelectionDescriptor
    public partial class RouteSelectionDescriptor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#ROUTE_SSC_MODE_1"/>
        /// </summary>
        public static int ROUTE_SSC_MODE_1 { get { if (!_ROUTE_SSC_MODE_1Ready) { _ROUTE_SSC_MODE_1Content = SGetField<int>(LocalBridgeClazz, "ROUTE_SSC_MODE_1"); _ROUTE_SSC_MODE_1Ready = true; } return _ROUTE_SSC_MODE_1Content; } }
        private static int _ROUTE_SSC_MODE_1Content = default;
        private static bool _ROUTE_SSC_MODE_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#ROUTE_SSC_MODE_2"/>
        /// </summary>
        public static int ROUTE_SSC_MODE_2 { get { if (!_ROUTE_SSC_MODE_2Ready) { _ROUTE_SSC_MODE_2Content = SGetField<int>(LocalBridgeClazz, "ROUTE_SSC_MODE_2"); _ROUTE_SSC_MODE_2Ready = true; } return _ROUTE_SSC_MODE_2Content; } }
        private static int _ROUTE_SSC_MODE_2Content = default;
        private static bool _ROUTE_SSC_MODE_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#ROUTE_SSC_MODE_3"/>
        /// </summary>
        public static int ROUTE_SSC_MODE_3 { get { if (!_ROUTE_SSC_MODE_3Ready) { _ROUTE_SSC_MODE_3Content = SGetField<int>(LocalBridgeClazz, "ROUTE_SSC_MODE_3"); _ROUTE_SSC_MODE_3Ready = true; } return _ROUTE_SSC_MODE_3Content; } }
        private static int _ROUTE_SSC_MODE_3Content = default;
        private static bool _ROUTE_SSC_MODE_3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#SESSION_TYPE_IPV4"/>
        /// </summary>
        public static int SESSION_TYPE_IPV4 { get { if (!_SESSION_TYPE_IPV4Ready) { _SESSION_TYPE_IPV4Content = SGetField<int>(LocalBridgeClazz, "SESSION_TYPE_IPV4"); _SESSION_TYPE_IPV4Ready = true; } return _SESSION_TYPE_IPV4Content; } }
        private static int _SESSION_TYPE_IPV4Content = default;
        private static bool _SESSION_TYPE_IPV4Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#SESSION_TYPE_IPV4V6"/>
        /// </summary>
        public static int SESSION_TYPE_IPV4V6 { get { if (!_SESSION_TYPE_IPV4V6Ready) { _SESSION_TYPE_IPV4V6Content = SGetField<int>(LocalBridgeClazz, "SESSION_TYPE_IPV4V6"); _SESSION_TYPE_IPV4V6Ready = true; } return _SESSION_TYPE_IPV4V6Content; } }
        private static int _SESSION_TYPE_IPV4V6Content = default;
        private static bool _SESSION_TYPE_IPV4V6Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#SESSION_TYPE_IPV6"/>
        /// </summary>
        public static int SESSION_TYPE_IPV6 { get { if (!_SESSION_TYPE_IPV6Ready) { _SESSION_TYPE_IPV6Content = SGetField<int>(LocalBridgeClazz, "SESSION_TYPE_IPV6"); _SESSION_TYPE_IPV6Ready = true; } return _SESSION_TYPE_IPV6Content; } }
        private static int _SESSION_TYPE_IPV6Content = default;
        private static bool _SESSION_TYPE_IPV6Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#getDataNetworkName()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> DataNetworkName
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getDataNetworkName", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#getPrecedence()"/> 
        /// </summary>
        public int Precedence
        {
            get { return IExecuteWithSignature<int>("getPrecedence", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#getSessionType()"/> 
        /// </summary>
        public int SessionType
        {
            get { return IExecuteWithSignature<int>("getSessionType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#getSliceInfo()"/> 
        /// </summary>
        public Java.Util.List<Android.Telephony.Data.NetworkSliceInfo> SliceInfo
        {
            get { return IExecuteWithSignature<Java.Util.List<Android.Telephony.Data.NetworkSliceInfo>>("getSliceInfo", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#getSscMode()"/> 
        /// </summary>
        public int SscMode
        {
            get { return IExecuteWithSignature<int>("getSscMode", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/telephony/data/RouteSelectionDescriptor.html#writeToParcel(android.os.Parcel,int)"/>
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
}