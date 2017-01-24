/* 
 * GraphHopper Directions API
 *
 * With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 
 *
 * OpenAPI spec version: 1.0.0
 * 
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Algorithm
    /// </summary>
    [DataContract]
    public partial class Algorithm :  IEquatable<Algorithm>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProblemTypeEnum
        {
            
            /// <summary>
            /// Enum Min for "min"
            /// </summary>
            [EnumMember(Value = "min")]
            Min,
            
            /// <summary>
            /// Enum Minmax for "min-max"
            /// </summary>
            [EnumMember(Value = "min-max")]
            Minmax
        }

        /// <summary>
        /// Gets or Sets Objective
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectiveEnum
        {
            
            /// <summary>
            /// Enum Transporttime for "transport_time"
            /// </summary>
            [EnumMember(Value = "transport_time")]
            Transporttime,
            
            /// <summary>
            /// Enum Completiontime for "completion_time"
            /// </summary>
            [EnumMember(Value = "completion_time")]
            Completiontime
        }

        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [DataMember(Name="problem_type", EmitDefaultValue=false)]
        public ProblemTypeEnum? ProblemType { get; set; }
        /// <summary>
        /// Gets or Sets Objective
        /// </summary>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public ObjectiveEnum? Objective { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Algorithm" /> class.
        /// </summary>
        /// <param name="ProblemType">ProblemType.</param>
        /// <param name="Objective">Objective.</param>
        public Algorithm(ProblemTypeEnum? ProblemType = default(ProblemTypeEnum?), ObjectiveEnum? Objective = default(ObjectiveEnum?))
        {
            this.ProblemType = ProblemType;
            this.Objective = Objective;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Algorithm {\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Algorithm);
        }

        /// <summary>
        /// Returns true if Algorithm instances are equal
        /// </summary>
        /// <param name="other">Instance of Algorithm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Algorithm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProblemType == other.ProblemType ||
                    this.ProblemType != null &&
                    this.ProblemType.Equals(other.ProblemType)
                ) && 
                (
                    this.Objective == other.Objective ||
                    this.Objective != null &&
                    this.Objective.Equals(other.Objective)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ProblemType != null)
                    hash = hash * 59 + this.ProblemType.GetHashCode();
                if (this.Objective != null)
                    hash = hash * 59 + this.Objective.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}