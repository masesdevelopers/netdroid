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

namespace Android.View
{
    #region OrientationListener
    public partial class OrientationListener
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
        /// Handlers initializer for <see cref="OrientationListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onOrientationChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnOrientationChangedEventHandler));
            AddEventHandler("disable", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(DisableEventHandler));
            AddEventHandler("enable", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(EnableEventHandler));
            AddEventHandler("onAccuracyChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnAccuracyChangedEventHandler));
            AddEventHandler("onSensorChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnSensorChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onOrientationChanged(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnOrientationChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int> OnOnOrientationChanged { get; set; } = null;

        void OnOrientationChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnOrientationChanged != null) ? OnOnOrientationChanged : OnOrientationChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onOrientationChanged(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public virtual void OnOrientationChanged(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/OrientationListener.html#disable()"/>
        /// </summary>
        /// <remarks>If <see cref="OnDisable"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnDisable { get; set; } = null;

        void DisableEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnDisable != null) ? OnDisable : Disable;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#disable()"/>
        /// </summary>
        [global::System.Obsolete()]
        public virtual void Disable()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/OrientationListener.html#enable()"/>
        /// </summary>
        /// <remarks>If <see cref="OnEnable"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action OnEnable { get; set; } = null;

        void EnableEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnEnable != null) ? OnEnable : Enable;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#enable()"/>
        /// </summary>
        [global::System.Obsolete()]
        public virtual void Enable()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAccuracyChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, int> OnOnAccuracyChanged { get; set; } = null;

        void OnAccuracyChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnAccuracyChanged != null) ? OnOnAccuracyChanged : OnAccuracyChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public virtual void OnAccuracyChanged(int arg0, int arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSensorChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, float[]> OnOnSensorChanged { get; set; } = null;

        void OnSensorChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnSensorChanged != null) ? OnOnSensorChanged : OnSensorChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<float[]>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public virtual void OnSensorChanged(int arg0, float[] arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OrientationListenerDirect
    public partial class OrientationListenerDirect
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
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onOrientationChanged(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public override void OnOrientationChanged(int arg0)
        {
            IExecuteWithSignature("onOrientationChanged", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#disable()"/>
        /// </summary>
        [global::System.Obsolete()]
        public override void Disable()
        {
            IExecuteWithSignature("disable", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#enable()"/>
        /// </summary>
        [global::System.Obsolete()]
        public override void Enable()
        {
            IExecuteWithSignature("enable", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public override void OnAccuracyChanged(int arg0, int arg1)
        {
            IExecute("onAccuracyChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/OrientationListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public override void OnSensorChanged(int arg0, float[] arg1)
        {
            IExecute("onSensorChanged", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}