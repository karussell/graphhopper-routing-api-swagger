=begin
#GraphHopper Directions API

#With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::GHIsochroneResponse
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'GHIsochroneResponse' do
  before do
    # run before each test
    @instance = SwaggerClient::GHIsochroneResponse.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of GHIsochroneResponse' do
    it 'should create an instact of GHIsochroneResponse' do
      expect(@instance).to be_instance_of(SwaggerClient::GHIsochroneResponse)
    end
  end
  describe 'test attribute "polygons"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "copyrights"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

