namespace extranet_xefi.Models
{
    using System;
    using System.Collections.Generic;
    public class AuthentificationModel
    {
        public int refLogin { get; set; }
        public string codeAbonne { get; set; }
        public string identifiant { get; set; }
        public string motdePasse { get; set; }
        public string codeclientgere { get; set; }
        public int CP { get; set; }
        public int Ville { get; set; }
        public int Tel { get; set; }
        public string reglement { get; set; }
        public string civilite { get; set; }
        public string totalHT { get; set; }
        public string totalTTC { get; set; }
        public DateTime dateCrea { get; set; }
        public DateTime dateEcheance { get; set; }

        

    }
}
