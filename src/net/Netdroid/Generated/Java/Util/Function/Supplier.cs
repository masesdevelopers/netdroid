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

namespace Java.Util.Function
{
    #region Supplier
    public partial class Supplier
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
        /// Handlers initializer for <see cref="Supplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("get", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGet"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<object> OnGet { get; set; } = null;

        void GetEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGet != null) ? OnGet : Get;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public virtual object Get()
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SupplierDirect
    public partial class SupplierDirect
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
        /// <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public override object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISupplier<T>
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.java.util.function.Supplier implementing <see href="https://developer.android.com/reference/java/util/function/Supplier.html"/>
    /// </summary>
    public partial interface ISupplier<T>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Supplier<T>
    public partial class Supplier<T> : Java.Util.Function.ISupplier<T>
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
        /// Handlers initializer for <see cref="Supplier"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("get", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGet"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<T> OnGet { get; set; } = null;

        void GetEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGet != null) ? OnGet : Get;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public virtual T Get()
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SupplierDirect<T>
    public partial class SupplierDirect<T> : Java.Util.Function.ISupplier<T>
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
        /// <see href="https://developer.android.com/reference/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public override T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}