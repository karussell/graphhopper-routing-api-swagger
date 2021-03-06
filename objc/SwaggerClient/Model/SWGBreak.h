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




@protocol SWGBreak
@end

@interface SWGBreak : SWGObject

/* earliest start of break [optional]
 */
@property(nonatomic) NSNumber* earliest;
/* latest start of break [optional]
 */
@property(nonatomic) NSNumber* latest;
/* duration of break [optional]
 */
@property(nonatomic) NSNumber* duration;
/* max driving time without break [optional]
 */
@property(nonatomic) NSNumber* maxDrivingTime;
/* initial driving time, i.e. the time your driver has already spent for driving [optional]
 */
@property(nonatomic) NSNumber* initialDrivingTime;
/* array of splits [optional]
 */
@property(nonatomic) NSArray<NSNumber*>* possibleSplit;

@end
