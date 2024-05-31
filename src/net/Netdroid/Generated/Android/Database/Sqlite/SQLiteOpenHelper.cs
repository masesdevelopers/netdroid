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

namespace Android.Database.Sqlite
{
    #region SQLiteOpenHelper
    public partial class SQLiteOpenHelper
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#%3Cinit%3E(android.content.Context,java.lang.String,android.database.sqlite.SQLiteDatabase.CursorFactory,int,android.database.DatabaseErrorHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Database.Sqlite.SQLiteDatabase.CursorFactory"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Android.Database.DatabaseErrorHandler"/></param>
        public SQLiteOpenHelper(Android.Content.Context arg0, Java.Lang.String arg1, Android.Database.Sqlite.SQLiteDatabase.CursorFactory arg2, int arg3, Android.Database.DatabaseErrorHandler arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#%3Cinit%3E(android.content.Context,java.lang.String,android.database.sqlite.SQLiteDatabase.CursorFactory,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Android.Database.Sqlite.SQLiteDatabase.CursorFactory"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SQLiteOpenHelper(Android.Content.Context arg0, Java.Lang.String arg1, Android.Database.Sqlite.SQLiteDatabase.CursorFactory arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#%3Cinit%3E(android.content.Context,java.lang.String,int,android.database.sqlite.SQLiteDatabase.OpenParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Content.Context"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Android.Database.Sqlite.SQLiteDatabase.OpenParams"/></param>
        public SQLiteOpenHelper(Android.Content.Context arg0, Java.Lang.String arg1, int arg2, Android.Database.Sqlite.SQLiteDatabase.OpenParams arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#getDatabaseName()"/> 
        /// </summary>
        public Java.Lang.String DatabaseName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDatabaseName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#getReadableDatabase()"/> 
        /// </summary>
        public Android.Database.Sqlite.SQLiteDatabase ReadableDatabase
        {
            get { return IExecuteWithSignature<Android.Database.Sqlite.SQLiteDatabase>("getReadableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#getWritableDatabase()"/> 
        /// </summary>
        public Android.Database.Sqlite.SQLiteDatabase WritableDatabase
        {
            get { return IExecuteWithSignature<Android.Database.Sqlite.SQLiteDatabase>("getWritableDatabase", "()Landroid/database/sqlite/SQLiteDatabase;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#onCreate(android.database.sqlite.SQLiteDatabase)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        public void OnCreate(Android.Database.Sqlite.SQLiteDatabase arg0)
        {
            IExecuteWithSignature("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#onUpgrade(android.database.sqlite.SQLiteDatabase,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnUpgrade(Android.Database.Sqlite.SQLiteDatabase arg0, int arg1, int arg2)
        {
            IExecute("onUpgrade", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#onConfigure(android.database.sqlite.SQLiteDatabase)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        public void OnConfigure(Android.Database.Sqlite.SQLiteDatabase arg0)
        {
            IExecuteWithSignature("onConfigure", "(Landroid/database/sqlite/SQLiteDatabase;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#onDowngrade(android.database.sqlite.SQLiteDatabase,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void OnDowngrade(Android.Database.Sqlite.SQLiteDatabase arg0, int arg1, int arg2)
        {
            IExecute("onDowngrade", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#onOpen(android.database.sqlite.SQLiteDatabase)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase"/></param>
        public void OnOpen(Android.Database.Sqlite.SQLiteDatabase arg0)
        {
            IExecuteWithSignature("onOpen", "(Landroid/database/sqlite/SQLiteDatabase;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#setIdleConnectionTimeout(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        [System.Obsolete()]
        public void SetIdleConnectionTimeout(long arg0)
        {
            IExecuteWithSignature("setIdleConnectionTimeout", "(J)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#setLookasideConfig(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLookasideConfig(int arg0, int arg1)
        {
            IExecute("setLookasideConfig", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#setOpenParams(android.database.sqlite.SQLiteDatabase.OpenParams)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Database.Sqlite.SQLiteDatabase.OpenParams"/></param>
        public void SetOpenParams(Android.Database.Sqlite.SQLiteDatabase.OpenParams arg0)
        {
            IExecuteWithSignature("setOpenParams", "(Landroid/database/sqlite/SQLiteDatabase$OpenParams;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/database/sqlite/SQLiteOpenHelper.html#setWriteAheadLoggingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWriteAheadLoggingEnabled(bool arg0)
        {
            IExecuteWithSignature("setWriteAheadLoggingEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}