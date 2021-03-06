# coding: utf-8

"""
    GraphHopper Directions API

    With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import sys
import os
import re

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class GeocodingApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def geocode_get(self, key, **kwargs):
        """
        Execute a Geocoding request
        This endpoint provides forward and reverse geocoding. For more details, review the official documentation at: https://graphhopper.com/api/1/docs/geocoding/ 
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.geocode_get(key, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str key: Get your key at graphhopper.com (required)
        :param str q: If you do forward geocoding, then this would be a textual description of the adress you are looking for. If you do reverse geocoding this would be in lat,lon.
        :param str locale: Display the search results for the specified locale. Currently French (fr), English (en), German (de) and Italian (it) are supported. If the locale wasn't found the default (en) is used.
        :param int limit: Specify the maximum number of returned results
        :param bool reverse: Set to true to do a reverse Geocoding request
        :param str point: The location bias in the format 'latitude,longitude' e.g. point=45.93272,11.58803
        :param str provider: Can be either, default, nominatim, opencagedata
        :return: GHGeocodingResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.geocode_get_with_http_info(key, **kwargs)
        else:
            (data) = self.geocode_get_with_http_info(key, **kwargs)
            return data

    def geocode_get_with_http_info(self, key, **kwargs):
        """
        Execute a Geocoding request
        This endpoint provides forward and reverse geocoding. For more details, review the official documentation at: https://graphhopper.com/api/1/docs/geocoding/ 
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.geocode_get_with_http_info(key, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str key: Get your key at graphhopper.com (required)
        :param str q: If you do forward geocoding, then this would be a textual description of the adress you are looking for. If you do reverse geocoding this would be in lat,lon.
        :param str locale: Display the search results for the specified locale. Currently French (fr), English (en), German (de) and Italian (it) are supported. If the locale wasn't found the default (en) is used.
        :param int limit: Specify the maximum number of returned results
        :param bool reverse: Set to true to do a reverse Geocoding request
        :param str point: The location bias in the format 'latitude,longitude' e.g. point=45.93272,11.58803
        :param str provider: Can be either, default, nominatim, opencagedata
        :return: GHGeocodingResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['key', 'q', 'locale', 'limit', 'reverse', 'point', 'provider']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method geocode_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'key' is set
        if ('key' not in params) or (params['key'] is None):
            raise ValueError("Missing the required parameter `key` when calling `geocode_get`")


        collection_formats = {}

        resource_path = '/geocode'.replace('{format}', 'json')
        path_params = {}

        query_params = {}
        if 'q' in params:
            query_params['q'] = params['q']
        if 'locale' in params:
            query_params['locale'] = params['locale']
        if 'limit' in params:
            query_params['limit'] = params['limit']
        if 'reverse' in params:
            query_params['reverse'] = params['reverse']
        if 'point' in params:
            query_params['point'] = params['point']
        if 'provider' in params:
            query_params['provider'] = params['provider']
        if 'key' in params:
            query_params['key'] = params['key']

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # Authentication setting
        auth_settings = []

        return self.api_client.call_api(resource_path, 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='GHGeocodingResponse',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)
