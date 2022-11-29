using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    class VerkooporderSjablonenOperations : CrudOperationsBase<VerkooporderSjabloonModel>, IVerkooporderSjablonenOperations
    {
        public VerkooporderSjablonenOperations(ClientState clientState)
            : base(clientState, VerkooporderSjabloonModel.ResourceName)
        { }

        public Task<Response<VerkooporderSjabloonModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<VerkooporderSjabloonModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<VerkooporderSjabloonModel>(ResourceName, cancellationToken);

        public Task<Response<VerkooporderSjabloonModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<VerkooporderSjabloonModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<VerkooporderSjabloonModel>(ResourceName, queryString, cancellationToken);
    }
}
