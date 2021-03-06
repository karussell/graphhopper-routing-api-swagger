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
    /// GHRouteResponse
    /// </summary>
    [DataContract]
    public partial class GHRouteResponse :  IEquatable<GHRouteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GHRouteResponse" /> class.
        /// </summary>
        /// <param name="Paths">Paths.</param>
        /// <param name="Info">Info.</param>
        public GHRouteResponse(List<GHRouteResponsePath> Paths = default(List<GHRouteResponsePath>), GHResponseInfo Info = default(GHResponseInfo))
        {
            this.Paths = Paths;
            this.Info = Info;
        }
        
        /// <summary>
        /// Gets or Sets Paths
        /// </summary>
        [DataMember(Name="paths", EmitDefaultValue=false)]
        public List<GHRouteResponsePath> Paths { get; set; }
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public GHResponseInfo Info { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GHRouteResponse {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(obj as GHRouteResponse);
        }

        /// <summary>
        /// Returns true if GHRouteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GHRouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GHRouteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Paths == other.Paths ||
                    this.Paths != null &&
                    this.Paths.SequenceEqual(other.Paths)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
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
                if (this.Paths != null)
                    hash = hash * 59 + this.Paths.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
