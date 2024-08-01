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

namespace Android.View
{
    #region PixelCopy
    public partial class PixelCopy
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#ERROR_DESTINATION_INVALID"/>
        /// </summary>
        public static int ERROR_DESTINATION_INVALID { get { if (!_ERROR_DESTINATION_INVALIDReady) { _ERROR_DESTINATION_INVALIDContent = SGetField<int>(LocalBridgeClazz, "ERROR_DESTINATION_INVALID"); _ERROR_DESTINATION_INVALIDReady = true; } return _ERROR_DESTINATION_INVALIDContent; } }
        private static int _ERROR_DESTINATION_INVALIDContent = default;
        private static bool _ERROR_DESTINATION_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#ERROR_SOURCE_INVALID"/>
        /// </summary>
        public static int ERROR_SOURCE_INVALID { get { if (!_ERROR_SOURCE_INVALIDReady) { _ERROR_SOURCE_INVALIDContent = SGetField<int>(LocalBridgeClazz, "ERROR_SOURCE_INVALID"); _ERROR_SOURCE_INVALIDReady = true; } return _ERROR_SOURCE_INVALIDContent; } }
        private static int _ERROR_SOURCE_INVALIDContent = default;
        private static bool _ERROR_SOURCE_INVALIDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#ERROR_SOURCE_NO_DATA"/>
        /// </summary>
        public static int ERROR_SOURCE_NO_DATA { get { if (!_ERROR_SOURCE_NO_DATAReady) { _ERROR_SOURCE_NO_DATAContent = SGetField<int>(LocalBridgeClazz, "ERROR_SOURCE_NO_DATA"); _ERROR_SOURCE_NO_DATAReady = true; } return _ERROR_SOURCE_NO_DATAContent; } }
        private static int _ERROR_SOURCE_NO_DATAContent = default;
        private static bool _ERROR_SOURCE_NO_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#ERROR_TIMEOUT"/>
        /// </summary>
        public static int ERROR_TIMEOUT { get { if (!_ERROR_TIMEOUTReady) { _ERROR_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "ERROR_TIMEOUT"); _ERROR_TIMEOUTReady = true; } return _ERROR_TIMEOUTContent; } }
        private static int _ERROR_TIMEOUTContent = default;
        private static bool _ERROR_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#ERROR_UNKNOWN"/>
        /// </summary>
        public static int ERROR_UNKNOWN { get { if (!_ERROR_UNKNOWNReady) { _ERROR_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "ERROR_UNKNOWN"); _ERROR_UNKNOWNReady = true; } return _ERROR_UNKNOWNContent; } }
        private static int _ERROR_UNKNOWNContent = default;
        private static bool _ERROR_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#SUCCESS"/>
        /// </summary>
        public static int SUCCESS { get { if (!_SUCCESSReady) { _SUCCESSContent = SGetField<int>(LocalBridgeClazz, "SUCCESS"); _SUCCESSReady = true; } return _SUCCESSContent; } }
        private static int _SUCCESSContent = default;
        private static bool _SUCCESSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.PixelCopy.Request,java.util.concurrent.Executor,java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.PixelCopy.Request"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.Consumer"/></param>
        public static void RequestMethod(Android.View.PixelCopy.Request arg0, Java.Util.Concurrent.Executor arg1, Java.Util.Function.Consumer<Android.View.PixelCopy.Result> arg2)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.Surface,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg2"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.Surface arg0, Android.Graphics.Bitmap arg1, Android.View.PixelCopy.OnPixelCopyFinishedListener arg2, Android.Os.Handler arg3)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.Surface,android.graphics.Rect,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Surface"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg3"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.Surface arg0, Android.Graphics.Rect arg1, Android.Graphics.Bitmap arg2, Android.View.PixelCopy.OnPixelCopyFinishedListener arg3, Android.Os.Handler arg4)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.SurfaceView,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceView"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg2"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.SurfaceView arg0, Android.Graphics.Bitmap arg1, Android.View.PixelCopy.OnPixelCopyFinishedListener arg2, Android.Os.Handler arg3)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.SurfaceView,android.graphics.Rect,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.SurfaceView"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg3"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.SurfaceView arg0, Android.Graphics.Rect arg1, Android.Graphics.Bitmap arg2, Android.View.PixelCopy.OnPixelCopyFinishedListener arg3, Android.Os.Handler arg4)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.Window,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Window"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg2"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg3"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.Window arg0, Android.Graphics.Bitmap arg1, Android.View.PixelCopy.OnPixelCopyFinishedListener arg2, Android.Os.Handler arg3)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/PixelCopy.html#request(android.view.Window,android.graphics.Rect,android.graphics.Bitmap,android.view.PixelCopy.OnPixelCopyFinishedListener,android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.Window"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg2"><see cref="Android.Graphics.Bitmap"/></param>
        /// <param name="arg3"><see cref="Android.View.PixelCopy.OnPixelCopyFinishedListener"/></param>
        /// <param name="arg4"><see cref="Android.Os.Handler"/></param>
        public static void RequestMethod(Android.View.Window arg0, Android.Graphics.Rect arg1, Android.Graphics.Bitmap arg2, Android.View.PixelCopy.OnPixelCopyFinishedListener arg3, Android.Os.Handler arg4)
        {
            SExecute(LocalBridgeClazz, "request", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region OnPixelCopyFinishedListener
        public partial class OnPixelCopyFinishedListener
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
            /// Handlers initializer for <see cref="OnPixelCopyFinishedListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onPixelCopyFinished", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnPixelCopyFinishedEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/view/PixelCopy.OnPixelCopyFinishedListener.html#onPixelCopyFinished(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnPixelCopyFinished"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnPixelCopyFinished { get; set; } = null;

            void OnPixelCopyFinishedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnPixelCopyFinished != null) ? OnOnPixelCopyFinished : OnPixelCopyFinished;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.OnPixelCopyFinishedListener.html#onPixelCopyFinished(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnPixelCopyFinished(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnPixelCopyFinishedListenerDirect
        public partial class OnPixelCopyFinishedListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.OnPixelCopyFinishedListener.html#onPixelCopyFinished(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnPixelCopyFinished(int arg0)
            {
                IExecuteWithSignature("onPixelCopyFinished", "(I)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Request
        public partial class Request
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
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.html#getDestinationBitmap()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
            public Android.Graphics.Bitmap GetDestinationBitmap()
            {
                return IExecuteWithSignature<Android.Graphics.Bitmap>("getDestinationBitmap", "()Landroid/graphics/Bitmap;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.html#getSourceRect()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Rect"/></returns>
            public Android.Graphics.Rect GetSourceRect()
            {
                return IExecuteWithSignature<Android.Graphics.Rect>("getSourceRect", "()Landroid/graphics/Rect;");
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
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#ofSurface(android.view.Surface)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.View.Surface"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public static Android.View.PixelCopy.Request.Builder OfSurface(Android.View.Surface arg0)
                {
                    return SExecuteWithSignature<Android.View.PixelCopy.Request.Builder>(LocalBridgeClazz, "ofSurface", "(Landroid/view/Surface;)Landroid/view/PixelCopy$Request$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#ofSurface(android.view.SurfaceView)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.View.SurfaceView"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public static Android.View.PixelCopy.Request.Builder OfSurface(Android.View.SurfaceView arg0)
                {
                    return SExecuteWithSignature<Android.View.PixelCopy.Request.Builder>(LocalBridgeClazz, "ofSurface", "(Landroid/view/SurfaceView;)Landroid/view/PixelCopy$Request$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#ofWindow(android.view.View)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.View.View"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public static Android.View.PixelCopy.Request.Builder OfWindow(Android.View.View arg0)
                {
                    return SExecuteWithSignature<Android.View.PixelCopy.Request.Builder>(LocalBridgeClazz, "ofWindow", "(Landroid/view/View;)Landroid/view/PixelCopy$Request$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#ofWindow(android.view.Window)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.View.Window"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public static Android.View.PixelCopy.Request.Builder OfWindow(Android.View.Window arg0)
                {
                    return SExecuteWithSignature<Android.View.PixelCopy.Request.Builder>(LocalBridgeClazz, "ofWindow", "(Landroid/view/Window;)Landroid/view/PixelCopy$Request$Builder;", arg0);
                }

                #endregion

                #region Instance methods
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#build()"/>
                /// </summary>
                /// <returns><see cref="Android.View.PixelCopy.Request"/></returns>
                public Android.View.PixelCopy.Request Build()
                {
                    return IExecuteWithSignature<Android.View.PixelCopy.Request>("build", "()Landroid/view/PixelCopy$Request;");
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#setDestinationBitmap(android.graphics.Bitmap)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Graphics.Bitmap"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public Android.View.PixelCopy.Request.Builder SetDestinationBitmap(Android.Graphics.Bitmap arg0)
                {
                    return IExecuteWithSignature<Android.View.PixelCopy.Request.Builder>("setDestinationBitmap", "(Landroid/graphics/Bitmap;)Landroid/view/PixelCopy$Request$Builder;", arg0);
                }
                /// <summary>
                /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Request.Builder.html#setSourceRect(android.graphics.Rect)"/>
                /// </summary>
                /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
                /// <returns><see cref="Android.View.PixelCopy.Request.Builder"/></returns>
                public Android.View.PixelCopy.Request.Builder SetSourceRect(Android.Graphics.Rect arg0)
                {
                    return IExecuteWithSignature<Android.View.PixelCopy.Request.Builder>("setSourceRect", "(Landroid/graphics/Rect;)Landroid/view/PixelCopy$Request$Builder;", arg0);
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

        #region Result
        public partial class Result
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
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Result.html#getBitmap()"/>
            /// </summary>
            /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
            public Android.Graphics.Bitmap GetBitmap()
            {
                return IExecuteWithSignature<Android.Graphics.Bitmap>("getBitmap", "()Landroid/graphics/Bitmap;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/view/PixelCopy.Result.html#getStatus()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetStatus()
            {
                return IExecuteWithSignature<int>("getStatus", "()I");
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