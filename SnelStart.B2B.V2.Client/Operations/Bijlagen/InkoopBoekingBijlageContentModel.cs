namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class InkoopBoekingBijlageContentModel : InkoopBoekingBijlageModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public new const string ResourceName = "documenten/inkoopboekingen";

        /// <summary>
        /// De inhoud van de bijlage.
        /// </summary>
        public byte[] Content { get; set; }
    }
}
