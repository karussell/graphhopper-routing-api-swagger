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
    /// GHIsochroneResponsePolygonGeometry
    /// </summary>
    [DataContract]
    public partial class GHIsochroneResponsePolygonGeometry :  IEquatable<GHIsochroneResponsePolygonGeometry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GHIsochroneResponsePolygonGeometry" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Coordinates">Coordinates.</param>
        public GHIsochroneResponsePolygonGeometry(string Type = default(string), GHResponseCoordinatesArray Coordinates = default(GHResponseCoordinatesArray))
        {
            this.Type = Type;
            this.Coordinates = Coordinates;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name="coordinates", EmitDefaultValue=false)]
        public GHResponseCoordinatesArray Coordinates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GHIsochroneResponsePolygonGeometry {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
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
            return this.Equals(obj as GHIsochroneResponsePolygonGeometry);
        }

        /// <summary>
        /// Returns true if GHIsochroneResponsePolygonGeometry instances are equal
        /// </summary>
        /// <param name="other">Instance of GHIsochroneResponsePolygonGeometry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GHIsochroneResponsePolygonGeometry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Coordinates == other.Coordinates ||
                    this.Coordinates != null &&
                    this.Coordinates.Equals(other.Coordinates)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Coordinates != null)
                    hash = hash * 59 + this.Coordinates.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
