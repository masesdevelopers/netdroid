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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region SortedMap declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/SortedMap.html"/>
    /// </summary>
    public partial class SortedMap : Java.Util.SequencedMap
    {
        const string _bridgeClassName = "java.util.SortedMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SortedMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SortedMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SortedMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SortedMap(params object[] args) : base(args) { }

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

    #region SortedMap<K, V> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/SortedMap.html"/>
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public partial class SortedMap<K, V> : Java.Util.SequencedMap<K, V>
    {
        const string _bridgeClassName = "java.util.SortedMap";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("SortedMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SortedMap() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("SortedMap class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public SortedMap(params object[] args) : base(args) { }

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

    #region SortedMap implementation
    public partial class SortedMap
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
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection Values()
        {
            return IExecuteWithSignature<Java.Util.Collection>("values", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#comparator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator Comparator()
        {
            return IExecuteWithSignature<Java.Util.Comparator>("comparator", "()Ljava/util/Comparator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#entrySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set EntrySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("entrySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#firstKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FirstKey()
        {
            return IExecuteWithSignature("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#lastKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object LastKey()
        {
            return IExecuteWithSignature("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#reversed()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.SequencedMap"/></returns>
        public Java.Util.SequencedMap Reversed()
        {
            return IExecuteWithSignature<Java.Util.SequencedMap>("reversed", "()Ljava/util/SequencedMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#putFirst(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutFirst(object arg0, object arg1)
        {
            return IExecuteWithSignature("putFirst", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#putLast(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutLast(object arg0, object arg1)
        {
            return IExecuteWithSignature("putLast", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISortedMap<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISortedMap<K, V> : Java.Util.ISequencedMap<K, V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SortedMap<K, V> implementation
    public partial class SortedMap<K, V> : Java.Util.ISortedMap<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.SortedMap{K, V}"/> to <see cref="Java.Util.SortedMap"/>
        /// </summary>
        public static implicit operator Java.Util.SortedMap(Java.Util.SortedMap<K, V> t) => t.Cast<Java.Util.SortedMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<V> Values()
        {
            return IExecuteWithSignature<Java.Util.Collection<V>>("values", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#comparator()"/>
        /// </summary>
        /// <typeparam name="ReturnobjectSuperK"><typeparamref name="K"/></typeparam>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator<ReturnobjectSuperK> Comparator<ReturnobjectSuperK>() where ReturnobjectSuperK : K
        {
            return IExecuteWithSignature<Java.Util.Comparator<ReturnobjectSuperK>>("comparator", "()Ljava/util/Comparator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#entrySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Map.Entry<K, V>> EntrySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Util.Map.Entry<K, V>>>("entrySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<K> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<K>>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> HeadMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> SubMap(K arg0, K arg1)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("subMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedMap;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> TailMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#firstKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K FirstKey()
        {
            return IExecuteWithSignature<K>("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#lastKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K LastKey()
        {
            return IExecuteWithSignature<K>("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#reversed()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.SequencedMap"/></returns>
        public Java.Util.SequencedMap Reversed()
        {
            return IExecuteWithSignature<Java.Util.SequencedMap>("reversed", "()Ljava/util/SequencedMap;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#putFirst(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V PutFirst(K arg0, V arg1)
        {
            return IExecuteWithSignature<V>("putFirst", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/SortedMap.html#putLast(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V PutLast(K arg0, V arg1)
        {
            return IExecuteWithSignature<V>("putLast", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}