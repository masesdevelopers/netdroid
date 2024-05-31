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

namespace Android.Os
{
    #region OutcomeReceiver
    public partial class OutcomeReceiver
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
        /// <see href="https://developer.android.com/reference/android/os/OutcomeReceiver.html#onResult(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void OnResult(object arg0)
        {
            IExecuteWithSignature("onResult", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/OutcomeReceiver.html#onError(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        public void OnError(Java.Lang.Throwable arg0)
        {
            IExecuteWithSignature("onError", "(Ljava/lang/Throwable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IOutcomeReceiver<R, E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOutcomeReceiver<R, E>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OutcomeReceiver<R, E>
    public partial class OutcomeReceiver<R, E> : Android.Os.IOutcomeReceiver<R, E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.OutcomeReceiver{R, E}"/> to <see cref="Android.Os.OutcomeReceiver"/>
        /// </summary>
        public static implicit operator Android.Os.OutcomeReceiver(Android.Os.OutcomeReceiver<R, E> t) => t.Cast<Android.Os.OutcomeReceiver>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/OutcomeReceiver.html#onResult(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        public void OnResult(R arg0)
        {
            IExecuteWithSignature("onResult", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/OutcomeReceiver.html#onError(java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void OnError(E arg0)
        {
            IExecuteWithSignature("onError", "(Ljava/lang/Throwable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}