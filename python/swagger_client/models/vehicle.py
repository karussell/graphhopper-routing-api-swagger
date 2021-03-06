# coding: utf-8

"""
    GraphHopper Directions API

    With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class Vehicle(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, vehicle_id=None, type_id=None, start_address=None, end_address=None, _break=None, return_to_depot=None, earliest_start=None, latest_end=None, skills=None):
        """
        Vehicle - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'vehicle_id': 'str',
            'type_id': 'str',
            'start_address': 'Address',
            'end_address': 'Address',
            '_break': 'ModelBreak',
            'return_to_depot': 'bool',
            'earliest_start': 'int',
            'latest_end': 'int',
            'skills': 'list[str]'
        }

        self.attribute_map = {
            'vehicle_id': 'vehicle_id',
            'type_id': 'type_id',
            'start_address': 'start_address',
            'end_address': 'end_address',
            '_break': 'break',
            'return_to_depot': 'return_to_depot',
            'earliest_start': 'earliest_start',
            'latest_end': 'latest_end',
            'skills': 'skills'
        }

        self._vehicle_id = vehicle_id
        self._type_id = type_id
        self._start_address = start_address
        self._end_address = end_address
        self.__break = _break
        self._return_to_depot = return_to_depot
        self._earliest_start = earliest_start
        self._latest_end = latest_end
        self._skills = skills

    @property
    def vehicle_id(self):
        """
        Gets the vehicle_id of this Vehicle.
        Unique identifier of vehicle

        :return: The vehicle_id of this Vehicle.
        :rtype: str
        """
        return self._vehicle_id

    @vehicle_id.setter
    def vehicle_id(self, vehicle_id):
        """
        Sets the vehicle_id of this Vehicle.
        Unique identifier of vehicle

        :param vehicle_id: The vehicle_id of this Vehicle.
        :type: str
        """

        self._vehicle_id = vehicle_id

    @property
    def type_id(self):
        """
        Gets the type_id of this Vehicle.
        Unique identifier referring to the available vehicle types

        :return: The type_id of this Vehicle.
        :rtype: str
        """
        return self._type_id

    @type_id.setter
    def type_id(self, type_id):
        """
        Sets the type_id of this Vehicle.
        Unique identifier referring to the available vehicle types

        :param type_id: The type_id of this Vehicle.
        :type: str
        """

        self._type_id = type_id

    @property
    def start_address(self):
        """
        Gets the start_address of this Vehicle.

        :return: The start_address of this Vehicle.
        :rtype: Address
        """
        return self._start_address

    @start_address.setter
    def start_address(self, start_address):
        """
        Sets the start_address of this Vehicle.

        :param start_address: The start_address of this Vehicle.
        :type: Address
        """

        self._start_address = start_address

    @property
    def end_address(self):
        """
        Gets the end_address of this Vehicle.

        :return: The end_address of this Vehicle.
        :rtype: Address
        """
        return self._end_address

    @end_address.setter
    def end_address(self, end_address):
        """
        Sets the end_address of this Vehicle.

        :param end_address: The end_address of this Vehicle.
        :type: Address
        """

        self._end_address = end_address

    @property
    def _break(self):
        """
        Gets the _break of this Vehicle.

        :return: The _break of this Vehicle.
        :rtype: ModelBreak
        """
        return self.__break

    @_break.setter
    def _break(self, _break):
        """
        Sets the _break of this Vehicle.

        :param _break: The _break of this Vehicle.
        :type: ModelBreak
        """

        self.__break = _break

    @property
    def return_to_depot(self):
        """
        Gets the return_to_depot of this Vehicle.
        Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.

        :return: The return_to_depot of this Vehicle.
        :rtype: bool
        """
        return self._return_to_depot

    @return_to_depot.setter
    def return_to_depot(self, return_to_depot):
        """
        Sets the return_to_depot of this Vehicle.
        Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.

        :param return_to_depot: The return_to_depot of this Vehicle.
        :type: bool
        """

        self._return_to_depot = return_to_depot

    @property
    def earliest_start(self):
        """
        Gets the earliest_start of this Vehicle.
        earliest start of vehicle at its start location

        :return: The earliest_start of this Vehicle.
        :rtype: int
        """
        return self._earliest_start

    @earliest_start.setter
    def earliest_start(self, earliest_start):
        """
        Sets the earliest_start of this Vehicle.
        earliest start of vehicle at its start location

        :param earliest_start: The earliest_start of this Vehicle.
        :type: int
        """

        self._earliest_start = earliest_start

    @property
    def latest_end(self):
        """
        Gets the latest_end of this Vehicle.
        latest end of vehicle at its end location

        :return: The latest_end of this Vehicle.
        :rtype: int
        """
        return self._latest_end

    @latest_end.setter
    def latest_end(self, latest_end):
        """
        Sets the latest_end of this Vehicle.
        latest end of vehicle at its end location

        :param latest_end: The latest_end of this Vehicle.
        :type: int
        """

        self._latest_end = latest_end

    @property
    def skills(self):
        """
        Gets the skills of this Vehicle.
        array of skills

        :return: The skills of this Vehicle.
        :rtype: list[str]
        """
        return self._skills

    @skills.setter
    def skills(self, skills):
        """
        Sets the skills of this Vehicle.
        array of skills

        :param skills: The skills of this Vehicle.
        :type: list[str]
        """

        self._skills = skills

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
