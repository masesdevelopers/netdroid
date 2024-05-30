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

namespace Android.Net.Ipsec.Ike
{
    #region IkeIpv6AddrIdentification
    public partial class IkeIpv6AddrIdentification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeIpv6AddrIdentification.html#%3Cinit%3E(java.net.Inet6Address)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Inet6Address"/></param>
        public IkeIpv6AddrIdentification(Java.Net.Inet6Address arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/ipsec/ike/IkeIpv6AddrIdentification.html#ipv6Address"/>
        /// </summary>
        public Java.Net.Inet6Address ipv6Address { get { if (!_ipv6AddressReady) { _ipv6AddressContent = IGetField<Java.Net.Inet6Address>("ipv6Address"); _ipv6AddressReady = true; } return _ipv6AddressContent; } }
        private Java.Net.Inet6Address _ipv6AddressContent = default;
        private bool _ipv6AddressReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}