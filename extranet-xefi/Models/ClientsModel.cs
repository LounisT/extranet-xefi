namespace extranet_xefi.Models
{
    using System;
    using System.Collections.Generic;
    public class ClientsModel
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public int CP { get; set; }
        public int Ville { get; set; }
        public int Tel { get; set; }
        public int CodeDevise { get; set; }
        
    }
}
