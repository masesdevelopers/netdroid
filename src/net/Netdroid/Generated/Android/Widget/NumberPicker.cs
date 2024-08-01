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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Widget
{
    #region NumberPicker
    public partial class NumberPicker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public NumberPicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public NumberPicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public NumberPicker(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public NumberPicker(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getWrapSelectorWheel()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWrapSelectorWheel()
        {
            return IExecuteWithSignature<bool>("getWrapSelectorWheel", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getTextSize()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetTextSize()
        {
            return IExecuteWithSignature<float>("getTextSize", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getMaxValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxValue()
        {
            return IExecuteWithSignature<int>("getMaxValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getMinValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMinValue()
        {
            return IExecuteWithSignature<int>("getMinValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getSelectionDividerHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSelectionDividerHeight()
        {
            return IExecuteWithSignature<int>("getSelectionDividerHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getTextColor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTextColor()
        {
            return IExecuteWithSignature<int>("getTextColor", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetValue()
        {
            return IExecuteWithSignature<int>("getValue", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#getDisplayedValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetDisplayedValues()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getDisplayedValues", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setDisplayedValues(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetDisplayedValues(Java.Lang.String[] arg0)
        {
            IExecuteWithSignature("setDisplayedValues", "([Ljava/lang/String;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setFormatter(android.widget.NumberPicker.Formatter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.NumberPicker.Formatter"/></param>
        public void SetFormatter(Android.Widget.NumberPicker.Formatter arg0)
        {
            IExecuteWithSignature("setFormatter", "(Landroid/widget/NumberPicker$Formatter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setMaxValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMaxValue(int arg0)
        {
            IExecuteWithSignature("setMaxValue", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setMinValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMinValue(int arg0)
        {
            IExecuteWithSignature("setMinValue", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setOnLongPressUpdateInterval(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetOnLongPressUpdateInterval(long arg0)
        {
            IExecuteWithSignature("setOnLongPressUpdateInterval", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setOnScrollListener(android.widget.NumberPicker.OnScrollListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.NumberPicker.OnScrollListener"/></param>
        public void SetOnScrollListener(Android.Widget.NumberPicker.OnScrollListener arg0)
        {
            IExecuteWithSignature("setOnScrollListener", "(Landroid/widget/NumberPicker$OnScrollListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setOnValueChangedListener(android.widget.NumberPicker.OnValueChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.NumberPicker.OnValueChangeListener"/></param>
        public void SetOnValueChangedListener(Android.Widget.NumberPicker.OnValueChangeListener arg0)
        {
            IExecuteWithSignature("setOnValueChangedListener", "(Landroid/widget/NumberPicker$OnValueChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setSelectionDividerHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetSelectionDividerHeight(int arg0)
        {
            IExecuteWithSignature("setSelectionDividerHeight", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setTextColor(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetTextColor(int arg0)
        {
            IExecuteWithSignature("setTextColor", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setTextSize(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public void SetTextSize(float arg0)
        {
            IExecuteWithSignature("setTextSize", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetValue(int arg0)
        {
            IExecuteWithSignature("setValue", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.html#setWrapSelectorWheel(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWrapSelectorWheel(bool arg0)
        {
            IExecuteWithSignature("setWrapSelectorWheel", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Formatter
        public partial class Formatter
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
            /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.Formatter.html#format(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Format(int arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("format", "(I)Ljava/lang/String;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnScrollListener
        public partial class OnScrollListener
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
            /// Handlers initializer for <see cref="OnScrollListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onScrollStateChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.NumberPicker>>>(OnScrollStateChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnScrollListener.html#onScrollStateChange(android.widget.NumberPicker,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnScrollStateChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.NumberPicker, int> OnOnScrollStateChange { get; set; } = null;

            void OnScrollStateChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.NumberPicker>> data)
            {
                var methodToExecute = (OnOnScrollStateChange != null) ? OnOnScrollStateChange : OnScrollStateChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnScrollListener.html#onScrollStateChange(android.widget.NumberPicker,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.NumberPicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public virtual void OnScrollStateChange(Android.Widget.NumberPicker arg0, int arg1)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnScrollListenerDirect
        public partial class OnScrollListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnScrollListener.html#onScrollStateChange(android.widget.NumberPicker,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.NumberPicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public override void OnScrollStateChange(Android.Widget.NumberPicker arg0, int arg1)
            {
                IExecute("onScrollStateChange", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnValueChangeListener
        public partial class OnValueChangeListener
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
            /// Handlers initializer for <see cref="OnValueChangeListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onValueChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Android.Widget.NumberPicker>>>(OnValueChangeEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnValueChangeListener.html#onValueChange(android.widget.NumberPicker,int,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnValueChange"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<Android.Widget.NumberPicker, int, int> OnOnValueChange { get; set; } = null;

            void OnValueChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Android.Widget.NumberPicker>> data)
            {
                var methodToExecute = (OnOnValueChange != null) ? OnOnValueChange : OnValueChange;
                methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<int>(1));
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnValueChangeListener.html#onValueChange(android.widget.NumberPicker,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.NumberPicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public virtual void OnValueChange(Android.Widget.NumberPicker arg0, int arg1, int arg2)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnValueChangeListenerDirect
        public partial class OnValueChangeListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/NumberPicker.OnValueChangeListener.html#onValueChange(android.widget.NumberPicker,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.NumberPicker"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public override void OnValueChange(Android.Widget.NumberPicker arg0, int arg1, int arg2)
            {
                IExecute("onValueChange", arg0, arg1, arg2);
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