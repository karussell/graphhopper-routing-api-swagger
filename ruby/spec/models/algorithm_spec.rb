=begin
#GraphHopper Directions API

#With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::Algorithm
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'Algorithm' do
  before do
    # run before each test
    @instance = SwaggerClient::Algorithm.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of Algorithm' do
    it 'should create an instact of Algorithm' do
      expect(@instance).to be_instance_of(SwaggerClient::Algorithm)
    end
  end
  describe 'test attribute "problem_type"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
       #validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["min", "min-max"])
       #validator.allowable_values.each do |value|
       #  expect { @instance.problem_type = value }.not_to raise_error
       #end
    end
  end

  describe 'test attribute "objective"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
       #validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["transport_time", "completion_time"])
       #validator.allowable_values.each do |value|
       #  expect { @instance.objective = value }.not_to raise_error
       #end
    end
  end

end

