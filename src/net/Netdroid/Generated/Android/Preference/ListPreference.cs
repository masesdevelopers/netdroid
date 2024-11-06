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

namespace Android.Preference
{
    #region ListPreference declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ListPreference : Android.Preference.DialogPreference
    {
        const string _bridgeClassName = "android.preference.ListPreference";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ListPreference() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ListPreference(params object[] args) : base(args) { }
    
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
    
    }
    #endregion

    #region ListPreference implementation
    public partial class ListPreference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        [global::System.Obsolete()]
        public ListPreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        [global::System.Obsolete()]
        public ListPreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        [global::System.Obsolete()]
        public ListPreference(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        [global::System.Obsolete()]
        public ListPreference(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#findIndexOfValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        [global::System.Obsolete()]
        public int FindIndexOfValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("findIndexOfValue", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#getEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence GetEntry()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getEntry", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#getEntries()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence[] GetEntries()
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getEntries", "()[Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#getEntryValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.CharSequence[] GetEntryValues()
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getEntryValues", "()[Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        [global::System.Obsolete()]
        public Java.Lang.String GetValue()
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setEntries(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetEntries(int arg0)
        {
            IExecuteWithSignature("setEntries", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setEntries(java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetEntries(Java.Lang.CharSequence[] arg0)
        {
            IExecuteWithSignature("setEntries", "([Ljava/lang/CharSequence;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setEntryValues(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetEntryValues(int arg0)
        {
            IExecuteWithSignature("setEntryValues", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setEntryValues(java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        [global::System.Obsolete()]
        public void SetEntryValues(Java.Lang.CharSequence[] arg0)
        {
            IExecuteWithSignature("setEntryValues", "([Ljava/lang/CharSequence;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        [global::System.Obsolete()]
        public void SetValue(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setValue", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/preference/ListPreference.html#setValueIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        [global::System.Obsolete()]
        public void SetValueIndex(int arg0)
        {
            IExecuteWithSignature("setValueIndex", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}