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

namespace Android.Sax
{
    #region Element declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/sax/Element.html"/>
    /// </summary>
    public partial class Element : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Element>
    {
        const string _bridgeClassName = "android.sax.Element";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Element() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Element(params object[] args) : base(args) { }

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

    #region Element implementation
    public partial class Element
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
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#getChild(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Sax.Element"/></returns>
        public Android.Sax.Element GetChild(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Sax.Element>("getChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#getChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Sax.Element"/></returns>
        public Android.Sax.Element GetChild(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Sax.Element>("getChild", "(Ljava/lang/String;)Landroid/sax/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#requireChild(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Sax.Element"/></returns>
        public Android.Sax.Element RequireChild(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Android.Sax.Element>("requireChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#requireChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Sax.Element"/></returns>
        public Android.Sax.Element RequireChild(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Android.Sax.Element>("requireChild", "(Ljava/lang/String;)Landroid/sax/Element;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#setElementListener(android.sax.ElementListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Sax.ElementListener"/></param>
        public void SetElementListener(Android.Sax.ElementListener arg0)
        {
            IExecuteWithSignature("setElementListener", "(Landroid/sax/ElementListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#setEndElementListener(android.sax.EndElementListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Sax.EndElementListener"/></param>
        public void SetEndElementListener(Android.Sax.EndElementListener arg0)
        {
            IExecuteWithSignature("setEndElementListener", "(Landroid/sax/EndElementListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#setEndTextElementListener(android.sax.EndTextElementListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Sax.EndTextElementListener"/></param>
        public void SetEndTextElementListener(Android.Sax.EndTextElementListener arg0)
        {
            IExecuteWithSignature("setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#setStartElementListener(android.sax.StartElementListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Sax.StartElementListener"/></param>
        public void SetStartElementListener(Android.Sax.StartElementListener arg0)
        {
            IExecuteWithSignature("setStartElementListener", "(Landroid/sax/StartElementListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/sax/Element.html#setTextElementListener(android.sax.TextElementListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Sax.TextElementListener"/></param>
        public void SetTextElementListener(Android.Sax.TextElementListener arg0)
        {
            IExecuteWithSignature("setTextElementListener", "(Landroid/sax/TextElementListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}