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
    #region ScriptIntrinsicBlend declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html"/>
    /// </summary>
    [global::System.Obsolete()]
    public partial class ScriptIntrinsicBlend : Android.Renderscript.ScriptIntrinsic
    {
        const string _bridgeClassName = "android.renderscript.ScriptIntrinsicBlend";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScriptIntrinsicBlend() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ScriptIntrinsicBlend(params object[] args) : base(args) { }
    
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

    #region ScriptIntrinsicBlend implementation
    public partial class ScriptIntrinsicBlend
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#create(android.renderscript.RenderScript,android.renderscript.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.RenderScript"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Element"/></param>
        /// <returns><see cref="Android.Renderscript.ScriptIntrinsicBlend"/></returns>
        [global::System.Obsolete()]
        public static Android.Renderscript.ScriptIntrinsicBlend Create(Android.Renderscript.RenderScript arg0, Android.Renderscript.Element arg1)
        {
            return SExecuteWithSignature<Android.Renderscript.ScriptIntrinsicBlend>(LocalBridgeClazz, "create", "(Landroid/renderscript/RenderScript;Landroid/renderscript/Element;)Landroid/renderscript/ScriptIntrinsicBlend;", arg0, arg1);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDAdd()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDAdd()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDAdd", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDClear()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDClear()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDClear", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDDst()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDDst()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDDst", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDDstAtop()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDDstAtop()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDDstAtop", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDDstIn()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDDstIn()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDDstIn", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDDstOut()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDDstOut()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDDstOut", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDDstOver()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDDstOver()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDDstOver", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDMultiply()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDMultiply()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDMultiply", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSrc()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSrc()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSrc", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSrcAtop()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSrcAtop()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSrcAtop", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSrcIn()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSrcIn()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSrcIn", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSrcOut()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSrcOut()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSrcOut", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSrcOver()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSrcOver()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSrcOver", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDSubtract()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDSubtract()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDSubtract", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#getKernelIDXor()"/>
        /// </summary>
        /// <returns><see cref="Android.Renderscript.Script.KernelID"/></returns>
        [global::System.Obsolete()]
        public Android.Renderscript.Script.KernelID GetKernelIDXor()
        {
            return IExecuteWithSignature<Android.Renderscript.Script.KernelID>("getKernelIDXor", "()Landroid/renderscript/Script$KernelID;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachAdd(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachAdd(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachAdd", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachAdd(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachAdd(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachAdd", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachClear(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachClear(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachClear", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachClear(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachClear(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachClear", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDst(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachDst(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachDst", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDst(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachDst(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachDst", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstAtop(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachDstAtop(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachDstAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstAtop(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachDstAtop(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachDstAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstIn(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachDstIn(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachDstIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstIn(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachDstIn(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachDstIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstOut(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachDstOut(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachDstOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstOut(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachDstOut(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachDstOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstOver(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachDstOver(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachDstOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachDstOver(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachDstOver(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachDstOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachMultiply(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachMultiply(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachMultiply", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachMultiply(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachMultiply(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachMultiply", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrc(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSrc(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSrc", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrc(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSrc(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSrc", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcAtop(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcAtop(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSrcAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcAtop(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcAtop(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSrcAtop", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcIn(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcIn(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSrcIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcIn(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcIn(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSrcIn", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcOut(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcOut(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSrcOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcOut(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcOut(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSrcOut", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcOver(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcOver(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSrcOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSrcOver(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSrcOver(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSrcOver", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSubtract(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachSubtract(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachSubtract", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachSubtract(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachSubtract(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachSubtract", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachXor(android.renderscript.Allocation,android.renderscript.Allocation,android.renderscript.Script.LaunchOptions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg2"><see cref="Android.Renderscript.Script.LaunchOptions"/></param>
        [global::System.Obsolete()]
        public void ForEachXor(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1, Android.Renderscript.Script.LaunchOptions arg2)
        {
            IExecuteWithSignature("forEachXor", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;Landroid/renderscript/Script$LaunchOptions;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/renderscript/ScriptIntrinsicBlend.html#forEachXor(android.renderscript.Allocation,android.renderscript.Allocation)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Renderscript.Allocation"/></param>
        /// <param name="arg1"><see cref="Android.Renderscript.Allocation"/></param>
        [global::System.Obsolete()]
        public void ForEachXor(Android.Renderscript.Allocation arg0, Android.Renderscript.Allocation arg1)
        {
            IExecuteWithSignature("forEachXor", "(Landroid/renderscript/Allocation;Landroid/renderscript/Allocation;)V", arg0, arg1);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}