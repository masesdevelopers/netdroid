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

namespace Android.App.Backup
{
    #region RestoreObserver
    public partial class RestoreObserver
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
        /// <see href="https://developer.android.com/reference/android/app/backup/RestoreObserver.html#onUpdate(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void OnUpdate(int arg0, Java.Lang.String arg1)
        {
            IExecute("onUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/RestoreObserver.html#restoreFinished(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RestoreFinished(int arg0)
        {
            IExecuteWithSignature("restoreFinished", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/app/backup/RestoreObserver.html#restoreStarting(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RestoreStarting(int arg0)
        {
            IExecuteWithSignature("restoreStarting", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}