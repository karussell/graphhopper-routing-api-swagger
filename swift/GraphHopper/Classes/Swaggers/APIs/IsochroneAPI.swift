//
// IsochroneAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire



public class IsochroneAPI: APIBase {
    /**
     Isochrone Request
     
     - parameter point: (query) Specify the start coordinate 
     - parameter key: (query) Get your key at graphhopper.com 
     - parameter timeLimit: (query) Specify which time the vehicle should travel. In seconds. The maximum depends on the subscribed package. (optional, default to 600)
     - parameter vehicle: (query) Possible vehicles are bike, car, foot and [more](https://graphhopper.com/api/1/docs/supported-vehicle-profiles/) (optional, default to car)
     - parameter buckets: (query) For how many sub intervals an additional polygon should be calculated. (optional, default to 1)
     - parameter reverseFlow: (query) If &#x60;false&#x60; the flow goes from point to the polygon, if &#x60;true&#x60; the flow goes from the polygon \&quot;inside\&quot; to the point. Example usage for &#x60;false&#x60;&amp;#58; *How many potential customer can be reached within 30min travel time from your store* vs. &#x60;true&#x60;&amp;#58; *How many customers can reach your store within 30min travel time.* (optional, default to false)
     - parameter completion: completion handler to receive the data and the error objects
     */
    public class func isochroneGet(point point: String, key: String, timeLimit: Int32? = nil, vehicle: String? = nil, buckets: Int32? = nil, reverseFlow: Bool? = nil, completion: ((data: GHIsochroneResponse?, error: ErrorType?) -> Void)) {
        isochroneGetWithRequestBuilder(point: point, key: key, timeLimit: timeLimit, vehicle: vehicle, buckets: buckets, reverseFlow: reverseFlow).execute { (response, error) -> Void in
            completion(data: response?.body, error: error);
        }
    }


    /**
     Isochrone Request
     - GET /isochrone
     - The GraphHopper Isochrone API allows calculating an isochrone of a locations means to calculate 'a line connecting points at which a vehicle arrives at the same time,' see [Wikipedia](http://en.wikipedia.org/wiki/Isochrone_map). It is also called **reachability** or **walkability**. 
     - examples: [{contentType=application/json, example={
  "polygons" : [ {
    "geometry" : {
      "coordinates" : "",
      "type" : "aeiou"
    },
    "type" : "aeiou",
    "properties" : {
      "bucket" : 123
    }
  } ],
  "copyrights" : [ "aeiou" ]
}}]
     
     - parameter point: (query) Specify the start coordinate 
     - parameter key: (query) Get your key at graphhopper.com 
     - parameter timeLimit: (query) Specify which time the vehicle should travel. In seconds. The maximum depends on the subscribed package. (optional, default to 600)
     - parameter vehicle: (query) Possible vehicles are bike, car, foot and [more](https://graphhopper.com/api/1/docs/supported-vehicle-profiles/) (optional, default to car)
     - parameter buckets: (query) For how many sub intervals an additional polygon should be calculated. (optional, default to 1)
     - parameter reverseFlow: (query) If &#x60;false&#x60; the flow goes from point to the polygon, if &#x60;true&#x60; the flow goes from the polygon \&quot;inside\&quot; to the point. Example usage for &#x60;false&#x60;&amp;#58; *How many potential customer can be reached within 30min travel time from your store* vs. &#x60;true&#x60;&amp;#58; *How many customers can reach your store within 30min travel time.* (optional, default to false)

     - returns: RequestBuilder<GHIsochroneResponse> 
     */
    public class func isochroneGetWithRequestBuilder(point point: String, key: String, timeLimit: Int32? = nil, vehicle: String? = nil, buckets: Int32? = nil, reverseFlow: Bool? = nil) -> RequestBuilder<GHIsochroneResponse> {
        let path = "/isochrone"
        let URLString = GraphHopperAPI.basePath + path

        let nillableParameters: [String:AnyObject?] = [
            "point": point,
            "time_limit": timeLimit?.encodeToJSON(),
            "vehicle": vehicle,
            "buckets": buckets?.encodeToJSON(),
            "reverse_flow": reverseFlow,
            "key": key
        ]
 
        let parameters = APIHelper.rejectNil(nillableParameters)
 
        let convertedParameters = APIHelper.convertBoolToString(parameters)
 
        let requestBuilder: RequestBuilder<GHIsochroneResponse>.Type = GraphHopperAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: URLString, parameters: convertedParameters, isBody: false)
    }

}
