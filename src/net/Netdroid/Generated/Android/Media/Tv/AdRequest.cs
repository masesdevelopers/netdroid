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

namespace Android.Media.Tv
{
    #region AdRequest
    public partial class AdRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#%3Cinit%3E(int,int,android.net.Uri,long,long,long,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="Android.Os.Bundle"/></param>
        public AdRequest(int arg0, int arg1, Android.Net.Uri arg2, long arg3, long arg4, long arg5, Android.Os.Bundle arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#%3Cinit%3E(int,int,android.os.ParcelFileDescriptor,long,long,long,java.lang.String,android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        /// <param name="arg5"><see cref="long"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="Android.Os.Bundle"/></param>
        public AdRequest(int arg0, int arg1, Android.Os.ParcelFileDescriptor arg2, long arg3, long arg4, long arg5, Java.Lang.String arg6, Android.Os.Bundle arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#REQUEST_TYPE_START"/>
        /// </summary>
        public static int REQUEST_TYPE_START { get { if (!_REQUEST_TYPE_STARTReady) { _REQUEST_TYPE_STARTContent = SGetField<int>(LocalBridgeClazz, "REQUEST_TYPE_START"); _REQUEST_TYPE_STARTReady = true; } return _REQUEST_TYPE_STARTContent; } }
        private static int _REQUEST_TYPE_STARTContent = default;
        private static bool _REQUEST_TYPE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#REQUEST_TYPE_STOP"/>
        /// </summary>
        public static int REQUEST_TYPE_STOP { get { if (!_REQUEST_TYPE_STOPReady) { _REQUEST_TYPE_STOPContent = SGetField<int>(LocalBridgeClazz, "REQUEST_TYPE_STOP"); _REQUEST_TYPE_STOPReady = true; } return _REQUEST_TYPE_STOPContent; } }
        private static int _REQUEST_TYPE_STOPContent = default;
        private static bool _REQUEST_TYPE_STOPReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getEchoIntervalMillis()"/> 
        /// </summary>
        public long EchoIntervalMillis
        {
            get { return IExecuteWithSignature<long>("getEchoIntervalMillis", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getFileDescriptor()"/> 
        /// </summary>
        public Android.Os.ParcelFileDescriptor FileDescriptor
        {
            get { return IExecuteWithSignature<Android.Os.ParcelFileDescriptor>("getFileDescriptor", "()Landroid/os/ParcelFileDescriptor;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getId()"/> 
        /// </summary>
        public int Id
        {
            get { return IExecuteWithSignature<int>("getId", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getMediaFileType()"/> 
        /// </summary>
        public Java.Lang.String MediaFileType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMediaFileType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getMetadata()"/> 
        /// </summary>
        public Android.Os.Bundle Metadata
        {
            get { return IExecuteWithSignature<Android.Os.Bundle>("getMetadata", "()Landroid/os/Bundle;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getRequestType()"/> 
        /// </summary>
        public int RequestType
        {
            get { return IExecuteWithSignature<int>("getRequestType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getStartTimeMillis()"/> 
        /// </summary>
        public long StartTimeMillis
        {
            get { return IExecuteWithSignature<long>("getStartTimeMillis", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getStopTimeMillis()"/> 
        /// </summary>
        public long StopTimeMillis
        {
            get { return IExecuteWithSignature<long>("getStopTimeMillis", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#getUri()"/> 
        /// </summary>
        public Android.Net.Uri Uri
        {
            get { return IExecuteWithSignature<Android.Net.Uri>("getUri", "()Landroid/net/Uri;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/AdRequest.html#writeToParcel(android.os.Parcel,int)"/>
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