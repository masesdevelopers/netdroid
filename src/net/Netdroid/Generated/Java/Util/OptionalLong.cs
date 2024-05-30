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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region OptionalLong
    public partial class OptionalLong
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#empty()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public static Java.Util.OptionalLong Empty()
        {
            return SExecuteWithSignature<Java.Util.OptionalLong>(LocalBridgeClazz, "empty", "()Ljava/util/OptionalLong;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#of(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.OptionalLong"/></returns>
        public static Java.Util.OptionalLong Of(long arg0)
        {
            return SExecuteWithSignature<Java.Util.OptionalLong>(LocalBridgeClazz, "of", "(J)Ljava/util/OptionalLong;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#getAsLong()"/> 
        /// </summary>
        public long AsLong
        {
            get { return IExecuteWithSignature<long>("getAsLong", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#orElseThrow(java.util.function.Supplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <typeparam name="Arg0ExtendsX"><typeparamref name="X"/></typeparam>
        /// <typeparam name="X"></typeparam>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.Throwable"/>
        public long OrElseThrow<Arg0ExtendsX, X>(Java.Util.Function.Supplier<Arg0ExtendsX> arg0) where Arg0ExtendsX: X
        {
            return IExecuteWithSignature<long>("orElseThrow", "(Ljava/util/function/Supplier;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#isPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPresent()
        {
            return IExecuteWithSignature<bool>("isPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#stream()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream Stream()
        {
            return IExecuteWithSignature<Java.Util.Stream.LongStream>("stream", "()Ljava/util/stream/LongStream;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#orElse(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long OrElse(long arg0)
        {
            return IExecuteWithSignature<long>("orElse", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#orElseGet(java.util.function.LongSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongSupplier"/></param>
        /// <returns><see cref="long"/></returns>
        public long OrElseGet(Java.Util.Function.LongSupplier arg0)
        {
            return IExecuteWithSignature<long>("orElseGet", "(Ljava/util/function/LongSupplier;)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#orElseThrow()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long OrElseThrow()
        {
            return IExecuteWithSignature<long>("orElseThrow", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#ifPresent(java.util.function.LongConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        public void IfPresent(Java.Util.Function.LongConsumer arg0)
        {
            IExecuteWithSignature("ifPresent", "(Ljava/util/function/LongConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/OptionalLong.html#ifPresentOrElse(java.util.function.LongConsumer,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        public void IfPresentOrElse(Java.Util.Function.LongConsumer arg0, Java.Lang.Runnable arg1)
        {
            IExecute("ifPresentOrElse", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}