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

namespace Android.Net.Vcn
{
    #region VcnCellUnderlyingNetworkTemplate
    public partial class VcnCellUnderlyingNetworkTemplate
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
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getCbs()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCbs()
        {
            return IExecuteWithSignature<int>("getCbs", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getDun()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetDun()
        {
            return IExecuteWithSignature<int>("getDun", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getIms()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetIms()
        {
            return IExecuteWithSignature<int>("getIms", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getInternet()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetInternet()
        {
            return IExecuteWithSignature<int>("getInternet", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getMms()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMms()
        {
            return IExecuteWithSignature<int>("getMms", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getOpportunistic()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOpportunistic()
        {
            return IExecuteWithSignature<int>("getOpportunistic", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getRcs()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRcs()
        {
            return IExecuteWithSignature<int>("getRcs", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getRoaming()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRoaming()
        {
            return IExecuteWithSignature<int>("getRoaming", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getSimSpecificCarrierIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.Integer> GetSimSpecificCarrierIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.Integer>>("getSimSpecificCarrierIds", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.html#getOperatorPlmnIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Lang.String> GetOperatorPlmnIds()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Lang.String>>("getOperatorPlmnIds", "()Ljava/util/Set;");
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
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate Build()
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate>("build", "()Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setCbs(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetCbs(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setCbs", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setDun(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetDun(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setDun", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setIms(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetIms(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setIms", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setInternet(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetInternet(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setInternet", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setMetered(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetMetered(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setMetered", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setMinDownstreamBandwidthKbps(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetMinDownstreamBandwidthKbps(int arg0, int arg1)
            {
                return IExecute<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setMinDownstreamBandwidthKbps", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setMinUpstreamBandwidthKbps(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetMinUpstreamBandwidthKbps(int arg0, int arg1)
            {
                return IExecute<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setMinUpstreamBandwidthKbps", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setMms(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetMms(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setMms", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setOperatorPlmnIds(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetOperatorPlmnIds(Java.Util.Set<Java.Lang.String> arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setOperatorPlmnIds", "(Ljava/util/Set;)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setOpportunistic(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetOpportunistic(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setOpportunistic", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setRcs(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetRcs(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setRcs", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setRoaming(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetRoaming(int arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setRoaming", "(I)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/net/vcn/VcnCellUnderlyingNetworkTemplate.Builder.html#setSimSpecificCarrierIds(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder"/></returns>
            public Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder SetSimSpecificCarrierIds(Java.Util.Set<Java.Lang.Integer> arg0)
            {
                return IExecuteWithSignature<Android.Net.Vcn.VcnCellUnderlyingNetworkTemplate.Builder>("setSimSpecificCarrierIds", "(Ljava/util/Set;)Landroid/net/vcn/VcnCellUnderlyingNetworkTemplate$Builder;", arg0);
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