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
 * SWGResponse.h
 * 
 * 
 */

#ifndef SWGResponse_H_
#define SWGResponse_H_

#include <QJsonObject>


#include "SWGSolution.h"
#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGResponse: public SWGObject {
public:
    SWGResponse();
    SWGResponse(QString* json);
    virtual ~SWGResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGResponse* fromJson(QString &jsonString);

    QList<QString*>* getCopyrights();
    void setCopyrights(QList<QString*>* copyrights);

    QString* getJobId();
    void setJobId(QString* job_id);

    QString* getStatus();
    void setStatus(QString* status);

    qint64 getWaitingInQueue();
    void setWaitingInQueue(qint64 waiting_in_queue);

    qint64 getProcessingTime();
    void setProcessingTime(qint64 processing_time);

    SWGSolution* getSolution();
    void setSolution(SWGSolution* solution);


private:
    QList<QString*>* copyrights;
    QString* job_id;
    QString* status;
    qint64 waiting_in_queue;
    qint64 processing_time;
    SWGSolution* solution;
};

} /* namespace Swagger */

#endif /* SWGResponse_H_ */
