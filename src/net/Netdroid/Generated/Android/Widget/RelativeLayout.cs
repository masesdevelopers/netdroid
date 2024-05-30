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

namespace Android.Widget
{
    #region RelativeLayout
    public partial class RelativeLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public RelativeLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public RelativeLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
        public RelativeLayout(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#%3Cinit%3E(android.content.Context)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        public RelativeLayout(Android.Content.Context arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ABOVE"/>
        /// </summary>
        public static int ABOVE { get { if (!_ABOVEReady) { _ABOVEContent = SGetField<int>(LocalBridgeClazz, "ABOVE"); _ABOVEReady = true; } return _ABOVEContent; } }
        private static int _ABOVEContent = default;
        private static bool _ABOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_BASELINE"/>
        /// </summary>
        public static int ALIGN_BASELINE { get { if (!_ALIGN_BASELINEReady) { _ALIGN_BASELINEContent = SGetField<int>(LocalBridgeClazz, "ALIGN_BASELINE"); _ALIGN_BASELINEReady = true; } return _ALIGN_BASELINEContent; } }
        private static int _ALIGN_BASELINEContent = default;
        private static bool _ALIGN_BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_BOTTOM"/>
        /// </summary>
        public static int ALIGN_BOTTOM { get { if (!_ALIGN_BOTTOMReady) { _ALIGN_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "ALIGN_BOTTOM"); _ALIGN_BOTTOMReady = true; } return _ALIGN_BOTTOMContent; } }
        private static int _ALIGN_BOTTOMContent = default;
        private static bool _ALIGN_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_END"/>
        /// </summary>
        public static int ALIGN_END { get { if (!_ALIGN_ENDReady) { _ALIGN_ENDContent = SGetField<int>(LocalBridgeClazz, "ALIGN_END"); _ALIGN_ENDReady = true; } return _ALIGN_ENDContent; } }
        private static int _ALIGN_ENDContent = default;
        private static bool _ALIGN_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_LEFT"/>
        /// </summary>
        public static int ALIGN_LEFT { get { if (!_ALIGN_LEFTReady) { _ALIGN_LEFTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_LEFT"); _ALIGN_LEFTReady = true; } return _ALIGN_LEFTContent; } }
        private static int _ALIGN_LEFTContent = default;
        private static bool _ALIGN_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_BOTTOM"/>
        /// </summary>
        public static int ALIGN_PARENT_BOTTOM { get { if (!_ALIGN_PARENT_BOTTOMReady) { _ALIGN_PARENT_BOTTOMContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_BOTTOM"); _ALIGN_PARENT_BOTTOMReady = true; } return _ALIGN_PARENT_BOTTOMContent; } }
        private static int _ALIGN_PARENT_BOTTOMContent = default;
        private static bool _ALIGN_PARENT_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_END"/>
        /// </summary>
        public static int ALIGN_PARENT_END { get { if (!_ALIGN_PARENT_ENDReady) { _ALIGN_PARENT_ENDContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_END"); _ALIGN_PARENT_ENDReady = true; } return _ALIGN_PARENT_ENDContent; } }
        private static int _ALIGN_PARENT_ENDContent = default;
        private static bool _ALIGN_PARENT_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_LEFT"/>
        /// </summary>
        public static int ALIGN_PARENT_LEFT { get { if (!_ALIGN_PARENT_LEFTReady) { _ALIGN_PARENT_LEFTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_LEFT"); _ALIGN_PARENT_LEFTReady = true; } return _ALIGN_PARENT_LEFTContent; } }
        private static int _ALIGN_PARENT_LEFTContent = default;
        private static bool _ALIGN_PARENT_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_RIGHT"/>
        /// </summary>
        public static int ALIGN_PARENT_RIGHT { get { if (!_ALIGN_PARENT_RIGHTReady) { _ALIGN_PARENT_RIGHTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_RIGHT"); _ALIGN_PARENT_RIGHTReady = true; } return _ALIGN_PARENT_RIGHTContent; } }
        private static int _ALIGN_PARENT_RIGHTContent = default;
        private static bool _ALIGN_PARENT_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_START"/>
        /// </summary>
        public static int ALIGN_PARENT_START { get { if (!_ALIGN_PARENT_STARTReady) { _ALIGN_PARENT_STARTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_START"); _ALIGN_PARENT_STARTReady = true; } return _ALIGN_PARENT_STARTContent; } }
        private static int _ALIGN_PARENT_STARTContent = default;
        private static bool _ALIGN_PARENT_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_PARENT_TOP"/>
        /// </summary>
        public static int ALIGN_PARENT_TOP { get { if (!_ALIGN_PARENT_TOPReady) { _ALIGN_PARENT_TOPContent = SGetField<int>(LocalBridgeClazz, "ALIGN_PARENT_TOP"); _ALIGN_PARENT_TOPReady = true; } return _ALIGN_PARENT_TOPContent; } }
        private static int _ALIGN_PARENT_TOPContent = default;
        private static bool _ALIGN_PARENT_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_RIGHT"/>
        /// </summary>
        public static int ALIGN_RIGHT { get { if (!_ALIGN_RIGHTReady) { _ALIGN_RIGHTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_RIGHT"); _ALIGN_RIGHTReady = true; } return _ALIGN_RIGHTContent; } }
        private static int _ALIGN_RIGHTContent = default;
        private static bool _ALIGN_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_START"/>
        /// </summary>
        public static int ALIGN_START { get { if (!_ALIGN_STARTReady) { _ALIGN_STARTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_START"); _ALIGN_STARTReady = true; } return _ALIGN_STARTContent; } }
        private static int _ALIGN_STARTContent = default;
        private static bool _ALIGN_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#ALIGN_TOP"/>
        /// </summary>
        public static int ALIGN_TOP { get { if (!_ALIGN_TOPReady) { _ALIGN_TOPContent = SGetField<int>(LocalBridgeClazz, "ALIGN_TOP"); _ALIGN_TOPReady = true; } return _ALIGN_TOPContent; } }
        private static int _ALIGN_TOPContent = default;
        private static bool _ALIGN_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#BELOW"/>
        /// </summary>
        public static int BELOW { get { if (!_BELOWReady) { _BELOWContent = SGetField<int>(LocalBridgeClazz, "BELOW"); _BELOWReady = true; } return _BELOWContent; } }
        private static int _BELOWContent = default;
        private static bool _BELOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#CENTER_HORIZONTAL"/>
        /// </summary>
        public static int CENTER_HORIZONTAL { get { if (!_CENTER_HORIZONTALReady) { _CENTER_HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "CENTER_HORIZONTAL"); _CENTER_HORIZONTALReady = true; } return _CENTER_HORIZONTALContent; } }
        private static int _CENTER_HORIZONTALContent = default;
        private static bool _CENTER_HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#CENTER_IN_PARENT"/>
        /// </summary>
        public static int CENTER_IN_PARENT { get { if (!_CENTER_IN_PARENTReady) { _CENTER_IN_PARENTContent = SGetField<int>(LocalBridgeClazz, "CENTER_IN_PARENT"); _CENTER_IN_PARENTReady = true; } return _CENTER_IN_PARENTContent; } }
        private static int _CENTER_IN_PARENTContent = default;
        private static bool _CENTER_IN_PARENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#CENTER_VERTICAL"/>
        /// </summary>
        public static int CENTER_VERTICAL { get { if (!_CENTER_VERTICALReady) { _CENTER_VERTICALContent = SGetField<int>(LocalBridgeClazz, "CENTER_VERTICAL"); _CENTER_VERTICALReady = true; } return _CENTER_VERTICALContent; } }
        private static int _CENTER_VERTICALContent = default;
        private static bool _CENTER_VERTICALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#END_OF"/>
        /// </summary>
        public static int END_OF { get { if (!_END_OFReady) { _END_OFContent = SGetField<int>(LocalBridgeClazz, "END_OF"); _END_OFReady = true; } return _END_OFContent; } }
        private static int _END_OFContent = default;
        private static bool _END_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#LEFT_OF"/>
        /// </summary>
        public static int LEFT_OF { get { if (!_LEFT_OFReady) { _LEFT_OFContent = SGetField<int>(LocalBridgeClazz, "LEFT_OF"); _LEFT_OFReady = true; } return _LEFT_OFContent; } }
        private static int _LEFT_OFContent = default;
        private static bool _LEFT_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#RIGHT_OF"/>
        /// </summary>
        public static int RIGHT_OF { get { if (!_RIGHT_OFReady) { _RIGHT_OFContent = SGetField<int>(LocalBridgeClazz, "RIGHT_OF"); _RIGHT_OFReady = true; } return _RIGHT_OFContent; } }
        private static int _RIGHT_OFContent = default;
        private static bool _RIGHT_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#START_OF"/>
        /// </summary>
        public static int START_OF { get { if (!_START_OFReady) { _START_OFContent = SGetField<int>(LocalBridgeClazz, "START_OF"); _START_OFReady = true; } return _START_OFContent; } }
        private static int _START_OFContent = default;
        private static bool _START_OFReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#TRUE"/>
        /// </summary>
        public static int TRUE { get { if (!_TRUEReady) { _TRUEContent = SGetField<int>(LocalBridgeClazz, "TRUE"); _TRUEReady = true; } return _TRUEContent; } }
        private static int _TRUEContent = default;
        private static bool _TRUEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#getGravity()"/> <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#setGravity(int)"/>
        /// </summary>
        public int Gravity
        {
            get { return IExecuteWithSignature<int>("getGravity", "()I"); } set { IExecuteWithSignature("setGravity", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#getIgnoreGravity()"/> <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#setIgnoreGravity(int)"/>
        /// </summary>
        public int IgnoreGravity
        {
            get { return IExecuteWithSignature<int>("getIgnoreGravity", "()I"); } set { IExecuteWithSignature("setIgnoreGravity", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#setHorizontalGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHorizontalGravity(int arg0)
        {
            IExecuteWithSignature("setHorizontalGravity", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.html#setVerticalGravity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetVerticalGravity(int arg0)
        {
            IExecuteWithSignature("setVerticalGravity", "(I)V", arg0);
        }

        #endregion

        #region Nested classes
        #region LayoutParams
        public partial class LayoutParams
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#%3Cinit%3E(android.content.Context,android.util.AttributeSet)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Content.Context"/></param>
            /// <param name="arg1"><see cref="Android.Util.AttributeSet"/></param>
            public LayoutParams(Android.Content.Context arg0, Android.Util.AttributeSet arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.LayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#%3Cinit%3E(android.view.ViewGroup.MarginLayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.View.ViewGroup.MarginLayoutParams"/></param>
            public LayoutParams(Android.View.ViewGroup.MarginLayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#%3Cinit%3E(android.widget.RelativeLayout.LayoutParams)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Widget.RelativeLayout.LayoutParams"/></param>
            public LayoutParams(Android.Widget.RelativeLayout.LayoutParams arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#%3Cinit%3E(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public LayoutParams(int arg0, int arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#alignWithParent"/>
            /// </summary>
            public bool alignWithParent { get { return IGetField<bool>("alignWithParent"); } set { ISetField("alignWithParent", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#getRules()"/> 
            /// </summary>
            public int[] Rules
            {
                get { return IExecuteWithSignatureArray<int>("getRules", "()[I"); }
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#getRule(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="int"/></returns>
            public int GetRule(int arg0)
            {
                return IExecuteWithSignature<int>("getRule", "(I)I", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#debug(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Lang.String"/></returns>
            public Java.Lang.String Debug(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Java.Lang.String>("debug", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#addRule(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void AddRule(int arg0, int arg1)
            {
                IExecute("addRule", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#addRule(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void AddRule(int arg0)
            {
                IExecuteWithSignature("addRule", "(I)V", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/widget/RelativeLayout.LayoutParams.html#removeRule(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public void RemoveRule(int arg0)
            {
                IExecuteWithSignature("removeRule", "(I)V", arg0);
            }

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