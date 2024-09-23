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

namespace Android.Util
{
    #region ArraySet declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/ArraySet.html"/>
    /// </summary>
    public partial class ArraySet : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ArraySet>
    {
        const string _bridgeClassName = "android.util.ArraySet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ArraySet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ArraySet(params object[] args) : base(args) { }

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

    #region ArraySet<E> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/ArraySet.html"/>
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public partial class ArraySet<E> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ArraySet<E>>
    {
        const string _bridgeClassName = "android.util.ArraySet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ArraySet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ArraySet(params object[] args) : base(args) { }

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

    #region ArraySet implementation
    public partial class ArraySet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        public ArraySet(Android.Util.ArraySet arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ArraySet(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ArraySet(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.ArraySet"/> to <see cref="Java.Util.Collection"/>
        /// </summary>
        public static implicit operator Java.Util.Collection(Android.Util.ArraySet t) => t.Cast<Java.Util.Collection>();
        /// <summary>
        /// Converter from <see cref="Android.Util.ArraySet"/> to <see cref="Java.Util.Set"/>
        /// </summary>
        public static implicit operator Java.Util.Set(Android.Util.ArraySet t) => t.Cast<Java.Util.Set>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteWithSignatureArray<object>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAll(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Android.Util.ArraySet arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Landroid/util/ArraySet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeIf(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveIf(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object RemoveAt(int arg0)
        {
            return IExecuteWithSignature("removeAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ValueAt(int arg0)
        {
            return IExecuteWithSignature("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#addAll(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        public void AddAll(Android.Util.ArraySet arg0)
        {
            IExecuteWithSignature("addAll", "(Landroid/util/ArraySet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#ensureCapacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnsureCapacity(int arg0)
        {
            IExecuteWithSignature("ensureCapacity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEach(Java.Util.Function.Consumer arg0)
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ArraySet<E> implementation
    public partial class ArraySet<E> : Java.Util.ICollection<E>, Java.Util.ISet<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        public ArraySet(Android.Util.ArraySet<E> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public ArraySet(E[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ArraySet(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ArraySet(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.ArraySet{E}"/> to <see cref="Java.Util.Collection{E}"/>
        /// </summary>
        public static implicit operator Java.Util.Collection<E>(Android.Util.ArraySet<E> t) => t.Cast<Java.Util.Collection<E>>();
        /// <summary>
        /// Converter from <see cref="Android.Util.ArraySet{E}"/> to <see cref="Java.Util.Set{E}"/>
        /// </summary>
        public static implicit operator Java.Util.Set<E>(Android.Util.ArraySet<E> t) => t.Cast<Java.Util.Set<E>>();
        /// <summary>
        /// Converter from <see cref="Android.Util.ArraySet{E}"/> to <see cref="Android.Util.ArraySet"/>
        /// </summary>
        public static implicit operator Android.Util.ArraySet(Android.Util.ArraySet<E> t) => t.Cast<Android.Util.ArraySet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] ToArray<T>(T[] arg0)
        {
            return IExecuteWithSignatureArray<T>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAll(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll<Arg0ExtendsE>(Android.Util.ArraySet<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            return IExecuteWithSignature<bool>("removeAll", "(Landroid/util/ArraySet;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeIf(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveIf<Arg0objectSuperE>(Java.Util.Function.Predicate<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            return IExecuteWithSignature<bool>("removeIf", "(Ljava/util/function/Predicate;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E RemoveAt(int arg0)
        {
            return IExecuteWithSignature<E>("removeAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E ValueAt(int arg0)
        {
            return IExecuteWithSignature<E>("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("indexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#addAll(android.util.ArraySet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.ArraySet"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        public void AddAll<Arg0ExtendsE>(Android.Util.ArraySet<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            IExecuteWithSignature("addAll", "(Landroid/util/ArraySet;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#ensureCapacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnsureCapacity(int arg0)
        {
            IExecuteWithSignature("ensureCapacity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/ArraySet.html#forEach(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        public void ForEach<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE : E
        {
            IExecuteWithSignature("forEach", "(Ljava/util/function/Consumer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}