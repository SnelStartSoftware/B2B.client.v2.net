using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een grootboek.
    /// </summary>
    public class GrootboekModel : GrootboekIdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public new const string ResourceName = "grootboeken";

        /// <summary>
        /// Geeft een instantie van een <see cref="GrootboekModel"/> terug.
        /// </summary>
        public GrootboekModel() : base(ResourceName)
        {
        }
        /// <summary>
        /// Het tijdstip waarop het grootboek is aangemaakt of voor het laatst is gewijzigd
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// De omschrijving van het grootboek.
        /// </summary>
        public string Omschrijving { get; set; }

        /// <summary>
        /// Kostenplaats wel of niet verplicht bij het boeken.
        /// </summary>
        public bool KostenplaatsVerplicht { get; set; }

        /// <summary>
        /// Rekening code van het grootboek.
        /// </summary>
        public RekeningCodeModel RekeningCode { get; set; }

        /// <summary>
        /// Een vlag dat aangeeft of het grootboek niet meer actief is binnen de administratie.
        /// Indien <see langword="true" />, dan kan het grootboek als "verwijderd" worden beschouwd.
        /// </summary>
        public bool Nonactief { get; set; }

        /// <summary>
        /// Het nummer van het grootboek.
        /// </summary>
        public int Nummer { get; set; }

        /// <summary>
        /// De grootboekfunctie van het grootboek.
        /// </summary>
        public GrootboekFunctieModel GrootboekFunctie { get; set; }

        /// <summary>
        /// RgsCodes
        /// </summary>
        public RgsModel[] RgsCode { get; set; }

        /// <summary>
        /// De toegestande btwsoorten van het grootboek.
        /// </summary>
        public BtwSoortModel[] BtwSoort { get; set; }
    }
}
