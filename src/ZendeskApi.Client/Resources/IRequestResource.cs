using System.Collections.Generic;
using ZendeskApi.Contracts.Models;
using ZendeskApi.Contracts.Requests;
using ZendeskApi.Contracts.Responses;

namespace ZendeskApi.Client.Resources
{
    public interface IRequestResource
    {
        IResponse<Request> Get(long id);
        IListResponse<Request> GetAll(List<long> ids);
        IResponse<Request> Put(RequestRequest request);
        IResponse<Request> Post(RequestRequest request);
        void Delete(long id);
    }
}
