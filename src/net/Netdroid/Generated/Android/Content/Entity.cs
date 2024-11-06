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

namespace Android.Content
{
    #region Entity declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/Entity.html"/>
    /// </summary>
    public partial class Entity : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Entity>
    {
        const string _bridgeClassName = "android.content.Entity";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Entity() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Entity(params object[] args) : base(args) { }
    
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
        #region NamedContentValues declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/Entity.NamedContentValues.html"/>
        /// </summary>
        public partial class NamedContentValues : MASES.JCOBridge.C2JBridge.JVMBridgeBase<NamedContentValues>
        {
            const string _bridgeClassName = "android.content.Entity$NamedContentValues";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public NamedContentValues() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public NamedContentValues(params object[] args) : base(args) { }
        
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

    #region Entity implementation
    public partial class Entity
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/Entity.html#%3Cinit%3E(android.content.ContentValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ContentValues"/></param>
        public Entity(Android.Content.ContentValues arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/Entity.html#getEntityValues()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.ContentValues"/></returns>
        public Android.Content.ContentValues GetEntityValues()
        {
            return IExecuteWithSignature<Android.Content.ContentValues>("getEntityValues", "()Landroid/content/ContentValues;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/Entity.html#getSubValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public Java.Util.ArrayList<Android.Content.Entity.NamedContentValues> GetSubValues()
        {
            return IExecuteWithSignature<Java.Util.ArrayList<Android.Content.Entity.NamedContentValues>>("getSubValues", "()Ljava/util/ArrayList;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/Entity.html#addSubValue(android.net.Uri,android.content.ContentValues)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
        /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
        public void AddSubValue(Android.Net.Uri arg0, Android.Content.ContentValues arg1)
        {
            IExecuteWithSignature("addSubValue", "(Landroid/net/Uri;Landroid/content/ContentValues;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
        #region NamedContentValues implementation
        public partial class NamedContentValues
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/Entity.NamedContentValues.html#%3Cinit%3E(android.net.Uri,android.content.ContentValues)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Net.Uri"/></param>
            /// <param name="arg1"><see cref="Android.Content.ContentValues"/></param>
            public NamedContentValues(Android.Net.Uri arg0, Android.Content.ContentValues arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/Entity.NamedContentValues.html#values"/>
            /// </summary>
            public Android.Content.ContentValues values { get { if (!_valuesReady) { _valuesContent = IGetField<Android.Content.ContentValues>("values"); _valuesReady = true; } return _valuesContent; } }
            private Android.Content.ContentValues _valuesContent = default;
            private bool _valuesReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/Entity.NamedContentValues.html#uri"/>
            /// </summary>
            public Android.Net.Uri uri { get { if (!_uriReady) { _uriContent = IGetField<Android.Net.Uri>("uri"); _uriReady = true; } return _uriContent; } }
            private Android.Net.Uri _uriContent = default;
            private bool _uriReady = false; // this is used because in case of generics 
        
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