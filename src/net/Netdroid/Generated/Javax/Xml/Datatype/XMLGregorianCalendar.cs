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

namespace Javax.Xml.Datatype
{
    #region XMLGregorianCalendar
    public partial class XMLGregorianCalendar
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
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getDay()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setDay(int)"/>
        /// </summary>
        public int Day
        {
            get { return IExecuteWithSignature<int>("getDay", "()I"); } set { IExecuteWithSignature("setDay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getEon()"/> 
        /// </summary>
        public Java.Math.BigInteger Eon
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getEon", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getEonAndYear()"/> 
        /// </summary>
        public Java.Math.BigInteger EonAndYear
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getEonAndYear", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getFractionalSecond()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setFractionalSecond(java.math.BigDecimal)"/>
        /// </summary>
        public Java.Math.BigDecimal FractionalSecond
        {
            get { return IExecuteWithSignature<Java.Math.BigDecimal>("getFractionalSecond", "()Ljava/math/BigDecimal;"); } set { IExecuteWithSignature("setFractionalSecond", "(Ljava/math/BigDecimal;)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getHour()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setHour(int)"/>
        /// </summary>
        public int Hour
        {
            get { return IExecuteWithSignature<int>("getHour", "()I"); } set { IExecuteWithSignature("setHour", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMillisecond()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMillisecond(int)"/>
        /// </summary>
        public int Millisecond
        {
            get { return IExecuteWithSignature<int>("getMillisecond", "()I"); } set { IExecuteWithSignature("setMillisecond", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMinute()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMinute(int)"/>
        /// </summary>
        public int Minute
        {
            get { return IExecuteWithSignature<int>("getMinute", "()I"); } set { IExecuteWithSignature("setMinute", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getMonth()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setMonth(int)"/>
        /// </summary>
        public int Month
        {
            get { return IExecuteWithSignature<int>("getMonth", "()I"); } set { IExecuteWithSignature("setMonth", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getSecond()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setSecond(int)"/>
        /// </summary>
        public int Second
        {
            get { return IExecuteWithSignature<int>("getSecond", "()I"); } set { IExecuteWithSignature("setSecond", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getTimezone()"/> <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTimezone(int)"/>
        /// </summary>
        public int Timezone
        {
            get { return IExecuteWithSignature<int>("getTimezone", "()I"); } set { IExecuteWithSignature("setTimezone", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getXMLSchemaType()"/> 
        /// </summary>
        public Javax.Xml.Namespace.QName XMLSchemaType
        {
            get { return IExecuteWithSignature<Javax.Xml.Namespace.QName>("getXMLSchemaType", "()Ljavax/xml/namespace/QName;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getYear()"/> 
        /// </summary>
        public int Year
        {
            get { return IExecuteWithSignature<int>("getYear", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#compare(javax.xml.datatype.XMLGregorianCalendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></param>
        /// <returns><see cref="int"/></returns>
        public int Compare(Javax.Xml.Datatype.XMLGregorianCalendar arg0)
        {
            return IExecuteWithSignature<int>("compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toXMLFormat()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToXMLFormat()
        {
            return IExecuteWithSignature<Java.Lang.String>("toXMLFormat", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toGregorianCalendar()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.GregorianCalendar"/></returns>
        public Java.Util.GregorianCalendar ToGregorianCalendar()
        {
            return IExecuteWithSignature<Java.Util.GregorianCalendar>("toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#toGregorianCalendar(java.util.TimeZone,java.util.Locale,javax.xml.datatype.XMLGregorianCalendar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.TimeZone"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></param>
        /// <returns><see cref="Java.Util.GregorianCalendar"/></returns>
        public Java.Util.GregorianCalendar ToGregorianCalendar(Java.Util.TimeZone arg0, Java.Util.Locale arg1, Javax.Xml.Datatype.XMLGregorianCalendar arg2)
        {
            return IExecute<Java.Util.GregorianCalendar>("toGregorianCalendar", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#getTimeZone(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.TimeZone"/></returns>
        public Java.Util.TimeZone GetTimeZone(int arg0)
        {
            return IExecuteWithSignature<Java.Util.TimeZone>("getTimeZone", "(I)Ljava/util/TimeZone;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#normalize()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Datatype.XMLGregorianCalendar"/></returns>
        public Javax.Xml.Datatype.XMLGregorianCalendar Normalize()
        {
            return IExecuteWithSignature<Javax.Xml.Datatype.XMLGregorianCalendar>("normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#add(javax.xml.datatype.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Datatype.Duration"/></param>
        public void Add(Javax.Xml.Datatype.Duration arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/xml/datatype/Duration;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecuteWithSignature("clear", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setYear(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetYear(int arg0)
        {
            IExecuteWithSignature("setYear", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setYear(java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        public void SetYear(Java.Math.BigInteger arg0)
        {
            IExecuteWithSignature("setYear", "(Ljava/math/BigInteger;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetTime(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int,java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigDecimal"/></param>
        public void SetTime(int arg0, int arg1, int arg2, Java.Math.BigDecimal arg3)
        {
            IExecute("setTime", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.xml/javax/xml/datatype/XMLGregorianCalendar.html#setTime(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetTime(int arg0, int arg1, int arg2)
        {
            IExecute("setTime", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}