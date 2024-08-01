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

namespace Java.Util.Jar
{
    #region Manifest
    public partial class Manifest
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Manifest(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#%3Cinit%3E(java.util.jar.Manifest)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Jar.Manifest"/></param>
        public Manifest(Java.Util.Jar.Manifest arg0)
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
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#getAttributes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        public Java.Util.Jar.Attributes GetAttributes(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getAttributes", "(Ljava/lang/String;)Ljava/util/jar/Attributes;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#getMainAttributes()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Jar.Attributes"/></returns>
        public Java.Util.Jar.Attributes GetMainAttributes()
        {
            return IExecuteWithSignature<Java.Util.Jar.Attributes>("getMainAttributes", "()Ljava/util/jar/Attributes;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#getEntries()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.String, Java.Util.Jar.Attributes> GetEntries()
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.Jar.Attributes>>("getEntries", "()Ljava/util/Map;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#read(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Read(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("read", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/jar/Manifest.html#write(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("write", "(Ljava/io/OutputStream;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}