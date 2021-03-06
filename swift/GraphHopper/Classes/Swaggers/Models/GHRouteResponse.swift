//
// GHRouteResponse.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class GHRouteResponse: JSONEncodable {
    public var paths: [GHRouteResponsePath]?
    public var info: GHResponseInfo?

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["paths"] = self.paths?.encodeToJSON()
        nillableDictionary["info"] = self.info?.encodeToJSON()
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}
