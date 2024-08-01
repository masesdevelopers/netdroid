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

namespace Android.Hardware
{
    #region ISensorListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.hardware.SensorListener implementing <see href="https://developer.android.com/reference/android/hardware/SensorListener.html"/>
    /// </summary>
    public partial interface ISensorListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SensorListener
    public partial class SensorListener : Android.Hardware.ISensorListener
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
        /// Handlers initializer for <see cref="SensorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onAccuracyChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnAccuracyChangedEventHandler));
            AddEventHandler("onSensorChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnSensorChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnAccuracyChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, int> OnOnAccuracyChanged { get; set; } = null;

        void OnAccuracyChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnAccuracyChanged != null) ? OnOnAccuracyChanged : OnAccuracyChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public virtual void OnAccuracyChanged(int arg0, int arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnSensorChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<int, float[]> OnOnSensorChanged { get; set; } = null;

        void OnSensorChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnOnSensorChanged != null) ? OnOnSensorChanged : OnSensorChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<float[]>(0));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
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

    #region SensorListenerDirect
    public partial class SensorListenerDirect : Android.Hardware.ISensorListener
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
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onAccuracyChanged(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        [global::System.Obsolete()]
        public override void OnAccuracyChanged(int arg0, int arg1)
        {
            IExecute("onAccuracyChanged", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorListener.html#onSensorChanged(int,float[])"/>
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