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

namespace Android.Mtp
{
    #region MtpObjectInfo declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html"/>
    /// </summary>
    public partial class MtpObjectInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<MtpObjectInfo>
    {
        const string _bridgeClassName = "android.mtp.MtpObjectInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MtpObjectInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MtpObjectInfo(params object[] args) : base(args) { }
    
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
        #region Builder declaration
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html"/>
        /// </summary>
        public partial class Builder : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Builder>
        {
            const string _bridgeClassName = "android.mtp.MtpObjectInfo$Builder";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Builder() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Builder(params object[] args) : base(args) { }
        
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

    #region MtpObjectInfo implementation
    public partial class MtpObjectInfo
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
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getAssociationDesc()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAssociationDesc()
        {
            return IExecuteWithSignature<int>("getAssociationDesc", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getAssociationType()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAssociationType()
        {
            return IExecuteWithSignature<int>("getAssociationType", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getCompressedSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCompressedSize()
        {
            return IExecuteWithSignature<int>("getCompressedSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getFormat()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetFormat()
        {
            return IExecuteWithSignature<int>("getFormat", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixDepth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImagePixDepth()
        {
            return IExecuteWithSignature<int>("getImagePixDepth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImagePixHeight()
        {
            return IExecuteWithSignature<int>("getImagePixHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetImagePixWidth()
        {
            return IExecuteWithSignature<int>("getImagePixWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getObjectHandle()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetObjectHandle()
        {
            return IExecuteWithSignature<int>("getObjectHandle", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getParent()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetParent()
        {
            return IExecuteWithSignature<int>("getParent", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getProtectionStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetProtectionStatus()
        {
            return IExecuteWithSignature<int>("getProtectionStatus", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getSequenceNumber()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetSequenceNumber()
        {
            return IExecuteWithSignature<int>("getSequenceNumber", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getStorageId()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStorageId()
        {
            return IExecuteWithSignature<int>("getStorageId", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbCompressedSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThumbCompressedSize()
        {
            return IExecuteWithSignature<int>("getThumbCompressedSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbFormat()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThumbFormat()
        {
            return IExecuteWithSignature<int>("getThumbFormat", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbPixHeight()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThumbPixHeight()
        {
            return IExecuteWithSignature<int>("getThumbPixHeight", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbPixWidth()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetThumbPixWidth()
        {
            return IExecuteWithSignature<int>("getThumbPixWidth", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getKeywords()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKeywords()
        {
            return IExecuteWithSignature<Java.Lang.String>("getKeywords", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getName()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName()
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getCompressedSizeLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetCompressedSizeLong()
        {
            return IExecuteWithSignature<long>("getCompressedSizeLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getDateCreated()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDateCreated()
        {
            return IExecuteWithSignature<long>("getDateCreated", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getDateModified()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetDateModified()
        {
            return IExecuteWithSignature<long>("getDateModified", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixDepthLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetImagePixDepthLong()
        {
            return IExecuteWithSignature<long>("getImagePixDepthLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixHeightLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetImagePixHeightLong()
        {
            return IExecuteWithSignature<long>("getImagePixHeightLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getImagePixWidthLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetImagePixWidthLong()
        {
            return IExecuteWithSignature<long>("getImagePixWidthLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getSequenceNumberLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetSequenceNumberLong()
        {
            return IExecuteWithSignature<long>("getSequenceNumberLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbCompressedSizeLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetThumbCompressedSizeLong()
        {
            return IExecuteWithSignature<long>("getThumbCompressedSizeLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbPixHeightLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetThumbPixHeightLong()
        {
            return IExecuteWithSignature<long>("getThumbPixHeightLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.html#getThumbPixWidthLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetThumbPixWidthLong()
        {
            return IExecuteWithSignature<long>("getThumbPixWidthLong", "()J");
        }
    
        #endregion
    
        #region Nested classes
        #region Builder implementation
        public partial class Builder
        {
            #region Constructors
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#%3Cinit%3E(android.mtp.MtpObjectInfo)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Android.Mtp.MtpObjectInfo"/></param>
            public Builder(Android.Mtp.MtpObjectInfo arg0)
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
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo"/></returns>
            public Android.Mtp.MtpObjectInfo Build()
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo>("build", "()Landroid/mtp/MtpObjectInfo;");
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setAssociationDesc(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetAssociationDesc(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setAssociationDesc", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setAssociationType(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetAssociationType(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setAssociationType", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setCompressedSize(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetCompressedSize(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setCompressedSize", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setDateCreated(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetDateCreated(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setDateCreated", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setDateModified(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetDateModified(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setDateModified", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setFormat(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetFormat(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setFormat", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setImagePixDepth(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetImagePixDepth(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setImagePixDepth", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setImagePixHeight(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetImagePixHeight(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setImagePixHeight", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setImagePixWidth(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetImagePixWidth(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setImagePixWidth", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setKeywords(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetKeywords(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setKeywords", "(Ljava/lang/String;)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setName(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetName(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setName", "(Ljava/lang/String;)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setObjectHandle(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetObjectHandle(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setObjectHandle", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setParent(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetParent(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setParent", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setProtectionStatus(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetProtectionStatus(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setProtectionStatus", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setSequenceNumber(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetSequenceNumber(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setSequenceNumber", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setStorageId(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetStorageId(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setStorageId", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setThumbCompressedSize(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetThumbCompressedSize(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setThumbCompressedSize", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setThumbFormat(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetThumbFormat(int arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setThumbFormat", "(I)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setThumbPixHeight(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetThumbPixHeight(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setThumbPixHeight", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://developer.android.com/reference/android/mtp/MtpObjectInfo.Builder.html#setThumbPixWidth(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="Android.Mtp.MtpObjectInfo.Builder"/></returns>
            public Android.Mtp.MtpObjectInfo.Builder SetThumbPixWidth(long arg0)
            {
                return IExecuteWithSignature<Android.Mtp.MtpObjectInfo.Builder>("setThumbPixWidth", "(J)Landroid/mtp/MtpObjectInfo$Builder;", arg0);
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