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
    #region ResourceCursorAdapter
    public partial class ResourceCursorAdapter
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
        /// Handlers initializer for <see cref="ResourceCursorAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("bindView", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.View.View>>>(BindViewEventHandler));
            AddEventHandler("getDropDownViewTheme", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetDropDownViewThemeEventHandler));
            AddEventHandler("getCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetCursorEventHandler));
            AddEventHandler("runQueryOnBackgroundThread", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>>>(RunQueryOnBackgroundThreadEventHandler));
            AddEventHandler("swapCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(SwapCursorEventHandler));
            AddEventHandler("getFilter", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetFilterEventHandler));
            AddEventHandler("getFilterQueryProvider", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetFilterQueryProviderEventHandler));
            AddEventHandler("areAllItemsEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(AreAllItemsEnabledEventHandler));
            AddEventHandler("isEmpty", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(IsEmptyEventHandler));
            AddEventHandler("isEnabled", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(IsEnabledEventHandler));
            AddEventHandler("getItemViewType", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(GetItemViewTypeEventHandler));
            AddEventHandler("getViewTypeCount", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetViewTypeCountEventHandler));
            AddEventHandler("convertToString", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(ConvertToStringEventHandler));
            AddEventHandler("getAutofillOptions", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(GetAutofillOptionsEventHandler));
            AddEventHandler("notifyDataSetChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetChangedEventHandler));
            AddEventHandler("notifyDataSetInvalidated", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(NotifyDataSetInvalidatedEventHandler));
            AddEventHandler("registerDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(RegisterDataSetObserverEventHandler));
            AddEventHandler("setAutofillOptions", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence[]>>>(SetAutofillOptionsEventHandler));
            AddEventHandler("unregisterDataSetObserver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>>>(UnregisterDataSetObserverEventHandler));
            AddEventHandler("changeCursor", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Database.Cursor>>>(ChangeCursorEventHandler));
            AddEventHandler("setFilterQueryProvider", new System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.FilterQueryProvider>>>(SetFilterQueryProviderEventHandler));
            AddEventHandler("setDropDownViewResource", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(SetDropDownViewResourceEventHandler));
            AddEventHandler("setViewResource", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(SetViewResourceEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#bindView(android.view.View,android.content.Context,android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnBindView"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.View.View, Android.Content.Context, Android.Database.Cursor> OnBindView { get; set; } = null;

        void BindViewEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.View.View>> data)
        {
            var methodToExecute = (OnBindView != null) ? OnBindView : BindView;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Android.Content.Context>(0), data.EventData.GetAt<Android.Database.Cursor>(1));
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#bindView(android.view.View,android.content.Context,android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Content.Context"/></param>
        /// <param name="arg2"><see cref="Android.Database.Cursor"/></param>
        public virtual void BindView(Android.View.View arg0, Android.Content.Context arg1, Android.Database.Cursor arg2)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetDropDownViewTheme"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Content.Res.Resources.Theme> OnGetDropDownViewTheme { get; set; } = null;

        void GetDropDownViewThemeEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetDropDownViewTheme != null) ? OnGetDropDownViewTheme : GetDropDownViewTheme;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getDropDownViewTheme()"/>
        /// </summary>
        /// <returns><see cref="Android.Content.Res.Resources.Theme"/></returns>
        public virtual Android.Content.Res.Resources.Theme GetDropDownViewTheme()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getCursor()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Database.Cursor> OnGetCursor { get; set; } = null;

        void GetCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetCursor != null) ? OnGetCursor : GetCursor;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getCursor()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public virtual Android.Database.Cursor GetCursor()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRunQueryOnBackgroundThread"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Java.Lang.CharSequence, Android.Database.Cursor> OnRunQueryOnBackgroundThread { get; set; } = null;

        void RunQueryOnBackgroundThreadEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence>> data)
        {
            var methodToExecute = (OnRunQueryOnBackgroundThread != null) ? OnRunQueryOnBackgroundThread : RunQueryOnBackgroundThread;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public virtual Android.Database.Cursor RunQueryOnBackgroundThread(Java.Lang.CharSequence arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#swapCursor(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSwapCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Database.Cursor, Android.Database.Cursor> OnSwapCursor { get; set; } = null;

        void SwapCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnSwapCursor != null) ? OnSwapCursor : SwapCursor;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#swapCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public virtual Android.Database.Cursor SwapCursor(Android.Database.Cursor arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilter()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFilter"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Widget.Filter> OnGetFilter { get; set; } = null;

        void GetFilterEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetFilter != null) ? OnGetFilter : GetFilter;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.Filter"/></returns>
        public virtual Android.Widget.Filter GetFilter()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilterQueryProvider()"/>
        /// </summary>
        /// <remarks>If <see cref="OnGetFilterQueryProvider"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Widget.FilterQueryProvider> OnGetFilterQueryProvider { get; set; } = null;

        void GetFilterQueryProviderEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnGetFilterQueryProvider != null) ? OnGetFilterQueryProvider : GetFilterQueryProvider;
            var executionResult = methodToExecute.Invoke();
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilterQueryProvider()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.FilterQueryProvider"/></returns>
        public virtual Android.Widget.FilterQueryProvider GetFilterQueryProvider()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool AreAllItemsEnabled()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEmpty()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool IsEnabled(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int GetItemViewType(int arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public virtual int GetViewTypeCount()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnConvertToString"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Func<Android.Database.Cursor, Java.Lang.CharSequence> OnConvertToString { get; set; } = null;

        void ConvertToStringEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnConvertToString != null) ? OnConvertToString : ConvertToString;
            var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData);
            data.SetReturnValue(executionResult);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public virtual Java.Lang.CharSequence ConvertToString(Android.Database.Cursor arg0)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/>
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public virtual Java.Lang.CharSequence[] GetAutofillOptions()
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnNotifyDataSetChanged { get; set; } = null;

        void NotifyDataSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetChanged != null) ? OnNotifyDataSetChanged : NotifyDataSetChanged;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public virtual void NotifyDataSetChanged()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        /// <remarks>If <see cref="OnNotifyDataSetInvalidated"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action OnNotifyDataSetInvalidated { get; set; } = null;

        void NotifyDataSetInvalidatedEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var methodToExecute = (OnNotifyDataSetInvalidated != null) ? OnNotifyDataSetInvalidated : NotifyDataSetInvalidated;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public virtual void NotifyDataSetInvalidated()
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRegisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnRegisterDataSetObserver { get; set; } = null;

        void RegisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnRegisterDataSetObserver != null) ? OnRegisterDataSetObserver : RegisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetAutofillOptions"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<> OnSetAutofillOptions { get; set; } = null;

        void SetAutofillOptionsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.CharSequence[]>> data)
        {
            var methodToExecute = (OnSetAutofillOptions != null) ? OnSetAutofillOptions : SetAutofillOptions;
            methodToExecute.Invoke();
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public virtual void SetAutofillOptions(params Java.Lang.CharSequence[] arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <remarks>If <see cref="OnUnregisterDataSetObserver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.DataSetObserver> OnUnregisterDataSetObserver { get; set; } = null;

        void UnregisterDataSetObserverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.DataSetObserver>> data)
        {
            var methodToExecute = (OnUnregisterDataSetObserver != null) ? OnUnregisterDataSetObserver : UnregisterDataSetObserver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public virtual void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <remarks>If <see cref="OnChangeCursor"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Database.Cursor> OnChangeCursor { get; set; } = null;

        void ChangeCursorEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Database.Cursor>> data)
        {
            var methodToExecute = (OnChangeCursor != null) ? OnChangeCursor : ChangeCursor;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public virtual void ChangeCursor(Android.Database.Cursor arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetFilterQueryProvider"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Android.Widget.FilterQueryProvider> OnSetFilterQueryProvider { get; set; } = null;

        void SetFilterQueryProviderEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.FilterQueryProvider>> data)
        {
            var methodToExecute = (OnSetFilterQueryProvider != null) ? OnSetFilterQueryProvider : SetFilterQueryProvider;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.FilterQueryProvider"/></param>
        public virtual void SetFilterQueryProvider(Android.Widget.FilterQueryProvider arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetDropDownViewResource"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int> OnSetDropDownViewResource { get; set; } = null;

        void SetDropDownViewResourceEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnSetDropDownViewResource != null) ? OnSetDropDownViewResource : SetDropDownViewResource;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void SetDropDownViewResource(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setViewResource(int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSetViewResource"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<int> OnSetViewResource { get; set; } = null;

        void SetViewResourceEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var methodToExecute = (OnSetViewResource != null) ? OnSetViewResource : SetViewResource;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void SetViewResource(int arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ResourceCursorAdapterDirect
    public partial class ResourceCursorAdapterDirect
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
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getAutofillOptions()"/> <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#setAutofillOptions(java.lang.CharSequence[])"/>
        /// </summary>
        public Java.Lang.CharSequence[] AutofillOptions
        {
            get { return IExecuteArray<Java.Lang.CharSequence>("getAutofillOptions"); } set { IExecute("setAutofillOptions", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getCursor()"/> 
        /// </summary>
        public Android.Database.Cursor Cursor
        {
            get { return IExecute<Android.Database.Cursor>("getCursor"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getDropDownViewTheme()"/> 
        /// </summary>
        public Android.Content.Res.Resources.Theme DropDownViewTheme
        {
            get { return IExecute<Android.Content.Res.Resources.Theme>("getDropDownViewTheme"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilter()"/> 
        /// </summary>
        public Android.Widget.Filter Filter
        {
            get { return IExecute<Android.Widget.Filter>("getFilter"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#getFilterQueryProvider()"/> <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#setFilterQueryProvider(android.widget.FilterQueryProvider)"/>
        /// </summary>
        public Android.Widget.FilterQueryProvider FilterQueryProvider
        {
            get { return IExecute<Android.Widget.FilterQueryProvider>("getFilterQueryProvider"); } set { IExecute("setFilterQueryProvider", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getViewTypeCount()"/> 
        /// </summary>
        public int ViewTypeCount
        {
            get { return IExecute<int>("getViewTypeCount"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#bindView(android.view.View,android.content.Context,android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.View.View"/></param>
        /// <param name="arg1"><see cref="Android.Content.Context"/></param>
        /// <param name="arg2"><see cref="Android.Database.Cursor"/></param>
        public override void BindView(Android.View.View arg0, Android.Content.Context arg1, Android.Database.Cursor arg2)
        {
            IExecute("bindView", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#runQueryOnBackgroundThread(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public override Android.Database.Cursor RunQueryOnBackgroundThread(Java.Lang.CharSequence arg0)
        {
            return IExecute<Android.Database.Cursor>("runQueryOnBackgroundThread", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#swapCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public override Android.Database.Cursor SwapCursor(Android.Database.Cursor arg0)
        {
            return IExecute<Android.Database.Cursor>("swapCursor", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#areAllItemsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool AreAllItemsEnabled()
        {
            return IExecute<bool>("areAllItemsEnabled");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#isEnabled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool IsEnabled(int arg0)
        {
            return IExecute<bool>("isEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#getItemViewType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int GetItemViewType(int arg0)
        {
            return IExecute<int>("getItemViewType", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#convertToString(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public override Java.Lang.CharSequence ConvertToString(Android.Database.Cursor arg0)
        {
            return IExecute<Java.Lang.CharSequence>("convertToString", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetChanged()"/>
        /// </summary>
        public override void NotifyDataSetChanged()
        {
            IExecute("notifyDataSetChanged");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#notifyDataSetInvalidated()"/>
        /// </summary>
        public override void NotifyDataSetInvalidated()
        {
            IExecute("notifyDataSetInvalidated");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("registerDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/BaseAdapter.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public override void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecute("unregisterDataSetObserver", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/CursorAdapter.html#changeCursor(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public override void ChangeCursor(Android.Database.Cursor arg0)
        {
            IExecute("changeCursor", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setDropDownViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void SetDropDownViewResource(int arg0)
        {
            IExecuteWithSignature("setDropDownViewResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorAdapter.html#setViewResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void SetViewResource(int arg0)
        {
            IExecuteWithSignature("setViewResource", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}