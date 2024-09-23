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

namespace Java.Util
{
    #region DoubleSummaryStatistics declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html"/>
    /// </summary>
    public partial class DoubleSummaryStatistics : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DoubleSummaryStatistics>
    {
        const string _bridgeClassName = "java.util.DoubleSummaryStatistics";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DoubleSummaryStatistics() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DoubleSummaryStatistics(params object[] args) : base(args) { }

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

    #region DoubleSummaryStatistics implementation
    public partial class DoubleSummaryStatistics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#%3Cinit%3E(long,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public DoubleSummaryStatistics(long arg0, double arg1, double arg2, double arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.DoubleSummaryStatistics"/> to <see cref="Java.Util.Function.DoubleConsumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.DoubleConsumer(Java.Util.DoubleSummaryStatistics t) => t.Cast<Java.Util.Function.DoubleConsumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#getAverage()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetAverage()
        {
            return IExecuteWithSignature<double>("getAverage", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#getMax()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetMax()
        {
            return IExecuteWithSignature<double>("getMax", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#getMin()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetMin()
        {
            return IExecuteWithSignature<double>("getMin", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#getSum()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double GetSum()
        {
            return IExecuteWithSignature<double>("getSum", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCount()
        {
            return IExecuteWithSignature<long>("getCount", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#accept(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void Accept(double arg0)
        {
            IExecuteWithSignature("accept", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/DoubleSummaryStatistics.html#combine(java.util.DoubleSummaryStatistics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.DoubleSummaryStatistics"/></param>
        public void Combine(Java.Util.DoubleSummaryStatistics arg0)
        {
            IExecuteWithSignature("combine", "(Ljava/util/DoubleSummaryStatistics;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}