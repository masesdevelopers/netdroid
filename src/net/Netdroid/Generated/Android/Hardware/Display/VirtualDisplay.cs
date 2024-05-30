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

namespace Android.Hardware.Display
{
    #region VirtualDisplay
    public partial class VirtualDisplay
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
        /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.html#getDisplay()"/> 
        /// </summary>
        public Android.View.Display Display
        {
            get { return IExecuteWithSignature<Android.View.Display>("getDisplay", "()Landroid/view/Display;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.html#getSurface()"/> <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.html#setSurface(android.view.Surface)"/>
        /// </summary>
        public Android.View.Surface Surface
        {
            get { return IExecuteWithSignature<Android.View.Surface>("getSurface", "()Landroid/view/Surface;"); } set { IExecuteWithSignature("setSurface", "(Landroid/view/Surface;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.html#resize(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Resize(int arg0, int arg1, int arg2)
        {
            IExecute("resize", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Callback
        public partial class Callback
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
            /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.Callback.html#onPaused()"/>
            /// </summary>
            public void OnPaused()
            {
                IExecuteWithSignature("onPaused", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.Callback.html#onResumed()"/>
            /// </summary>
            public void OnResumed()
            {
                IExecuteWithSignature("onResumed", "()V");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/hardware/display/VirtualDisplay.Callback.html#onStopped()"/>
            /// </summary>
            public void OnStopped()
            {
                IExecuteWithSignature("onStopped", "()V");
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