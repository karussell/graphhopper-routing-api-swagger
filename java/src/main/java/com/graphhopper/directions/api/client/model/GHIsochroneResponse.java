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
import com.graphhopper.directions.api.client.model.GHIsochroneResponsePolygon;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * GHIsochroneResponse
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-25T10:05:28.496+11:00")
public class GHIsochroneResponse {
  @SerializedName("polygons")
  private List<GHIsochroneResponsePolygon> polygons = new ArrayList<GHIsochroneResponsePolygon>();

  @SerializedName("copyrights")
  private List<String> copyrights = new ArrayList<String>();

  public GHIsochroneResponse polygons(List<GHIsochroneResponsePolygon> polygons) {
    this.polygons = polygons;
    return this;
  }

  public GHIsochroneResponse addPolygonsItem(GHIsochroneResponsePolygon polygonsItem) {
    this.polygons.add(polygonsItem);
    return this;
  }

   /**
   * Get polygons
   * @return polygons
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<GHIsochroneResponsePolygon> getPolygons() {
    return polygons;
  }

  public void setPolygons(List<GHIsochroneResponsePolygon> polygons) {
    this.polygons = polygons;
  }

  public GHIsochroneResponse copyrights(List<String> copyrights) {
    this.copyrights = copyrights;
    return this;
  }

  public GHIsochroneResponse addCopyrightsItem(String copyrightsItem) {
    this.copyrights.add(copyrightsItem);
    return this;
  }

   /**
   * Get copyrights
   * @return copyrights
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getCopyrights() {
    return copyrights;
  }

  public void setCopyrights(List<String> copyrights) {
    this.copyrights = copyrights;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GHIsochroneResponse ghIsochroneResponse = (GHIsochroneResponse) o;
    return Objects.equals(this.polygons, ghIsochroneResponse.polygons) &&
        Objects.equals(this.copyrights, ghIsochroneResponse.copyrights);
  }

  @Override
  public int hashCode() {
    return Objects.hash(polygons, copyrights);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GHIsochroneResponse {\n");
    
    sb.append("    polygons: ").append(toIndentedString(polygons)).append("\n");
    sb.append("    copyrights: ").append(toIndentedString(copyrights)).append("\n");
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

