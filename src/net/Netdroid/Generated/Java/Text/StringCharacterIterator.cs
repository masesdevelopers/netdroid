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
    #region StringCharacterIterator declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html"/>
    /// </summary>
    public partial class StringCharacterIterator : Java.Text.CharacterIterator
    {
        const string _bridgeClassName = "java.text.StringCharacterIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StringCharacterIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StringCharacterIterator(params object[] args) : base(args) { }
    
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

    #region StringCharacterIterator implementation
    public partial class StringCharacterIterator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public StringCharacterIterator(Java.Lang.String arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public StringCharacterIterator(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public StringCharacterIterator(Java.Lang.String arg0)
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
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Current()
        {
            return IExecuteWithSignature<char>("current", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char First()
        {
            return IExecuteWithSignature<char>("first", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Last()
        {
            return IExecuteWithSignature<char>("last", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Next()
        {
            return IExecuteWithSignature<char>("next", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Previous()
        {
            return IExecuteWithSignature<char>("previous", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char SetIndex(int arg0)
        {
            return IExecuteWithSignature<char>("setIndex", "(I)C", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#getBeginIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetBeginIndex()
        {
            return IExecuteWithSignature<int>("getBeginIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#getEndIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetEndIndex()
        {
            return IExecuteWithSignature<int>("getEndIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#getIndex()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIndex()
        {
            return IExecuteWithSignature<int>("getIndex", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/text/StringCharacterIterator.html#setText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetText(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/lang/String;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}