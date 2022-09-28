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
    ///  Class for testing PurchaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PurchaseApiTests : IDisposable
    {
        private PurchaseApi instance;

        public PurchaseApiTests()
        {
            instance = new PurchaseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PurchaseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PurchaseApi
            //Assert.IsType<PurchaseApi>(instance);
        }

        /// <summary>
        /// Test PurchaseActorCreate
        /// </summary>
        [Fact]
        public void PurchaseActorCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //SimpleDocument simpleDocument = null;
            //var response = instance.PurchaseActorCreate(culture, simpleDocument);
            //Assert.IsType<MessageSent>(response);
        }

        /// <summary>
        /// Test PurchaseActorCreateInline
        /// </summary>
        [Fact]
        public void PurchaseActorCreateInlineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string culture = null;
            //InlineDocument inlineDocument = null;
            //var response = instance.PurchaseActorCreateInline(culture, inlineDocument);
            //Assert.IsType<MessageSent>(response);
        }

        /// <summary>
        /// Test PurchaseChangeStatusByKey
        /// </summary>
        [Fact]
        public void PurchaseChangeStatusByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long documentId = null;
            //string statusKey = null;
            //string culture = null;
            //var response = instance.PurchaseChangeStatusByKey(documentId, statusKey, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseDelete
        /// </summary>
        [Fact]
        public void PurchaseDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //var response = instance.PurchaseDelete(id, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseDetails
        /// </summary>
        [Fact]
        public void PurchaseDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //var response = instance.PurchaseDetails(id, culture);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseEdit
        /// </summary>
        [Fact]
        public void PurchaseEditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //SimpleDocument simpleDocument = null;
            //var response = instance.PurchaseEdit(id, culture, simpleDocument);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseEdit2
        /// </summary>
        [Fact]
        public void PurchaseEdit2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //InlineDocument inlineDocument = null;
            //var response = instance.PurchaseEdit2(id, culture, inlineDocument);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseIndex
        /// </summary>
        [Fact]
        public void PurchaseIndexTest()
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
            //var response = instance.PurchaseIndex(culture, sortBy, currentPage, pageSize, filter, searchString, customDocumentModels, range, month, year, startDate, endDate);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test PurchaseReceivePayment
        /// </summary>
        [Fact]
        public void PurchaseReceivePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string culture = null;
            //PaymentModel paymentModel = null;
            //var response = instance.PurchaseReceivePayment(id, culture, paymentModel);
            //Assert.IsType<System.IO.Stream>(response);
        }
    }
}
