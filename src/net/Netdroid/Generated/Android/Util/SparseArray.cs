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

namespace Android.Util
{
    #region SparseArray declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/SparseArray.html"/>
    /// </summary>
    public partial class SparseArray : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "android.util.SparseArray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SparseArray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SparseArray(params object[] args) : base(args) { }
    
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

    #region SparseArray<E> declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/util/SparseArray.html"/>
    /// </summary>
    /// <typeparam name="E"></typeparam>
    public partial class SparseArray<E> : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "android.util.SparseArray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SparseArray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SparseArray(params object[] args) : base(args) { }
    
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

    #region SparseArray implementation
    public partial class SparseArray
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public SparseArray(int arg0)
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
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray Clone()
        {
            return IExecuteWithSignature<Android.Util.SparseArray>("clone", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contains(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(int arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contentEquals(android.util.SparseArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.SparseArray"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContentEquals(Android.Util.SparseArray arg0)
        {
            return IExecuteWithSignature<bool>("contentEquals", "(Landroid/util/SparseArray;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#get(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int arg0, object arg1)
        {
            return IExecuteWithSignature("get", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(int arg0)
        {
            return IExecuteWithSignature("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ValueAt(int arg0)
        {
            return IExecuteWithSignature("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contentHashCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ContentHashCode()
        {
            return IExecuteWithSignature<int>("contentHashCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#indexOfKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfKey(int arg0)
        {
            return IExecuteWithSignature<int>("indexOfKey", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#indexOfValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfValue(object arg0)
        {
            return IExecuteWithSignature<int>("indexOfValue", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#keyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int KeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("keyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#append(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Append(int arg0, object arg1)
        {
            IExecuteWithSignature("append", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#delete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Delete(int arg0)
        {
            IExecuteWithSignature("delete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#put(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(int arg0, object arg1)
        {
            IExecuteWithSignature("put", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveAt(int arg0)
        {
            IExecuteWithSignature("removeAt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#removeAtRange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveAtRange(int arg0, int arg1)
        {
            IExecuteWithSignature("removeAtRange", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Set(int arg0, object arg1)
        {
            IExecuteWithSignature("set", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#setValueAt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetValueAt(int arg0, object arg1)
        {
            IExecuteWithSignature("setValueAt", "(ILjava/lang/Object;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion

    #region SparseArray<E> implementation
    public partial class SparseArray<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public SparseArray(int arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Util.SparseArray{E}"/> to <see cref="Android.Util.SparseArray"/>
        /// </summary>
        public static implicit operator Android.Util.SparseArray(Android.Util.SparseArray<E> t) => t.Cast<Android.Util.SparseArray>();
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Android.Util.SparseArray"/></returns>
        public Android.Util.SparseArray<E> Clone()
        {
            return IExecuteWithSignature<Android.Util.SparseArray<E>>("clone", "()Landroid/util/SparseArray;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contains(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(int arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contentEquals(android.util.SparseArray)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Util.SparseArray"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContentEquals(Android.Util.SparseArray<object> arg0)
        {
            return IExecuteWithSignature<bool>("contentEquals", "(Landroid/util/SparseArray;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#get(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(int arg0, E arg1)
        {
            return IExecuteWithSignature<E>("get", "(ILjava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E Get(int arg0)
        {
            return IExecuteWithSignature<E>("get", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#valueAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="E"/></returns>
        public E ValueAt(int arg0)
        {
            return IExecuteWithSignature<E>("valueAt", "(I)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#contentHashCode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ContentHashCode()
        {
            return IExecuteWithSignature<int>("contentHashCode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#indexOfKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfKey(int arg0)
        {
            return IExecuteWithSignature<int>("indexOfKey", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#indexOfValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfValue(E arg0)
        {
            return IExecuteWithSignature<int>("indexOfValue", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#keyAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int KeyAt(int arg0)
        {
            return IExecuteWithSignature<int>("keyAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#append(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Append(int arg0, E arg1)
        {
            IExecuteWithSignature("append", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#delete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Delete(int arg0)
        {
            IExecuteWithSignature("delete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#put(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Put(int arg0, E arg1)
        {
            IExecuteWithSignature("put", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#removeAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveAt(int arg0)
        {
            IExecuteWithSignature("removeAt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#removeAtRange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveAtRange(int arg0, int arg1)
        {
            IExecuteWithSignature("removeAtRange", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void Set(int arg0, E arg1)
        {
            IExecuteWithSignature("set", "(ILjava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/SparseArray.html#setValueAt(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        public void SetValueAt(int arg0, E arg1)
        {
            IExecuteWithSignature("setValueAt", "(ILjava/lang/Object;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}