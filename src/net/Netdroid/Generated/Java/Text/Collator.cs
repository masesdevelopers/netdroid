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

namespace Java.Text
{
    #region Collator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/text/Collator.html"/>
    /// </summary>
    public partial class Collator : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Collator>
    {
        const string _bridgeClassName = "java.text.Collator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Collator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Collator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Collator(params object[] args) : base(args) { }
    
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

    #region Collator implementation
    public partial class Collator : Java.Util.IComparator<object>, Java.Lang.ICloneable
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Text.Collator"/> to <see cref="Java.Util.Comparator"/>
        /// </summary>
        public static implicit operator Java.Util.Comparator(Java.Text.Collator t) => t.Cast<Java.Util.Comparator>();
        /// <summary>
        /// Converter from <see cref="Java.Text.Collator"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Text.Collator t) => t.Cast<Java.Lang.Cloneable>();
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#CANONICAL_DECOMPOSITION"/>
        /// </summary>
        public static int CANONICAL_DECOMPOSITION { get { if (!_CANONICAL_DECOMPOSITIONReady) { _CANONICAL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "CANONICAL_DECOMPOSITION"); _CANONICAL_DECOMPOSITIONReady = true; } return _CANONICAL_DECOMPOSITIONContent; } }
        private static int _CANONICAL_DECOMPOSITIONContent = default;
        private static bool _CANONICAL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#FULL_DECOMPOSITION"/>
        /// </summary>
        public static int FULL_DECOMPOSITION { get { if (!_FULL_DECOMPOSITIONReady) { _FULL_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "FULL_DECOMPOSITION"); _FULL_DECOMPOSITIONReady = true; } return _FULL_DECOMPOSITIONContent; } }
        private static int _FULL_DECOMPOSITIONContent = default;
        private static bool _FULL_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#IDENTICAL"/>
        /// </summary>
        public static int IDENTICAL { get { if (!_IDENTICALReady) { _IDENTICALContent = SGetField<int>(LocalBridgeClazz, "IDENTICAL"); _IDENTICALReady = true; } return _IDENTICALContent; } }
        private static int _IDENTICALContent = default;
        private static bool _IDENTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#NO_DECOMPOSITION"/>
        /// </summary>
        public static int NO_DECOMPOSITION { get { if (!_NO_DECOMPOSITIONReady) { _NO_DECOMPOSITIONContent = SGetField<int>(LocalBridgeClazz, "NO_DECOMPOSITION"); _NO_DECOMPOSITIONReady = true; } return _NO_DECOMPOSITIONContent; } }
        private static int _NO_DECOMPOSITIONContent = default;
        private static bool _NO_DECOMPOSITIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#PRIMARY"/>
        /// </summary>
        public static int PRIMARY { get { if (!_PRIMARYReady) { _PRIMARYContent = SGetField<int>(LocalBridgeClazz, "PRIMARY"); _PRIMARYReady = true; } return _PRIMARYContent; } }
        private static int _PRIMARYContent = default;
        private static bool _PRIMARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#SECONDARY"/>
        /// </summary>
        public static int SECONDARY { get { if (!_SECONDARYReady) { _SECONDARYContent = SGetField<int>(LocalBridgeClazz, "SECONDARY"); _SECONDARYReady = true; } return _SECONDARYContent; } }
        private static int _SECONDARYContent = default;
        private static bool _SECONDARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#TERTIARY"/>
        /// </summary>
        public static int TERTIARY { get { if (!_TERTIARYReady) { _TERTIARYContent = SGetField<int>(LocalBridgeClazz, "TERTIARY"); _TERTIARYReady = true; } return _TERTIARYContent; } }
        private static int _TERTIARYContent = default;
        private static bool _TERTIARYReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.Collator"/></returns>
        public static Java.Text.Collator GetInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.Collator>(LocalBridgeClazz, "getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getInstance()"/>
        /// </summary>
        /// <returns><see cref="Java.Text.Collator"/></returns>
        public static Java.Text.Collator GetInstance()
        {
            return SExecuteWithSignature<Java.Text.Collator>(LocalBridgeClazz, "getInstance", "()Ljava/text/Collator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getAvailableLocales()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Locale"/></returns>
        public static Java.Util.Locale[] GetAvailableLocales()
        {
            return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#compare(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<int>("compare", "(Ljava/lang/String;Ljava/lang/String;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getCollationKey(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Text.CollationKey"/></returns>
        public Java.Text.CollationKey GetCollationKey(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Text.CollationKey>("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#equals(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Equals(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<bool>("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(object arg0, object arg1)
        {
            return IExecuteWithSignature<int>("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getDecomposition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDecomposition()
        {
            return IExecuteWithSignature<int>("getDecomposition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#getStrength()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStrength()
        {
            return IExecuteWithSignature<int>("getStrength", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#setDecomposition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDecomposition(int arg0)
        {
            IExecuteWithSignature("setDecomposition", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/Collator.html#setStrength(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStrength(int arg0)
        {
            IExecuteWithSignature("setStrength", "(I)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}