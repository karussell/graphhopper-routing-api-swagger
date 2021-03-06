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

/*
 * SWGGHIsochroneResponse.h
 * 
 * 
 */

#ifndef SWGGHIsochroneResponse_H_
#define SWGGHIsochroneResponse_H_

#include <QJsonObject>


#include "SWGGHIsochroneResponsePolygon.h"
#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGGHIsochroneResponse: public SWGObject {
public:
    SWGGHIsochroneResponse();
    SWGGHIsochroneResponse(QString* json);
    virtual ~SWGGHIsochroneResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGGHIsochroneResponse* fromJson(QString &jsonString);

    QList<SWGGHIsochroneResponsePolygon*>* getPolygons();
    void setPolygons(QList<SWGGHIsochroneResponsePolygon*>* polygons);

    QList<QString*>* getCopyrights();
    void setCopyrights(QList<QString*>* copyrights);


private:
    QList<SWGGHIsochroneResponsePolygon*>* polygons;
    QList<QString*>* copyrights;
};

} /* namespace Swagger */

#endif /* SWGGHIsochroneResponse_H_ */
