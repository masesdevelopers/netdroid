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

namespace Java.Util.Regex
{
    #region Matcher declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html"/>
    /// </summary>
    public partial class Matcher : Java.Util.Regex.MatchResult
    {
        const string _bridgeClassName = "java.util.regex.Matcher";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Matcher() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Matcher(params object[] args) : base(args) { }
    
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

    #region Matcher implementation
    public partial class Matcher
    {
        #region Constructors
    
        #endregion
    
        #region Class/Interface conversion operators
    
        #endregion
    
        #region Fields
    
        #endregion
    
        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#quoteReplacement(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String QuoteReplacement(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
    
        #endregion
    
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#find()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Find()
        {
            return IExecuteWithSignature<bool>("find", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#find(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Find(int arg0)
        {
            return IExecuteWithSignature<bool>("find", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#hasAnchoringBounds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasAnchoringBounds()
        {
            return IExecuteWithSignature<bool>("hasAnchoringBounds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#hasTransparentBounds()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasTransparentBounds()
        {
            return IExecuteWithSignature<bool>("hasTransparentBounds", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#hitEnd()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HitEnd()
        {
            return IExecuteWithSignature<bool>("hitEnd", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#lookingAt()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool LookingAt()
        {
            return IExecuteWithSignature<bool>("lookingAt", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#matches()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Matches()
        {
            return IExecuteWithSignature<bool>("matches", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#requireEnd()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool RequireEnd()
        {
            return IExecuteWithSignature<bool>("requireEnd", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#end()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int End()
        {
            return IExecuteWithSignature<int>("end", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#end(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(int arg0)
        {
            return IExecuteWithSignature<int>("end", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#end(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int End(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("end", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#groupCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GroupCount()
        {
            return IExecuteWithSignature<int>("groupCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#regionEnd()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RegionEnd()
        {
            return IExecuteWithSignature<int>("regionEnd", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#regionStart()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int RegionStart()
        {
            return IExecuteWithSignature<int>("regionStart", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#start()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Start()
        {
            return IExecuteWithSignature<int>("start", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#start(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(int arg0)
        {
            return IExecuteWithSignature<int>("start", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#start(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int Start(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("start", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#group()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Group()
        {
            return IExecuteWithSignature<Java.Lang.String>("group", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#group(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Group(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("group", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#group(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Group(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("group", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#replaceAll(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceAll(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#replaceAll(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceAll(Java.Util.Function.Function<Java.Util.Regex.MatchResult, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("replaceAll", "(Ljava/util/function/Function;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#replaceFirst(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceFirst(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#replaceFirst(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ReplaceFirst(Java.Util.Function.Function<Java.Util.Regex.MatchResult, Java.Lang.String> arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("replaceFirst", "(Ljava/util/function/Function;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#appendTail(java.lang.StringBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuffer"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer AppendTail(Java.Lang.StringBuffer arg0)
        {
            return IExecuteWithSignature<Java.Lang.StringBuffer>("appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#appendTail(java.lang.StringBuilder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <returns><see cref="Java.Lang.StringBuilder"/></returns>
        public Java.Lang.StringBuilder AppendTail(Java.Lang.StringBuilder arg0)
        {
            return IExecuteWithSignature<Java.Lang.StringBuilder>("appendTail", "(Ljava/lang/StringBuilder;)Ljava/lang/StringBuilder;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuffer,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuffer arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#appendReplacement(java.lang.StringBuilder,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.StringBuilder"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher AppendReplacement(Java.Lang.StringBuilder arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("appendReplacement", "(Ljava/lang/StringBuilder;Ljava/lang/String;)Ljava/util/regex/Matcher;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#region(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Region(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("region", "(II)Ljava/util/regex/Matcher;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#reset()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Reset()
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("reset", "()Ljava/util/regex/Matcher;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#reset(java.lang.CharSequence)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher Reset(Java.Lang.CharSequence arg0)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#useAnchoringBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UseAnchoringBounds(bool arg0)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#usePattern(java.util.regex.Pattern)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Regex.Pattern"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UsePattern(Java.Util.Regex.Pattern arg0)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#useTransparentBounds(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Regex.Matcher"/></returns>
        public Java.Util.Regex.Matcher UseTransparentBounds(bool arg0)
        {
            return IExecuteWithSignature<Java.Util.Regex.Matcher>("useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#toMatchResult()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.MatchResult"/></returns>
        public Java.Util.Regex.MatchResult ToMatchResult()
        {
            return IExecuteWithSignature<Java.Util.Regex.MatchResult>("toMatchResult", "()Ljava/util/regex/MatchResult;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#pattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Regex.Pattern"/></returns>
        public Java.Util.Regex.Pattern Pattern()
        {
            return IExecuteWithSignature<Java.Util.Regex.Pattern>("pattern", "()Ljava/util/regex/Pattern;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/regex/Matcher.html#results()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Util.Regex.MatchResult> Results()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Util.Regex.MatchResult>>("results", "()Ljava/util/stream/Stream;");
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}