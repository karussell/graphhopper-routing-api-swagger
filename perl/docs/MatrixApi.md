# WWW::SwaggerClient::MatrixApi

## Load the API package
```perl
use WWW::SwaggerClient::Object::MatrixApi;
```

All URIs are relative to *https://graphhopper.com/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**matrix_get**](MatrixApi.md#matrix_get) | **GET** /matrix | Matrix API
[**matrix_post**](MatrixApi.md#matrix_post) | **POST** /matrix | Matrix API Post


# **matrix_get**
> GHMatrixResponse matrix_get(key => $key, point => $point, from_point => $from_point, to_point => $to_point, out_array => $out_array, vehicle => $vehicle)

Matrix API

The Matrix API is part of the GraphHopper Directions API and with this API you can calculate many-to-many distances, times or routes a lot more efficient than calling the Routing API multiple times. In the Routing API we support multiple points, so called 'via points', which results in one route being calculated. The Matrix API results in NxM routes or more precise NxM weights, distances or times being calculated but is a lot faster compared to NxM single requests. The most simple example is a tourist trying to decide which pizza is close to him instead of using beeline distance she can calculate a 1x4 matrix. Or a delivery service in the need of often big NxN matrices to solve vehicle routing problems. E.g. the GraphHopper Route Optimization API uses the Matrix API under the hood to achieve this. 

### Example 
```perl
use Data::Dumper;
use WWW::SwaggerClient::Configuration;
use WWW::SwaggerClient::MatrixApi;

my $api_instance = WWW::SwaggerClient::MatrixApi->new();
my $key = 'key_example'; # string | Get your key at graphhopper.com
my $point = []; # ARRAY[string] | Specifiy multiple points for which the weight-, route-, time- or distance-matrix should be calculated. In this case the starts are identical to the destinations. If there are N points, then NxN entries will be calculated. The order of the point parameter is important. Specify at least three points. Cannot be used together with from_point or to_point. Is a string with the format latitude,longitude.
my $from_point = 'from_point_example'; # string | The starting points for the routes. E.g. if you want to calculate the three routes A->1, A->2, A->3 then you have one from_point parameter and three to_point parameters. Is a string with the format latitude,longitude.
my $to_point = 'to_point_example'; # string | The destination points for the routes. Is a string with the format latitude,longitude.
my $out_array = []; # ARRAY[string] | pecifies which arrays should be included in the response. Specify one or more of the following options 'weights', 'times', 'distances'. To specify more than one array use e.g. out_array=times&out_array=distances. The units of the entries of distances are meters, of times are seconds and of weights is arbitrary and it can differ for different vehicles or versions of this API.
my $vehicle = 'vehicle_example'; # string | The vehicle for which the route should be calculated. Other vehicles are foot, bike, mtb, racingbike, motorcycle, small_truck, bus and truck. See here for the details.

eval { 
    my $result = $api_instance->matrix_get(key => $key, point => $point, from_point => $from_point, to_point => $to_point, out_array => $out_array, vehicle => $vehicle);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling MatrixApi->matrix_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Get your key at graphhopper.com | 
 **point** | [**ARRAY[string]**](string.md)| Specifiy multiple points for which the weight-, route-, time- or distance-matrix should be calculated. In this case the starts are identical to the destinations. If there are N points, then NxN entries will be calculated. The order of the point parameter is important. Specify at least three points. Cannot be used together with from_point or to_point. Is a string with the format latitude,longitude. | [optional] 
 **from_point** | **string**| The starting points for the routes. E.g. if you want to calculate the three routes A-&gt;1, A-&gt;2, A-&gt;3 then you have one from_point parameter and three to_point parameters. Is a string with the format latitude,longitude. | [optional] 
 **to_point** | **string**| The destination points for the routes. Is a string with the format latitude,longitude. | [optional] 
 **out_array** | [**ARRAY[string]**](string.md)| pecifies which arrays should be included in the response. Specify one or more of the following options &#39;weights&#39;, &#39;times&#39;, &#39;distances&#39;. To specify more than one array use e.g. out_array&#x3D;times&amp;out_array&#x3D;distances. The units of the entries of distances are meters, of times are seconds and of weights is arbitrary and it can differ for different vehicles or versions of this API. | [optional] 
 **vehicle** | **string**| The vehicle for which the route should be calculated. Other vehicles are foot, bike, mtb, racingbike, motorcycle, small_truck, bus and truck. See here for the details. | [optional] [default to car]

### Return type

[**GHMatrixResponse**](GHMatrixResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **matrix_post**
> GHMatrixResponse matrix_post(key => $key, body => $body)

Matrix API Post

The GET request has an URL length limitation, which hurts for many locations per request. In those cases use a HTTP POST request with JSON data as input. The only parameter in the URL will be the key which stays in the URL. Both request scenarios are identically except that all singular parameter names are named as their plural for a POST request. 

### Example 
```perl
use Data::Dumper;
use WWW::SwaggerClient::Configuration;
use WWW::SwaggerClient::MatrixApi;

my $api_instance = WWW::SwaggerClient::MatrixApi->new();
my $key = 'key_example'; # string | Get your key at graphhopper.com
my $body = WWW::SwaggerClient::Object::GHMatrixRequest->new(); # GHMatrixRequest | 

eval { 
    my $result = $api_instance->matrix_post(key => $key, body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling MatrixApi->matrix_post: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Get your key at graphhopper.com | 
 **body** | [**GHMatrixRequest**](GHMatrixRequest.md)|  | [optional] 

### Return type

[**GHMatrixResponse**](GHMatrixResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

