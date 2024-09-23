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

namespace Android.View
{
    #region ViewOutlineProvider declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html"/>
    /// </summary>
    public partial class ViewOutlineProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ViewOutlineProvider>
    {
        const string _bridgeClassName = "android.view.ViewOutlineProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ViewOutlineProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ViewOutlineProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ViewOutlineProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ViewOutlineProvider(params object[] args) : base(args) { }

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

    #region ViewOutlineProvider implementation
    public partial class ViewOutlineProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#BACKGROUND"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider BACKGROUND { get { if (!_BACKGROUNDReady) { _BACKGROUNDContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "BACKGROUND"); _BACKGROUNDReady = true; } return _BACKGROUNDContent; } }
        private static Android.View.ViewOutlineProvider _BACKGROUNDContent = default;
        private static bool _BACKGROUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#BOUNDS"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider BOUNDS { get { if (!_BOUNDSReady) { _BOUNDSContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "BOUNDS"); _BOUNDSReady = true; } return _BOUNDSContent; } }
        private static Android.View.ViewOutlineProvider _BOUNDSContent = default;
        private static bool _BOUNDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#PADDED_BOUNDS"/>
        /// </summary>
        public static Android.View.ViewOutlineProvider PADDED_BOUNDS { get { if (!_PADDED_BOUNDSReady) { _PADDED_BOUNDSContent = SGetField<Android.View.ViewOutlineProvider>(LocalBridgeClazz, "PADDED_BOUNDS"); _PADDED_BOUNDSReady = true; } return _PADDED_BOUNDSContent; } }
        private static Android.View.ViewOutlineProvider _PADDED_BOUNDSContent = default;
        private static bool _PADDED_BOUNDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/view/ViewOutlineProvider.html#getOutline(android.view.View,android.graphics.Outline)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Outline"/></param>
        public void GetOutline(Android.View.View arg0, Android.Graphics.Outline arg1)
        {
            IExecute("getOutline", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}