using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class RelatieDoorlopendeIncassoMachtigingenOperations : IRelatieDoorlopendeIncassoMachtigingenOperations
    {
        private readonly ClientState ClientState;

        public RelatieDoorlopendeIncassoMachtigingenOperations(ClientState clientState)
        {
            ClientState = clientState;
        }

        public Task<Response<DoorlopendeIncassoMachtigingModel[]>> GetAllAsync(Guid parentId) => GetAllAsync(parentId,
            CancellationToken.None);

        public Task<Response<DoorlopendeIncassoMachtigingModel[]>> GetAllAsync(Guid parentId, CancellationToken cancellationToken)
        {
            return ClientState.ExecuteGetAllAsync<DoorlopendeIncassoMachtigingModel>($"{RelatieModel.ResourceName}/{parentId}/{DoorlopendeIncassoMachtigingModel.ResourceName}", cancellationToken);
        }
    }
}
