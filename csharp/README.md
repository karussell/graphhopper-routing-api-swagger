# IO.Swagger - the C# library for the GraphHopper Directions API

With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new GeocodingApi();
            var key = key_example;  // string | Get your key at graphhopper.com
            var q = q_example;  // string | If you do forward geocoding, then this would be a textual description of the adress you are looking for. If you do reverse geocoding this would be in lat,lon. (optional) 
            var locale = locale_example;  // string | Display the search results for the specified locale. Currently French (fr), English (en), German (de) and Italian (it) are supported. If the locale wasn't found the default (en) is used. (optional) 
            var limit = 56;  // int? | Specify the maximum number of returned results (optional) 
            var reverse = true;  // bool? | Set to true to do a reverse Geocoding request (optional) 
            var point = point_example;  // string | The location bias in the format 'latitude,longitude' e.g. point=45.93272,11.58803 (optional) 
            var provider = provider_example;  // string | Can be either, default, nominatim, opencagedata (optional) 

            try
            {
                // Execute a Geocoding request
                GHGeocodingResponse result = apiInstance.GeocodeGet(key, q, locale, limit, reverse, point, provider);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeocodingApi.GeocodeGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://graphhopper.com/api/1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*GeocodingApi* | [**GeocodeGet**](docs/GeocodingApi.md#geocodeget) | **GET** /geocode | Execute a Geocoding request
*IsochroneApi* | [**IsochroneGet**](docs/IsochroneApi.md#isochroneget) | **GET** /isochrone | Isochrone Request
*MatrixApi* | [**MatrixGet**](docs/MatrixApi.md#matrixget) | **GET** /matrix | Matrix API
*MatrixApi* | [**MatrixPost**](docs/MatrixApi.md#matrixpost) | **POST** /matrix | Matrix API Post
*RouteOptimizationApi* | [**GetSolution**](docs/RouteOptimizationApi.md#getsolution) | **GET** /vrp/solution/{jobId} | Return the solution associated to the jobId
*RouteOptimizationApi* | [**PostVrp**](docs/RouteOptimizationApi.md#postvrp) | **POST** /vrp/optimize | Solves vehicle routing problems
*RoutingApi* | [**RouteGet**](docs/RoutingApi.md#routeget) | **GET** /route | Routing Request


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Activity](docs/Activity.md)
 - [Model.Address](docs/Address.md)
 - [Model.Algorithm](docs/Algorithm.md)
 - [Model.CostMatrix](docs/CostMatrix.md)
 - [Model.GHError](docs/GHError.md)
 - [Model.GHErrorHints](docs/GHErrorHints.md)
 - [Model.GHGeocodingLocation](docs/GHGeocodingLocation.md)
 - [Model.GHGeocodingPoint](docs/GHGeocodingPoint.md)
 - [Model.GHGeocodingResponse](docs/GHGeocodingResponse.md)
 - [Model.GHIsochroneResponse](docs/GHIsochroneResponse.md)
 - [Model.GHIsochroneResponsePolygon](docs/GHIsochroneResponsePolygon.md)
 - [Model.GHIsochroneResponsePolygonGeometry](docs/GHIsochroneResponsePolygonGeometry.md)
 - [Model.GHIsochroneResponsePolygonProperties](docs/GHIsochroneResponsePolygonProperties.md)
 - [Model.GHMatrixRequest](docs/GHMatrixRequest.md)
 - [Model.GHMatrixResponse](docs/GHMatrixResponse.md)
 - [Model.GHResponseCoordinates](docs/GHResponseCoordinates.md)
 - [Model.GHResponseCoordinatesArray](docs/GHResponseCoordinatesArray.md)
 - [Model.GHResponseInfo](docs/GHResponseInfo.md)
 - [Model.GHResponseInstruction](docs/GHResponseInstruction.md)
 - [Model.GHResponseInstructions](docs/GHResponseInstructions.md)
 - [Model.GHRouteResponse](docs/GHRouteResponse.md)
 - [Model.GHRouteResponsePath](docs/GHRouteResponsePath.md)
 - [Model.JobId](docs/JobId.md)
 - [Model.ModelBreak](docs/ModelBreak.md)
 - [Model.Objective](docs/Objective.md)
 - [Model.Relation](docs/Relation.md)
 - [Model.Request](docs/Request.md)
 - [Model.Response](docs/Response.md)
 - [Model.Route](docs/Route.md)
 - [Model.Service](docs/Service.md)
 - [Model.Shipment](docs/Shipment.md)
 - [Model.Solution](docs/Solution.md)
 - [Model.SolutionUnassigned](docs/SolutionUnassigned.md)
 - [Model.Stop](docs/Stop.md)
 - [Model.TimeWindow](docs/TimeWindow.md)
 - [Model.Vehicle](docs/Vehicle.md)
 - [Model.VehicleType](docs/VehicleType.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api_key"></a>
### api_key

- **Type**: API key
- **API key parameter name**: key
- **Location**: URL query string

