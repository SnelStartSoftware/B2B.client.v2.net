using System;
using System.Collections.Generic;
using System.Text;

namespace SnelStart.B2B.V2.Client.Operations
{
    public class DoorlopendeIncassoMachtigingModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "doorlopendeincassomachtigingen";

        /// <summary>
        /// Geeft een instantie van een <see cref="DoorlopendeIncassoMachtigingModel"/> terug.
        /// </summary>
        public DoorlopendeIncassoMachtigingModel() : base(ResourceName)
        {
        }

        /// <summary>
        /// Het unieke kenmerk van de incassomachtiging.
        /// </summary>
        public string Kenmerk { get; set; }

        /// <summary>
        /// De datum waarop de machtiging is afgesloten.
        /// </summary>
        public DateTime Afsluitdatum { get; set; }

        /// <summary>
        /// De omschrijving van de incassomachtiging.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// De klant waarbij kan worden geïncasseerd met deze incassomachtiging.
        /// </summary>
        public RelatieIdentifierModel Klant { get; set; }

        /// <summary>
        /// De datum waarop deze incassomachtiging is ingetrokken.
        /// </summary>
        public DateTime? Intrekkingsdatum { get; set; }

    }
}
