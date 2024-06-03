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

namespace Android.Service.Autofill
{
    #region Presentations
    public partial class Presentations
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
        /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.html#getInlinePresentation()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Autofill.InlinePresentation"/></returns>
        public Android.Service.Autofill.InlinePresentation GetInlinePresentation()
        {
            return IExecuteWithSignature<Android.Service.Autofill.InlinePresentation>("getInlinePresentation", "()Landroid/service/autofill/InlinePresentation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.html#getInlineTooltipPresentation()"/>
        /// </summary>
        /// <returns><see cref="Android.Service.Autofill.InlinePresentation"/></returns>
        public Android.Service.Autofill.InlinePresentation GetInlineTooltipPresentation()
        {
            return IExecuteWithSignature<Android.Service.Autofill.InlinePresentation>("getInlineTooltipPresentation", "()Landroid/service/autofill/InlinePresentation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.html#getDialogPresentation()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.RemoteViews"/></returns>
        public Android.Widget.RemoteViews GetDialogPresentation()
        {
            return IExecuteWithSignature<Android.Widget.RemoteViews>("getDialogPresentation", "()Landroid/widget/RemoteViews;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.html#getMenuPresentation()"/>
        /// </summary>
        /// <returns><see cref="Android.Widget.RemoteViews"/></returns>
        public Android.Widget.RemoteViews GetMenuPresentation()
        {
            return IExecuteWithSignature<Android.Widget.RemoteViews>("getMenuPresentation", "()Landroid/widget/RemoteViews;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Service.Autofill.Presentations"/></returns>
            public Android.Service.Autofill.Presentations Build()
            {
                return IExecuteWithSignature<Android.Service.Autofill.Presentations>("build", "()Landroid/service/autofill/Presentations;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.Builder.html#setDialogPresentation(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.Presentations.Builder"/></returns>
            public Android.Service.Autofill.Presentations.Builder SetDialogPresentation(Android.Widget.RemoteViews arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Presentations.Builder>("setDialogPresentation", "(Landroid/widget/RemoteViews;)Landroid/service/autofill/Presentations$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.Builder.html#setInlinePresentation(android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Presentations.Builder"/></returns>
            public Android.Service.Autofill.Presentations.Builder SetInlinePresentation(Android.Service.Autofill.InlinePresentation arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Presentations.Builder>("setInlinePresentation", "(Landroid/service/autofill/InlinePresentation;)Landroid/service/autofill/Presentations$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.Builder.html#setInlineTooltipPresentation(android.service.autofill.InlinePresentation)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Service.Autofill.InlinePresentation"/></param>
            /// <returns><see cref="Android.Service.Autofill.Presentations.Builder"/></returns>
            public Android.Service.Autofill.Presentations.Builder SetInlineTooltipPresentation(Android.Service.Autofill.InlinePresentation arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Presentations.Builder>("setInlineTooltipPresentation", "(Landroid/service/autofill/InlinePresentation;)Landroid/service/autofill/Presentations$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/service/autofill/Presentations.Builder.html#setMenuPresentation(android.widget.RemoteViews)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RemoteViews"/></param>
            /// <returns><see cref="Android.Service.Autofill.Presentations.Builder"/></returns>
            public Android.Service.Autofill.Presentations.Builder SetMenuPresentation(Android.Widget.RemoteViews arg0)
            {
                return IExecuteWithSignature<Android.Service.Autofill.Presentations.Builder>("setMenuPresentation", "(Landroid/widget/RemoteViews;)Landroid/service/autofill/Presentations$Builder;", arg0);
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