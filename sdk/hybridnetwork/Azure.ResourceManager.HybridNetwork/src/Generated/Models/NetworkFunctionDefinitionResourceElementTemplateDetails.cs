// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The network function definition resource element template details. </summary>
    public partial class NetworkFunctionDefinitionResourceElementTemplateDetails : ResourceElementTemplate
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionResourceElementTemplateDetails. </summary>
        public NetworkFunctionDefinitionResourceElementTemplateDetails()
        {
            ResourceElementType = Type.NetworkFunctionDefinition;
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionResourceElementTemplateDetails. </summary>
        /// <param name="name"> Name of the resource element template. </param>
        /// <param name="resourceElementType"> The resource element template type. </param>
        /// <param name="dependsOnProfile"> The depends on profile. </param>
        /// <param name="configuration"> The resource element template type. </param>
        internal NetworkFunctionDefinitionResourceElementTemplateDetails(string name, Type resourceElementType, DependsOnProfile dependsOnProfile, ArmResourceDefinitionResourceElementTemplate configuration) : base(name, resourceElementType, dependsOnProfile)
        {
            Configuration = configuration;
            ResourceElementType = resourceElementType;
        }

        /// <summary> The resource element template type. </summary>
        public ArmResourceDefinitionResourceElementTemplate Configuration { get; set; }
    }
}
