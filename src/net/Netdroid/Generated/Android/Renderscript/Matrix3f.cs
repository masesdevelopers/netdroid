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

namespace Android.Renderscript
{
    #region Matrix3f declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class Matrix3f : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Matrix3f>
    {
        const string _bridgeClassName = "android.renderscript.Matrix3f";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Matrix3f() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Matrix3f(params object[] args) : base(args) { }
    
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

    #region Matrix3f implementation
    public partial class Matrix3f
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#%3Cinit%3E(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        [global::System.Obsolete()]
        public Matrix3f(float[] arg0)
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
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#get(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public float Get(int arg0, int arg1)
        {
            return IExecuteWithSignature<float>("get", "(II)F", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#getArray()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        [global::System.Obsolete()]
        public float[] GetArray()
        {
            return IExecuteWithSignatureArray<float>("getArray", "()[F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#load(android.renderscript.Matrix3f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix3f"/></param>
        [global::System.Obsolete()]
        public void Load(Android.Renderscript.Matrix3f arg0)
        {
            IExecuteWithSignature("load", "(Landroid/renderscript/Matrix3f;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadIdentity()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void LoadIdentity()
        {
            IExecuteWithSignature("loadIdentity", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadMultiply(android.renderscript.Matrix3f,android.renderscript.Matrix3f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix3f"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Matrix3f"/></param>
        [global::System.Obsolete()]
        public void LoadMultiply(Android.Renderscript.Matrix3f arg0, Android.Renderscript.Matrix3f arg1)
        {
            IExecuteWithSignature("loadMultiply", "(Landroid/renderscript/Matrix3f;Landroid/renderscript/Matrix3f;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadRotate(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadRotate(float arg0, float arg1, float arg2, float arg3)
        {
            IExecuteWithSignature("loadRotate", "(FFFF)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadRotate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadRotate(float arg0)
        {
            IExecuteWithSignature("loadRotate", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadScale(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadScale(float arg0, float arg1, float arg2)
        {
            IExecuteWithSignature("loadScale", "(FFF)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadScale(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadScale(float arg0, float arg1)
        {
            IExecuteWithSignature("loadScale", "(FF)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#loadTranslate(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void LoadTranslate(float arg0, float arg1)
        {
            IExecuteWithSignature("loadTranslate", "(FF)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#multiply(android.renderscript.Matrix3f)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Matrix3f"/></param>
        [global::System.Obsolete()]
        public void Multiply(Android.Renderscript.Matrix3f arg0)
        {
            IExecuteWithSignature("multiply", "(Landroid/renderscript/Matrix3f;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#rotate(float,float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Rotate(float arg0, float arg1, float arg2, float arg3)
        {
            IExecuteWithSignature("rotate", "(FFFF)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#rotate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Rotate(float arg0)
        {
            IExecuteWithSignature("rotate", "(F)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#scale(float,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Scale(float arg0, float arg1, float arg2)
        {
            IExecuteWithSignature("scale", "(FFF)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#scale(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Scale(float arg0, float arg1)
        {
            IExecuteWithSignature("scale", "(FF)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#set(int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Set(int arg0, int arg1, float arg2)
        {
            IExecuteWithSignature("set", "(IIF)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#translate(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        [global::System.Obsolete()]
        public void Translate(float arg0, float arg1)
        {
            IExecuteWithSignature("translate", "(FF)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/Matrix3f.html#transpose()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Transpose()
        {
            IExecuteWithSignature("transpose", "()V");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}