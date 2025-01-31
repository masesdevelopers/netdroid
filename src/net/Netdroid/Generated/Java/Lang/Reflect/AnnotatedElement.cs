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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region AnnotatedElement declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html"/>
    /// </summary>
    public partial class AnnotatedElement : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AnnotatedElement>
    {
        const string _bridgeClassName = "java.lang.reflect.AnnotatedElement";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AnnotatedElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AnnotatedElement() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AnnotatedElement class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AnnotatedElement(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region IAnnotatedElement
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAnnotatedElement
    {
        #region Instance methods
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region AnnotatedElement implementation
    public partial class AnnotatedElement : Java.Lang.Reflect.IAnnotatedElement
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
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignature<T>("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getDeclaredAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetDeclaredAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T GetDeclaredAnnotation<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignature<T>("getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetAnnotationsByType<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignatureArray<T>("getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetDeclaredAnnotationsByType<T>(Java.Lang.Class arg0) where T : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignatureArray<T>("getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/reflect/AnnotatedElement.html#isAnnotationPresent(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnnotationPresent(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}