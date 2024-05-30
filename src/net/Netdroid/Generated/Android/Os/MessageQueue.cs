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

namespace Android.Os
{
    #region MessageQueue
    public partial class MessageQueue
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
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#isIdle()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIdle()
        {
            return IExecuteWithSignature<bool>("isIdle", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#addIdleHandler(android.os.MessageQueue.IdleHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.MessageQueue.IdleHandler"/></param>
        public void AddIdleHandler(Android.Os.MessageQueue.IdleHandler arg0)
        {
            IExecuteWithSignature("addIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#addOnFileDescriptorEventListener(java.io.FileDescriptor,int,android.os.MessageQueue.OnFileDescriptorEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Os.MessageQueue.OnFileDescriptorEventListener"/></param>
        public void AddOnFileDescriptorEventListener(Java.Io.FileDescriptor arg0, int arg1, Android.Os.MessageQueue.OnFileDescriptorEventListener arg2)
        {
            IExecute("addOnFileDescriptorEventListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#removeIdleHandler(android.os.MessageQueue.IdleHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.MessageQueue.IdleHandler"/></param>
        public void RemoveIdleHandler(Android.Os.MessageQueue.IdleHandler arg0)
        {
            IExecuteWithSignature("removeIdleHandler", "(Landroid/os/MessageQueue$IdleHandler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/MessageQueue.html#removeOnFileDescriptorEventListener(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        public void RemoveOnFileDescriptorEventListener(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("removeOnFileDescriptorEventListener", "(Ljava/io/FileDescriptor;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region IdleHandler
        public partial class IdleHandler
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
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.IdleHandler.html#queueIdle()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool QueueIdle()
            {
                return IExecuteWithSignature<bool>("queueIdle", "()Z");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnFileDescriptorEventListener
        public partial class OnFileDescriptorEventListener
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
            /// Handlers initializer for <see cref="OnFileDescriptorEventListener"/>
            /// </summary>
            protected virtual void InitializeHandlers()
            {
                AddEventHandler("onFileDescriptorEvents", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Io.FileDescriptor>>>(OnFileDescriptorEventsEventHandler));

            }

            /// <summary>
            /// Handler for <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <remarks>If <see cref="OnOnFileDescriptorEvents"/> has a value it takes precedence over corresponding class method</remarks>
            public System.Func<Java.Io.FileDescriptor, int, int> OnOnFileDescriptorEvents { get; set; } = null;

            void OnFileDescriptorEventsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Io.FileDescriptor>> data)
            {
                var methodToExecute = (OnOnFileDescriptorEvents != null) ? OnOnFileDescriptorEvents : OnFileDescriptorEvents;
                var executionResult = methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0));
                data.SetReturnValue(executionResult);
            }

            /// <summary>
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public virtual int OnFileDescriptorEvents(Java.Io.FileDescriptor arg0, int arg1)
            {
                return default;
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OnFileDescriptorEventListenerDirect
        public partial class OnFileDescriptorEventListenerDirect
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
            /// <see href="https://developer.android.com/reference/android/os/MessageQueue.OnFileDescriptorEventListener.html#onFileDescriptorEvents(java.io.FileDescriptor,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public override int OnFileDescriptorEvents(Java.Io.FileDescriptor arg0, int arg1)
            {
                return IExecute<int>("onFileDescriptorEvents", arg0, arg1);
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