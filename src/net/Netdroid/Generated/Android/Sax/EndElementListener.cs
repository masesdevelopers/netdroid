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

namespace Android.Sax
{
    #region IEndElementListener
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.sax.EndElementListener implementing <see href="https://developer.android.com/reference/android/sax/EndElementListener.html"/>
    /// </summary>
    public partial interface IEndElementListener
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EndElementListener
    public partial class EndElementListener : Android.Sax.IEndElementListener
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
        /// Handlers initializer for <see cref="EndElementListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("end", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(EndEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/sax/EndElementListener.html#end()"/>
        /// </summary>
        /// <remarks>If <see cref="OnEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnEnd { get; set; } = null;

        void EndEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnEnd != null) ? OnEnd : End;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/EndElementListener.html#end()"/>
        /// </summary>
        public virtual void End()
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region EndElementListenerDirect
    public partial class EndElementListenerDirect : Android.Sax.IEndElementListener
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
        /// <see href="https://developer.android.com/reference/android/sax/EndElementListener.html#end()"/>
        /// </summary>
        public override void End()
        {
            IExecuteWithSignature("end", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}