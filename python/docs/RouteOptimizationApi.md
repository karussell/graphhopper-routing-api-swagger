# swagger_client.RouteOptimizationApi

All URIs are relative to *https://graphhopper.com/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](RouteOptimizationApi.md#get_solution) | **GET** /vrp/solution/{jobId} | Return the solution associated to the jobId
[**post_vrp**](RouteOptimizationApi.md#post_vrp) | **POST** /vrp/optimize | Solves vehicle routing problems


# **get_solution**
> Response get_solution(key, job_id)

Return the solution associated to the jobId

This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 

### Example 
```python
from __future__ import print_statement
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RouteOptimizationApi()
key = 'key_example' # str | your API key
job_id = 'job_id_example' # str | Request solution with jobId

try: 
    # Return the solution associated to the jobId
    api_response = api_instance.get_solution(key, job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RouteOptimizationApi->get_solution: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **str**| your API key | 
 **job_id** | **str**| Request solution with jobId | 

### Return type

[**Response**](Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **post_vrp**
> JobId post_vrp(key, body)

Solves vehicle routing problems

This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution. 

### Example 
```python
from __future__ import print_statement
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RouteOptimizationApi()
key = 'key_example' # str | your API key
body = swagger_client.Request() # Request | Request object that contains the problem to be solved

try: 
    # Solves vehicle routing problems
    api_response = api_instance.post_vrp(key, body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RouteOptimizationApi->post_vrp: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **str**| your API key | 
 **body** | [**Request**](Request.md)| Request object that contains the problem to be solved | 

### Return type

[**JobId**](JobId.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

