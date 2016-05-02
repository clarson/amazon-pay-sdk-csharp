﻿/*******************************************************************************
 *  Copyright 2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License");	
 *
 *  You may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at:
 *  http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License
 *  for the
 *  specific language governing permissions and limitations under the
 *  License.
 * *****************************************************************************	
 */

using System.Xml.Serialization;

namespace OffAmazonPaymentsNotifications
{
    public class SolutionProviderOptions
    {
        private SolutionProviderOption[] solutionProviderOptionsListField;

        /// <remarks/>
        [XmlElementAttribute(ElementName = "SolutionProviderOption", IsNullable = false)]
        public SolutionProviderOption[] SolutionProviderOption
        {
            get
            {
                return this.solutionProviderOptionsListField;
            }
            set
            {
                this.solutionProviderOptionsListField = value;
            }
        }

    }
}
