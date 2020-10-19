using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class KasboekingenOperations : CrudOperationsBase<KasboekingModel>, IKasboekingenOperations
    {
        public KasboekingenOperations(ClientState clientState)
            : base(clientState, KasboekingModel.ResourceName)
        { }

        public Task<Response<KasboekingModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<KasboekingModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<KasboekingModel>(ResourceName, cancellationToken);
    }
}
