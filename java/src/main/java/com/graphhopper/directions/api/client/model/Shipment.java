/*
 * GraphHopper Directions API
 * With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.graphhopper.directions.api.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import com.graphhopper.directions.api.client.model.Stop;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * Shipment
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-25T10:05:28.496+11:00")
public class Shipment {
  @SerializedName("id")
  private String id = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("priority")
  private Integer priority = null;

  @SerializedName("pickup")
  private Stop pickup = null;

  @SerializedName("delivery")
  private Stop delivery = null;

  @SerializedName("size")
  private List<Integer> size = new ArrayList<Integer>();

  @SerializedName("required_skills")
  private List<String> requiredSkills = new ArrayList<String>();

  @SerializedName("allowed_vehicles")
  private List<String> allowedVehicles = new ArrayList<String>();

  public Shipment id(String id) {
    this.id = id;
    return this;
  }

   /**
   * Unique identifier of service
   * @return id
  **/
  @ApiModelProperty(example = "null", value = "Unique identifier of service")
  public String getId() {
    return id;
  }

  public void setId(String id) {
    this.id = id;
  }

  public Shipment name(String name) {
    this.name = name;
    return this;
  }

   /**
   * name of shipment
   * @return name
  **/
  @ApiModelProperty(example = "null", value = "name of shipment")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Shipment priority(Integer priority) {
    this.priority = priority;
    return this;
  }

   /**
   * priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2.
   * @return priority
  **/
  @ApiModelProperty(example = "null", value = "priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2.")
  public Integer getPriority() {
    return priority;
  }

  public void setPriority(Integer priority) {
    this.priority = priority;
  }

  public Shipment pickup(Stop pickup) {
    this.pickup = pickup;
    return this;
  }

   /**
   * Get pickup
   * @return pickup
  **/
  @ApiModelProperty(example = "null", value = "")
  public Stop getPickup() {
    return pickup;
  }

  public void setPickup(Stop pickup) {
    this.pickup = pickup;
  }

  public Shipment delivery(Stop delivery) {
    this.delivery = delivery;
    return this;
  }

   /**
   * Get delivery
   * @return delivery
  **/
  @ApiModelProperty(example = "null", value = "")
  public Stop getDelivery() {
    return delivery;
  }

  public void setDelivery(Stop delivery) {
    this.delivery = delivery;
  }

  public Shipment size(List<Integer> size) {
    this.size = size;
    return this;
  }

  public Shipment addSizeItem(Integer sizeItem) {
    this.size.add(sizeItem);
    return this;
  }

   /**
   * array of capacity dimensions
   * @return size
  **/
  @ApiModelProperty(example = "null", value = "array of capacity dimensions")
  public List<Integer> getSize() {
    return size;
  }

  public void setSize(List<Integer> size) {
    this.size = size;
  }

  public Shipment requiredSkills(List<String> requiredSkills) {
    this.requiredSkills = requiredSkills;
    return this;
  }

  public Shipment addRequiredSkillsItem(String requiredSkillsItem) {
    this.requiredSkills.add(requiredSkillsItem);
    return this;
  }

   /**
   * array of required skills
   * @return requiredSkills
  **/
  @ApiModelProperty(example = "null", value = "array of required skills")
  public List<String> getRequiredSkills() {
    return requiredSkills;
  }

  public void setRequiredSkills(List<String> requiredSkills) {
    this.requiredSkills = requiredSkills;
  }

  public Shipment allowedVehicles(List<String> allowedVehicles) {
    this.allowedVehicles = allowedVehicles;
    return this;
  }

  public Shipment addAllowedVehiclesItem(String allowedVehiclesItem) {
    this.allowedVehicles.add(allowedVehiclesItem);
    return this;
  }

   /**
   * array of allowed vehicle ids
   * @return allowedVehicles
  **/
  @ApiModelProperty(example = "null", value = "array of allowed vehicle ids")
  public List<String> getAllowedVehicles() {
    return allowedVehicles;
  }

  public void setAllowedVehicles(List<String> allowedVehicles) {
    this.allowedVehicles = allowedVehicles;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Shipment shipment = (Shipment) o;
    return Objects.equals(this.id, shipment.id) &&
        Objects.equals(this.name, shipment.name) &&
        Objects.equals(this.priority, shipment.priority) &&
        Objects.equals(this.pickup, shipment.pickup) &&
        Objects.equals(this.delivery, shipment.delivery) &&
        Objects.equals(this.size, shipment.size) &&
        Objects.equals(this.requiredSkills, shipment.requiredSkills) &&
        Objects.equals(this.allowedVehicles, shipment.allowedVehicles);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, name, priority, pickup, delivery, size, requiredSkills, allowedVehicles);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Shipment {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    priority: ").append(toIndentedString(priority)).append("\n");
    sb.append("    pickup: ").append(toIndentedString(pickup)).append("\n");
    sb.append("    delivery: ").append(toIndentedString(delivery)).append("\n");
    sb.append("    size: ").append(toIndentedString(size)).append("\n");
    sb.append("    requiredSkills: ").append(toIndentedString(requiredSkills)).append("\n");
    sb.append("    allowedVehicles: ").append(toIndentedString(allowedVehicles)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

