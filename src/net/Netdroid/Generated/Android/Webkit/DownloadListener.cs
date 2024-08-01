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

namespace Android.Webkit
{
    #region IDownloadListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.webkit.DownloadListener implementing <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html"/>
    /// </summary>
    public partial interface IDownloadListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DownloadListener
    public partial class DownloadListener : Android.Webkit.IDownloadListener
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
        /// Handlers initializer for <see cref="DownloadListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onDownloadStart", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnDownloadStartEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnDownloadStart"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Lang.String, Java.Lang.String, Java.Lang.String, Java.Lang.String, long> OnOnDownloadStart { get; set; } = null;

        void OnDownloadStartEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnDownloadStart != null) ? OnOnDownloadStart : OnDownloadStart;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Lang.String>(0), data.EventData.GetAt<Java.Lang.String>(1), data.EventData.GetAt<Java.Lang.String>(2), data.EventData.GetAt<long>(3));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public virtual void OnDownloadStart(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, long arg4)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DownloadListenerDirect
    public partial class DownloadListenerDirect : Android.Webkit.IDownloadListener
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
        /// <see href="https://developer.android.com/reference/android/webkit/DownloadListener.html#onDownloadStart(java.lang.String,java.lang.String,java.lang.String,java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public override void OnDownloadStart(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, long arg4)
        {
            IExecute("onDownloadStart", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}