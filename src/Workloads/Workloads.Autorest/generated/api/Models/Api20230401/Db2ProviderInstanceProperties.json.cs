// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Gets or sets the DB2 provider properties.</summary>
    public partial class Db2ProviderInstanceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject into a new instance of <see cref="Db2ProviderInstanceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Db2ProviderInstanceProperties(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __providerSpecificProperties = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ProviderSpecificProperties(json);
            {_hostname = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("hostname"), out var __jsonHostname) ? (string)__jsonHostname : (string)Hostname;}
            {_dbName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("dbName"), out var __jsonDbName) ? (string)__jsonDbName : (string)DbName;}
            {_dbPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("dbPort"), out var __jsonDbPort) ? (string)__jsonDbPort : (string)DbPort;}
            {_dbUsername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("dbUsername"), out var __jsonDbUsername) ? (string)__jsonDbUsername : (string)DbUsername;}
            {_dbPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("dbPassword"), out var __jsonDbPassword) ? (string)__jsonDbPassword : (string)DbPassword;}
            {_dbPasswordUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("dbPasswordUri"), out var __jsonDbPasswordUri) ? (string)__jsonDbPasswordUri : (string)DbPasswordUri;}
            {_sapSid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("sapSid"), out var __jsonSapSid) ? (string)__jsonSapSid : (string)SapSid;}
            {_sslPreference = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("sslPreference"), out var __jsonSslPreference) ? (string)__jsonSslPreference : (string)SslPreference;}
            {_sslCertificateUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString>("sslCertificateUri"), out var __jsonSslCertificateUri) ? (string)__jsonSslCertificateUri : (string)SslCertificateUri;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDb2ProviderInstanceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDb2ProviderInstanceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IDb2ProviderInstanceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject json ? new Db2ProviderInstanceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Db2ProviderInstanceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Db2ProviderInstanceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __providerSpecificProperties?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._hostname)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._hostname.ToString()) : null, "hostname" ,container.Add );
            AddIf( null != (((object)this._dbName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._dbName.ToString()) : null, "dbName" ,container.Add );
            AddIf( null != (((object)this._dbPort)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._dbPort.ToString()) : null, "dbPort" ,container.Add );
            AddIf( null != (((object)this._dbUsername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._dbUsername.ToString()) : null, "dbUsername" ,container.Add );
            AddIf( null != (((object)this._dbPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._dbPassword.ToString()) : null, "dbPassword" ,container.Add );
            AddIf( null != (((object)this._dbPasswordUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._dbPasswordUri.ToString()) : null, "dbPasswordUri" ,container.Add );
            AddIf( null != (((object)this._sapSid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._sapSid.ToString()) : null, "sapSid" ,container.Add );
            AddIf( null != (((object)this._sslPreference)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._sslPreference.ToString()) : null, "sslPreference" ,container.Add );
            AddIf( null != (((object)this._sslCertificateUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Json.JsonString(this._sslCertificateUri.ToString()) : null, "sslCertificateUri" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}