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

namespace Android.Accessibilityservice
{
    #region BrailleDisplayController declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html"/>
    /// </summary>
    public partial class BrailleDisplayController : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BrailleDisplayController>
    {
        const string _bridgeClassName = "android.accessibilityservice.BrailleDisplayController";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BrailleDisplayController class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BrailleDisplayController() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BrailleDisplayController class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BrailleDisplayController(params object[] args) : base(args) { }
    
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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
        #region BrailleDisplayCallback declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html"/>
        /// </summary>
        public partial class BrailleDisplayCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BrailleDisplayCallback>
        {
            const string _bridgeClassName = "android.accessibilityservice.BrailleDisplayController$BrailleDisplayCallback";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("BrailleDisplayCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BrailleDisplayCallback() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("BrailleDisplayCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public BrailleDisplayCallback(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region IBrailleDisplayController
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBrailleDisplayController
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region BrailleDisplayController implementation
    public partial class BrailleDisplayController : Android.Accessibilityservice.IBrailleDisplayController
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
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.bluetooth.BluetoothDevice,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Bluetooth.BluetoothDevice arg0, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg1)
        {
            IExecuteWithSignature("connect", "(Landroid/bluetooth/BluetoothDevice;Landroid/accessibilityservice/BrailleDisplayController$BrailleDisplayCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.bluetooth.BluetoothDevice,java.util.concurrent.Executor,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Bluetooth.BluetoothDevice"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Bluetooth.BluetoothDevice arg0, Java.Util.Concurrent.Executor arg1, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg2)
        {
            IExecuteWithSignature("connect", "(Landroid/bluetooth/BluetoothDevice;Ljava/util/concurrent/Executor;Landroid/accessibilityservice/BrailleDisplayController$BrailleDisplayCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.hardware.usb.UsbDevice,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <param name="arg1"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Hardware.Usb.UsbDevice arg0, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg1)
        {
            IExecuteWithSignature("connect", "(Landroid/hardware/usb/UsbDevice;Landroid/accessibilityservice/BrailleDisplayController$BrailleDisplayCallback;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#connect(android.hardware.usb.UsbDevice,java.util.concurrent.Executor,android.accessibilityservice.BrailleDisplayController.BrailleDisplayCallback)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Hardware.Usb.UsbDevice"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.Executor"/></param>
        /// <param name="arg2"><see cref="Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback"/></param>
        public void Connect(Android.Hardware.Usb.UsbDevice arg0, Java.Util.Concurrent.Executor arg1, Android.Accessibilityservice.BrailleDisplayController.BrailleDisplayCallback arg2)
        {
            IExecuteWithSignature("connect", "(Landroid/hardware/usb/UsbDevice;Ljava/util/concurrent/Executor;Landroid/accessibilityservice/BrailleDisplayController$BrailleDisplayCallback;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.html#write(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(byte[] arg0)
        {
            IExecuteWithSignature("write", "([B)V", new object[] { arg0 });
        }
    
        #endregion
    
        #region Nested classes
        #region BrailleDisplayCallback implementation
        public partial class BrailleDisplayCallback
        {
            #region Constructors
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND"/>
            /// </summary>
            public static int FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND { get { if (!_FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady) { _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUND"); _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady = true; } return _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent; } }
            private static int _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDContent = default;
            private static bool _FLAG_ERROR_BRAILLE_DISPLAY_NOT_FOUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#FLAG_ERROR_CANNOT_ACCESS"/>
            /// </summary>
            public static int FLAG_ERROR_CANNOT_ACCESS { get { if (!_FLAG_ERROR_CANNOT_ACCESSReady) { _FLAG_ERROR_CANNOT_ACCESSContent = SGetField<int>(LocalBridgeClazz, "FLAG_ERROR_CANNOT_ACCESS"); _FLAG_ERROR_CANNOT_ACCESSReady = true; } return _FLAG_ERROR_CANNOT_ACCESSContent; } }
            private static int _FLAG_ERROR_CANNOT_ACCESSContent = default;
            private static bool _FLAG_ERROR_CANNOT_ACCESSReady = false; // this is used because in case of generics 
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onConnected(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            public void OnConnected(byte[] arg0)
            {
                IExecuteWithSignature("onConnected", "([B)V", new object[] { arg0 });
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onConnectionFailed(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void OnConnectionFailed(int arg0)
            {
                IExecuteWithSignature("onConnectionFailed", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onDisconnected()"/>
            /// </summary>
            public void OnDisconnected()
            {
                IExecuteWithSignature("onDisconnected", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/accessibilityservice/BrailleDisplayController.BrailleDisplayCallback.html#onInput(byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="byte"/></param>
            public void OnInput(byte[] arg0)
            {
                IExecuteWithSignature("onInput", "([B)V", new object[] { arg0 });
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