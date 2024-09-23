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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Util
{
    #region EventLog declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/EventLog.html"/>
    /// </summary>
    public partial class EventLog : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EventLog>
    {
        const string _bridgeClassName = "android.util.EventLog";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public EventLog() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public EventLog(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Event declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html"/>
        /// </summary>
        public partial class Event : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Event>
        {
            const string _bridgeClassName = "android.util.EventLog$Event";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Event() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Event(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region EventLog implementation
    public partial class EventLog
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#getTagCode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetTagCode(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getTagCode", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#getTagName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetTagName(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getTagName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#writeEvent(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int WriteEvent(int arg0, float arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#writeEvent(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int WriteEvent(int arg0, int arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#writeEvent(int,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int WriteEvent(int arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0); else return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#writeEvent(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public static int WriteEvent(int arg0, Java.Lang.String arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#writeEvent(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public static int WriteEvent(int arg0, long arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "writeEvent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/EventLog.html#readEvents(int[],java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void ReadEvents(int[] arg0, Java.Util.Collection<Android.Util.EventLog.Event> arg1)
        {
            SExecute(LocalBridgeClazz, "readEvents", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Event implementation
        public partial class Event
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
            /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html#getProcessId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetProcessId()
            {
                return IExecuteWithSignature<int>("getProcessId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html#getTag()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetTag()
            {
                return IExecuteWithSignature<int>("getTag", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html#getThreadId()"/>
            /// </summary>
            /// <returns><see cref="int"/></returns>
            public int GetThreadId()
            {
                return IExecuteWithSignature<int>("getThreadId", "()I");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html#getTimeNanos()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long GetTimeNanos()
            {
                return IExecuteWithSignature<long>("getTimeNanos", "()J");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/util/EventLog.Event.html#getData()"/>
            /// </summary>
            /// <returns><see cref="object"/></returns>
            public object GetData()
            {
                return IExecuteWithSignature("getData", "()Ljava/lang/Object;");
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