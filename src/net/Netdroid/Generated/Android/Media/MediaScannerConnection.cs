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

namespace Android.Media
{
    #region MediaScannerConnection
    public partial class MediaScannerConnection
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#%3Cinit%3E(android.content.Context,android.media.MediaScannerConnection.MediaScannerConnectionClient)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Media.MediaScannerConnection.MediaScannerConnectionClient"/></param>
        public MediaScannerConnection(Android.Content.Context arg0, Android.Media.MediaScannerConnection.MediaScannerConnectionClient arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#scanFile(android.content.Context,java.lang.String[],java.lang.String[],android.media.MediaScannerConnection.OnScanCompletedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Android.Media.MediaScannerConnection.OnScanCompletedListener"/></param>
        public static void ScanFile(Android.Content.Context arg0, Java.Lang.String[] arg1, Java.Lang.String[] arg2, Android.Media.MediaScannerConnection.OnScanCompletedListener arg3)
        {
            SExecute(LocalBridgeClazz, "scanFile", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#connect()"/>
        /// </summary>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#onServiceConnected(android.content.ComponentName,android.os.IBinder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        /// <param name="arg1"><see cref="Android.Os.IBinder"/></param>
        public void OnServiceConnected(Android.Content.ComponentName arg0, Android.Os.IBinder arg1)
        {
            IExecute("onServiceConnected", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#onServiceDisconnected(android.content.ComponentName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ComponentName"/></param>
        public void OnServiceDisconnected(Android.Content.ComponentName arg0)
        {
            IExecuteWithSignature("onServiceDisconnected", "(Landroid/content/ComponentName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.html#scanFile(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void ScanFile(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("scanFile", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region MediaScannerConnectionClient
        public partial class MediaScannerConnectionClient
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
            /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.MediaScannerConnectionClient.html#onMediaScannerConnected()"/>
            /// </summary>
            public void OnMediaScannerConnected()
            {
                IExecuteWithSignature("onMediaScannerConnected", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnScanCompletedListener
        public partial class OnScanCompletedListener
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
            /// Handlers initializer for <see cref="OnScanCompletedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onScanCompleted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnScanCompletedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.OnScanCompletedListener.html#onScanCompleted(java.lang.String,android.net.Uri)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScanCompleted"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Action<Java.Lang.String, Android.Net.Uri> OnOnScanCompleted { get; set; } = null;

            void OnScanCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
            {
                var methodToExecute = (OnOnScanCompleted != null) ? OnOnScanCompleted : OnScanCompleted;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Net.Uri>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.OnScanCompletedListener.html#onScanCompleted(java.lang.String,android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            public virtual void OnScanCompleted(Java.Lang.String arg0, Android.Net.Uri arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnScanCompletedListenerDirect
        public partial class OnScanCompletedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/MediaScannerConnection.OnScanCompletedListener.html#onScanCompleted(java.lang.String,android.net.Uri)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
            public override void OnScanCompleted(Java.Lang.String arg0, Android.Net.Uri arg1)
            {
                IExecute("onScanCompleted", arg0, arg1);
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