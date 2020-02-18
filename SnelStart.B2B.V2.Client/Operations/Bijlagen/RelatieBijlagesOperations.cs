using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class RelatieBijlagesOperations : CrudOperationsBase<RelatieBijlageContentModel>,
        IRelatieBijlagesOperations
    {
        public RelatieBijlagesOperations(ClientState clientState)
            : base(clientState, RelatieBijlageContentModel.ResourceName)
        { }

        public Task<Response<RelatieBijlageContentModel[]>> GetAllAsync(Guid parentId) => GetAllAsync(parentId, CancellationToken.None);
        public Task<Response<RelatieBijlageContentModel[]>> GetAllAsync(Guid parentId, CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<RelatieBijlageContentModel>(GetAllUri(parentId), cancellationToken);

        private string GetAllUri(Guid parentId)
        {
            return $"{RelatieBijlageContentModel.ResourceName}/{parentId}";
        }
    }
}