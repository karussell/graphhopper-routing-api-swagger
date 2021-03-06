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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * TimeWindow
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-25T10:05:28.496+11:00")
public class TimeWindow {
  @SerializedName("earliest")
  private Long earliest = null;

  @SerializedName("latest")
  private Long latest = null;

  public TimeWindow earliest(Long earliest) {
    this.earliest = earliest;
    return this;
  }

   /**
   * earliest start time of corresponding activity
   * @return earliest
  **/
  @ApiModelProperty(example = "null", value = "earliest start time of corresponding activity")
  public Long getEarliest() {
    return earliest;
  }

  public void setEarliest(Long earliest) {
    this.earliest = earliest;
  }

  public TimeWindow latest(Long latest) {
    this.latest = latest;
    return this;
  }

   /**
   * latest start time of corresponding activity
   * @return latest
  **/
  @ApiModelProperty(example = "null", value = "latest start time of corresponding activity")
  public Long getLatest() {
    return latest;
  }

  public void setLatest(Long latest) {
    this.latest = latest;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TimeWindow timeWindow = (TimeWindow) o;
    return Objects.equals(this.earliest, timeWindow.earliest) &&
        Objects.equals(this.latest, timeWindow.latest);
  }

  @Override
  public int hashCode() {
    return Objects.hash(earliest, latest);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TimeWindow {\n");
    
    sb.append("    earliest: ").append(toIndentedString(earliest)).append("\n");
    sb.append("    latest: ").append(toIndentedString(latest)).append("\n");
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

