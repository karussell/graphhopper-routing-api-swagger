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
 * SWGGHResponseInstruction.h
 * 
 * 
 */

#ifndef SWGGHResponseInstruction_H_
#define SWGGHResponseInstruction_H_

#include <QJsonObject>


#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGGHResponseInstruction: public SWGObject {
public:
    SWGGHResponseInstruction();
    SWGGHResponseInstruction(QString* json);
    virtual ~SWGGHResponseInstruction();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGGHResponseInstruction* fromJson(QString &jsonString);

    QString* getText();
    void setText(QString* text);

    double getDistance();
    void setDistance(double distance);

    qint32 getTime();
    void setTime(qint32 time);

    QList<qint32>* getInterval();
    void setInterval(QList<qint32>* interval);

    qint32 getSign();
    void setSign(qint32 sign);

    QString* getAnnotationText();
    void setAnnotationText(QString* annotation_text);

    qint32 getAnnotationImportance();
    void setAnnotationImportance(qint32 annotation_importance);

    qint32 getExitNumber();
    void setExitNumber(qint32 exit_number);

    double getTurnAngle();
    void setTurnAngle(double turn_angle);


private:
    QString* text;
    double distance;
    qint32 time;
    QList<qint32>* interval;
    qint32 sign;
    QString* annotation_text;
    qint32 annotation_importance;
    qint32 exit_number;
    double turn_angle;
};

} /* namespace Swagger */

#endif /* SWGGHResponseInstruction_H_ */
