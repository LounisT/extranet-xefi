namespace extranet_xefi.Models
{
    public class FactureDetailleModel
    {
        public int refDetail { get; set; }
        public string codeArticle { get; set; }
        public string codeFacture { get; set; }
        public int PU { get; set; }
        public int QTE { get; set; }
        public string descriptif { get; set; }
        public int totHT { get; set; }
        public int totTTC { get; set; }
        public DateTime DateLivraison { get; set; }

    }
}