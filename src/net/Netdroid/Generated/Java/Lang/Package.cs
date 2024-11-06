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

namespace Java.Lang
{
    #region Package declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/lang/Package.html"/>
    /// </summary>
    public partial class Package : Java.Lang.Reflect.AnnotatedElement
    {
        const string _bridgeClassName = "java.lang.Package";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Package() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Package(params object[] args) : base(args) { }
    
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
    
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;
    
        // TODO: complete the class
    
    }
    #endregion

    #region Package implementation
    public partial class Package
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getPackage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Package"/></returns>
        [global::System.Obsolete()]
        public static Java.Lang.Package GetPackage(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.Package>(LocalBridgeClazz, "getPackage", "(Ljava/lang/String;)Ljava/lang/Package;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getPackages()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Package"/></returns>
        public static Java.Lang.Package[] GetPackages()
        {
            return SExecuteWithSignatureArray<Java.Lang.Package>(LocalBridgeClazz, "getPackages", "()[Ljava/lang/Package;");
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A GetAnnotation<A>(Java.Lang.Class arg0) where A : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignature<A>("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getDeclaredAnnotation(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A GetDeclaredAnnotation<A>(Java.Lang.Class arg0) where A : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignature<A>("getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A[] GetAnnotationsByType<A>(Java.Lang.Class arg0) where A : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignatureArray<A>("getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getDeclaredAnnotationsByType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="A"><see cref="Java.Lang.Annotation.IAnnotation"/></typeparam>
        /// <returns><typeparamref name="A"/></returns>
        public A[] GetDeclaredAnnotationsByType<A>(Java.Lang.Class arg0) where A : Java.Lang.Annotation.IAnnotation, new()
        {
            return IExecuteWithSignatureArray<A>("getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#isAnnotationPresent(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsAnnotationPresent(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isAnnotationPresent", "(Ljava/lang/Class;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#isCompatibleWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.NumberFormatException"/>
        public bool IsCompatibleWith(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isCompatibleWith", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#isSealed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSealed()
        {
            return IExecuteWithSignature<bool>("isSealed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#isSealed(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSealed(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<bool>("isSealed", "(Ljava/net/URL;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getDeclaredAnnotations()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Annotation.Annotation"/></returns>
        public Java.Lang.Annotation.Annotation[] GetDeclaredAnnotations()
        {
            return IExecuteWithSignatureArray<Java.Lang.Annotation.Annotation>("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getImplementationTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetImplementationTitle()
        {
            return IExecuteWithSignature<Java.Lang.String>("getImplementationTitle", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getImplementationVendor()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetImplementationVendor()
        {
            return IExecuteWithSignature<Java.Lang.String>("getImplementationVendor", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getImplementationVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetImplementationVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getImplementationVersion", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getSpecificationTitle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSpecificationTitle()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSpecificationTitle", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getSpecificationVendor()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSpecificationVendor()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSpecificationVendor", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/lang/Package.html#getSpecificationVersion()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetSpecificationVersion()
        {
            return IExecuteWithSignature<Java.Lang.String>("getSpecificationVersion", "()Ljava/lang/String;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}