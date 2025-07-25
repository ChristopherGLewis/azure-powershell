// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>A list of DigitalTwinsInstance Endpoints with a next link.</summary>
    public partial class DigitalTwinsEndpointResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of DigitalTwinsInstance Endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource> _value;

        /// <summary>A list of DigitalTwinsInstance Endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DigitalTwinsEndpointResourceListResult" /> instance.</summary>
        public DigitalTwinsEndpointResourceListResult()
        {

        }
    }
    /// A list of DigitalTwinsInstance Endpoints with a next link.
    public partial interface IDigitalTwinsEndpointResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of DigitalTwinsInstance Endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link used to get the next page of DigitalTwinsInstance Endpoints.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A list of DigitalTwinsInstance Endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of DigitalTwinsInstance Endpoints.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource> Value { get; set; }

    }
    /// A list of DigitalTwinsInstance Endpoints with a next link.
    internal partial interface IDigitalTwinsEndpointResourceListResultInternal

    {
        /// <summary>The link used to get the next page of DigitalTwinsInstance Endpoints.</summary>
        string NextLink { get; set; }
        /// <summary>A list of DigitalTwinsInstance Endpoints.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsEndpointResource> Value { get; set; }

    }
}