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

namespace Java.Util
{
    #region AbstractCollection
    public partial class AbstractCollection
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
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteWithSignatureArray<object>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractCollection<E>
    public partial class AbstractCollection<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractCollection{E}"/> to <see cref="Java.Util.AbstractCollection"/>
        /// </summary>
        public static implicit operator Java.Util.AbstractCollection(Java.Util.AbstractCollection<E> t) => t.Cast<Java.Util.AbstractCollection>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] ToArray<T>(T[] arg0)
        {
            return IExecuteWithSignatureArray<T>("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#iterator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<E>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecuteWithSignature<bool>("add", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE: E
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("containsAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecuteWithSignature<bool>("remove", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("removeAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection<object> arg0)
        {
            return IExecuteWithSignature<bool>("retainAll", "(Ljava/util/Collection;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#toArray()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteWithSignatureArray<object>("toArray", "()[Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/util/AbstractCollection.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}