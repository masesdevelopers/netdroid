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

namespace Android.Net.Http
{
    #region ConnectionMigrationOptions declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html"/>
    /// </summary>
    public partial class ConnectionMigrationOptions : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ConnectionMigrationOptions>
    {
        const string _bridgeClassName = "android.net.http.ConnectionMigrationOptions";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ConnectionMigrationOptions() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ConnectionMigrationOptions(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.net.http.ConnectionMigrationOptions$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region ConnectionMigrationOptions implementation
    public partial class ConnectionMigrationOptions
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#MIGRATION_OPTION_DISABLED"/>
        /// </summary>
        public static int MIGRATION_OPTION_DISABLED { get { if (!_MIGRATION_OPTION_DISABLEDReady) { _MIGRATION_OPTION_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "MIGRATION_OPTION_DISABLED"); _MIGRATION_OPTION_DISABLEDReady = true; } return _MIGRATION_OPTION_DISABLEDContent; } }
        private static int _MIGRATION_OPTION_DISABLEDContent = default;
        private static bool _MIGRATION_OPTION_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#MIGRATION_OPTION_ENABLED"/>
        /// </summary>
        public static int MIGRATION_OPTION_ENABLED { get { if (!_MIGRATION_OPTION_ENABLEDReady) { _MIGRATION_OPTION_ENABLEDContent = SGetField<int>(LocalBridgeClazz, "MIGRATION_OPTION_ENABLED"); _MIGRATION_OPTION_ENABLEDReady = true; } return _MIGRATION_OPTION_ENABLEDContent; } }
        private static int _MIGRATION_OPTION_ENABLEDContent = default;
        private static bool _MIGRATION_OPTION_ENABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#MIGRATION_OPTION_UNSPECIFIED"/>
        /// </summary>
        public static int MIGRATION_OPTION_UNSPECIFIED { get { if (!_MIGRATION_OPTION_UNSPECIFIEDReady) { _MIGRATION_OPTION_UNSPECIFIEDContent = SGetField<int>(LocalBridgeClazz, "MIGRATION_OPTION_UNSPECIFIED"); _MIGRATION_OPTION_UNSPECIFIEDReady = true; } return _MIGRATION_OPTION_UNSPECIFIEDContent; } }
        private static int _MIGRATION_OPTION_UNSPECIFIEDContent = default;
        private static bool _MIGRATION_OPTION_UNSPECIFIEDReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#getAllowNonDefaultNetworkUsage()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAllowNonDefaultNetworkUsage()
        {
            return IExecuteWithSignature<int>("getAllowNonDefaultNetworkUsage", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#getDefaultNetworkMigration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDefaultNetworkMigration()
        {
            return IExecuteWithSignature<int>("getDefaultNetworkMigration", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.html#getPathDegradationMigration()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPathDegradationMigration()
        {
            return IExecuteWithSignature<int>("getPathDegradationMigration", "()I");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Http.ConnectionMigrationOptions"/></returns>
            public Android.Net.Http.ConnectionMigrationOptions Build()
            {
                return IExecuteWithSignature<Android.Net.Http.ConnectionMigrationOptions>("build", "()Landroid/net/http/ConnectionMigrationOptions;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.Builder.html#setAllowNonDefaultNetworkUsage(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.ConnectionMigrationOptions.Builder"/></returns>
            public Android.Net.Http.ConnectionMigrationOptions.Builder SetAllowNonDefaultNetworkUsage(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.ConnectionMigrationOptions.Builder>("setAllowNonDefaultNetworkUsage", "(I)Landroid/net/http/ConnectionMigrationOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.Builder.html#setDefaultNetworkMigration(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.ConnectionMigrationOptions.Builder"/></returns>
            public Android.Net.Http.ConnectionMigrationOptions.Builder SetDefaultNetworkMigration(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.ConnectionMigrationOptions.Builder>("setDefaultNetworkMigration", "(I)Landroid/net/http/ConnectionMigrationOptions$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/http/ConnectionMigrationOptions.Builder.html#setPathDegradationMigration(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Http.ConnectionMigrationOptions.Builder"/></returns>
            public Android.Net.Http.ConnectionMigrationOptions.Builder SetPathDegradationMigration(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Http.ConnectionMigrationOptions.Builder>("setPathDegradationMigration", "(I)Landroid/net/http/ConnectionMigrationOptions$Builder;", arg0);
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