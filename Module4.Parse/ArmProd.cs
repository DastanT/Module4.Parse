using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4.Parse
{
    public class ArmProd
    {
        [Newtonsoft.Json.JsonProperty("PIN")]
        public string PIN { get; set; }

        [Newtonsoft.Json.JsonProperty("BRAND")]
        public string BRAND { get; set; }

        [Newtonsoft.Json.JsonProperty("NAME")]
        public string NAME { get; set; }

        [Newtonsoft.Json.JsonProperty("ARTID")]
        public string ARTID { get; set; }

        [Newtonsoft.Json.JsonProperty("PARNR")]
        public string PARNR { get; set; }

        [Newtonsoft.Json.JsonProperty("KEYZAK")]
        public string KEYZAK { get; set; }

        [Newtonsoft.Json.JsonProperty("RVALUE")]
        public string RVALUE { get; set; }

        [Newtonsoft.Json.JsonProperty("RDPRF")]
        public string RDPRF { get; set; }

        [Newtonsoft.Json.JsonProperty("MINBM")]
        public string MINBM { get; set; }

        [Newtonsoft.Json.JsonProperty("VENSL")]
        public string VENSL { get; set; }

        [Newtonsoft.Json.JsonProperty("PRICE")]
        public string PRICE { get; set; }

        [Newtonsoft.Json.JsonProperty("WAERS")]
        public string WAERS { get; set; }

        [Newtonsoft.Json.JsonProperty("DLVDT")]
        public string DLVDT { get; set; }

        [Newtonsoft.Json.JsonProperty("ANALOG")]
        public string ANALOG { get; set; }

        [Newtonsoft.Json.JsonProperty("MSG")]
        public string MSG { get; set; }

        [Newtonsoft.Json.JsonProperty("PriceTenge")]
        public int PriceTenge { get; set; }

        [Newtonsoft.Json.JsonProperty("PriceRub")]
        public double PriceRub { get; set; }

        [Newtonsoft.Json.JsonProperty("ArtificialPrice")]
        public string ArtificialPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("ShowArtificialByDefault")]
        public bool ShowArtificialByDefault { get; set; }

        [Newtonsoft.Json.JsonProperty("SupplierId")]
        public int SupplierId { get; set; }

        [Newtonsoft.Json.JsonProperty("Delivery")]
        public string Delivery { get; set; }

        [Newtonsoft.Json.JsonProperty("DeliveryEx")]
        public int DeliveryEx { get; set; }

        [Newtonsoft.Json.JsonProperty("DeliveryGu")]
        public int DeliveryGu { get; set; }

        [Newtonsoft.Json.JsonProperty("Vkorg")]
        public string Vkorg { get; set; }

        [Newtonsoft.Json.JsonProperty("Kunnr")]
        public string Kunnr { get; set; }

    }
}
