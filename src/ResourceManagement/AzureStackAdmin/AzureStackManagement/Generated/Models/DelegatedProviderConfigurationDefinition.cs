// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Delegated Provider Configuration Definition.
    /// </summary>
    public partial class DelegatedProviderConfigurationDefinition
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. The display name for the reseller.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _externalReferenceId;
        
        /// <summary>
        /// Optional. The external reference Id for the reseller.
        /// </summary>
        public string ExternalReferenceId
        {
            get { return this._externalReferenceId; }
            set { this._externalReferenceId = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the reseller configuration definition.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private ResourceProviderEndpoint _pricingEndpoint;
        
        /// <summary>
        /// Optional. The pricing endpoint.
        /// </summary>
        public ResourceProviderEndpoint PricingEndpoint
        {
            get { return this._pricingEndpoint; }
            set { this._pricingEndpoint = value; }
        }
        
        private string _providerIdentifier;
        
        /// <summary>
        /// Optional. The provider identifier which uniquely identifies a
        /// delegated provider.
        /// </summary>
        public string ProviderIdentifier
        {
            get { return this._providerIdentifier; }
            set { this._providerIdentifier = value; }
        }
        
        private ResourceProviderEndpoint _subscriptionApprovalEndpoint;
        
        /// <summary>
        /// Optional. The approval endpoint.
        /// </summary>
        public ResourceProviderEndpoint SubscriptionApprovalEndpoint
        {
            get { return this._subscriptionApprovalEndpoint; }
            set { this._subscriptionApprovalEndpoint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DelegatedProviderConfigurationDefinition class.
        /// </summary>
        public DelegatedProviderConfigurationDefinition()
        {
        }
    }
}