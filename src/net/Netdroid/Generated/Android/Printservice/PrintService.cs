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

namespace Android.Printservice
{
    #region PrintService declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html"/>
    /// </summary>
    public partial class PrintService : Android.App.Service
    {
        const string _bridgeClassName = "android.printservice.PrintService";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PrintService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrintService() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PrintService class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrintService(params object[] args) : base(args) { }
    
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

    #region PrintService implementation
    public partial class PrintService
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#EXTRA_CAN_SELECT_PRINTER"/>
        /// </summary>
        public static Java.Lang.String EXTRA_CAN_SELECT_PRINTER { get { if (!_EXTRA_CAN_SELECT_PRINTERReady) { _EXTRA_CAN_SELECT_PRINTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_CAN_SELECT_PRINTER"); _EXTRA_CAN_SELECT_PRINTERReady = true; } return _EXTRA_CAN_SELECT_PRINTERContent; } }
        private static Java.Lang.String _EXTRA_CAN_SELECT_PRINTERContent = default;
        private static bool _EXTRA_CAN_SELECT_PRINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#EXTRA_PRINT_DOCUMENT_INFO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PRINT_DOCUMENT_INFO { get { if (!_EXTRA_PRINT_DOCUMENT_INFOReady) { _EXTRA_PRINT_DOCUMENT_INFOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PRINT_DOCUMENT_INFO"); _EXTRA_PRINT_DOCUMENT_INFOReady = true; } return _EXTRA_PRINT_DOCUMENT_INFOContent; } }
        private static Java.Lang.String _EXTRA_PRINT_DOCUMENT_INFOContent = default;
        private static bool _EXTRA_PRINT_DOCUMENT_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#EXTRA_PRINT_JOB_INFO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PRINT_JOB_INFO { get { if (!_EXTRA_PRINT_JOB_INFOReady) { _EXTRA_PRINT_JOB_INFOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PRINT_JOB_INFO"); _EXTRA_PRINT_JOB_INFOReady = true; } return _EXTRA_PRINT_JOB_INFOContent; } }
        private static Java.Lang.String _EXTRA_PRINT_JOB_INFOContent = default;
        private static bool _EXTRA_PRINT_JOB_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#EXTRA_PRINTER_INFO"/>
        /// </summary>
        public static Java.Lang.String EXTRA_PRINTER_INFO { get { if (!_EXTRA_PRINTER_INFOReady) { _EXTRA_PRINTER_INFOContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_PRINTER_INFO"); _EXTRA_PRINTER_INFOReady = true; } return _EXTRA_PRINTER_INFOContent; } }
        private static Java.Lang.String _EXTRA_PRINTER_INFOContent = default;
        private static bool _EXTRA_PRINTER_INFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#EXTRA_SELECT_PRINTER"/>
        /// </summary>
        public static Java.Lang.String EXTRA_SELECT_PRINTER { get { if (!_EXTRA_SELECT_PRINTERReady) { _EXTRA_SELECT_PRINTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EXTRA_SELECT_PRINTER"); _EXTRA_SELECT_PRINTERReady = true; } return _EXTRA_SELECT_PRINTERContent; } }
        private static Java.Lang.String _EXTRA_SELECT_PRINTERContent = default;
        private static bool _EXTRA_SELECT_PRINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#SERVICE_INTERFACE"/>
        /// </summary>
        public static Java.Lang.String SERVICE_INTERFACE { get { if (!_SERVICE_INTERFACEReady) { _SERVICE_INTERFACEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_INTERFACE"); _SERVICE_INTERFACEReady = true; } return _SERVICE_INTERFACEContent; } }
        private static Java.Lang.String _SERVICE_INTERFACEContent = default;
        private static bool _SERVICE_INTERFACEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#SERVICE_META_DATA"/>
        /// </summary>
        public static Java.Lang.String SERVICE_META_DATA { get { if (!_SERVICE_META_DATAReady) { _SERVICE_META_DATAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SERVICE_META_DATA"); _SERVICE_META_DATAReady = true; } return _SERVICE_META_DATAContent; } }
        private static Java.Lang.String _SERVICE_META_DATAContent = default;
        private static bool _SERVICE_META_DATAReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#generatePrinterId(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Print.PrinterId"/></returns>
        public Android.Print.PrinterId GeneratePrinterId(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Print.PrinterId>("generatePrinterId", "(Ljava/lang/String;)Landroid/print/PrinterId;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/printservice/PrintService.html#getActivePrintJobs()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Printservice.PrintJob> GetActivePrintJobs()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Printservice.PrintJob>>("getActivePrintJobs", "()Ljava/util/List;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}