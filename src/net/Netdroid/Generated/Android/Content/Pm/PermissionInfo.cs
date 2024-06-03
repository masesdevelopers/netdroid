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

namespace Android.Content.Pm
{
    #region PermissionInfo
    public partial class PermissionInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#%3Cinit%3E(android.content.pm.PermissionInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PermissionInfo"/></param>
        [global::System.Obsolete()]
        public PermissionInfo(Android.Content.Pm.PermissionInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Content.Pm.PermissionInfo"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Content.Pm.PermissionInfo t) => t.Cast<Android.Os.Parcelable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#descriptionRes"/>
        /// </summary>
        public int descriptionRes { get { return IGetField<int>("descriptionRes"); } set { ISetField("descriptionRes", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#flags"/>
        /// </summary>
        public int flags { get { return IGetField<int>("flags"); } set { ISetField("flags", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#protectionLevel"/>
        /// </summary>
        [global::System.Obsolete()]
        public int protectionLevel { get { return IGetField<int>("protectionLevel"); } set { ISetField("protectionLevel", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#nonLocalizedDescription"/>
        /// </summary>
        public Java.Lang.CharSequence nonLocalizedDescription { get { return IGetField<Java.Lang.CharSequence>("nonLocalizedDescription"); } set { ISetField("nonLocalizedDescription", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#group"/>
        /// </summary>
        public Java.Lang.String group { get { return IGetField<Java.Lang.String>("group"); } set { ISetField("group", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#FLAG_COSTS_MONEY"/>
        /// </summary>
        public static int FLAG_COSTS_MONEY { get { if (!_FLAG_COSTS_MONEYReady) { _FLAG_COSTS_MONEYContent = SGetField<int>(LocalBridgeClazz, "FLAG_COSTS_MONEY"); _FLAG_COSTS_MONEYReady = true; } return _FLAG_COSTS_MONEYContent; } }
        private static int _FLAG_COSTS_MONEYContent = default;
        private static bool _FLAG_COSTS_MONEYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#FLAG_HARD_RESTRICTED"/>
        /// </summary>
        public static int FLAG_HARD_RESTRICTED { get { if (!_FLAG_HARD_RESTRICTEDReady) { _FLAG_HARD_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_HARD_RESTRICTED"); _FLAG_HARD_RESTRICTEDReady = true; } return _FLAG_HARD_RESTRICTEDContent; } }
        private static int _FLAG_HARD_RESTRICTEDContent = default;
        private static bool _FLAG_HARD_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#FLAG_IMMUTABLY_RESTRICTED"/>
        /// </summary>
        public static int FLAG_IMMUTABLY_RESTRICTED { get { if (!_FLAG_IMMUTABLY_RESTRICTEDReady) { _FLAG_IMMUTABLY_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_IMMUTABLY_RESTRICTED"); _FLAG_IMMUTABLY_RESTRICTEDReady = true; } return _FLAG_IMMUTABLY_RESTRICTEDContent; } }
        private static int _FLAG_IMMUTABLY_RESTRICTEDContent = default;
        private static bool _FLAG_IMMUTABLY_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#FLAG_INSTALLED"/>
        /// </summary>
        public static int FLAG_INSTALLED { get { if (!_FLAG_INSTALLEDReady) { _FLAG_INSTALLEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_INSTALLED"); _FLAG_INSTALLEDReady = true; } return _FLAG_INSTALLEDContent; } }
        private static int _FLAG_INSTALLEDContent = default;
        private static bool _FLAG_INSTALLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#FLAG_SOFT_RESTRICTED"/>
        /// </summary>
        public static int FLAG_SOFT_RESTRICTED { get { if (!_FLAG_SOFT_RESTRICTEDReady) { _FLAG_SOFT_RESTRICTEDContent = SGetField<int>(LocalBridgeClazz, "FLAG_SOFT_RESTRICTED"); _FLAG_SOFT_RESTRICTEDReady = true; } return _FLAG_SOFT_RESTRICTEDContent; } }
        private static int _FLAG_SOFT_RESTRICTEDContent = default;
        private static bool _FLAG_SOFT_RESTRICTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_DANGEROUS"/>
        /// </summary>
        public static int PROTECTION_DANGEROUS { get { if (!_PROTECTION_DANGEROUSReady) { _PROTECTION_DANGEROUSContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_DANGEROUS"); _PROTECTION_DANGEROUSReady = true; } return _PROTECTION_DANGEROUSContent; } }
        private static int _PROTECTION_DANGEROUSContent = default;
        private static bool _PROTECTION_DANGEROUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_APPOP"/>
        /// </summary>
        public static int PROTECTION_FLAG_APPOP { get { if (!_PROTECTION_FLAG_APPOPReady) { _PROTECTION_FLAG_APPOPContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_APPOP"); _PROTECTION_FLAG_APPOPReady = true; } return _PROTECTION_FLAG_APPOPContent; } }
        private static int _PROTECTION_FLAG_APPOPContent = default;
        private static bool _PROTECTION_FLAG_APPOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_DEVELOPMENT"/>
        /// </summary>
        public static int PROTECTION_FLAG_DEVELOPMENT { get { if (!_PROTECTION_FLAG_DEVELOPMENTReady) { _PROTECTION_FLAG_DEVELOPMENTContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_DEVELOPMENT"); _PROTECTION_FLAG_DEVELOPMENTReady = true; } return _PROTECTION_FLAG_DEVELOPMENTContent; } }
        private static int _PROTECTION_FLAG_DEVELOPMENTContent = default;
        private static bool _PROTECTION_FLAG_DEVELOPMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_INSTALLER"/>
        /// </summary>
        public static int PROTECTION_FLAG_INSTALLER { get { if (!_PROTECTION_FLAG_INSTALLERReady) { _PROTECTION_FLAG_INSTALLERContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_INSTALLER"); _PROTECTION_FLAG_INSTALLERReady = true; } return _PROTECTION_FLAG_INSTALLERContent; } }
        private static int _PROTECTION_FLAG_INSTALLERContent = default;
        private static bool _PROTECTION_FLAG_INSTALLERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_INSTANT"/>
        /// </summary>
        public static int PROTECTION_FLAG_INSTANT { get { if (!_PROTECTION_FLAG_INSTANTReady) { _PROTECTION_FLAG_INSTANTContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_INSTANT"); _PROTECTION_FLAG_INSTANTReady = true; } return _PROTECTION_FLAG_INSTANTContent; } }
        private static int _PROTECTION_FLAG_INSTANTContent = default;
        private static bool _PROTECTION_FLAG_INSTANTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_PRE23"/>
        /// </summary>
        public static int PROTECTION_FLAG_PRE23 { get { if (!_PROTECTION_FLAG_PRE23Ready) { _PROTECTION_FLAG_PRE23Content = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_PRE23"); _PROTECTION_FLAG_PRE23Ready = true; } return _PROTECTION_FLAG_PRE23Content; } }
        private static int _PROTECTION_FLAG_PRE23Content = default;
        private static bool _PROTECTION_FLAG_PRE23Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_PREINSTALLED"/>
        /// </summary>
        public static int PROTECTION_FLAG_PREINSTALLED { get { if (!_PROTECTION_FLAG_PREINSTALLEDReady) { _PROTECTION_FLAG_PREINSTALLEDContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_PREINSTALLED"); _PROTECTION_FLAG_PREINSTALLEDReady = true; } return _PROTECTION_FLAG_PREINSTALLEDContent; } }
        private static int _PROTECTION_FLAG_PREINSTALLEDContent = default;
        private static bool _PROTECTION_FLAG_PREINSTALLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_PRIVILEGED"/>
        /// </summary>
        public static int PROTECTION_FLAG_PRIVILEGED { get { if (!_PROTECTION_FLAG_PRIVILEGEDReady) { _PROTECTION_FLAG_PRIVILEGEDContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_PRIVILEGED"); _PROTECTION_FLAG_PRIVILEGEDReady = true; } return _PROTECTION_FLAG_PRIVILEGEDContent; } }
        private static int _PROTECTION_FLAG_PRIVILEGEDContent = default;
        private static bool _PROTECTION_FLAG_PRIVILEGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_RUNTIME_ONLY"/>
        /// </summary>
        public static int PROTECTION_FLAG_RUNTIME_ONLY { get { if (!_PROTECTION_FLAG_RUNTIME_ONLYReady) { _PROTECTION_FLAG_RUNTIME_ONLYContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_RUNTIME_ONLY"); _PROTECTION_FLAG_RUNTIME_ONLYReady = true; } return _PROTECTION_FLAG_RUNTIME_ONLYContent; } }
        private static int _PROTECTION_FLAG_RUNTIME_ONLYContent = default;
        private static bool _PROTECTION_FLAG_RUNTIME_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_SETUP"/>
        /// </summary>
        public static int PROTECTION_FLAG_SETUP { get { if (!_PROTECTION_FLAG_SETUPReady) { _PROTECTION_FLAG_SETUPContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_SETUP"); _PROTECTION_FLAG_SETUPReady = true; } return _PROTECTION_FLAG_SETUPContent; } }
        private static int _PROTECTION_FLAG_SETUPContent = default;
        private static bool _PROTECTION_FLAG_SETUPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_SYSTEM"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PROTECTION_FLAG_SYSTEM { get { if (!_PROTECTION_FLAG_SYSTEMReady) { _PROTECTION_FLAG_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_SYSTEM"); _PROTECTION_FLAG_SYSTEMReady = true; } return _PROTECTION_FLAG_SYSTEMContent; } }
        private static int _PROTECTION_FLAG_SYSTEMContent = default;
        private static bool _PROTECTION_FLAG_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_FLAG_VERIFIER"/>
        /// </summary>
        public static int PROTECTION_FLAG_VERIFIER { get { if (!_PROTECTION_FLAG_VERIFIERReady) { _PROTECTION_FLAG_VERIFIERContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_FLAG_VERIFIER"); _PROTECTION_FLAG_VERIFIERReady = true; } return _PROTECTION_FLAG_VERIFIERContent; } }
        private static int _PROTECTION_FLAG_VERIFIERContent = default;
        private static bool _PROTECTION_FLAG_VERIFIERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_INTERNAL"/>
        /// </summary>
        public static int PROTECTION_INTERNAL { get { if (!_PROTECTION_INTERNALReady) { _PROTECTION_INTERNALContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_INTERNAL"); _PROTECTION_INTERNALReady = true; } return _PROTECTION_INTERNALContent; } }
        private static int _PROTECTION_INTERNALContent = default;
        private static bool _PROTECTION_INTERNALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_MASK_BASE"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PROTECTION_MASK_BASE { get { if (!_PROTECTION_MASK_BASEReady) { _PROTECTION_MASK_BASEContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_MASK_BASE"); _PROTECTION_MASK_BASEReady = true; } return _PROTECTION_MASK_BASEContent; } }
        private static int _PROTECTION_MASK_BASEContent = default;
        private static bool _PROTECTION_MASK_BASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_MASK_FLAGS"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PROTECTION_MASK_FLAGS { get { if (!_PROTECTION_MASK_FLAGSReady) { _PROTECTION_MASK_FLAGSContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_MASK_FLAGS"); _PROTECTION_MASK_FLAGSReady = true; } return _PROTECTION_MASK_FLAGSContent; } }
        private static int _PROTECTION_MASK_FLAGSContent = default;
        private static bool _PROTECTION_MASK_FLAGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_NORMAL"/>
        /// </summary>
        public static int PROTECTION_NORMAL { get { if (!_PROTECTION_NORMALReady) { _PROTECTION_NORMALContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_NORMAL"); _PROTECTION_NORMALReady = true; } return _PROTECTION_NORMALContent; } }
        private static int _PROTECTION_NORMALContent = default;
        private static bool _PROTECTION_NORMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_SIGNATURE"/>
        /// </summary>
        public static int PROTECTION_SIGNATURE { get { if (!_PROTECTION_SIGNATUREReady) { _PROTECTION_SIGNATUREContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_SIGNATURE"); _PROTECTION_SIGNATUREReady = true; } return _PROTECTION_SIGNATUREContent; } }
        private static int _PROTECTION_SIGNATUREContent = default;
        private static bool _PROTECTION_SIGNATUREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#PROTECTION_SIGNATURE_OR_SYSTEM"/>
        /// </summary>
        [global::System.Obsolete()]
        public static int PROTECTION_SIGNATURE_OR_SYSTEM { get { if (!_PROTECTION_SIGNATURE_OR_SYSTEMReady) { _PROTECTION_SIGNATURE_OR_SYSTEMContent = SGetField<int>(LocalBridgeClazz, "PROTECTION_SIGNATURE_OR_SYSTEM"); _PROTECTION_SIGNATURE_OR_SYSTEMReady = true; } return _PROTECTION_SIGNATURE_OR_SYSTEMContent; } }
        private static int _PROTECTION_SIGNATURE_OR_SYSTEMContent = default;
        private static bool _PROTECTION_SIGNATURE_OR_SYSTEMReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#getProtection()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProtection()
        {
            return IExecuteWithSignature<int>("getProtection", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#getProtectionFlags()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProtectionFlags()
        {
            return IExecuteWithSignature<int>("getProtectionFlags", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/content/pm/PermissionInfo.html#loadDescription(android.content.pm.PackageManager)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Pm.PackageManager"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        public Java.Lang.CharSequence LoadDescription(Android.Content.Pm.PackageManager arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}