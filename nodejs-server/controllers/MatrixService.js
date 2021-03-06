'use strict';

exports.matrixGET = function(args, res, next) {
  /**
   * Matrix API
   * The Matrix API is part of the GraphHopper Directions API and with this API you can calculate many-to-many distances, times or routes a lot more efficient than calling the Routing API multiple times. In the Routing API we support multiple points, so called 'via points', which results in one route being calculated. The Matrix API results in NxM routes or more precise NxM weights, distances or times being calculated but is a lot faster compared to NxM single requests. The most simple example is a tourist trying to decide which pizza is close to him instead of using beeline distance she can calculate a 1x4 matrix. Or a delivery service in the need of often big NxN matrices to solve vehicle routing problems. E.g. the GraphHopper Route Optimization API uses the Matrix API under the hood to achieve this. 
   *
   * key String Get your key at graphhopper.com
   * point List Specifiy multiple points for which the weight-, route-, time- or distance-matrix should be calculated. In this case the starts are identical to the destinations. If there are N points, then NxN entries will be calculated. The order of the point parameter is important. Specify at least three points. Cannot be used together with from_point or to_point. Is a string with the format latitude,longitude. (optional)
   * from_point String The starting points for the routes. E.g. if you want to calculate the three routes A->1, A->2, A->3 then you have one from_point parameter and three to_point parameters. Is a string with the format latitude,longitude. (optional)
   * to_point String The destination points for the routes. Is a string with the format latitude,longitude. (optional)
   * out_array List pecifies which arrays should be included in the response. Specify one or more of the following options 'weights', 'times', 'distances'. To specify more than one array use e.g. out_array=times&out_array=distances. The units of the entries of distances are meters, of times are seconds and of weights is arbitrary and it can differ for different vehicles or versions of this API. (optional)
   * vehicle String The vehicle for which the route should be calculated. Other vehicles are foot, bike, mtb, racingbike, motorcycle, small_truck, bus and truck. See here for the details. (optional)
   * returns GHMatrixResponse
   **/
  var examples = {};
  examples['application/json'] = {
  "distances" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "times" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "weights" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "info" : {
    "took" : 123,
    "copyrights" : [ "aeiou" ]
  }
};
  if (Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  } else {
    res.end();
  }
}

exports.matrixPOST = function(args, res, next) {
  /**
   * Matrix API Post
   * The GET request has an URL length limitation, which hurts for many locations per request. In those cases use a HTTP POST request with JSON data as input. The only parameter in the URL will be the key which stays in the URL. Both request scenarios are identically except that all singular parameter names are named as their plural for a POST request. 
   *
   * key String Get your key at graphhopper.com
   * body GHMatrixRequest  (optional)
   * returns GHMatrixResponse
   **/
  var examples = {};
  examples['application/json'] = {
  "distances" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "times" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "weights" : [ [ 1.3579000000000001069366817318950779736042022705078125 ] ],
  "info" : {
    "took" : 123,
    "copyrights" : [ "aeiou" ]
  }
};
  if (Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  } else {
    res.end();
  }
}

