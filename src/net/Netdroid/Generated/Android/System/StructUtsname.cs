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

namespace Android.System
{
    #region StructUtsname
    public partial class StructUtsname
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        public StructUtsname(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#machine"/>
        /// </summary>
        public Java.Lang.String machine { get { if (!_machineReady) { _machineContent = IGetField<Java.Lang.String>("machine"); _machineReady = true; } return _machineContent; } }
        private Java.Lang.String _machineContent = default;
        private bool _machineReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#nodename"/>
        /// </summary>
        public Java.Lang.String nodename { get { if (!_nodenameReady) { _nodenameContent = IGetField<Java.Lang.String>("nodename"); _nodenameReady = true; } return _nodenameContent; } }
        private Java.Lang.String _nodenameContent = default;
        private bool _nodenameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#release"/>
        /// </summary>
        public Java.Lang.String release { get { if (!_releaseReady) { _releaseContent = IGetField<Java.Lang.String>("release"); _releaseReady = true; } return _releaseContent; } }
        private Java.Lang.String _releaseContent = default;
        private bool _releaseReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#sysname"/>
        /// </summary>
        public Java.Lang.String sysname { get { if (!_sysnameReady) { _sysnameContent = IGetField<Java.Lang.String>("sysname"); _sysnameReady = true; } return _sysnameContent; } }
        private Java.Lang.String _sysnameContent = default;
        private bool _sysnameReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/system/StructUtsname.html#version"/>
        /// </summary>
        public Java.Lang.String version { get { if (!_versionReady) { _versionContent = IGetField<Java.Lang.String>("version"); _versionReady = true; } return _versionContent; } }
        private Java.Lang.String _versionContent = default;
        private bool _versionReady = false; // this is used because in case of generics 

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