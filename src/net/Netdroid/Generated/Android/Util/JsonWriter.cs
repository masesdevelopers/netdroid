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

namespace Android.Util
{
    #region JsonWriter
    public partial class JsonWriter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#%3Cinit%3E(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        public JsonWriter(Java.Io.Writer arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#beginArray()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter BeginArray()
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("beginArray", "()Landroid/util/JsonWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#beginObject()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter BeginObject()
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("beginObject", "()Landroid/util/JsonWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#endArray()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter EndArray()
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("endArray", "()Landroid/util/JsonWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#endObject()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter EndObject()
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("endObject", "()Landroid/util/JsonWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#name(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Name(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("name", "(Ljava/lang/String;)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#nullValue()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter NullValue()
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("nullValue", "()Landroid/util/JsonWriter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#value(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Value(bool arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("value", "(Z)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#value(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Value(double arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("value", "(D)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#value(java.lang.Number)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Number"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Value(Java.Lang.Number arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("value", "(Ljava/lang/Number;)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#value(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Value(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("value", "(Ljava/lang/String;)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#value(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Android.Util.JsonWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Android.Util.JsonWriter Value(long arg0)
        {
            return IExecuteWithSignature<Android.Util.JsonWriter>("value", "(J)Landroid/util/JsonWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#isLenient()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLenient()
        {
            return IExecuteWithSignature<bool>("isLenient", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#setIndent(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetIndent(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setIndent", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/JsonWriter.html#setLenient(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLenient(bool arg0)
        {
            IExecuteWithSignature("setLenient", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}