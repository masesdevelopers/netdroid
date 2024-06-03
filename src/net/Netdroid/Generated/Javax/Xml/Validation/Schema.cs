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

namespace Javax.Xml.Validation
{
    #region Schema
    public partial class Schema
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
        /// <see href="https://developer.android.com/reference/javax/xml/validation/Schema.html#newValidator()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.Validator"/></returns>
        public Javax.Xml.Validation.Validator NewValidator()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.Validator>("newValidator", "()Ljavax/xml/validation/Validator;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/javax/xml/validation/Schema.html#newValidatorHandler()"/>
        /// </summary>
        /// <returns><see cref="Javax.Xml.Validation.ValidatorHandler"/></returns>
        public Javax.Xml.Validation.ValidatorHandler NewValidatorHandler()
        {
            return IExecuteWithSignature<Javax.Xml.Validation.ValidatorHandler>("newValidatorHandler", "()Ljavax/xml/validation/ValidatorHandler;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}