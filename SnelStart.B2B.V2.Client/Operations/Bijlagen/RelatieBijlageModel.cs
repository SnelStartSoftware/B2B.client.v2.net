using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class RelatieBijlageModel : DocumentModel
    {
        /// <summary>
        /// 
        /// </summary>
        protected RelatieBijlageModel() : base(ResourceName)
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
