using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class InkoopBoekingBijlageModel : DocumentModel
    {
        /// <summary>
        /// 
        /// </summary>
        protected InkoopBoekingBijlageModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Geeft de naam van de resource (type object) terug waartoe deze identifier behoort.
        /// </summary>
        protected override string Resource()
        {
            return $"documenten/{Id}";
        }
    }
}
