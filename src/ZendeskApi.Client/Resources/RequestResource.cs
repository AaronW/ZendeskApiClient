﻿using System.Collections.Generic;
using ZendeskApi.Client.Http;
using ZendeskApi.Contracts.Models;
using ZendeskApi.Contracts.Requests;
using ZendeskApi.Contracts.Responses;

namespace ZendeskApi.Client.Resources
{
    public class RequestResource : ZendeskResource<Request>, IRequestResource
    {
        protected override string ResourceUri
        {
            get { return @"/api/v2/requests"; }
        }

        public RequestResource(IRestClient client)
        {
            Client = client;
        }

        public IResponse<Request> Get(long id)
        {
            return Get<RequestResponse>(id);
        }

        public IListResponse<Request> GetAll(List<long> ids)
        {
            return GetAll<RequestListResponse>(ids);
        }

        public IResponse<Request> Put(RequestRequest request)
        {
            return Put<RequestRequest, RequestResponse>(request);
        }

        public IResponse<Request> Post(RequestRequest request)
        {
            return Post<RequestRequest, RequestResponse>(request);
        }
    }
}
