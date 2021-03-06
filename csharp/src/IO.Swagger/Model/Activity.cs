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
    /// Activity
    /// </summary>
    [DataContract]
    public partial class Activity :  IEquatable<Activity>, IValidatableObject
    {
        /// <summary>
        /// type of activity
        /// </summary>
        /// <value>type of activity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Start for "start"
            /// </summary>
            [EnumMember(Value = "start")]
            Start,
            
            /// <summary>
            /// Enum End for "end"
            /// </summary>
            [EnumMember(Value = "end")]
            End,
            
            /// <summary>
            /// Enum Service for "service"
            /// </summary>
            [EnumMember(Value = "service")]
            Service,
            
            /// <summary>
            /// Enum PickupShipment for "pickupShipment"
            /// </summary>
            [EnumMember(Value = "pickupShipment")]
            PickupShipment,
            
            /// <summary>
            /// Enum DeliverShipment for "deliverShipment"
            /// </summary>
            [EnumMember(Value = "deliverShipment")]
            DeliverShipment,
            
            /// <summary>
            /// Enum Pickup for "pickup"
            /// </summary>
            [EnumMember(Value = "pickup")]
            Pickup,
            
            /// <summary>
            /// Enum Delivery for "delivery"
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery
        }

        /// <summary>
        /// type of activity
        /// </summary>
        /// <value>type of activity</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="Type">type of activity.</param>
        /// <param name="Id">id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to.</param>
        /// <param name="LocationId">id that refers to address.</param>
        /// <param name="ArrTime">arrival time at this activity in ms.</param>
        /// <param name="EndTime">end time of and thus departure time at this activity.</param>
        /// <param name="WaitingTime">waiting time at this activity in ms.</param>
        /// <param name="Distance">cumulated distance from start to this activity in m.</param>
        /// <param name="DrivingTime">driving time of driver in ms.</param>
        /// <param name="LoadBefore">Array with size/capacity dimensions before this activity.</param>
        /// <param name="LoadAfter">Array with size/capacity dimensions after this activity.</param>
        public Activity(TypeEnum? Type = default(TypeEnum?), string Id = default(string), string LocationId = default(string), long? ArrTime = default(long?), long? EndTime = default(long?), long? WaitingTime = default(long?), long? Distance = default(long?), long? DrivingTime = default(long?), List<int?> LoadBefore = default(List<int?>), List<int?> LoadAfter = default(List<int?>))
        {
            this.Type = Type;
            this.Id = Id;
            this.LocationId = LocationId;
            this.ArrTime = ArrTime;
            this.EndTime = EndTime;
            this.WaitingTime = WaitingTime;
            this.Distance = Distance;
            this.DrivingTime = DrivingTime;
            this.LoadBefore = LoadBefore;
            this.LoadAfter = LoadAfter;
        }
        
        /// <summary>
        /// id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to
        /// </summary>
        /// <value>id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// id that refers to address
        /// </summary>
        /// <value>id that refers to address</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// arrival time at this activity in ms
        /// </summary>
        /// <value>arrival time at this activity in ms</value>
        [DataMember(Name="arr_time", EmitDefaultValue=false)]
        public long? ArrTime { get; set; }
        /// <summary>
        /// end time of and thus departure time at this activity
        /// </summary>
        /// <value>end time of and thus departure time at this activity</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public long? EndTime { get; set; }
        /// <summary>
        /// waiting time at this activity in ms
        /// </summary>
        /// <value>waiting time at this activity in ms</value>
        [DataMember(Name="waiting_time", EmitDefaultValue=false)]
        public long? WaitingTime { get; set; }
        /// <summary>
        /// cumulated distance from start to this activity in m
        /// </summary>
        /// <value>cumulated distance from start to this activity in m</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public long? Distance { get; set; }
        /// <summary>
        /// driving time of driver in ms
        /// </summary>
        /// <value>driving time of driver in ms</value>
        [DataMember(Name="driving_time", EmitDefaultValue=false)]
        public long? DrivingTime { get; set; }
        /// <summary>
        /// Array with size/capacity dimensions before this activity
        /// </summary>
        /// <value>Array with size/capacity dimensions before this activity</value>
        [DataMember(Name="load_before", EmitDefaultValue=false)]
        public List<int?> LoadBefore { get; set; }
        /// <summary>
        /// Array with size/capacity dimensions after this activity
        /// </summary>
        /// <value>Array with size/capacity dimensions after this activity</value>
        [DataMember(Name="load_after", EmitDefaultValue=false)]
        public List<int?> LoadAfter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ArrTime: ").Append(ArrTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  WaitingTime: ").Append(WaitingTime).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DrivingTime: ").Append(DrivingTime).Append("\n");
            sb.Append("  LoadBefore: ").Append(LoadBefore).Append("\n");
            sb.Append("  LoadAfter: ").Append(LoadAfter).Append("\n");
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
            return this.Equals(obj as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="other">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.ArrTime == other.ArrTime ||
                    this.ArrTime != null &&
                    this.ArrTime.Equals(other.ArrTime)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.WaitingTime == other.WaitingTime ||
                    this.WaitingTime != null &&
                    this.WaitingTime.Equals(other.WaitingTime)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.DrivingTime == other.DrivingTime ||
                    this.DrivingTime != null &&
                    this.DrivingTime.Equals(other.DrivingTime)
                ) && 
                (
                    this.LoadBefore == other.LoadBefore ||
                    this.LoadBefore != null &&
                    this.LoadBefore.SequenceEqual(other.LoadBefore)
                ) && 
                (
                    this.LoadAfter == other.LoadAfter ||
                    this.LoadAfter != null &&
                    this.LoadAfter.SequenceEqual(other.LoadAfter)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.ArrTime != null)
                    hash = hash * 59 + this.ArrTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.WaitingTime != null)
                    hash = hash * 59 + this.WaitingTime.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.DrivingTime != null)
                    hash = hash * 59 + this.DrivingTime.GetHashCode();
                if (this.LoadBefore != null)
                    hash = hash * 59 + this.LoadBefore.GetHashCode();
                if (this.LoadAfter != null)
                    hash = hash * 59 + this.LoadAfter.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
