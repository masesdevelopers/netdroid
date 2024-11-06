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

namespace Java.Time
{
    #region InstantSource declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/InstantSource.html"/>
    /// </summary>
    public partial class InstantSource : MASES.JCOBridge.C2JBridge.JVMBridgeBase<InstantSource>
    {
        const string _bridgeClassName = "java.time.InstantSource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InstantSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InstantSource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InstantSource class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InstantSource(params object[] args) : base(args) { }
    
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

    #region IInstantSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInstantSource
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region InstantSource implementation
    public partial class InstantSource : Java.Time.IInstantSource
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#fixed(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Fixed(Java.Time.Instant arg0)
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "fixed", "(Ljava/time/Instant;)Ljava/time/InstantSource;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#offset(java.time.InstantSource,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.InstantSource"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Offset(Java.Time.InstantSource arg0, Java.Time.Duration arg1)
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "offset", "(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#system()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource System()
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "system", "()Ljava/time/InstantSource;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#tick(java.time.InstantSource,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.InstantSource"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Tick(Java.Time.InstantSource arg0, Java.Time.Duration arg1)
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "tick", "(Ljava/time/InstantSource;Ljava/time/Duration;)Ljava/time/InstantSource;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#instant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant Instant()
        {
            return IExecuteWithSignature<Java.Time.Instant>("instant", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#withZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public Java.Time.Clock WithZone(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Clock>("withZone", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#millis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Millis()
        {
            return IExecuteWithSignature<long>("millis", "()J");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}