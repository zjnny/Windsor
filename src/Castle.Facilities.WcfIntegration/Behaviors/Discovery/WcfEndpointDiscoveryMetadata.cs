﻿// Copyright 2004-2012 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


namespace Castle.Facilities.WcfIntegration
{
	using System;
	using System.Collections.Generic;
	using System.ServiceModel.Channels;
	using System.ServiceModel.Description;
	using System.ServiceModel.Dispatcher;
	using System.Xml.Linq;

	public class WcfEndpointDiscoveryMetadata : IEndpointBehavior, IWcfDiscoveryMetadata
	{
		public WcfEndpointDiscoveryMetadata()
		{
			Scopes = new HashSet<Uri>();
			Extensions = new List<XElement>();
		}

		public ICollection<Uri> Scopes { get; private set; }

		public ICollection<XElement> Extensions { get; private set; }

		#region Ignored Behavior Contract
 
		void IEndpointBehavior.AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		void IEndpointBehavior.ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
		}

		void IEndpointBehavior.ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
		}

		void IEndpointBehavior.Validate(ServiceEndpoint endpoint)
		{
		}

		#endregion
	}
}