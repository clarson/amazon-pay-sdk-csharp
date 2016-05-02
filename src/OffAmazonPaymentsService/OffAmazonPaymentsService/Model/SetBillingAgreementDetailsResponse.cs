﻿/******************************************************************************* 
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Off Amazon Payments Service CSharp Library
 *  API Version: 2013-01-01
 * 
 */


using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace OffAmazonPaymentsService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/OffAmazonPayments/2013-01-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/OffAmazonPayments/2013-01-01", IsNullable = false)]
    public class SetBillingAgreementDetailsResponse
    {

        private SetBillingAgreementDetailsResult setBillingAgreementDetailsResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the SetBillingAgreementDetailsResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SetBillingAgreementDetailsResult")]
        public SetBillingAgreementDetailsResult SetBillingAgreementDetailsResult
        {
            get { return this.setBillingAgreementDetailsResultField; }
            set { this.setBillingAgreementDetailsResultField = value; }
        }



        /// <summary>
        /// Sets the SetBillingAgreementDetailsResult property
        /// </summary>
        /// <param name="setBillingAgreementDetailsResult">SetBillingAgreementDetailsResult property</param>
        /// <returns>this instance</returns>
        public SetBillingAgreementDetailsResponse WithSetBillingAgreementDetailsResult(SetBillingAgreementDetailsResult setBillingAgreementDetailsResult)
        {
            this.setBillingAgreementDetailsResultField = setBillingAgreementDetailsResult;
            return this;
        }



        /// <summary>
        /// Checks if SetBillingAgreementDetailsResult property is set
        /// </summary>
        /// <returns>true if SetBillingAgreementDetailsResult property is set</returns>
        public Boolean IsSetSetBillingAgreementDetailsResult()
        {
            return this.setBillingAgreementDetailsResultField != null;
        }



        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }



        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property</param>
        /// <returns>this instance</returns>
        public SetBillingAgreementDetailsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }



        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public Boolean IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }





        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>

        public String ToXML()
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<SetBillingAgreementDetailsResponse xmlns=\"http://mws.amazonservices.com/schema/OffAmazonPayments/2013-01-01\">");
            if (IsSetSetBillingAgreementDetailsResult())
            {
                SetBillingAgreementDetailsResult setBillingAgreementDetailsResult = this.SetBillingAgreementDetailsResult;
                xml.Append("<SetBillingAgreementDetailsResult>");
                xml.Append(setBillingAgreementDetailsResult.ToXMLFragment());
                xml.Append("</SetBillingAgreementDetailsResult>");
            }
            if (IsSetResponseMetadata())
            {
                ResponseMetadata responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            }
            xml.Append("</SetBillingAgreementDetailsResponse>");
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str)
        {
            if (str == null)
                return "null";
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c)
                {
                    case '&':
                        sb.Append("&amp;");
                        break;
                    case '<':
                        sb.Append("&lt;");
                        break;
                    case '>':
                        sb.Append("&gt;");
                        break;
                    case '\'':
                        sb.Append("&#039;");
                        break;
                    case '"':
                        sb.Append("&quot;");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }



    }

}