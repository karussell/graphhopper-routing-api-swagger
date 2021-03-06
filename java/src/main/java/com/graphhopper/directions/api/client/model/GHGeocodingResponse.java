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
import com.graphhopper.directions.api.client.model.GHGeocodingLocation;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * GHGeocodingResponse
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-25T10:05:28.496+11:00")
public class GHGeocodingResponse {
  @SerializedName("hits")
  private List<GHGeocodingLocation> hits = new ArrayList<GHGeocodingLocation>();

  @SerializedName("locale")
  private String locale = null;

  public GHGeocodingResponse hits(List<GHGeocodingLocation> hits) {
    this.hits = hits;
    return this;
  }

  public GHGeocodingResponse addHitsItem(GHGeocodingLocation hitsItem) {
    this.hits.add(hitsItem);
    return this;
  }

   /**
   * Get hits
   * @return hits
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<GHGeocodingLocation> getHits() {
    return hits;
  }

  public void setHits(List<GHGeocodingLocation> hits) {
    this.hits = hits;
  }

  public GHGeocodingResponse locale(String locale) {
    this.locale = locale;
    return this;
  }

   /**
   * Get locale
   * @return locale
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getLocale() {
    return locale;
  }

  public void setLocale(String locale) {
    this.locale = locale;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GHGeocodingResponse ghGeocodingResponse = (GHGeocodingResponse) o;
    return Objects.equals(this.hits, ghGeocodingResponse.hits) &&
        Objects.equals(this.locale, ghGeocodingResponse.locale);
  }

  @Override
  public int hashCode() {
    return Objects.hash(hits, locale);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GHGeocodingResponse {\n");
    
    sb.append("    hits: ").append(toIndentedString(hits)).append("\n");
    sb.append("    locale: ").append(toIndentedString(locale)).append("\n");
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

