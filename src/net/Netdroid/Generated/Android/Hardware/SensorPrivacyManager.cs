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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware
{
    #region SensorPrivacyManager declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.html"/>
    /// </summary>
    public partial class SensorPrivacyManager : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SensorPrivacyManager>
    {
        const string _bridgeClassName = "android.hardware.SensorPrivacyManager";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SensorPrivacyManager() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SensorPrivacyManager(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
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
        #region Sensors declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.Sensors.html"/>
        /// </summary>
        public partial class Sensors : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Sensors>
        {
            const string _bridgeClassName = "android.hardware.SensorPrivacyManager$Sensors";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Sensors() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Sensors(params object[] args) : base(args) { }
        
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region SensorPrivacyManager implementation
    public partial class SensorPrivacyManager
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.html#TOGGLE_TYPE_HARDWARE"/>
        /// </summary>
        public static int TOGGLE_TYPE_HARDWARE { get { if (!_TOGGLE_TYPE_HARDWAREReady) { _TOGGLE_TYPE_HARDWAREContent = SGetField<int>(LocalBridgeClazz, "TOGGLE_TYPE_HARDWARE"); _TOGGLE_TYPE_HARDWAREReady = true; } return _TOGGLE_TYPE_HARDWAREContent; } }
        private static int _TOGGLE_TYPE_HARDWAREContent = default;
        private static bool _TOGGLE_TYPE_HARDWAREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.html#TOGGLE_TYPE_SOFTWARE"/>
        /// </summary>
        public static int TOGGLE_TYPE_SOFTWARE { get { if (!_TOGGLE_TYPE_SOFTWAREReady) { _TOGGLE_TYPE_SOFTWAREContent = SGetField<int>(LocalBridgeClazz, "TOGGLE_TYPE_SOFTWARE"); _TOGGLE_TYPE_SOFTWAREReady = true; } return _TOGGLE_TYPE_SOFTWAREContent; } }
        private static int _TOGGLE_TYPE_SOFTWAREContent = default;
        private static bool _TOGGLE_TYPE_SOFTWAREReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.html#supportsSensorToggle(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsSensorToggle(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("supportsSensorToggle", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.html#supportsSensorToggle(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsSensorToggle(int arg0)
        {
            return IExecuteWithSignature<bool>("supportsSensorToggle", "(I)Z", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Sensors implementation
        public partial class Sensors
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.Sensors.html#CAMERA"/>
            /// </summary>
            public static int CAMERA { get { if (!_CAMERAReady) { _CAMERAContent = SGetField<int>(LocalBridgeClazz, "CAMERA"); _CAMERAReady = true; } return _CAMERAContent; } }
            private static int _CAMERAContent = default;
            private static bool _CAMERAReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/SensorPrivacyManager.Sensors.html#MICROPHONE"/>
            /// </summary>
            public static int MICROPHONE { get { if (!_MICROPHONEReady) { _MICROPHONEContent = SGetField<int>(LocalBridgeClazz, "MICROPHONE"); _MICROPHONEReady = true; } return _MICROPHONEContent; } }
            private static int _MICROPHONEContent = default;
            private static bool _MICROPHONEReady = false; // this is used because in case of generics 
        
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