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

namespace Android.Util
{
    #region IDumpable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDumpable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Dumpable.html#getDumpableName()"/> 
        /// </summary>
        Java.Lang.String DumpableName { get; }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Dumpable.html#dump(java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        void Dump(Java.Io.PrintWriter arg0, Java.Lang.String[] arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Dumpable
    public partial class Dumpable : Android.Util.IDumpable
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
        /// <see href="https://developer.android.com/reference/android/util/Dumpable.html#getDumpableName()"/> 
        /// </summary>
        public Java.Lang.String DumpableName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDumpableName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/Dumpable.html#dump(java.io.PrintWriter,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintWriter"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Dump(Java.Io.PrintWriter arg0, Java.Lang.String[] arg1)
        {
            IExecute("dump", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}