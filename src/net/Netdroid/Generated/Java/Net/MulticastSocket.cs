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

namespace Java.Net
{
    #region MulticastSocket
    public partial class MulticastSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public MulticastSocket(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#%3Cinit%3E(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public MulticastSocket(Java.Net.SocketAddress arg0)
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
        /// <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#getNetworkInterface()"/> <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#setNetworkInterface(java.net.NetworkInterface)"/>
        /// </summary>
        public Java.Net.NetworkInterface NetworkInterface
        {
            get { return IExecuteWithSignature<Java.Net.NetworkInterface>("getNetworkInterface", "()Ljava/net/NetworkInterface;"); } set { IExecuteWithSignature("setNetworkInterface", "(Ljava/net/NetworkInterface;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#getTimeToLive()"/> <see href="https://developer.android.com/reference/java.base/java/net/MulticastSocket.html#setTimeToLive(int)"/>
        /// </summary>
        public int TimeToLive
        {
            get { return IExecuteWithSignature<int>("getTimeToLive", "()I"); } set { IExecuteWithSignature("setTimeToLive", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}