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

namespace Android.Database
{
    #region CursorWrapper declaration
    /// <summary>
    /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html"/>
    /// </summary>
    public partial class CursorWrapper : Android.Database.Cursor
    {
        const string _bridgeClassName = "android.database.CursorWrapper";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CursorWrapper() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CursorWrapper(params object[] args) : base(args) { }
    
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

    #region CursorWrapper implementation
    public partial class CursorWrapper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#%3Cinit%3E(android.database.Cursor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Cursor"/></param>
        public CursorWrapper(Android.Database.Cursor arg0)
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
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getWrappedCursor()"/>
        /// </summary>
        /// <returns><see cref="Android.Database.Cursor"/></returns>
        public Android.Database.Cursor GetWrappedCursor()
        {
            return IExecuteWithSignature<Android.Database.Cursor>("getWrappedCursor", "()Landroid/database/Cursor;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getNotificationUri()"/>
        /// </summary>
        /// <returns><see cref="Android.Net.Uri"/></returns>
        public Android.Net.Uri GetNotificationUri()
        {
            return IExecuteWithSignature<Android.Net.Uri>("getNotificationUri", "()Landroid/net/Uri;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getExtras()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetExtras()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getExtras", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#respond(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle Respond(Android.Os.Bundle arg0)
        {
            return IExecuteWithSignature<Android.Os.Bundle>("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getWantsAllOnMoveCalls()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool GetWantsAllOnMoveCalls()
        {
            return IExecuteWithSignature<bool>("getWantsAllOnMoveCalls", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isAfterLast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAfterLast()
        {
            return IExecuteWithSignature<bool>("isAfterLast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isBeforeFirst()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBeforeFirst()
        {
            return IExecuteWithSignature<bool>("isBeforeFirst", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isClosed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecuteWithSignature<bool>("isClosed", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isFirst()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFirst()
        {
            return IExecuteWithSignature<bool>("isFirst", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isLast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLast()
        {
            return IExecuteWithSignature<bool>("isLast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#isNull(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNull(int arg0)
        {
            return IExecuteWithSignature<bool>("isNull", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#move(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Move(int arg0)
        {
            return IExecuteWithSignature<bool>("move", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#moveToFirst()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToFirst()
        {
            return IExecuteWithSignature<bool>("moveToFirst", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#moveToLast()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToLast()
        {
            return IExecuteWithSignature<bool>("moveToLast", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#moveToNext()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToNext()
        {
            return IExecuteWithSignature<bool>("moveToNext", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#moveToPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToPosition(int arg0)
        {
            return IExecuteWithSignature<bool>("moveToPosition", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#moveToPrevious()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToPrevious()
        {
            return IExecuteWithSignature<bool>("moveToPrevious", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#requery()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        [global::System.Obsolete()]
        public bool Requery()
        {
            return IExecuteWithSignature<bool>("requery", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getBlob(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] GetBlob(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("getBlob", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetDouble(int arg0)
        {
            return IExecuteWithSignature<double>("getDouble", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getFloat(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetFloat(int arg0)
        {
            return IExecuteWithSignature<float>("getFloat", "(I)F", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getColumnCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetColumnCount()
        {
            return IExecuteWithSignature<int>("getColumnCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getColumnIndex(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndex(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndex", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getColumnIndexOrThrow(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public int GetColumnIndexOrThrow(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getColumnIndexOrThrow", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetCount()
        {
            return IExecuteWithSignature<int>("getCount", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetInt(int arg0)
        {
            return IExecuteWithSignature<int>("getInt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getPosition()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetPosition()
        {
            return IExecuteWithSignature<int>("getPosition", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetType(int arg0)
        {
            return IExecuteWithSignature<int>("getType", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetColumnName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetString(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getString", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getColumnNames()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetColumnNames()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getColumnNames", "()[Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getNotificationUris()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Android.Net.Uri> GetNotificationUris()
        {
            return IExecuteWithSignature<Java.Util.List<Android.Net.Uri>>("getNotificationUris", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetLong(int arg0)
        {
            return IExecuteWithSignature<long>("getLong", "(I)J", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#getShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short GetShort(int arg0)
        {
            return IExecuteWithSignature<short>("getShort", "(I)S", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#copyStringToBuffer(int,android.database.CharArrayBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Android.Database.CharArrayBuffer"/></param>
        public void CopyStringToBuffer(int arg0, Android.Database.CharArrayBuffer arg1)
        {
            IExecuteWithSignature("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#deactivate()"/>
        /// </summary>
        [global::System.Obsolete()]
        public void Deactivate()
        {
            IExecuteWithSignature("deactivate", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#registerContentObserver(android.database.ContentObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.ContentObserver"/></param>
        public void RegisterContentObserver(Android.Database.ContentObserver arg0)
        {
            IExecuteWithSignature("registerContentObserver", "(Landroid/database/ContentObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#registerDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public void RegisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#setExtras(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetExtras(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setExtras", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#setNotificationUri(android.content.ContentResolver,android.net.Uri)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ContentResolver"/></param>
        /// <param name="arg1"><see cref="Android.Net.Uri"/></param>
        public void SetNotificationUri(Android.Content.ContentResolver arg0, Android.Net.Uri arg1)
        {
            IExecuteWithSignature("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#setNotificationUris(android.content.ContentResolver,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.ContentResolver"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public void SetNotificationUris(Android.Content.ContentResolver arg0, Java.Util.List<Android.Net.Uri> arg1)
        {
            IExecuteWithSignature("setNotificationUris", "(Landroid/content/ContentResolver;Ljava/util/List;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#unregisterContentObserver(android.database.ContentObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.ContentObserver"/></param>
        public void UnregisterContentObserver(Android.Database.ContentObserver arg0)
        {
            IExecuteWithSignature("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/CursorWrapper.html#unregisterDataSetObserver(android.database.DataSetObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.DataSetObserver"/></param>
        public void UnregisterDataSetObserver(Android.Database.DataSetObserver arg0)
        {
            IExecuteWithSignature("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", arg0);
        }
    
        #endregion
    
        #region Nested classes
    
        #endregion
    
        // TODO: complete the class
    }
    #endregion
}