using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class VerkoopboekingBijlagesOperations : CrudOperationsBase<VerkoopBoekingBijlageContentModel>, 
        IVerkoopboekingBijlagesOperations
    {
        public VerkoopboekingBijlagesOperations(ClientState clientState)
            : base(clientState, VerkoopBoekingBijlageContentModel.ResourceName)
        { }

        public Task<Response<VerkoopBoekingBijlageContentModel[]>> GetAllAsync(Guid parentId) => GetAllAsync(parentId, CancellationToken.None);
        public Task<Response<VerkoopBoekingBijlageContentModel[]>> GetAllAsync(Guid parentId, CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<VerkoopBoekingBijlageContentModel>(GetAllUri(parentId), cancellationToken);

        private string GetAllUri(Guid parentId)
        {
            return $"{VerkoopBoekingBijlageContentModel.ResourceName}/{parentId}";
        }
    }
}