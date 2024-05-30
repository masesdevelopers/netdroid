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
    #region AbsSpinner
    public partial class AbsSpinner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AbsSpinner(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AbsSpinner(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public AbsSpinner(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AbsSpinner(Android.Content.Context arg0)
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
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#onSaveInstanceState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        public Android.Os.Parcelable OnSaveInstanceState()
        {
            return IExecuteWithSignature<Android.Os.Parcelable>("onSaveInstanceState", "()Landroid/os/Parcelable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#pointToPosition(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int PointToPosition(int arg0, int arg1)
        {
            return IExecute<int>("pointToPosition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#onRestoreInstanceState(android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        public void OnRestoreInstanceState(Android.Os.Parcelable arg0)
        {
            IExecuteWithSignature("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#setAdapter(android.widget.SpinnerAdapter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Widget.SpinnerAdapter"/></param>
        public void SetAdapter(Android.Widget.SpinnerAdapter arg0)
        {
            IExecuteWithSignature("setAdapter", "(Landroid/widget/SpinnerAdapter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AbsSpinner.html#setSelection(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetSelection(int arg0, bool arg1)
        {
            IExecute("setSelection", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}