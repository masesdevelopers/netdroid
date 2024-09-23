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

namespace Android.Speech.Tts
{
    #region SynthesisCallback declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html"/>
    /// </summary>
    public partial class SynthesisCallback : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SynthesisCallback>
    {
        const string _bridgeClassName = "android.speech.tts.SynthesisCallback";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SynthesisCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SynthesisCallback() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SynthesisCallback class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SynthesisCallback(params object[] args) : base(args) { }

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

    }
    #endregion

    #region ISynthesisCallback
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISynthesisCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SynthesisCallback implementation
    public partial class SynthesisCallback : Android.Speech.Tts.ISynthesisCallback
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
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#hasFinished()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasFinished()
        {
            return IExecuteWithSignature<bool>("hasFinished", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#hasStarted()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasStarted()
        {
            return IExecuteWithSignature<bool>("hasStarted", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#audioAvailable(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AudioAvailable(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("audioAvailable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#done()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Done()
        {
            return IExecuteWithSignature<int>("done", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#getMaxBufferSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxBufferSize()
        {
            return IExecuteWithSignature<int>("getMaxBufferSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#start(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("start", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#error()"/>
        /// </summary>
        public void Error()
        {
            IExecuteWithSignature("error", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#error(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Error(int arg0)
        {
            IExecuteWithSignature("error", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/speech/tts/SynthesisCallback.html#rangeStart(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RangeStart(int arg0, int arg1, int arg2)
        {
            IExecute("rangeStart", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}