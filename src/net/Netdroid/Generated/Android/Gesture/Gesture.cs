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

namespace Android.Gesture
{
    #region Gesture
    public partial class Gesture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#getBoundingBox()"/> 
        /// </summary>
        public Android.Graphics.RectF BoundingBox
        {
            get { return IExecuteWithSignature<Android.Graphics.RectF>("getBoundingBox", "()Landroid/graphics/RectF;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#getID()"/> 
        /// </summary>
        public long ID
        {
            get { return IExecuteWithSignature<long>("getID", "()J"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#getLength()"/> 
        /// </summary>
        public float Length
        {
            get { return IExecuteWithSignature<float>("getLength", "()F"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#getStrokes()"/> 
        /// </summary>
        public Java.Util.ArrayList<Android.Gesture.GestureStroke> Strokes
        {
            get { return IExecuteWithSignature<Java.Util.ArrayList<Android.Gesture.GestureStroke>>("getStrokes", "()Ljava/util/ArrayList;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#getStrokesCount()"/> 
        /// </summary>
        public int StrokesCount
        {
            get { return IExecuteWithSignature<int>("getStrokesCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toBitmap(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap ToBitmap(int arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Android.Graphics.Bitmap>("toBitmap", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toBitmap(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Bitmap"/></returns>
        public Android.Graphics.Bitmap ToBitmap(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Android.Graphics.Bitmap>("toBitmap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toPath()"/>
        /// </summary>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path ToPath()
        {
            return IExecuteWithSignature<Android.Graphics.Path>("toPath", "()Landroid/graphics/Path;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toPath(android.graphics.Path,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path ToPath(Android.Graphics.Path arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Android.Graphics.Path>("toPath", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toPath(android.graphics.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Graphics.Path"/></param>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path ToPath(Android.Graphics.Path arg0)
        {
            return IExecuteWithSignature<Android.Graphics.Path>("toPath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#toPath(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Graphics.Path"/></returns>
        public Android.Graphics.Path ToPath(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Android.Graphics.Path>("toPath", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#addStroke(android.gesture.GestureStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Gesture.GestureStroke"/></param>
        public void AddStroke(Android.Gesture.GestureStroke arg0)
        {
            IExecuteWithSignature("addStroke", "(Landroid/gesture/GestureStroke;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/gesture/Gesture.html#writeToParcel(android.os.Parcel,int)"/>
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