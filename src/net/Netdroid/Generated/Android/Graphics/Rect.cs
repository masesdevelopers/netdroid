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

namespace Android.Graphics
{
    #region Rect
    public partial class Rect
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#%3Cinit%3E(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public Rect(Android.Graphics.Rect arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public Rect(int arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#bottom"/>
        /// </summary>
        public int bottom { get { return IGetField<int>("bottom"); } set { ISetField("bottom", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#left"/>
        /// </summary>
        public int left { get { return IGetField<int>("left"); } set { ISetField("left", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#right"/>
        /// </summary>
        public int right { get { return IGetField<int>("right"); } set { ISetField("right", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#top"/>
        /// </summary>
        public int top { get { return IGetField<int>("top"); } set { ISetField("top", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#unflattenFromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Android.Graphics.Rect"/></returns>
        public static Android.Graphics.Rect UnflattenFromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Android.Graphics.Rect>(LocalBridgeClazz, "unflattenFromString", "(Ljava/lang/String;)Landroid/graphics/Rect;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#intersects(android.graphics.Rect,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool Intersects(Android.Graphics.Rect arg0, Android.Graphics.Rect arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "intersects", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#contains(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Landroid/graphics/Rect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#contains(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#contains(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(int arg0, int arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#intersect(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersect(Android.Graphics.Rect arg0)
        {
            return IExecuteWithSignature<bool>("intersect", "(Landroid/graphics/Rect;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#intersect(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersect(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<bool>("intersect", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#intersects(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#setIntersect(android.graphics.Rect,android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        /// <param name="arg1"><see cref="Android.Graphics.Rect"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetIntersect(Android.Graphics.Rect arg0, Android.Graphics.Rect arg1)
        {
            return IExecute<bool>("setIntersect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#exactCenterX()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float ExactCenterX()
        {
            return IExecuteWithSignature<float>("exactCenterX", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#exactCenterY()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        public float ExactCenterY()
        {
            return IExecuteWithSignature<float>("exactCenterY", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#centerX()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CenterX()
        {
            return IExecuteWithSignature<int>("centerX", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#centerY()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int CenterY()
        {
            return IExecuteWithSignature<int>("centerY", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#height()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Height()
        {
            return IExecuteWithSignature<int>("height", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#width()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Width()
        {
            return IExecuteWithSignature<int>("width", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#flattenToString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String FlattenToString()
        {
            return IExecuteWithSignature<Java.Lang.String>("flattenToString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#toShortString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToShortString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toShortString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#inset(android.graphics.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Insets"/></param>
        public void Inset(Android.Graphics.Insets arg0)
        {
            IExecuteWithSignature("inset", "(Landroid/graphics/Insets;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#inset(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Inset(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("inset", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#inset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Inset(int arg0, int arg1)
        {
            IExecute("inset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#offset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Offset(int arg0, int arg1)
        {
            IExecute("offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#offsetTo(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void OffsetTo(int arg0, int arg1)
        {
            IExecute("offsetTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#readFromParcel(android.os.Parcel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        public void ReadFromParcel(Android.Os.Parcel arg0)
        {
            IExecuteWithSignature("readFromParcel", "(Landroid/os/Parcel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#set(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void Set(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("set", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#set(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Set(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("set", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#setEmpty()"/>
        /// </summary>
        public void SetEmpty()
        {
            IExecuteWithSignature("setEmpty", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#sort()"/>
        /// </summary>
        public void Sort()
        {
            IExecuteWithSignature("sort", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#union(android.graphics.Rect)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Rect"/></param>
        public void Union(Android.Graphics.Rect arg0)
        {
            IExecuteWithSignature("union", "(Landroid/graphics/Rect;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#union(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Union(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("union", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#union(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Union(int arg0, int arg1)
        {
            IExecute("union", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/graphics/Rect.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}