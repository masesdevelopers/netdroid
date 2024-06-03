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
    #region AutoCompleteTextView
    public partial class AutoCompleteTextView
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int,android.content.res.Resources.Theme)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Content.Res.Resources.Theme"/></param>
        public AutoCompleteTextView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3, Android.Content.Res.Resources.Theme arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AutoCompleteTextView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AutoCompleteTextView(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public AutoCompleteTextView(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AutoCompleteTextView(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setAdapter(android.widget.ListAdapter)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"><see cref="Android.Widget.IListAdapter"/></typeparam>
        public void SetAdapter<T>(T arg0) where T : Android.Widget.IListAdapter, Android.Widget.IFilterable, new()
        {
            IExecute("setAdapter", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownBackground()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Drawable.Drawable"/></returns>
        public Android.Graphics.Drawable.Drawable GetDropDownBackground()
        {
            return IExecuteWithSignature<Android.Graphics.Drawable.Drawable>("getDropDownBackground", "()Landroid/graphics/drawable/Drawable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getItemClickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemClickListener"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.AdapterView.OnItemClickListener GetItemClickListener()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemClickListener>("getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getItemClickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemClickListener"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.AdapterView.OnItemClickListener GetItemClickListenerDirect()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemClickListenerDirect, Android.Widget.AdapterView.OnItemClickListener>("getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getOnItemClickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemClickListener"/></returns>
        public Android.Widget.AdapterView.OnItemClickListener GetOnItemClickListener()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemClickListener>("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getOnItemClickListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemClickListener"/></returns>
        public Android.Widget.AdapterView.OnItemClickListener GetOnItemClickListenerDirect()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemClickListenerDirect, Android.Widget.AdapterView.OnItemClickListener>("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getItemSelectedListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.AdapterView.OnItemSelectedListener GetItemSelectedListener()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemSelectedListener>("getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getItemSelectedListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></returns>
        [global::System.Obsolete()]
        public Android.Widget.AdapterView.OnItemSelectedListener GetItemSelectedListenerDirect()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemSelectedListenerDirect, Android.Widget.AdapterView.OnItemSelectedListener>("getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getOnItemSelectedListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></returns>
        public Android.Widget.AdapterView.OnItemSelectedListener GetOnItemSelectedListener()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemSelectedListener>("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getOnItemSelectedListener()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></returns>
        public Android.Widget.AdapterView.OnItemSelectedListener GetOnItemSelectedListenerDirect()
        {
            return IExecuteWithSignature<Android.Widget.AdapterView.OnItemSelectedListenerDirect, Android.Widget.AdapterView.OnItemSelectedListener>("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getValidator()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.AutoCompleteTextView.Validator"/></returns>
        public Android.Widget.AutoCompleteTextView.Validator GetValidator()
        {
            return IExecuteWithSignature<Android.Widget.AutoCompleteTextView.Validator>("getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public Android.Widget.ListAdapter GetAdapter()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapter>("getAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getAdapter()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.ListAdapter"/></returns>
        public Android.Widget.ListAdapter GetAdapterDirect()
        {
            return IExecuteWithSignature<Android.Widget.ListAdapterDirect, Android.Widget.ListAdapter>("getAdapter", "()Landroid/widget/ListAdapter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#enoughToFilter()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool EnoughToFilter()
        {
            return IExecuteWithSignature<bool>("enoughToFilter", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#isPerformingCompletion()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPerformingCompletion()
        {
            return IExecuteWithSignature<bool>("isPerformingCompletion", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#isPopupShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPopupShowing()
        {
            return IExecuteWithSignature<bool>("isPopupShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#refreshAutoCompleteResults()"/>
        /// </summary>
        public void RefreshAutoCompleteResults()
        {
            IExecuteWithSignature("refreshAutoCompleteResults", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownAnchor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDropDownAnchor()
        {
            return IExecuteWithSignature<int>("getDropDownAnchor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDropDownHeight()
        {
            return IExecuteWithSignature<int>("getDropDownHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownHorizontalOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDropDownHorizontalOffset()
        {
            return IExecuteWithSignature<int>("getDropDownHorizontalOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownVerticalOffset()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDropDownVerticalOffset()
        {
            return IExecuteWithSignature<int>("getDropDownVerticalOffset", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getDropDownWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDropDownWidth()
        {
            return IExecuteWithSignature<int>("getDropDownWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getInputMethodMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInputMethodMode()
        {
            return IExecuteWithSignature<int>("getInputMethodMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getListSelection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetListSelection()
        {
            return IExecuteWithSignature<int>("getListSelection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getThreshold()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThreshold()
        {
            return IExecuteWithSignature<int>("getThreshold", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#getCompletionHint()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence GetCompletionHint()
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCompletionHint", "()Ljava/lang/CharSequence;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#clearListSelection()"/>
        /// </summary>
        public void ClearListSelection()
        {
            IExecuteWithSignature("clearListSelection", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#dismissDropDown()"/>
        /// </summary>
        public void DismissDropDown()
        {
            IExecuteWithSignature("dismissDropDown", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#onFilterComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void OnFilterComplete(int arg0)
        {
            IExecuteWithSignature("onFilterComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#performCompletion()"/>
        /// </summary>
        public void PerformCompletion()
        {
            IExecuteWithSignature("performCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#performValidation()"/>
        /// </summary>
        public void PerformValidation()
        {
            IExecuteWithSignature("performValidation", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setCompletionHint(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void SetCompletionHint(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("setCompletionHint", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownAnchor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownAnchor(int arg0)
        {
            IExecuteWithSignature("setDropDownAnchor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownBackgroundDrawable(android.graphics.drawable.Drawable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Drawable.Drawable"/></param>
        public void SetDropDownBackgroundDrawable(Android.Graphics.Drawable.Drawable arg0)
        {
            IExecuteWithSignature("setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownBackgroundResource(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownBackgroundResource(int arg0)
        {
            IExecuteWithSignature("setDropDownBackgroundResource", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownHeight(int arg0)
        {
            IExecuteWithSignature("setDropDownHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownHorizontalOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownHorizontalOffset(int arg0)
        {
            IExecuteWithSignature("setDropDownHorizontalOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownVerticalOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownVerticalOffset(int arg0)
        {
            IExecuteWithSignature("setDropDownVerticalOffset", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setDropDownWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDropDownWidth(int arg0)
        {
            IExecuteWithSignature("setDropDownWidth", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setInputMethodMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetInputMethodMode(int arg0)
        {
            IExecuteWithSignature("setInputMethodMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setListSelection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetListSelection(int arg0)
        {
            IExecuteWithSignature("setListSelection", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setOnDismissListener(android.widget.AutoCompleteTextView.OnDismissListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AutoCompleteTextView.OnDismissListener"/></param>
        public void SetOnDismissListener(Android.Widget.AutoCompleteTextView.OnDismissListener arg0)
        {
            IExecuteWithSignature("setOnDismissListener", "(Landroid/widget/AutoCompleteTextView$OnDismissListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setOnItemClickListener(android.widget.AdapterView.OnItemClickListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AdapterView.OnItemClickListener"/></param>
        public void SetOnItemClickListener(Android.Widget.AdapterView.OnItemClickListener arg0)
        {
            IExecuteWithSignature("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AdapterView.OnItemSelectedListener"/></param>
        public void SetOnItemSelectedListener(Android.Widget.AdapterView.OnItemSelectedListener arg0)
        {
            IExecuteWithSignature("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setText(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetText(Java.Lang.CharSequence arg0, bool arg1)
        {
            IExecute("setText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setThreshold(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetThreshold(int arg0)
        {
            IExecuteWithSignature("setThreshold", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#setValidator(android.widget.AutoCompleteTextView.Validator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.AutoCompleteTextView.Validator"/></param>
        public void SetValidator(Android.Widget.AutoCompleteTextView.Validator arg0)
        {
            IExecuteWithSignature("setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.html#showDropDown()"/>
        /// </summary>
        public void ShowDropDown()
        {
            IExecuteWithSignature("showDropDown", "()V");
        }

        #endregion

        #region Nested classes
        #region OnDismissListener
        public partial class OnDismissListener
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
            /// Handlers initializer for <see cref="OnDismissListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onDismiss", new global::System.EventHandler<CLRListenerEventArgs<CLREventData>>(OnDismissEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.OnDismissListener.html#onDismiss()"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnDismiss"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action OnOnDismiss { get; set; } = null;

            void OnDismissEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
            {
                var methodToExecute = (OnOnDismiss != null) ? OnOnDismiss : OnDismiss;
                methodToExecute.Invoke();
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.OnDismissListener.html#onDismiss()"/>
            /// </summary>
            public virtual void OnDismiss()
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnDismissListenerDirect
        public partial class OnDismissListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.OnDismissListener.html#onDismiss()"/>
            /// </summary>
            public override void OnDismiss()
            {
                IExecuteWithSignature("onDismiss", "()V");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Validator
        public partial class Validator
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
            /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.Validator.html#isValid(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool IsValid(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<bool>("isValid", "(Ljava/lang/CharSequence;)Z", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/AutoCompleteTextView.Validator.html#fixText(java.lang.CharSequence)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
            /// <returns><see cref="Java.Lang.CharSequence"/></returns>
            public Java.Lang.CharSequence FixText(Java.Lang.CharSequence arg0)
            {
                return IExecuteWithSignature<Java.Lang.CharSequence>("fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}