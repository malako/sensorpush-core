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
    /// Response object for an oAuth authorization code.
    /// </summary>
    [DataContract]
    public partial class AuthorizeResponse :  IEquatable<AuthorizeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeResponse" /> class.
        /// </summary>
        /// <param name="authorization">JWT oAuth authorization code. Pass this code to the oauth/accesscode service to request an access token. The [jwt](https://jwt.io/) website has a useful jwt viewer..</param>
        public AuthorizeResponse(string authorization = default(string))
        {
            this.Authorization = authorization;
        }
        
        /// <summary>
        /// JWT oAuth authorization code. Pass this code to the oauth/accesscode service to request an access token. The [jwt](https://jwt.io/) website has a useful jwt viewer.
        /// </summary>
        /// <value>JWT oAuth authorization code. Pass this code to the oauth/accesscode service to request an access token. The [jwt](https://jwt.io/) website has a useful jwt viewer.</value>
        [DataMember(Name="authorization", EmitDefaultValue=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorizeResponse {\n");
            sb.Append("  Authorization: ").Append(Authorization).Append("\n");
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
            return this.Equals(input as AuthorizeResponse);
        }

        /// <summary>
        /// Returns true if AuthorizeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
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
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
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
