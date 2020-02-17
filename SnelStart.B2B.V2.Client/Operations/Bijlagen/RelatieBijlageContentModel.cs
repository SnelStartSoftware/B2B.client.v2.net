namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class RelatieBijlageContentModel : RelatieBijlageModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public new const string ResourceName = "documenten/relaties";

        /// <summary>
        /// De inhoud van de bijlage.
        /// </summary>
        public byte[] Content { get; set; }
    }
}
