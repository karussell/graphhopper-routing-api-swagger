#import <Foundation/Foundation.h>
#import "SWGObject.h"

/**
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


#import "SWGAlgorithm.h"
#import "SWGCostMatrix.h"
#import "SWGObjective.h"
#import "SWGRelation.h"
#import "SWGService.h"
#import "SWGShipment.h"
#import "SWGVehicle.h"
#import "SWGVehicleType.h"


@protocol SWGRequest
@end

@interface SWGRequest : SWGObject

/* An array of vehicles that can be employed [optional]
 */
@property(nonatomic) NSArray<SWGVehicle>* vehicles;
/* An array of vehicle types [optional]
 */
@property(nonatomic) NSArray<SWGVehicleType>* vehicleTypes;
/* An array of services [optional]
 */
@property(nonatomic) NSArray<SWGService>* services;
/* An array of shipments [optional]
 */
@property(nonatomic) NSArray<SWGShipment>* shipments;
/* An array of relations [optional]
 */
@property(nonatomic) NSArray<SWGRelation>* relations;

@property(nonatomic) SWGAlgorithm* algorithm;
/* An array of objectives [optional]
 */
@property(nonatomic) NSArray<SWGObjective>* objectives;
/* An array of cost matrices [optional]
 */
@property(nonatomic) NSArray<SWGCostMatrix>* costMatrices;

@end
