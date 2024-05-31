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

namespace Java.Nio.File.Attribute
{
    #region IBasicFileAttributes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBasicFileAttributes
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BasicFileAttributes
    public partial class BasicFileAttributes : Java.Nio.File.Attribute.IBasicFileAttributes
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
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#isDirectory()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecuteWithSignature<bool>("isDirectory", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#isOther()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOther()
        {
            return IExecuteWithSignature<bool>("isOther", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#isRegularFile()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRegularFile()
        {
            return IExecuteWithSignature<bool>("isRegularFile", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#isSymbolicLink()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSymbolicLink()
        {
            return IExecuteWithSignature<bool>("isSymbolicLink", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#fileKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FileKey()
        {
            return IExecuteWithSignature("fileKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#creationTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime CreationTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("creationTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastAccessTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime LastAccessTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("lastAccessTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#lastModifiedTime()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public Java.Nio.File.Attribute.FileTime LastModifiedTime()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.FileTime>("lastModifiedTime", "()Ljava/nio/file/attribute/FileTime;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/nio/file/attribute/BasicFileAttributes.html#size()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}