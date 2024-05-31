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
    #region IHeterogeneousExpandableList
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHeterogeneousExpandableList
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HeterogeneousExpandableList
    public partial class HeterogeneousExpandableList : Android.Widget.IHeterogeneousExpandableList
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
        /// <see href="https://developer.android.com/reference/android/widget/HeterogeneousExpandableList.html#getChildTypeCount()"/> 
        /// </summary>
        public int ChildTypeCount
        {
            get { return IExecuteWithSignature<int>("getChildTypeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeterogeneousExpandableList.html#getGroupTypeCount()"/> 
        /// </summary>
        public int GroupTypeCount
        {
            get { return IExecuteWithSignature<int>("getGroupTypeCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeterogeneousExpandableList.html#getChildType(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetChildType(int arg0, int arg1)
        {
            return IExecute<int>("getChildType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/HeterogeneousExpandableList.html#getGroupType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGroupType(int arg0)
        {
            return IExecuteWithSignature<int>("getGroupType", "(I)I", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}