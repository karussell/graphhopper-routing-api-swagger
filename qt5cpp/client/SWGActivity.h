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
 * SWGActivity.h
 * 
 * 
 */

#ifndef SWGActivity_H_
#define SWGActivity_H_

#include <QJsonObject>


#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGActivity: public SWGObject {
public:
    SWGActivity();
    SWGActivity(QString* json);
    virtual ~SWGActivity();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGActivity* fromJson(QString &jsonString);

    QString* getType();
    void setType(QString* type);

    QString* getId();
    void setId(QString* id);

    QString* getLocationId();
    void setLocationId(QString* location_id);

    qint64 getArrTime();
    void setArrTime(qint64 arr_time);

    qint64 getEndTime();
    void setEndTime(qint64 end_time);

    qint64 getWaitingTime();
    void setWaitingTime(qint64 waiting_time);

    qint64 getDistance();
    void setDistance(qint64 distance);

    qint64 getDrivingTime();
    void setDrivingTime(qint64 driving_time);

    QList<qint32>* getLoadBefore();
    void setLoadBefore(QList<qint32>* load_before);

    QList<qint32>* getLoadAfter();
    void setLoadAfter(QList<qint32>* load_after);


private:
    QString* type;
    QString* id;
    QString* location_id;
    qint64 arr_time;
    qint64 end_time;
    qint64 waiting_time;
    qint64 distance;
    qint64 driving_time;
    QList<qint32>* load_before;
    QList<qint32>* load_after;
};

} /* namespace Swagger */

#endif /* SWGActivity_H_ */
