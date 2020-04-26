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
    /// Calibration settings
    /// </summary>
    [DataContract]
    public partial class SensorCalibration :  IEquatable<SensorCalibration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorCalibration" /> class.
        /// </summary>
        /// <param name="humidity">Humidity calibration.</param>
        /// <param name="temperature">Temperature calibration.</param>
        public SensorCalibration(decimal? humidity = default(decimal?), decimal? temperature = default(decimal?))
        {
            this.Humidity = humidity;
            this.Temperature = temperature;
        }
        
        /// <summary>
        /// Humidity calibration
        /// </summary>
        /// <value>Humidity calibration</value>
        [DataMember(Name="humidity", EmitDefaultValue=false)]
        public decimal? Humidity { get; set; }

        /// <summary>
        /// Temperature calibration
        /// </summary>
        /// <value>Temperature calibration</value>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SensorCalibration {\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
            return this.Equals(input as SensorCalibration);
        }

        /// <summary>
        /// Returns true if SensorCalibration instances are equal
        /// </summary>
        /// <param name="input">Instance of SensorCalibration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensorCalibration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Humidity == input.Humidity ||
                    (this.Humidity != null &&
                    this.Humidity.Equals(input.Humidity))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
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
                if (this.Humidity != null)
                    hashCode = hashCode * 59 + this.Humidity.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
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
