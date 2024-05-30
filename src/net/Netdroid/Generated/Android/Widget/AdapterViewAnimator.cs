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
    #region AdapterViewAnimator
    public partial class AdapterViewAnimator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AdapterViewAnimator(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public AdapterViewAnimator(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public AdapterViewAnimator(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public AdapterViewAnimator(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Widget.AdapterViewAnimator"/> to <see cref="Android.Widget.Advanceable"/>
        /// </summary>
        public static implicit operator Android.Widget.Advanceable(Android.Widget.AdapterViewAnimator t) => t.Cast<Android.Widget.Advanceable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#getCurrentView()"/> 
        /// </summary>
        public Android.View.View CurrentView
        {
            get { return IExecuteWithSignature<Android.View.View>("getCurrentView", "()Landroid/view/View;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#getDisplayedChild()"/> <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setDisplayedChild(int)"/>
        /// </summary>
        public int DisplayedChild
        {
            get { return IExecuteWithSignature<int>("getDisplayedChild", "()I"); } set { IExecuteWithSignature("setDisplayedChild", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#getInAnimation()"/> <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setInAnimation(android.animation.ObjectAnimator)"/>
        /// </summary>
        public Android.Animation.ObjectAnimator InAnimation
        {
            get { return IExecuteWithSignature<Android.Animation.ObjectAnimator>("getInAnimation", "()Landroid/animation/ObjectAnimator;"); } set { IExecuteWithSignature("setInAnimation", "(Landroid/animation/ObjectAnimator;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#getOutAnimation()"/> <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setOutAnimation(android.animation.ObjectAnimator)"/>
        /// </summary>
        public Android.Animation.ObjectAnimator OutAnimation
        {
            get { return IExecuteWithSignature<Android.Animation.ObjectAnimator>("getOutAnimation", "()Landroid/animation/ObjectAnimator;"); } set { IExecuteWithSignature("setOutAnimation", "(Landroid/animation/ObjectAnimator;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#onSaveInstanceState()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Parcelable"/></returns>
        public Android.Os.Parcelable OnSaveInstanceState()
        {
            return IExecuteWithSignature<Android.Os.Parcelable>("onSaveInstanceState", "()Landroid/os/Parcelable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#onRemoteAdapterConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool OnRemoteAdapterConnected()
        {
            return IExecuteWithSignature<bool>("onRemoteAdapterConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#advance()"/>
        /// </summary>
        public void Advance()
        {
            IExecuteWithSignature("advance", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#deferNotifyDataSetChanged()"/>
        /// </summary>
        public void DeferNotifyDataSetChanged()
        {
            IExecuteWithSignature("deferNotifyDataSetChanged", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#fyiWillBeAdvancedByHostKThx()"/>
        /// </summary>
        public void FyiWillBeAdvancedByHostKThx()
        {
            IExecuteWithSignature("fyiWillBeAdvancedByHostKThx", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#onRemoteAdapterDisconnected()"/>
        /// </summary>
        public void OnRemoteAdapterDisconnected()
        {
            IExecuteWithSignature("onRemoteAdapterDisconnected", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#onRestoreInstanceState(android.os.Parcelable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcelable"/></param>
        public void OnRestoreInstanceState(Android.Os.Parcelable arg0)
        {
            IExecuteWithSignature("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setAnimateFirstView(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnimateFirstView(bool arg0)
        {
            IExecuteWithSignature("setAnimateFirstView", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setInAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetInAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecute("setInAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setOutAnimation(android.content.Context,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetOutAnimation(Android.Content.Context arg0, int arg1)
        {
            IExecute("setOutAnimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#setRemoteViewsAdapter(android.content.Intent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Intent"/></param>
        public void SetRemoteViewsAdapter(Android.Content.Intent arg0)
        {
            IExecuteWithSignature("setRemoteViewsAdapter", "(Landroid/content/Intent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#showNext()"/>
        /// </summary>
        public void ShowNext()
        {
            IExecuteWithSignature("showNext", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/AdapterViewAnimator.html#showPrevious()"/>
        /// </summary>
        public void ShowPrevious()
        {
            IExecuteWithSignature("showPrevious", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}