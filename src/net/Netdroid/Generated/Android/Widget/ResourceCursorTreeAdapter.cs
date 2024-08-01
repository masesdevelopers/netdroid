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
    #region ResourceCursorTreeAdapter
    public partial class ResourceCursorTreeAdapter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public ResourceCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, int arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public ResourceCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorTreeAdapter.html#%3Cinit%3E(android.content.Context,android.database.Cursor,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ResourceCursorTreeAdapter(Android.Content.Context arg0, Android.Database.Cursor arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorTreeAdapter.html#newChildView(android.content.Context,android.database.Cursor,boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View NewChildView(Android.Content.Context arg0, Android.Database.Cursor arg1, bool arg2, Android.View.ViewGroup arg3)
        {
            return IExecute<Android.View.View>("newChildView", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/ResourceCursorTreeAdapter.html#newGroupView(android.content.Context,android.database.Cursor,boolean,android.view.ViewGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Database.Cursor"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Android.View.ViewGroup"/></param>
        /// <returns><see cref="Android.View.View"/></returns>
        public Android.View.View NewGroupView(Android.Content.Context arg0, Android.Database.Cursor arg1, bool arg2, Android.View.ViewGroup arg3)
        {
            return IExecute<Android.View.View>("newGroupView", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}