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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Os
{
    #region VibratorManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html"/>
    /// </summary>
    public partial class VibratorManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<VibratorManager>
    {
        const string _bridgeClassName = "android.os.VibratorManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("VibratorManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VibratorManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("VibratorManager class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public VibratorManager(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region VibratorManager implementation
    public partial class VibratorManager
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
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getDefaultVibrator()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Vibrator"/></returns>
        public Android.Os.Vibrator GetDefaultVibrator()
        {
            return IExecuteWithSignature<Android.Os.Vibrator>("getDefaultVibrator", "()Landroid/os/Vibrator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getVibrator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Vibrator"/></returns>
        public Android.Os.Vibrator GetVibrator(int arg0)
        {
            return IExecuteWithSignature<Android.Os.Vibrator>("getVibrator", "(I)Landroid/os/Vibrator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#getVibratorIds()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int[] GetVibratorIds()
        {
            return IExecuteWithSignatureArray<int>("getVibratorIds", "()[I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#cancel()"/>
        /// </summary>
        public void Cancel()
        {
            IExecuteWithSignature("cancel", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#vibrate(android.os.CombinedVibration,android.os.VibrationAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.CombinedVibration"/></param>
        /// <param name="arg1"><see cref="Android.Os.VibrationAttributes"/></param>
        public void Vibrate(Android.Os.CombinedVibration arg0, Android.Os.VibrationAttributes arg1)
        {
            IExecute("vibrate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/VibratorManager.html#vibrate(android.os.CombinedVibration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.CombinedVibration"/></param>
        public void Vibrate(Android.Os.CombinedVibration arg0)
        {
            IExecuteWithSignature("vibrate", "(Landroid/os/CombinedVibration;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}