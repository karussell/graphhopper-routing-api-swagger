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


class GHMatrixRequest(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, points=None, from_points=None, to_points=None, out_arrays=None, vehicle=None):
        """
        GHMatrixRequest - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'points': 'list[list[float]]',
            'from_points': 'str',
            'to_points': 'str',
            'out_arrays': 'list[str]',
            'vehicle': 'str'
        }

        self.attribute_map = {
            'points': 'points',
            'from_points': 'from_points',
            'to_points': 'to_points',
            'out_arrays': 'out_arrays',
            'vehicle': 'vehicle'
        }

        self._points = points
        self._from_points = from_points
        self._to_points = to_points
        self._out_arrays = out_arrays
        self._vehicle = vehicle

    @property
    def points(self):
        """
        Gets the points of this GHMatrixRequest.
        Specifiy multiple points for which the weight-, route-, time- or distance-matrix should be calculated. In this case the starts are identical to the destinations. If there are N points, then NxN entries will be calculated. The order of the point parameter is important. Specify at least three points. Cannot be used together with from_point or to_point. Is a string with the format longitude,latitude.

        :return: The points of this GHMatrixRequest.
        :rtype: list[list[float]]
        """
        return self._points

    @points.setter
    def points(self, points):
        """
        Sets the points of this GHMatrixRequest.
        Specifiy multiple points for which the weight-, route-, time- or distance-matrix should be calculated. In this case the starts are identical to the destinations. If there are N points, then NxN entries will be calculated. The order of the point parameter is important. Specify at least three points. Cannot be used together with from_point or to_point. Is a string with the format longitude,latitude.

        :param points: The points of this GHMatrixRequest.
        :type: list[list[float]]
        """

        self._points = points

    @property
    def from_points(self):
        """
        Gets the from_points of this GHMatrixRequest.
        The starting points for the routes. E.g. if you want to calculate the three routes A->1, A->2, A->3 then you have one from_point parameter and three to_point parameters. Is a string with the format longitude,latitude.

        :return: The from_points of this GHMatrixRequest.
        :rtype: str
        """
        return self._from_points

    @from_points.setter
    def from_points(self, from_points):
        """
        Sets the from_points of this GHMatrixRequest.
        The starting points for the routes. E.g. if you want to calculate the three routes A->1, A->2, A->3 then you have one from_point parameter and three to_point parameters. Is a string with the format longitude,latitude.

        :param from_points: The from_points of this GHMatrixRequest.
        :type: str
        """

        self._from_points = from_points

    @property
    def to_points(self):
        """
        Gets the to_points of this GHMatrixRequest.
        The destination points for the routes. Is a string with the format longitude,latitude.

        :return: The to_points of this GHMatrixRequest.
        :rtype: str
        """
        return self._to_points

    @to_points.setter
    def to_points(self, to_points):
        """
        Sets the to_points of this GHMatrixRequest.
        The destination points for the routes. Is a string with the format longitude,latitude.

        :param to_points: The to_points of this GHMatrixRequest.
        :type: str
        """

        self._to_points = to_points

    @property
    def out_arrays(self):
        """
        Gets the out_arrays of this GHMatrixRequest.
        pecifies which arrays should be included in the response. Specify one or more of the following options 'weights', 'times', 'distances'. To specify more than one array use e.g. out_array=times&out_array=distances. The units of the entries of distances are meters, of times are seconds and of weights is arbitrary and it can differ for different vehicles or versions of this API.

        :return: The out_arrays of this GHMatrixRequest.
        :rtype: list[str]
        """
        return self._out_arrays

    @out_arrays.setter
    def out_arrays(self, out_arrays):
        """
        Sets the out_arrays of this GHMatrixRequest.
        pecifies which arrays should be included in the response. Specify one or more of the following options 'weights', 'times', 'distances'. To specify more than one array use e.g. out_array=times&out_array=distances. The units of the entries of distances are meters, of times are seconds and of weights is arbitrary and it can differ for different vehicles or versions of this API.

        :param out_arrays: The out_arrays of this GHMatrixRequest.
        :type: list[str]
        """

        self._out_arrays = out_arrays

    @property
    def vehicle(self):
        """
        Gets the vehicle of this GHMatrixRequest.
        The vehicle for which the route should be calculated. Other vehicles are foot, bike, mtb, racingbike, motorcycle, small_truck, bus and truck. See here for the details.

        :return: The vehicle of this GHMatrixRequest.
        :rtype: str
        """
        return self._vehicle

    @vehicle.setter
    def vehicle(self, vehicle):
        """
        Sets the vehicle of this GHMatrixRequest.
        The vehicle for which the route should be calculated. Other vehicles are foot, bike, mtb, racingbike, motorcycle, small_truck, bus and truck. See here for the details.

        :param vehicle: The vehicle of this GHMatrixRequest.
        :type: str
        """

        self._vehicle = vehicle

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
