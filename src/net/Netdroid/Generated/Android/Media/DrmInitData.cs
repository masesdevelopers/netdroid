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

namespace Android.Media
{
    #region DrmInitData declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html"/>
    /// </summary>
    public partial class DrmInitData : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DrmInitData>
    {
        const string _bridgeClassName = "android.media.DrmInitData";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DrmInitData class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DrmInitData() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DrmInitData class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DrmInitData(params object[] args) : base(args) { }
    
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
        #region SchemeInitData declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html"/>
        /// </summary>
        public partial class SchemeInitData : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SchemeInitData>
        {
            const string _bridgeClassName = "android.media.DrmInitData$SchemeInitData";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public SchemeInitData() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public SchemeInitData(params object[] args) : base(args) { }
        
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

    #region DrmInitData implementation
    public partial class DrmInitData
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
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#get(java.util.UUID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
        /// <returns><see cref="Android.Media.DrmInitData.SchemeInitData"/></returns>
        [global::System.Obsolete()]
        public Android.Media.DrmInitData.SchemeInitData Get(Java.Util.UUID arg0)
        {
            return IExecuteWithSignature<Android.Media.DrmInitData.SchemeInitData>("get", "(Ljava/util/UUID;)Landroid/media/DrmInitData$SchemeInitData;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#getSchemeInitDataAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Media.DrmInitData.SchemeInitData"/></returns>
        public Android.Media.DrmInitData.SchemeInitData GetSchemeInitDataAt(int arg0)
        {
            return IExecuteWithSignature<Android.Media.DrmInitData.SchemeInitData>("getSchemeInitDataAt", "(I)Landroid/media/DrmInitData$SchemeInitData;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/DrmInitData.html#getSchemeInitDataCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSchemeInitDataCount()
        {
            return IExecuteWithSignature<int>("getSchemeInitDataCount", "()I");
        }
    
        #endregion
    
        #region Nested classes
        #region SchemeInitData implementation
        public partial class SchemeInitData
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#%3Cinit%3E(java.util.UUID,java.lang.String,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.UUID"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="byte"/></param>
            public SchemeInitData(Java.Util.UUID arg0, Java.Lang.String arg1, byte[] arg2)
                : base(arg0, arg1, arg2)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#data"/>
            /// </summary>
            public byte[] data { get { if (!_dataReady) { _dataContent = IGetFieldArray<byte>("data"); _dataReady = true; } return _dataContent; } }
            private byte[] _dataContent = default;
            private bool _dataReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#mimeType"/>
            /// </summary>
            public Java.Lang.String mimeType { get { if (!_mimeTypeReady) { _mimeTypeContent = IGetField<Java.Lang.String>("mimeType"); _mimeTypeReady = true; } return _mimeTypeContent; } }
            private Java.Lang.String _mimeTypeContent = default;
            private bool _mimeTypeReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#uuid"/>
            /// </summary>
            public Java.Util.UUID uuid { get { if (!_uuidReady) { _uuidContent = IGetField<Java.Util.UUID>("uuid"); _uuidReady = true; } return _uuidContent; } }
            private Java.Util.UUID _uuidContent = default;
            private bool _uuidReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/media/DrmInitData.SchemeInitData.html#UUID_NIL"/>
            /// </summary>
            public static Java.Util.UUID UUID_NIL { get { if (!_UUID_NILReady) { _UUID_NILContent = SGetField<Java.Util.UUID>(LocalBridgeClazz, "UUID_NIL"); _UUID_NILReady = true; } return _UUID_NILContent; } }
            private static Java.Util.UUID _UUID_NILContent = default;
            private static bool _UUID_NILReady = false; // this is used because in case of generics 
        
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