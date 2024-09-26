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

namespace Android.Media.Tv
{
    #region TvContentRating declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html"/>
    /// </summary>
    public partial class TvContentRating : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TvContentRating>
    {
        const string _bridgeClassName = "android.media.tv.TvContentRating";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TvContentRating() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TvContentRating(params object[] args) : base(args) { }

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

    #region TvContentRating implementation
    public partial class TvContentRating
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#UNRATED"/>
        /// </summary>
        public static Android.Media.Tv.TvContentRating UNRATED { get { if (!_UNRATEDReady) { _UNRATEDContent = SGetField<Android.Media.Tv.TvContentRating>(LocalBridgeClazz, "UNRATED"); _UNRATEDReady = true; } return _UNRATEDContent; } }
        private static Android.Media.Tv.TvContentRating _UNRATEDContent = default;
        private static bool _UNRATEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#createRating(java.lang.String,java.lang.String,java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Media.Tv.TvContentRating"/></returns>
        public static Android.Media.Tv.TvContentRating CreateRating(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, params Java.Lang.String[] arg3)
        {
            if (arg3.Length == 0) return SExecuteWithSignature<Android.Media.Tv.TvContentRating>(LocalBridgeClazz, "createRating", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Landroid/media/tv/TvContentRating;", arg0, arg1, arg2); else return SExecuteWithSignature<Android.Media.Tv.TvContentRating>(LocalBridgeClazz, "createRating", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Landroid/media/tv/TvContentRating;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#unflattenFromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Media.Tv.TvContentRating"/></returns>
        public static Android.Media.Tv.TvContentRating UnflattenFromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Media.Tv.TvContentRating>(LocalBridgeClazz, "unflattenFromString", "(Ljava/lang/String;)Landroid/media/tv/TvContentRating;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#contains(android.media.tv.TvContentRating)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Media.Tv.TvContentRating"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Android.Media.Tv.TvContentRating arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Landroid/media/tv/TvContentRating;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#flattenToString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FlattenToString()
        {
            return IExecuteWithSignature<Java.Lang.String>("flattenToString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#getDomain()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDomain()
        {
            return IExecuteWithSignature<Java.Lang.String>("getDomain", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#getMainRating()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetMainRating()
        {
            return IExecuteWithSignature<Java.Lang.String>("getMainRating", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#getRatingSystem()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRatingSystem()
        {
            return IExecuteWithSignature<Java.Lang.String>("getRatingSystem", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/tv/TvContentRating.html#getSubRatings()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Java.Lang.String> GetSubRatings()
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getSubRatings", "()Ljava/util/List;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}