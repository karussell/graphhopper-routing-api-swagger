
#include "SamiGHResponseInstruction.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiGHResponseInstruction::SamiGHResponseInstruction() {
    init();
}

SamiGHResponseInstruction::~SamiGHResponseInstruction() {
    this->cleanup();
}

void
SamiGHResponseInstruction::init() {
    pText = null;
pDistance = null;
pTime = null;
pInterval = null;
pSign = null;
pAnnotation_text = null;
pAnnotation_importance = null;
pExit_number = null;
pTurn_angle = null;
}

void
SamiGHResponseInstruction::cleanup() {
    if(pText != null) {
        
        delete pText;
        pText = null;
    }
if(pDistance != null) {
        
        delete pDistance;
        pDistance = null;
    }
if(pTime != null) {
        
        delete pTime;
        pTime = null;
    }
if(pInterval != null) {
        pInterval->RemoveAll(true);
        delete pInterval;
        pInterval = null;
    }
if(pSign != null) {
        
        delete pSign;
        pSign = null;
    }
if(pAnnotation_text != null) {
        
        delete pAnnotation_text;
        pAnnotation_text = null;
    }
if(pAnnotation_importance != null) {
        
        delete pAnnotation_importance;
        pAnnotation_importance = null;
    }
if(pExit_number != null) {
        
        delete pExit_number;
        pExit_number = null;
    }
if(pTurn_angle != null) {
        
        delete pTurn_angle;
        pTurn_angle = null;
    }
}


SamiGHResponseInstruction*
SamiGHResponseInstruction::fromJson(String* json) {
    this->cleanup();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
    return this;
}


void
SamiGHResponseInstruction::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pTextKey = new JsonString(L"text");
        IJsonValue* pTextVal = null;
        pJsonObject->GetValue(pTextKey, pTextVal);
        if(pTextVal != null) {
            
            pText = new String();
            jsonToValue(pText, pTextVal, L"String", L"String");
        }
        delete pTextKey;
JsonString* pDistanceKey = new JsonString(L"distance");
        IJsonValue* pDistanceVal = null;
        pJsonObject->GetValue(pDistanceKey, pDistanceVal);
        if(pDistanceVal != null) {
            
            pDistance = new Double();
            jsonToValue(pDistance, pDistanceVal, L"Double", L"Double");
        }
        delete pDistanceKey;
JsonString* pTimeKey = new JsonString(L"time");
        IJsonValue* pTimeVal = null;
        pJsonObject->GetValue(pTimeKey, pTimeVal);
        if(pTimeVal != null) {
            
            pTime = new Integer();
            jsonToValue(pTime, pTimeVal, L"Integer", L"Integer");
        }
        delete pTimeKey;
JsonString* pIntervalKey = new JsonString(L"interval");
        IJsonValue* pIntervalVal = null;
        pJsonObject->GetValue(pIntervalKey, pIntervalVal);
        if(pIntervalVal != null) {
            pInterval = new ArrayList();
            
            jsonToValue(pInterval, pIntervalVal, L"IList", L"Integer");
        }
        delete pIntervalKey;
JsonString* pSignKey = new JsonString(L"sign");
        IJsonValue* pSignVal = null;
        pJsonObject->GetValue(pSignKey, pSignVal);
        if(pSignVal != null) {
            
            pSign = new Integer();
            jsonToValue(pSign, pSignVal, L"Integer", L"Integer");
        }
        delete pSignKey;
JsonString* pAnnotation_textKey = new JsonString(L"annotation_text");
        IJsonValue* pAnnotation_textVal = null;
        pJsonObject->GetValue(pAnnotation_textKey, pAnnotation_textVal);
        if(pAnnotation_textVal != null) {
            
            pAnnotation_text = new String();
            jsonToValue(pAnnotation_text, pAnnotation_textVal, L"String", L"String");
        }
        delete pAnnotation_textKey;
JsonString* pAnnotation_importanceKey = new JsonString(L"annotation_importance");
        IJsonValue* pAnnotation_importanceVal = null;
        pJsonObject->GetValue(pAnnotation_importanceKey, pAnnotation_importanceVal);
        if(pAnnotation_importanceVal != null) {
            
            pAnnotation_importance = new Integer();
            jsonToValue(pAnnotation_importance, pAnnotation_importanceVal, L"Integer", L"Integer");
        }
        delete pAnnotation_importanceKey;
JsonString* pExit_numberKey = new JsonString(L"exit_number");
        IJsonValue* pExit_numberVal = null;
        pJsonObject->GetValue(pExit_numberKey, pExit_numberVal);
        if(pExit_numberVal != null) {
            
            pExit_number = new Integer();
            jsonToValue(pExit_number, pExit_numberVal, L"Integer", L"Integer");
        }
        delete pExit_numberKey;
JsonString* pTurn_angleKey = new JsonString(L"turn_angle");
        IJsonValue* pTurn_angleVal = null;
        pJsonObject->GetValue(pTurn_angleKey, pTurn_angleVal);
        if(pTurn_angleVal != null) {
            
            pTurn_angle = new Double();
            jsonToValue(pTurn_angle, pTurn_angleVal, L"Double", L"Double");
        }
        delete pTurn_angleKey;
    }
}

SamiGHResponseInstruction::SamiGHResponseInstruction(String* json) {
    init();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
}

String
SamiGHResponseInstruction::asJson ()
{
    JsonObject* pJsonObject = asJsonObject();

    char *pComposeBuf = new char[256];
    JsonWriter::Compose(pJsonObject, pComposeBuf, 256);
    String s = String(pComposeBuf);

    delete pComposeBuf;
    pJsonObject->RemoveAll(true);
    delete pJsonObject;

    return s;
}

JsonObject*
SamiGHResponseInstruction::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    JsonString *pTextKey = new JsonString(L"text");
    pJsonObject->Add(pTextKey, toJson(getPText(), "String", ""));

    JsonString *pDistanceKey = new JsonString(L"distance");
    pJsonObject->Add(pDistanceKey, toJson(getPDistance(), "Double", ""));

    JsonString *pTimeKey = new JsonString(L"time");
    pJsonObject->Add(pTimeKey, toJson(getPTime(), "Integer", ""));

    JsonString *pIntervalKey = new JsonString(L"interval");
    pJsonObject->Add(pIntervalKey, toJson(getPInterval(), "Integer", "array"));

    JsonString *pSignKey = new JsonString(L"sign");
    pJsonObject->Add(pSignKey, toJson(getPSign(), "Integer", ""));

    JsonString *pAnnotation_textKey = new JsonString(L"annotation_text");
    pJsonObject->Add(pAnnotation_textKey, toJson(getPAnnotationText(), "String", ""));

    JsonString *pAnnotation_importanceKey = new JsonString(L"annotation_importance");
    pJsonObject->Add(pAnnotation_importanceKey, toJson(getPAnnotationImportance(), "Integer", ""));

    JsonString *pExit_numberKey = new JsonString(L"exit_number");
    pJsonObject->Add(pExit_numberKey, toJson(getPExitNumber(), "Integer", ""));

    JsonString *pTurn_angleKey = new JsonString(L"turn_angle");
    pJsonObject->Add(pTurn_angleKey, toJson(getPTurnAngle(), "Double", ""));

    return pJsonObject;
}

String*
SamiGHResponseInstruction::getPText() {
    return pText;
}
void
SamiGHResponseInstruction::setPText(String* pText) {
    this->pText = pText;
}

Double*
SamiGHResponseInstruction::getPDistance() {
    return pDistance;
}
void
SamiGHResponseInstruction::setPDistance(Double* pDistance) {
    this->pDistance = pDistance;
}

Integer*
SamiGHResponseInstruction::getPTime() {
    return pTime;
}
void
SamiGHResponseInstruction::setPTime(Integer* pTime) {
    this->pTime = pTime;
}

IList*
SamiGHResponseInstruction::getPInterval() {
    return pInterval;
}
void
SamiGHResponseInstruction::setPInterval(IList* pInterval) {
    this->pInterval = pInterval;
}

Integer*
SamiGHResponseInstruction::getPSign() {
    return pSign;
}
void
SamiGHResponseInstruction::setPSign(Integer* pSign) {
    this->pSign = pSign;
}

String*
SamiGHResponseInstruction::getPAnnotationText() {
    return pAnnotation_text;
}
void
SamiGHResponseInstruction::setPAnnotationText(String* pAnnotation_text) {
    this->pAnnotation_text = pAnnotation_text;
}

Integer*
SamiGHResponseInstruction::getPAnnotationImportance() {
    return pAnnotation_importance;
}
void
SamiGHResponseInstruction::setPAnnotationImportance(Integer* pAnnotation_importance) {
    this->pAnnotation_importance = pAnnotation_importance;
}

Integer*
SamiGHResponseInstruction::getPExitNumber() {
    return pExit_number;
}
void
SamiGHResponseInstruction::setPExitNumber(Integer* pExit_number) {
    this->pExit_number = pExit_number;
}

Double*
SamiGHResponseInstruction::getPTurnAngle() {
    return pTurn_angle;
}
void
SamiGHResponseInstruction::setPTurnAngle(Double* pTurn_angle) {
    this->pTurn_angle = pTurn_angle;
}



} /* namespace Swagger */

