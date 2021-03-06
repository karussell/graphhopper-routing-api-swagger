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
 * SWGGHError.h
 * 
 * 
 */

#ifndef SWGGHError_H_
#define SWGGHError_H_

#include <QJsonObject>


#include "SWGGHError_hints.h"
#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGGHError: public SWGObject {
public:
    SWGGHError();
    SWGGHError(QString* json);
    virtual ~SWGGHError();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGGHError* fromJson(QString &jsonString);

    qint32 getCode();
    void setCode(qint32 code);

    QString* getMessage();
    void setMessage(QString* message);

    QList<SWGGHError_hints*>* getHints();
    void setHints(QList<SWGGHError_hints*>* hints);


private:
    qint32 code;
    QString* message;
    QList<SWGGHError_hints*>* hints;
};

} /* namespace Swagger */

#endif /* SWGGHError_H_ */
