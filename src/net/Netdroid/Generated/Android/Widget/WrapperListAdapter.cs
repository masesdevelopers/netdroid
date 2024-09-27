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

namespace Android.Widget
{
    #region WrapperListAdapter declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html"/>
    /// </summary>
    public partial class WrapperListAdapter : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public WrapperListAdapter() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.netdroid.generated.android.widget.WrapperListAdapter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region WrapperListAdapterDirect declaration
    /// <summary>
    /// Direct override of <see cref="WrapperListAdapter"/> or its generic type if there is one
    /// </summary>
    public partial class WrapperListAdapterDirect : WrapperListAdapter
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "android.widget.WrapperListAdapter";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region IWrapperListAdapter
    /// <summary>
    /// .NET interface for org.mases.netdroid.generated.android.widget.WrapperListAdapter implementing <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html"/>
    /// </summary>
    public partial interface IWrapperListAdapter
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WrapperListAdapter implementation
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
            AddEventHandler("getView", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetViewEventHandler));
            AddEventHandler("getWrappedAdapter", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetWrappedAdapterEventHandler));
            AddEventHandler("hasStableIds", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(HasStableIdsEventHandler));
            AddEventHandler("isEmpty", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(IsEmptyEventHandler));
            AddEventHandler("areAllItemsEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("isEnabled", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(IsEnabledEventHandler));
            AddEventHandler("getCount", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetCountEventHandler));
            AddEventHandler("getItemViewType", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetItemViewTypeEventHandler));
            AddEventHandler("getViewTypeCount", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetViewTypeCountEventHandler));
            AddEventHandler("getItem", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetItemEventHandler));
            AddEventHandler("getItemId", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetItemIdEventHandler));
            AddEventHandler("registerDataSetObserver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("unregisterDataSetObserver", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(UnregisterDataSetObserverEventHandler));
            AddEventHandler("getAutofillOptions", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(GetAutofillOptionsEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetView"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, Android.View.View, Android.View.ViewGroup, Android.View.View> OnGetView { get; set; } = null;

        bool hasOverrideGetView = true;
        void GetViewEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetView = true;
            var methodToExecute = (OnGetView != null) ? OnGetView : GetView;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0), data.EventData.GetAt<Android.View.View>(1), data.EventData.GetAt<Android.View.ViewGroup>(2));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetView, executionResult);
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
            hasOverrideGetView = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetWrappedAdapter"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Android.Widget.ListAdapter> OnGetWrappedAdapter { get; set; } = null;

        bool hasOverrideGetWrappedAdapter = true;
        void GetWrappedAdapterEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetWrappedAdapter = true;
            var methodToExecute = (OnGetWrappedAdapter != null) ? OnGetWrappedAdapter : GetWrappedAdapter;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetWrappedAdapter, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public virtual Android.Widget.ListAdapter GetWrappedAdapter()
        {
            hasOverrideGetWrappedAdapter = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <remarks>If <see cref="OnHasStableIds"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnHasStableIds { get; set; } = null;

        bool hasOverrideHasStableIds = true;
        void HasStableIdsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideHasStableIds = true;
            var methodToExecute = (OnHasStableIds != null) ? OnHasStableIds : HasStableIds;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideHasStableIds, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool HasStableIds()
        {
            hasOverrideHasStableIds = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEmpty"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnIsEmpty { get; set; } = null;

        bool hasOverrideIsEmpty = true;
        void IsEmptyEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideIsEmpty = true;
            var methodToExecute = (OnIsEmpty != null) ? OnIsEmpty : IsEmpty;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideIsEmpty, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            hasOverrideIsEmpty = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <remarks>If <see cref="OnAreAllItemsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<bool> OnAreAllItemsEnabled { get; set; } = null;

        bool hasOverrideAreAllItemsEnabled = true;
        void AreAllItemsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideAreAllItemsEnabled = true;
            var methodToExecute = (OnAreAllItemsEnabled != null) ? OnAreAllItemsEnabled : AreAllItemsEnabled;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideAreAllItemsEnabled, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            hasOverrideAreAllItemsEnabled = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnIsEnabled"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, bool> OnIsEnabled { get; set; } = null;

        bool hasOverrideIsEnabled = true;
        void IsEnabledEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideIsEnabled = true;
            var methodToExecute = (OnIsEnabled != null) ? OnIsEnabled : IsEnabled;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideIsEnabled, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled(int arg0)
        {
            hasOverrideIsEnabled = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCount"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int> OnGetCount { get; set; } = null;

        bool hasOverrideGetCount = true;
        void GetCountEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetCount = true;
            var methodToExecute = (OnGetCount != null) ? OnGetCount : GetCount;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetCount, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetCount()
        {
            hasOverrideGetCount = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItemViewType"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, int> OnGetItemViewType { get; set; } = null;

        bool hasOverrideGetItemViewType = true;
        void GetItemViewTypeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetItemViewType = true;
            var methodToExecute = (OnGetItemViewType != null) ? OnGetItemViewType : GetItemViewType;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetItemViewType, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetItemViewType(int arg0)
        {
            hasOverrideGetItemViewType = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetViewTypeCount"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int> OnGetViewTypeCount { get; set; } = null;

        bool hasOverrideGetViewTypeCount = true;
        void GetViewTypeCountEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetViewTypeCount = true;
            var methodToExecute = (OnGetViewTypeCount != null) ? OnGetViewTypeCount : GetViewTypeCount;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetViewTypeCount, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetViewTypeCount()
        {
            hasOverrideGetViewTypeCount = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItem"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, object> OnGetItem { get; set; } = null;

        bool hasOverrideGetItem = true;
        void GetItemEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetItem = true;
            var methodToExecute = (OnGetItem != null) ? OnGetItem : GetItem;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetItem, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object GetItem(int arg0)
        {
            hasOverrideGetItem = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetItemId"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<int, long> OnGetItemId { get; set; } = null;

        bool hasOverrideGetItemId = true;
        void GetItemIdEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetItemId = true;
            var methodToExecute = (OnGetItemId != null) ? OnGetItemId : GetItemId;
            var executionResult = methodToExecute.Invoke(data.EventData.GetAt<int>(0));
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetItemId, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public virtual long GetItemId(int arg0)
        {
            hasOverrideGetItemId = false; return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        bool hasOverrideRegisterDataSetObserver = true;
        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideRegisterDataSetObserver = true;
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Database.DataSetObserver>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideRegisterDataSetObserver;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            hasOverrideRegisterDataSetObserver = false;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        bool hasOverrideUnregisterDataSetObserver = true;
        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideUnregisterDataSetObserver = true;
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.GetAt<Android.Database.DataSetObserver>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideUnregisterDataSetObserver;
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            hasOverrideUnregisterDataSetObserver = false;
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface</remarks>
        public Java.Lang.CharSequence[] GetAutofillOptionsDefault()
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getAutofillOptionsDefault", "()[Ljava/lang/CharSequence;");
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetAutofillOptions"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Func<Java.Lang.CharSequence[]> OnGetAutofillOptions { get; set; } = null;

        bool hasOverrideGetAutofillOptions = true;
        void GetAutofillOptionsEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideGetAutofillOptions = true;
            var methodToExecute = (OnGetAutofillOptions != null) ? OnGetAutofillOptions : GetAutofillOptions;
            var executionResult = methodToExecute.Invoke();
            data.EventData.TypedEventData.SetReturnData(hasOverrideGetAutofillOptions, executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <remarks>The method invokes the default implementation in the JVM interface using <see cref="GetAutofillOptionsDefault"/>; override the method to implement a different behavior</remarks>
        public virtual Java.Lang.CharSequence[] GetAutofillOptions()
        {
            hasOverrideGetAutofillOptions = false; return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WrapperListAdapterDirect implementation
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
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getView(int,android.view.View,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.View.View"/></param>
        /// <param name="arg2"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public override Android.View.View GetView(int arg0, Android.View.View arg1, Android.View.ViewGroup arg2)
        {
            return IExecuteWithSignature<Android.View.View>("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/WrapperListAdapter.html#getWrappedAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public override Android.Widget.ListAdapter GetWrappedAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapterDirect, Android.Widget.ListAdapter>("getWrappedAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#hasStableIds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool HasStableIds()
        {
            return IExecuteWithSignature<bool>("hasStableIds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecuteWithSignature<bool>("areAllItemsEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ListAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEnabled(int arg0)
        {
            return IExecuteWithSignature<bool>("isEnabled", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public override int GetCount()
        {
            return IExecuteWithSignature<int>("getCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetItemViewType(int arg0)
        {
            return IExecuteWithSignature<int>("getItemViewType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public override int GetViewTypeCount()
        {
            return IExecuteWithSignature<int>("getViewTypeCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public override object GetItem(int arg0)
        {
            return IExecuteWithSignature("getItem", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getItemId(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public override long GetItemId(int arg0)
        {
            return IExecuteWithSignature<long>("getItemId", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Adapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public override Java.Lang.CharSequence[] GetAutofillOptions()
        {
            return IExecuteWithSignatureArray<Java.Lang.CharSequence>("getAutofillOptions", "()[Ljava/lang/CharSequence;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}