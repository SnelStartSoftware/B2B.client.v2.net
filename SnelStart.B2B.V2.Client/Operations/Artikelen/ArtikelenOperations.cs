using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    class ArtikelenOperations : CrudOperationsBase<ArtikelModel>, IArtikelenOperations
    {
        public ArtikelenOperations(ClientState clientState)
            : base(clientState, ArtikelModel.ResourceName)
        { }

        public Task<Response<ArtikelModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<ArtikelModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<ArtikelModel>(ResourceName, cancellationToken);

        public Task<Response<ArtikelModel[]>> GetAsync(string queryString) => GetAsync(queryString, CancellationToken.None);
        public Task<Response<ArtikelModel[]>> GetAsync(string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetAsync<ArtikelModel>(ResourceName, queryString, cancellationToken);
        public Task<Response<ArtikelModel>> GetByIdAsync(Guid id, string queryString) => GetByIdAsync(id, queryString, CancellationToken.None);
        public Task<Response<ArtikelModel>> GetByIdAsync(Guid id, string queryString, CancellationToken cancellationToken) => ClientState.ExecuteGetByIdAsync<ArtikelModel>(ResourceName, id, queryString, cancellationToken);
    }
}
