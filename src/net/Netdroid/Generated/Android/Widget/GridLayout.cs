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

namespace Android.Widget
{
    #region GridLayout declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html"/>
    /// </summary>
    public partial class GridLayout : Android.View.ViewGroup
    {
        const string _bridgeClassName = "android.widget.GridLayout";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public GridLayout() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public GridLayout(params object[] args) : base(args) { }
    
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
        #region Alignment declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.Alignment.html"/>
        /// </summary>
        public partial class Alignment : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Alignment>
        {
            const string _bridgeClassName = "android.widget.GridLayout$Alignment";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("Alignment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Alignment() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("Alignment class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public Alignment(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region LayoutParams declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html"/>
        /// </summary>
        public partial class LayoutParams : Android.View.ViewGroup.MarginLayoutParams
        {
            const string _bridgeClassName = "android.widget.GridLayout$LayoutParams";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public LayoutParams() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public LayoutParams(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

        #region Spec declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.Spec.html"/>
        /// </summary>
        public partial class Spec : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Spec>
        {
            const string _bridgeClassName = "android.widget.GridLayout$Spec";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Spec() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Spec(params object[] args) : base(args) { }
        
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
            public override bool IsBridgeStatic => true;
        
            // TODO: complete the class
        
        }
        #endregion

    
    }
    #endregion

    #region GridLayout implementation
    public partial class GridLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public GridLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public GridLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public GridLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public GridLayout(Android.Content.Context arg0)
            : base(arg0)
        {
        }
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#BASELINE"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment BASELINE { get { if (!_BASELINEReady) { _BASELINEContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "BASELINE"); _BASELINEReady = true; } return _BASELINEContent; } }
        private static Android.Widget.GridLayout.Alignment _BASELINEContent = default;
        private static bool _BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#BOTTOM"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment BOTTOM { get { if (!_BOTTOMReady) { _BOTTOMContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "BOTTOM"); _BOTTOMReady = true; } return _BOTTOMContent; } }
        private static Android.Widget.GridLayout.Alignment _BOTTOMContent = default;
        private static bool _BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#CENTER"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static Android.Widget.GridLayout.Alignment _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#END"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment END { get { if (!_ENDReady) { _ENDContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "END"); _ENDReady = true; } return _ENDContent; } }
        private static Android.Widget.GridLayout.Alignment _ENDContent = default;
        private static bool _ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#FILL"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment FILL { get { if (!_FILLReady) { _FILLContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "FILL"); _FILLReady = true; } return _FILLContent; } }
        private static Android.Widget.GridLayout.Alignment _FILLContent = default;
        private static bool _FILLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#LEFT"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static Android.Widget.GridLayout.Alignment _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#RIGHT"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static Android.Widget.GridLayout.Alignment _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#START"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment START { get { if (!_STARTReady) { _STARTContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "START"); _STARTReady = true; } return _STARTContent; } }
        private static Android.Widget.GridLayout.Alignment _STARTContent = default;
        private static bool _STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#TOP"/>
        /// </summary>
        public static Android.Widget.GridLayout.Alignment TOP { get { if (!_TOPReady) { _TOPContent = SGetField<Android.Widget.GridLayout.Alignment>(LocalBridgeClazz, "TOP"); _TOPReady = true; } return _TOPContent; } }
        private static Android.Widget.GridLayout.Alignment _TOPContent = default;
        private static bool _TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#ALIGN_BOUNDS"/>
        /// </summary>
        public static int ALIGN_BOUNDS { get { if (!_ALIGN_BOUNDSReady) { _ALIGN_BOUNDSContent = SGetField<int>(LocalBridgeClazz, "ALIGN_BOUNDS"); _ALIGN_BOUNDSReady = true; } return _ALIGN_BOUNDSContent; } }
        private static int _ALIGN_BOUNDSContent = default;
        private static bool _ALIGN_BOUNDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#ALIGN_MARGINS"/>
        /// </summary>
        public static int ALIGN_MARGINS { get { if (!_ALIGN_MARGINSReady) { _ALIGN_MARGINSContent = SGetField<int>(LocalBridgeClazz, "ALIGN_MARGINS"); _ALIGN_MARGINSReady = true; } return _ALIGN_MARGINSContent; } }
        private static int _ALIGN_MARGINSContent = default;
        private static bool _ALIGN_MARGINSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#UNDEFINED"/>
        /// </summary>
        public static int UNDEFINED { get { if (!_UNDEFINEDReady) { _UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "UNDEFINED"); _UNDEFINEDReady = true; } return _UNDEFINEDContent; } }
        private static int _UNDEFINEDContent = default;
        private static bool _UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,android.widget.GridLayout.Alignment,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.GridLayout.Alignment"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, Android.Widget.GridLayout.Alignment arg1, float arg2)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(ILandroid/widget/GridLayout$Alignment;F)Landroid/widget/GridLayout$Spec;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,android.widget.GridLayout.Alignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Widget.GridLayout.Alignment"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, Android.Widget.GridLayout.Alignment arg1)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(ILandroid/widget/GridLayout$Alignment;)Landroid/widget/GridLayout$Spec;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, float arg1)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(IF)Landroid/widget/GridLayout$Spec;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,int,android.widget.GridLayout.Alignment,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Widget.GridLayout.Alignment"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, int arg1, Android.Widget.GridLayout.Alignment arg2, float arg3)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(IILandroid/widget/GridLayout$Alignment;F)Landroid/widget/GridLayout$Spec;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,int,android.widget.GridLayout.Alignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Android.Widget.GridLayout.Alignment"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, int arg1, Android.Widget.GridLayout.Alignment arg2)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(IILandroid/widget/GridLayout$Alignment;)Landroid/widget/GridLayout$Spec;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, int arg1, float arg2)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(IIF)Landroid/widget/GridLayout$Spec;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0, int arg1)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(II)Landroid/widget/GridLayout$Spec;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#spec(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Android.Widget.GridLayout.Spec"/></returns>
        public static Android.Widget.GridLayout.Spec SpecMethod(int arg0)
        {
            return SExecuteWithSignature<Android.Widget.GridLayout.Spec>(LocalBridgeClazz, "spec", "(I)Landroid/widget/GridLayout$Spec;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#getUseDefaultMargins()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetUseDefaultMargins()
        {
            return IExecuteWithSignature<bool>("getUseDefaultMargins", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#isColumnOrderPreserved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsColumnOrderPreserved()
        {
            return IExecuteWithSignature<bool>("isColumnOrderPreserved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#isRowOrderPreserved()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRowOrderPreserved()
        {
            return IExecuteWithSignature<bool>("isRowOrderPreserved", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#getAlignmentMode()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAlignmentMode()
        {
            return IExecuteWithSignature<int>("getAlignmentMode", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#getColumnCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColumnCount()
        {
            return IExecuteWithSignature<int>("getColumnCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#getOrientation()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetOrientation()
        {
            return IExecuteWithSignature<int>("getOrientation", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#getRowCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetRowCount()
        {
            return IExecuteWithSignature<int>("getRowCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setAlignmentMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetAlignmentMode(int arg0)
        {
            IExecuteWithSignature("setAlignmentMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setColumnCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColumnCount(int arg0)
        {
            IExecuteWithSignature("setColumnCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setColumnOrderPreserved(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetColumnOrderPreserved(bool arg0)
        {
            IExecuteWithSignature("setColumnOrderPreserved", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setOrientation(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetOrientation(int arg0)
        {
            IExecuteWithSignature("setOrientation", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setRowCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRowCount(int arg0)
        {
            IExecuteWithSignature("setRowCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setRowOrderPreserved(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRowOrderPreserved(bool arg0)
        {
            IExecuteWithSignature("setRowOrderPreserved", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/GridLayout.html#setUseDefaultMargins(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUseDefaultMargins(bool arg0)
        {
            IExecuteWithSignature("setUseDefaultMargins", "(Z)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
        #region Alignment implementation
        public partial class Alignment
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region LayoutParams implementation
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.MarginLayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.MarginLayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.MarginLayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#%3Cinit%3E(android.widget.GridLayout.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.GridLayout.LayoutParams"/></param>
            public LayoutParams(Android.Widget.GridLayout.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#%3Cinit%3E(android.widget.GridLayout.Spec,android.widget.GridLayout.Spec)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.GridLayout.Spec"/></param>
            /// <param name="arg1"><see cref="Android.Widget.GridLayout.Spec"/></param>
            public LayoutParams(Android.Widget.GridLayout.Spec arg0, Android.Widget.GridLayout.Spec arg1)
                : base(arg0, arg1)
            {
            }
        
            #endregion
        
            #region Class/Interface conversion operators
        
            #endregion
        
            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#columnSpec"/>
            /// </summary>
            public Android.Widget.GridLayout.Spec columnSpec { get { return IGetField<Android.Widget.GridLayout.Spec>("columnSpec"); } set { ISetField("columnSpec", value); } }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#rowSpec"/>
            /// </summary>
            public Android.Widget.GridLayout.Spec rowSpec { get { return IGetField<Android.Widget.GridLayout.Spec>("rowSpec"); } set { ISetField("rowSpec", value); } }
        
            #endregion
        
            #region Static methods
        
            #endregion
        
            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/GridLayout.LayoutParams.html#setGravity(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void SetGravity(int arg0)
            {
                IExecuteWithSignature("setGravity", "(I)V", arg0);
            }
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

        #region Spec implementation
        public partial class Spec
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
        
            #endregion
        
            #region Nested classes
        
            #endregion
        
            // TODO: complete the class
        }
        #endregion

    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}