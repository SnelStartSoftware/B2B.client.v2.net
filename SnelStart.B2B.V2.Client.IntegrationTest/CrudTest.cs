﻿using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using SnelStart.B2B.V2.Client.Operations;

namespace SnelStart.B2B.V2.Client.IntegrationTest
{
    public abstract class CrudTest<T> where T : IIdentifierModel
    {
        protected abstract Task<T> CreateNewModelAsync();

        protected abstract ICrudOperations<T> CrudSubject { get; }

        [Test]
        public async Task DeleteAsync()
        {
            var createResponse = await SetupCreatedAsync();

            var deleteResponse = await CrudSubject.DeleteAsync(createResponse.Result.Id);
            var getByIdResponse = await CrudSubject.GetByIdAsync(createResponse.Result.Id);

            Assert.AreEqual(HttpStatusCode.OK, deleteResponse.HttpStatusCode);
            Assert.AreEqual(HttpStatusCode.NotFound, getByIdResponse.HttpStatusCode);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            var createResponse = await SetupCreatedAsync();

            try
            {
                var getByIdResponse = await CrudSubject.GetByIdAsync(createResponse.Result.Id);
                Assert.AreEqual(HttpStatusCode.OK, getByIdResponse.HttpStatusCode);
            }
            finally
            {
                await CrudSubject.DeleteAsync(createResponse.Result.Id);
            }
        }

        [Test]
        public async Task UpdateAsync()
        {
            var createResponse = await SetupCreatedAsync();

            var createdModel = createResponse.Result;
            try
            {
                var updateResponse = await CrudSubject.UpdateAsync(createdModel);

                Assert.AreEqual(HttpStatusCode.OK, updateResponse.HttpStatusCode);
            }
            finally
            {
                await CrudSubject.DeleteAsync(createdModel.Id);
            }
        }

        private async Task<Response<T>> SetupCreatedAsync()
        {
            var dto = await CreateNewModelAsync();

            var createResponse = await CrudSubject.CreateAsync(dto);
            if (createResponse.HttpStatusCode != HttpStatusCode.Created)
            {
                Assert.Inconclusive($"dto not created Status {createResponse.HttpStatusCode}, Response:\r\n{createResponse.ResponseBody}");
            }
            return createResponse;
        }
    }
}