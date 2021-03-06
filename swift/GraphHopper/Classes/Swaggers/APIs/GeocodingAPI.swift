//
// GeocodingAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire



public class GeocodingAPI: APIBase {
    /**
     Execute a Geocoding request
     
     - parameter key: (query) Get your key at graphhopper.com 
     - parameter q: (query) If you do forward geocoding, then this would be a textual description of the adress you are looking for. If you do reverse geocoding this would be in lat,lon. (optional)
     - parameter locale: (query) Display the search results for the specified locale. Currently French (fr), English (en), German (de) and Italian (it) are supported. If the locale wasn&#39;t found the default (en) is used. (optional)
     - parameter limit: (query) Specify the maximum number of returned results (optional)
     - parameter reverse: (query) Set to true to do a reverse Geocoding request (optional)
     - parameter point: (query) The location bias in the format &#39;latitude,longitude&#39; e.g. point&#x3D;45.93272,11.58803 (optional)
     - parameter provider: (query) Can be either, default, nominatim, opencagedata (optional)
     - parameter completion: completion handler to receive the data and the error objects
     */
    public class func geocodeGet(key key: String, q: String? = nil, locale: String? = nil, limit: Int32? = nil, reverse: Bool? = nil, point: String? = nil, provider: String? = nil, completion: ((data: GHGeocodingResponse?, error: ErrorType?) -> Void)) {
        geocodeGetWithRequestBuilder(key: key, q: q, locale: locale, limit: limit, reverse: reverse, point: point, provider: provider).execute { (response, error) -> Void in
            completion(data: response?.body, error: error);
        }
    }


    /**
     Execute a Geocoding request
     - GET /geocode
     - This endpoint provides forward and reverse geocoding. For more details, review the official documentation at: https://graphhopper.com/api/1/docs/geocoding/ 
     - examples: [{contentType=application/json, example={
  "hits" : [ {
    "osm_id" : "aeiou",
    "osm_type" : "aeiou",
    "country" : "aeiou",
    "city" : "aeiou",
    "housenumber" : "aeiou",
    "street" : "aeiou",
    "name" : "aeiou",
    "postcode" : "aeiou",
    "state" : "aeiou",
    "point" : {
      "lng" : 1.3579000000000001069366817318950779736042022705078125,
      "lat" : 1.3579000000000001069366817318950779736042022705078125
    }
  } ],
  "locale" : "aeiou"
}}]
     
     - parameter key: (query) Get your key at graphhopper.com 
     - parameter q: (query) If you do forward geocoding, then this would be a textual description of the adress you are looking for. If you do reverse geocoding this would be in lat,lon. (optional)
     - parameter locale: (query) Display the search results for the specified locale. Currently French (fr), English (en), German (de) and Italian (it) are supported. If the locale wasn&#39;t found the default (en) is used. (optional)
     - parameter limit: (query) Specify the maximum number of returned results (optional)
     - parameter reverse: (query) Set to true to do a reverse Geocoding request (optional)
     - parameter point: (query) The location bias in the format &#39;latitude,longitude&#39; e.g. point&#x3D;45.93272,11.58803 (optional)
     - parameter provider: (query) Can be either, default, nominatim, opencagedata (optional)

     - returns: RequestBuilder<GHGeocodingResponse> 
     */
    public class func geocodeGetWithRequestBuilder(key key: String, q: String? = nil, locale: String? = nil, limit: Int32? = nil, reverse: Bool? = nil, point: String? = nil, provider: String? = nil) -> RequestBuilder<GHGeocodingResponse> {
        let path = "/geocode"
        let URLString = GraphHopperAPI.basePath + path

        let nillableParameters: [String:AnyObject?] = [
            "q": q,
            "locale": locale,
            "limit": limit?.encodeToJSON(),
            "reverse": reverse,
            "point": point,
            "provider": provider,
            "key": key
        ]
 
        let parameters = APIHelper.rejectNil(nillableParameters)
 
        let convertedParameters = APIHelper.convertBoolToString(parameters)
 
        let requestBuilder: RequestBuilder<GHGeocodingResponse>.Type = GraphHopperAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: URLString, parameters: convertedParameters, isBody: false)
    }

}
