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

namespace Java.Time.Temporal
{
    #region TemporalUnit declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html"/>
    /// </summary>
    public partial class TemporalUnit : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TemporalUnit>
    {
        const string _bridgeClassName = "java.time.temporal.TemporalUnit";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("TemporalUnit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TemporalUnit() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("TemporalUnit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public TemporalUnit(params object[] args) : base(args) { }
    
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

    #region ITemporalUnit
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITemporalUnit
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region TemporalUnit implementation
    public partial class TemporalUnit : Java.Time.Temporal.ITemporalUnit
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
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#addTo(java.time.temporal.Temporal,long)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <typeparam name="R"><see cref="Java.Time.Temporal.ITemporal"/></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R AddTo<R>(R arg0, long arg1) where R : Java.Time.Temporal.ITemporal, new()
        {
            return IExecuteWithSignature<R>("addTo", "(Ljava/time/temporal/Temporal;J)Ljava/time/temporal/Temporal;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isDateBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDateBased()
        {
            return IExecuteWithSignature<bool>("isDateBased", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isDurationEstimated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDurationEstimated()
        {
            return IExecuteWithSignature<bool>("isDurationEstimated", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isTimeBased()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTimeBased()
        {
            return IExecuteWithSignature<bool>("isTimeBased", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#getDuration()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Duration"/></returns>
        public Java.Time.Duration GetDuration()
        {
            return IExecuteWithSignature<Java.Time.Duration>("getDuration", "()Ljava/time/Duration;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#between(java.time.temporal.Temporal,java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <param name="arg1"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="long"/></returns>
        public long Between(Java.Time.Temporal.Temporal arg0, Java.Time.Temporal.Temporal arg1)
        {
            return IExecuteWithSignature<long>("between", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)J", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/temporal/TemporalUnit.html#isSupportedBy(java.time.temporal.Temporal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.Temporal"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupportedBy(Java.Time.Temporal.Temporal arg0)
        {
            return IExecuteWithSignature<bool>("isSupportedBy", "(Ljava/time/temporal/Temporal;)Z", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}