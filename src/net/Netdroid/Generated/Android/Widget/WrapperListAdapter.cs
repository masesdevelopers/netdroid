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

namespace Android.Widget
{
    #region IWrapperListAdapter
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.widget.WrapperListAdapter implementing <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html"/>
    /// </summary>
    public partial interface IWrapperListAdapter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        Android.View.View GetView(int arg0, Android.View.View arg1, Android.View.ViewGroup arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        Android.Widget.ListAdapter GetWrappedAdapter();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasStableIds();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsEmpty();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool AreAllItemsEnabled();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsEnabled(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int GetCount();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        int GetItemViewType(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int GetViewTypeCount();
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        object GetItem(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        long GetItemId(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        void RegisterDataSetObserver(Android.Database.DataSetObserver arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        Java.Lang.CharSequence[] GetAutofillOptions();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WrapperListAdapter
    public partial class WrapperListAdapter : Android.Widget.IWrapperListAdapter
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
        /// Handlers initializer for <see cref="WrapperListAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("getView", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetViewEventHandler));
            AddEventHandler("getWrappedAdapter", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetWrappedAdapterEventHandler));
            AddEventHandler("hasStableIds", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(HasStableIdsEventHandler));
            AddEventHandler("isEmpty", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEmptyEventHandler));
            AddEventHandler("areAllItemsEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("isEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(IsEnabledEventHandler));
            AddEventHandler("getCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetCountEventHandler));
            AddEventHandler("getItemViewType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetItemViewTypeEventHandler));
            AddEventHandler("getViewTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetViewTypeCountEventHandler));
            AddEventHandler("getItem", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetItemEventHandler));
            AddEventHandler("getItemId", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetItemIdEventHandler));
            AddEventHandler("registerDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("unregisterDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(UnregisterDataSetObserverEventHandler));
            AddEventHandler("getAutofillOptions", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAutofillOptionsEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetView"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, Android.View.View, Android.View.ViewGroup, Android.View.View> OnGetView { get; set; } = null;

        void GetViewEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetView != null) ? OnGetView : GetView;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.View.View>(0), data.EventData.GetAt<Android.View.ViewGroup>(1));
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public virtual Android.View.View GetView(int arg0, Android.View.View arg1, Android.View.ViewGroup arg2)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetWrappedAdapter"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Widget.ListAdapter> OnGetWrappedAdapter { get; set; } = null;

        void GetWrappedAdapterEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetWrappedAdapter != null) ? OnGetWrappedAdapter : GetWrappedAdapter;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public virtual Android.Widget.ListAdapter GetWrappedAdapter()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <remarks>If <see cref="OnHasStableIds"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnHasStableIds { get; set; } = null;

        void HasStableIdsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnHasStableIds != null) ? OnHasStableIds : HasStableIds;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool HasStableIds()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEmpty"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnIsEmpty { get; set; } = null;

        void IsEmptyEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnIsEmpty != null) ? OnIsEmpty : IsEmpty;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnAreAllItemsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<bool> OnAreAllItemsEnabled { get; set; } = null;

        void AreAllItemsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnAreAllItemsEnabled != null) ? OnAreAllItemsEnabled : AreAllItemsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, bool> OnIsEnabled { get; set; } = null;

        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnIsEnabled != null) ? OnIsEnabled : IsEnabled;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetCount { get; set; } = null;

        void GetCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetCount != null) ? OnGetCount : GetCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItemViewType"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, int> OnGetItemViewType { get; set; } = null;

        void GetItemViewTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetItemViewType != null) ? OnGetItemViewType : GetItemViewType;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetItemViewType(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetViewTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int> OnGetViewTypeCount { get; set; } = null;

        void GetViewTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetViewTypeCount != null) ? OnGetViewTypeCount : GetViewTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetViewTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItem"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, object> OnGetItem { get; set; } = null;

        void GetItemEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetItem != null) ? OnGetItem : GetItem;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object GetItem(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItemId"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<int, long> OnGetItemId { get; set; } = null;

        void GetItemIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnGetItemId != null) ? OnGetItemId : GetItemId;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetItemId(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Lang.CharSequence[] GetAutofillOptionsDefault()
        {
            return IExecuteArray<Java.Lang.CharSequence>("getAutofillOptionsDefault");
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAutofillOptions"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.CharSequence[]> OnGetAutofillOptions { get; set; } = null;

        void GetAutofillOptionsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetAutofillOptions != null) ? OnGetAutofillOptions : GetAutofillOptions;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="GetAutofillOptionsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Lang.CharSequence[] GetAutofillOptions()
        {
            return GetAutofillOptionsDefault();
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WrapperListAdapterDirect
    public partial class WrapperListAdapterDirect : Android.Widget.IWrapperListAdapter
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
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/> 
        /// </summary>
        public Java.Lang.CharSequence[] AutofillOptions
        {
            get { return IExecuteArray<Java.Lang.CharSequence>("getAutofillOptions"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("getCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/> 
        /// </summary>
        public int ViewTypeCount
        {
            get { return IExecute<int>("getViewTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/> 
        /// </summary>
        public Android.Widget.ListAdapter WrappedAdapter
        {
            get { return IExecuteWithSignature<Android.Widget.ListAdapter>("getWrappedAdapter", "()Landroid/widget/ListAdapter;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public override Android.View.View GetView(int arg0, Android.View.View arg1, Android.View.ViewGroup arg2)
        {
            return IExecute<Android.View.View>("getView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool HasStableIds()
        {
            return IExecute<bool>("hasStableIds");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecute<bool>("areAllItemsEnabled");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEnabled(int arg0)
        {
            return IExecute<bool>("isEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetItemViewType(int arg0)
        {
            return IExecute<int>("getItemViewType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public override object GetItem(int arg0)
        {
            return IExecute("getItem", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetItemId(int arg0)
        {
            return IExecute<long>("getItemId", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("registerDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("unregisterDataSetObserver", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}