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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Hardware
{
    #region GeomagneticField
    public partial class GeomagneticField
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#%3Cinit%3E(float,float,float,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        public GeomagneticField(float arg0, float arg1, float arg2, long arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getDeclination()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetDeclination()
        {
            return IExecuteWithSignature<float>("getDeclination", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getFieldStrength()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetFieldStrength()
        {
            return IExecuteWithSignature<float>("getFieldStrength", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getHorizontalStrength()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetHorizontalStrength()
        {
            return IExecuteWithSignature<float>("getHorizontalStrength", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getInclination()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetInclination()
        {
            return IExecuteWithSignature<float>("getInclination", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetX()
        {
            return IExecuteWithSignature<float>("getX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetY()
        {
            return IExecuteWithSignature<float>("getY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/hardware/GeomagneticField.html#getZ()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float GetZ()
        {
            return IExecuteWithSignature<float>("getZ", "()F");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}