namespace SnelStart.B2B.V2.Client.Operations
{
    internal class InkoopBoekingBijlagesOperations : CrudOperationsBase<InkoopBoekingBijlageContentModel>, 
        IInkoopBoekingBijlagesOperations
    {
        public InkoopBoekingBijlagesOperations(ClientState clientState)
            : base(clientState, InkoopBoekingBijlageContentModel.ResourceName)
        { }
    }
}