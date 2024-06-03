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

namespace Android.Media.Audiofx
{
    #region BassBoost
    public partial class BassBoost
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.RuntimeException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public BassBoost(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#PARAM_STRENGTH"/>
        /// </summary>
        public static int PARAM_STRENGTH { get { if (!_PARAM_STRENGTHReady) { _PARAM_STRENGTHContent = SGetField<int>(LocalBridgeClazz, "PARAM_STRENGTH"); _PARAM_STRENGTHReady = true; } return _PARAM_STRENGTHContent; } }
        private static int _PARAM_STRENGTHContent = default;
        private static bool _PARAM_STRENGTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#PARAM_STRENGTH_SUPPORTED"/>
        /// </summary>
        public static int PARAM_STRENGTH_SUPPORTED { get { if (!_PARAM_STRENGTH_SUPPORTEDReady) { _PARAM_STRENGTH_SUPPORTEDContent = SGetField<int>(LocalBridgeClazz, "PARAM_STRENGTH_SUPPORTED"); _PARAM_STRENGTH_SUPPORTEDReady = true; } return _PARAM_STRENGTH_SUPPORTEDContent; } }
        private static int _PARAM_STRENGTH_SUPPORTEDContent = default;
        private static bool _PARAM_STRENGTH_SUPPORTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#getProperties()"/>
        /// </summary>
        /// <returns><see cref="Android.Media.Audiofx.BassBoost.Settings"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public Android.Media.Audiofx.BassBoost.Settings GetProperties()
        {
            return IExecuteWithSignature<Android.Media.Audiofx.BassBoost.Settings>("getProperties", "()Landroid/media/audiofx/BassBoost$Settings;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#getStrengthSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetStrengthSupported()
        {
            return IExecuteWithSignature<bool>("getStrengthSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#getRoundedStrength()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public short GetRoundedStrength()
        {
            return IExecuteWithSignature<short>("getRoundedStrength", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#setParameterListener(android.media.audiofx.BassBoost.OnParameterChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.BassBoost.OnParameterChangeListener"/></param>
        public void SetParameterListener(Android.Media.Audiofx.BassBoost.OnParameterChangeListener arg0)
        {
            IExecuteWithSignature("setParameterListener", "(Landroid/media/audiofx/BassBoost$OnParameterChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#setProperties(android.media.audiofx.BassBoost.Settings)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Audiofx.BassBoost.Settings"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetProperties(Android.Media.Audiofx.BassBoost.Settings arg0)
        {
            IExecuteWithSignature("setProperties", "(Landroid/media/audiofx/BassBoost$Settings;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.html#setStrength(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetStrength(short arg0)
        {
            IExecuteWithSignature("setStrength", "(S)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OnParameterChangeListener
        public partial class OnParameterChangeListener
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
            /// Handlers initializer for <see cref="OnParameterChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onParameterChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Media.Audiofx.BassBoost>>>(OnParameterChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.BassBoost,int,int,short)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnParameterChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Media.Audiofx.BassBoost, int, int, short> OnOnParameterChange { get; set; } = null;

            void OnParameterChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Media.Audiofx.BassBoost>> data)
            {
                var methodToExecute = (OnOnParameterChange != null) ? OnOnParameterChange : OnParameterChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<short>(2));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.BassBoost,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.BassBoost"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            public virtual void OnParameterChange(Android.Media.Audiofx.BassBoost arg0, int arg1, int arg2, short arg3)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnParameterChangeListenerDirect
        public partial class OnParameterChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.OnParameterChangeListener.html#onParameterChange(android.media.audiofx.BassBoost,int,int,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Media.Audiofx.BassBoost"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="short"/></param>
            public override void OnParameterChange(Android.Media.Audiofx.BassBoost arg0, int arg1, int arg2, short arg3)
            {
                IExecute("onParameterChange", arg0, arg1, arg2, arg3);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Settings
        public partial class Settings
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.Settings.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public Settings(Java.Lang.String arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/audiofx/BassBoost.Settings.html#strength"/>
            /// </summary>
            public short strength { get { return IGetField<short>("strength"); } set { ISetField("strength", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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