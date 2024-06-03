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

namespace Java.Lang.Reflect
{
    #region Executable
    public partial class Executable : Java.Lang.Reflect.IMember, Java.Lang.Reflect.IGenericDeclaration
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.Member"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.Member(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.Member>();
        /// <summary>
        /// Converter from <see cref="Java.Lang.Reflect.Executable"/> to <see cref="Java.Lang.Reflect.GenericDeclaration"/>
        /// </summary>
        public static implicit operator Java.Lang.Reflect.GenericDeclaration(Java.Lang.Reflect.Executable t) => t.Cast<Java.Lang.Reflect.GenericDeclaration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getModifiers()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetModifiers()
        {
            return IExecuteWithSignature<int>("getModifiers", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getParameterAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetParameterAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getDeclaringClass()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetDeclaringClass()
        {
            return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getExceptionTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class[] GetExceptionTypes()
        {
            return IExecuteWithSignatureArray<Java.Lang.Class>("getExceptionTypes", "()[Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getParameterTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class[] GetParameterTypes()
        {
            return IExecuteWithSignatureArray<Java.Lang.Class>("getParameterTypes", "()[Ljava/lang/Class;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getTypeParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.TypeVariable"/></returns>
        public Java.Lang.Reflect.TypeVariable[] GetTypeParameters()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.TypeVariable>("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#toGenericString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToGenericString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toGenericString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#isSynthetic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecuteWithSignature<bool>("isSynthetic", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#isVarArgs()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVarArgs()
        {
            return IExecuteWithSignature<bool>("isVarArgs", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getParameterCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParameterCount()
        {
            return IExecute<int>("getParameterCount");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getParameters()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Parameter"/></returns>
        public Java.Lang.Reflect.Parameter[] GetParameters()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.Parameter>("getParameters", "()[Ljava/lang/reflect/Parameter;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getGenericExceptionTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type[] GetGenericExceptionTypes()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/Executable.html#getGenericParameterTypes()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Reflect.Type"/></returns>
        public Java.Lang.Reflect.Type[] GetGenericParameterTypes()
        {
            return IExecuteWithSignatureArray<Java.Lang.Reflect.Type>("getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}