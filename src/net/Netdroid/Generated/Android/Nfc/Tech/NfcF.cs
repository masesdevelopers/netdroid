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

namespace Android.Nfc.Tech
{
    #region NfcF
    public partial class NfcF
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#get(android.nfc.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
        /// <returns><see cref="Android.Nfc.Tech.NfcF"/></returns>
        public static Android.Nfc.Tech.NfcF Get(Android.Nfc.Tag arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Tech.NfcF>(LocalBridgeClazz, "get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcF;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#getManufacturer()"/> 
        /// </summary>
        public byte[] Manufacturer
        {
            get { return IExecuteWithSignatureArray<byte>("getManufacturer", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#getMaxTransceiveLength()"/> 
        /// </summary>
        public int MaxTransceiveLength
        {
            get { return IExecuteWithSignature<int>("getMaxTransceiveLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#getSystemCode()"/> 
        /// </summary>
        public byte[] SystemCode
        {
            get { return IExecuteWithSignatureArray<byte>("getSystemCode", "()[B"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#getTag()"/> 
        /// </summary>
        public Android.Nfc.Tag Tag
        {
            get { return IExecuteWithSignature<Android.Nfc.Tag>("getTag", "()Landroid/nfc/Tag;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#getTimeout()"/> <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#setTimeout(int)"/>
        /// </summary>
        public int Timeout
        {
            get { return IExecuteWithSignature<int>("getTimeout", "()I"); } set { IExecuteWithSignature("setTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#transceive(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] Transceive(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("transceive", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/NfcF.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}