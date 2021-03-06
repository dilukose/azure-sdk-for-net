// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the activity on an elastic pool.
    /// </summary>
    [JsonTransformation]
    public partial class ElasticPoolActivity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPoolActivity class.
        /// </summary>
        public ElasticPoolActivity() { }

        /// <summary>
        /// Initializes a new instance of the ElasticPoolActivity class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">Resource ID</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="endTime">The time the operation finished (ISO8601
        /// format).</param>
        /// <param name="errorCode">The error code if available.</param>
        /// <param name="errorMessage">The error message if available.</param>
        /// <param name="errorSeverity">The error severity if
        /// available.</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="operationId">The unique operation ID.</param>
        /// <param name="percentComplete">The percentage complete if
        /// available.</param>
        /// <param name="requestedDatabaseDtuMax">The requested max DTU per
        /// database if available.</param>
        /// <param name="requestedDatabaseDtuMin">The requested min DTU per
        /// database if available.</param>
        /// <param name="requestedDtu">The requested DTU for the pool if
        /// available.</param>
        /// <param name="requestedElasticPoolName">The requested name for the
        /// elastic pool if available.</param>
        /// <param name="requestedStorageLimitInGB">The requested storage limit
        /// for the pool in GB if available.</param>
        /// <param name="elasticPoolName">The name of the elastic pool.</param>
        /// <param name="serverName">The name of the server the elastic pool is
        /// in.</param>
        /// <param name="startTime">The time the operation started (ISO8601
        /// format).</param>
        /// <param name="state">The current state of the operation.</param>
        /// <param name="requestedStorageLimitInMB">The requested storage limit
        /// in MB.</param>
        /// <param name="requestedDatabaseDtuGuarantee">The requested per
        /// database DTU guarantee.</param>
        /// <param name="requestedDatabaseDtuCap">The requested per database
        /// DTU cap.</param>
        /// <param name="requestedDtuGuarantee">The requested DTU
        /// guarantee.</param>
        public ElasticPoolActivity(string location, string name = default(string), string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? endTime = default(System.DateTime?), int? errorCode = default(int?), string errorMessage = default(string), int? errorSeverity = default(int?), string operation = default(string), string operationId = default(string), int? percentComplete = default(int?), int? requestedDatabaseDtuMax = default(int?), int? requestedDatabaseDtuMin = default(int?), int? requestedDtu = default(int?), string requestedElasticPoolName = default(string), long? requestedStorageLimitInGB = default(long?), string elasticPoolName = default(string), string serverName = default(string), System.DateTime? startTime = default(System.DateTime?), string state = default(string), int? requestedStorageLimitInMB = default(int?), int? requestedDatabaseDtuGuarantee = default(int?), int? requestedDatabaseDtuCap = default(int?), int? requestedDtuGuarantee = default(int?))
            : base(location, name, id, type, tags)
        {
            EndTime = endTime;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorSeverity = errorSeverity;
            Operation = operation;
            OperationId = operationId;
            PercentComplete = percentComplete;
            RequestedDatabaseDtuMax = requestedDatabaseDtuMax;
            RequestedDatabaseDtuMin = requestedDatabaseDtuMin;
            RequestedDtu = requestedDtu;
            RequestedElasticPoolName = requestedElasticPoolName;
            RequestedStorageLimitInGB = requestedStorageLimitInGB;
            ElasticPoolName = elasticPoolName;
            ServerName = serverName;
            StartTime = startTime;
            State = state;
            RequestedStorageLimitInMB = requestedStorageLimitInMB;
            RequestedDatabaseDtuGuarantee = requestedDatabaseDtuGuarantee;
            RequestedDatabaseDtuCap = requestedDatabaseDtuCap;
            RequestedDtuGuarantee = requestedDtuGuarantee;
        }

        /// <summary>
        /// Gets the time the operation finished (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; protected set; }

        /// <summary>
        /// Gets the error code if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorCode")]
        public int? ErrorCode { get; protected set; }

        /// <summary>
        /// Gets the error message if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; protected set; }

        /// <summary>
        /// Gets the error severity if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorSeverity")]
        public int? ErrorSeverity { get; protected set; }

        /// <summary>
        /// Gets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operation")]
        public string Operation { get; protected set; }

        /// <summary>
        /// Gets the unique operation ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; protected set; }

        /// <summary>
        /// Gets the percentage complete if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.percentComplete")]
        public int? PercentComplete { get; protected set; }

        /// <summary>
        /// Gets the requested max DTU per database if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDatabaseDtuMax")]
        public int? RequestedDatabaseDtuMax { get; protected set; }

        /// <summary>
        /// Gets the requested min DTU per database if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDatabaseDtuMin")]
        public int? RequestedDatabaseDtuMin { get; protected set; }

        /// <summary>
        /// Gets the requested DTU for the pool if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDtu")]
        public int? RequestedDtu { get; protected set; }

        /// <summary>
        /// Gets the requested name for the elastic pool if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedElasticPoolName")]
        public string RequestedElasticPoolName { get; protected set; }

        /// <summary>
        /// Gets the requested storage limit for the pool in GB if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedStorageLimitInGB")]
        public long? RequestedStorageLimitInGB { get; protected set; }

        /// <summary>
        /// Gets the name of the elastic pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; protected set; }

        /// <summary>
        /// Gets the name of the server the elastic pool is in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName { get; protected set; }

        /// <summary>
        /// Gets the time the operation started (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; protected set; }

        /// <summary>
        /// Gets the current state of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; protected set; }

        /// <summary>
        /// Gets the requested storage limit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedStorageLimitInMB")]
        public int? RequestedStorageLimitInMB { get; protected set; }

        /// <summary>
        /// Gets the requested per database DTU guarantee.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDatabaseDtuGuarantee")]
        public int? RequestedDatabaseDtuGuarantee { get; protected set; }

        /// <summary>
        /// Gets the requested per database DTU cap.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDatabaseDtuCap")]
        public int? RequestedDatabaseDtuCap { get; protected set; }

        /// <summary>
        /// Gets the requested DTU guarantee.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedDtuGuarantee")]
        public int? RequestedDtuGuarantee { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

