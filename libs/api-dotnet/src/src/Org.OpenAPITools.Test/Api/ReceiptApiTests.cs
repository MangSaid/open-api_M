/*
 * FlowAccount Open API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing ReceiptApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReceiptApiTests : IDisposable
    {
        private ReceiptApi instance;

        public ReceiptApiTests()
        {
            instance = new ReceiptApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReceiptApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReceiptApi
            //Assert.IsType<ReceiptApi>(instance);
        }

        /// <summary>
        /// Test ReceiptActorCreate
        /// </summary>
        [Fact]
        public void ReceiptActorCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //SimpleDocument simpleDocument = null;
            //var response = instance.ReceiptActorCreate(culture, simpleDocument);
            //Assert.IsType<MessageSent>(response);
        }

        /// <summary>
        /// Test ReceiptActorCreateInline
        /// </summary>
        [Fact]
        public void ReceiptActorCreateInlineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //InlineDocument inlineDocument = null;
            //var response = instance.ReceiptActorCreateInline(culture, inlineDocument);
            //Assert.IsType<MessageSent>(response);
        }

        /// <summary>
        /// Test ReceiptChangeStatusByKey
        /// </summary>
        [Fact]
        public void ReceiptChangeStatusByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long documentId = null;
            //string statusKey = null;
            //string culture = null;
            //var response = instance.ReceiptChangeStatusByKey(documentId, statusKey, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptDelete
        /// </summary>
        [Fact]
        public void ReceiptDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //var response = instance.ReceiptDelete(id, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptDetails
        /// </summary>
        [Fact]
        public void ReceiptDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //var response = instance.ReceiptDetails(id, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptEdit
        /// </summary>
        [Fact]
        public void ReceiptEditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //SimpleDocument simpleDocument = null;
            //var response = instance.ReceiptEdit(id, culture, simpleDocument);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptEdit2
        /// </summary>
        [Fact]
        public void ReceiptEdit2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //InlineDocument inlineDocument = null;
            //var response = instance.ReceiptEdit2(id, culture, inlineDocument);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptGetBusinessCategories
        /// </summary>
        [Fact]
        public void ReceiptGetBusinessCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //var response = instance.ReceiptGetBusinessCategories(culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptGetChartOfAccounts
        /// </summary>
        [Fact]
        public void ReceiptGetChartOfAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //var response = instance.ReceiptGetChartOfAccounts(culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptIndex
        /// </summary>
        [Fact]
        public void ReceiptIndexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //string sortBy = null;
            //string currentPage = null;
            //string pageSize = null;
            //string filter = null;
            //string searchString = null;
            //string customDocumentModels = null;
            //string range = null;
            //string month = null;
            //string year = null;
            //string startDate = null;
            //string endDate = null;
            //var response = instance.ReceiptIndex(culture, sortBy, currentPage, pageSize, filter, searchString, customDocumentModels, range, month, year, startDate, endDate);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ReceiptReceivePayment
        /// </summary>
        [Fact]
        public void ReceiptReceivePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //PaymentModel paymentModel = null;
            //var response = instance.ReceiptReceivePayment(id, culture, paymentModel);
            //Assert.IsType<System.IO.Stream>(response);
        }
    }
}
