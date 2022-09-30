=begin
#FlowAccount Open API

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.4.0

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::ReceiptApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'ReceiptApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::ReceiptApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ReceiptApi' do
    it 'should create an instance of ReceiptApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::ReceiptApi)
    end
  end

  # unit tests for receipt_change_status_by_key
  # To change status by the document id and key
  # @param document_id 
  # @param status_key 
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_change_status_by_key test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_create
  # To Create a document with SimpleDocument as the parameter
  # @param culture 
  # @param simple_document 
  # @param [Hash] opts the optional parameters
  # @return [MessageSent]
  describe 'receipt_create test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_create2
  # To Create a document with InlineDocument as the parameter
  # @param culture 
  # @param inline_document 
  # @param [Hash] opts the optional parameters
  # @return [MessageSent]
  describe 'receipt_create2 test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_delete
  # To delete the document given a list of documentids
  # @param id 
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_details
  # To get details of a document
  # @param id Sql DocumentId
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_details test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_edit
  # To Update a document with simpleDocument as the parameter
  # @param id 
  # @param culture 
  # @param simple_document 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_edit test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_edit2
  # To Update a document with inlineDocument as the parameter
  # @param id 
  # @param culture 
  # @param inline_document 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_edit2 test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_get_business_categories
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_get_business_categories test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_get_chart_of_accounts
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_get_chart_of_accounts test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_index
  # To query for documents.
  # @param culture 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort_by 
  # @option opts [String] :current_page 
  # @option opts [String] :page_size 
  # @option opts [String] :filter 
  # @option opts [String] :search_string 
  # @option opts [String] :custom_document_models 
  # @option opts [String] :range 
  # @option opts [String] :month 
  # @option opts [String] :year 
  # @option opts [String] :start_date 
  # @option opts [String] :end_date 
  # @return [File]
  describe 'receipt_index test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for receipt_receive_payment
  # To Accept payment with the paymentModel
  # @param id 
  # @param culture 
  # @param payment_model 
  # @param [Hash] opts the optional parameters
  # @return [File]
  describe 'receipt_receive_payment test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
