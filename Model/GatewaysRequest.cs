/* 
 * SensorPush Public API
 *
 * This is a swagger definition for the SensorPush public REST API. Download the definition file [here](https://api.sensorpush.com/api/v1/support/swagger/swagger-v1.json).
 *
 * OpenAPI spec version: v1.0.20200327
 * Contact: support@sensorpush.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Mrc.SensorPushCore.Client.SwaggerDateConverter;

namespace Mrc.SensorPushCore.Model
{
    /// <summary>
    /// Request object for gateways.
    /// </summary>
    [DataContract]
    public partial class GatewaysRequest :  IEquatable<GatewaysRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewaysRequest" /> class.
        /// </summary>
        /// <param name="format">Returns the results as the specified format (csv|json). Defaults to json.</param>
        public GatewaysRequest(string format = default(string))
        {
            this.Format = format;
        }
        
        /// <summary>
        /// Returns the results as the specified format (csv|json). Defaults to json
        /// </summary>
        /// <value>Returns the results as the specified format (csv|json). Defaults to json</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewaysRequest {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GatewaysRequest);
        }

        /// <summary>
        /// Returns true if GatewaysRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewaysRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewaysRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
