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

namespace Android.Adservices.Adselection
{
    #region AddAdSelectionOverrideRequest
    public partial class AddAdSelectionOverrideRequest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AddAdSelectionOverrideRequest.html#%3Cinit%3E(android.adservices.adselection.AdSelectionConfig,java.lang.String,android.adservices.common.AdSelectionSignals)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Adservices.Adselection.AdSelectionConfig"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Adservices.Common.AdSelectionSignals"/></param>
        public AddAdSelectionOverrideRequest(Android.Adservices.Adselection.AdSelectionConfig arg0, Java.Lang.String arg1, Android.Adservices.Common.AdSelectionSignals arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AddAdSelectionOverrideRequest.html#getAdSelectionConfig()"/> 
        /// </summary>
        public Android.Adservices.Adselection.AdSelectionConfig AdSelectionConfig
        {
            get { return IExecuteWithSignature<Android.Adservices.Adselection.AdSelectionConfig>("getAdSelectionConfig", "()Landroid/adservices/adselection/AdSelectionConfig;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AddAdSelectionOverrideRequest.html#getDecisionLogicJs()"/> 
        /// </summary>
        public Java.Lang.String DecisionLogicJs
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDecisionLogicJs", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/adservices/adselection/AddAdSelectionOverrideRequest.html#getTrustedScoringSignals()"/> 
        /// </summary>
        public Android.Adservices.Common.AdSelectionSignals TrustedScoringSignals
        {
            get { return IExecuteWithSignature<Android.Adservices.Common.AdSelectionSignals>("getTrustedScoringSignals", "()Landroid/adservices/common/AdSelectionSignals;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}