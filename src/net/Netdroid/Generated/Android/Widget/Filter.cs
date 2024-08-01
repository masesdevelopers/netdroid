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
    #region Filter
    public partial class Filter
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
        /// <see href="https://developer.android.com/reference/android/widget/Filter.html#filter(java.lang.CharSequence,android.widget.Filter.FilterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="Android.Widget.Filter.FilterListener"/></param>
        public void FilterMethod(Java.Lang.CharSequence arg0, Android.Widget.Filter.FilterListener arg1)
        {
            IExecute("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Filter.html#filter(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        public void FilterMethod(Java.Lang.CharSequence arg0)
        {
            IExecuteWithSignature("filter", "(Ljava/lang/CharSequence;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/Filter.html#convertResultToString(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence ConvertResultToString(object arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", arg0);
        }

        #endregion

        #region Nested classes
        #region FilterListener
        public partial class FilterListener
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
            /// Handlers initializer for <see cref="FilterListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onFilterComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(OnFilterCompleteEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/widget/Filter.FilterListener.html#onFilterComplete(int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnFilterComplete"/> has a value it takes precedence over corresponding class method</remarks>
            public global::System.Action<int> OnOnFilterComplete { get; set; } = null;

            void OnFilterCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
            {
                var methodToExecute = (OnOnFilterComplete != null) ? OnOnFilterComplete : OnFilterComplete;
                methodToExecute.Invoke(data.EventData.TypedEventData);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/Filter.FilterListener.html#onFilterComplete(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public virtual void OnFilterComplete(int arg0)
            {
                
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FilterListenerDirect
        public partial class FilterListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/widget/Filter.FilterListener.html#onFilterComplete(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public override void OnFilterComplete(int arg0)
            {
                IExecuteWithSignature("onFilterComplete", "(I)V", arg0);
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