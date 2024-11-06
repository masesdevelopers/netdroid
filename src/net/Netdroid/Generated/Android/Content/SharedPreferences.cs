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
    #region SharedPreferences declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html"/>
    /// </summary>
    public partial class SharedPreferences : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SharedPreferences>
    {
        const string _bridgeClassName = "android.content.SharedPreferences";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SharedPreferences class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SharedPreferences() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SharedPreferences class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SharedPreferences(params object[] args) : base(args) { }
    
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
        #region Editor declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html"/>
        /// </summary>
        public partial class Editor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Editor>
        {
            const string _bridgeClassName = "android.content.SharedPreferences$Editor";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Editor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Editor() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Editor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Editor(params object[] args) : base(args) { }
        
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

        #region OnSharedPreferenceChangeListener declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.OnSharedPreferenceChangeListener.html"/>
        /// </summary>
        public partial class OnSharedPreferenceChangeListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
        {
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public OnSharedPreferenceChangeListener() { InitializeHandlers(); }
        
            const string _bridgeClassName = "org.mases.netdroid.generated.android.content.SharedPreferences_OnSharedPreferenceChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
            
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
        
        
            // TODO: complete the class
        
        }
        #endregion
        
        #region OnSharedPreferenceChangeListenerDirect declaration
        /// <summary>
        /// Direct override of <see cref="OnSharedPreferenceChangeListener"/> or its generic type if there is one
        /// </summary>
        public partial class OnSharedPreferenceChangeListenerDirect : OnSharedPreferenceChangeListener
        {
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
            /// </summary>
            public override bool AutoInit => false;
        
            /// <inheritdoc />
            protected override void InitializeHandlers() { }
        
            const string _bridgeClassName = "android.content.SharedPreferences$OnSharedPreferenceChangeListener";
            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
        }
        #endregion

    
    }
    #endregion

    #region ISharedPreferences
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISharedPreferences
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region SharedPreferences implementation
    public partial class SharedPreferences : Android.Content.ISharedPreferences
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
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#edit()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
        public Android.Content.SharedPreferences.Editor Edit()
        {
            return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("edit", "()Landroid/content/SharedPreferences$Editor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#contains(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getBoolean(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetBoolean(Java.Lang.String arg0, bool arg1)
        {
            return IExecuteWithSignature<bool>("getBoolean", "(Ljava/lang/String;Z)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getFloat(java.lang.String,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(Java.Lang.String arg0, float arg1)
        {
            return IExecuteWithSignature<float>("getFloat", "(Ljava/lang/String;F)F", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(Java.Lang.String arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getInt", "(Ljava/lang/String;I)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getString(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getAll()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, object> GetAll()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, object>>("getAll", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getStringSet(java.lang.String,java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetStringSet(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getStringSet", "(Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#getLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(Java.Lang.String arg0, long arg1)
        {
            return IExecuteWithSignature<long>("getLong", "(Ljava/lang/String;J)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#registerOnSharedPreferenceChangeListener(android.content.SharedPreferences.OnSharedPreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.SharedPreferences.OnSharedPreferenceChangeListener"/></param>
        public void RegisterOnSharedPreferenceChangeListener(Android.Content.SharedPreferences.OnSharedPreferenceChangeListener arg0)
        {
            IExecuteWithSignature("registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.html#unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences.OnSharedPreferenceChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.SharedPreferences.OnSharedPreferenceChangeListener"/></param>
        public void UnregisterOnSharedPreferenceChangeListener(Android.Content.SharedPreferences.OnSharedPreferenceChangeListener arg0)
        {
            IExecuteWithSignature("unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Editor implementation
        public partial class Editor
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
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#clear()"/>
            /// </summary>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor Clear()
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("clear", "()Landroid/content/SharedPreferences$Editor;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putBoolean(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutBoolean(Java.Lang.String arg0, bool arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putFloat(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutFloat(Java.Lang.String arg0, float arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putInt(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutInt(Java.Lang.String arg0, int arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putLong(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutLong(Java.Lang.String arg0, long arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putString(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutString(Java.Lang.String arg0, Java.Lang.String arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#putStringSet(java.lang.String,java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor PutStringSet(Java.Lang.String arg0, Java.Util.Set<Java.Lang.String> arg1)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("putStringSet", "(Ljava/lang/String;Ljava/util/Set;)Landroid/content/SharedPreferences$Editor;", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#remove(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Content.SharedPreferences.Editor"/></returns>
            public Android.Content.SharedPreferences.Editor Remove(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Content.SharedPreferences.Editor>("remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#commit()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool Commit()
            {
                return IExecuteWithSignature<bool>("commit", "()Z");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.Editor.html#apply()"/>
            /// </summary>
            public void Apply()
            {
                IExecuteWithSignature("apply", "()V");
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnSharedPreferenceChangeListener implementation
        public partial class OnSharedPreferenceChangeListener
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
            /// Handlers initializer for <see cref="OnSharedPreferenceChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onSharedPreferenceChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(OnSharedPreferenceChangedEventHandler));

            }
            
            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/content/SharedPreferences.OnSharedPreferenceChangeListener.html#onSharedPreferenceChanged(android.content.SharedPreferences,java.lang.String)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnSharedPreferenceChanged"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Content.SharedPreferences, Java.Lang.String> OnOnSharedPreferenceChanged { get; set; } = null;
            
            bool hasOverrideOnSharedPreferenceChanged = true;
            void OnSharedPreferenceChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
            {
                hasOverrideOnSharedPreferenceChanged = true;
                var methodToExecute = (OnOnSharedPreferenceChanged != null) ? OnOnSharedPreferenceChanged : OnSharedPreferenceChanged;
                methodToExecute.Invoke(data.EventData.GetAt<Android.Content.SharedPreferences>(0), data.EventData.GetAt<Java.Lang.String>(1));
                data.EventData.TypedEventData.HasOverride = hasOverrideOnSharedPreferenceChanged;
            }
            
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.OnSharedPreferenceChangeListener.html#onSharedPreferenceChanged(android.content.SharedPreferences,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.SharedPreferences"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public virtual void OnSharedPreferenceChanged(Android.Content.SharedPreferences arg0, Java.Lang.String arg1)
            {
                hasOverrideOnSharedPreferenceChanged = false;
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region OnSharedPreferenceChangeListenerDirect implementation
        public partial class OnSharedPreferenceChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/content/SharedPreferences.OnSharedPreferenceChangeListener.html#onSharedPreferenceChanged(android.content.SharedPreferences,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.SharedPreferences"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public override void OnSharedPreferenceChanged(Android.Content.SharedPreferences arg0, Java.Lang.String arg1)
            {
                IExecuteWithSignature("onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", arg0, arg1);
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