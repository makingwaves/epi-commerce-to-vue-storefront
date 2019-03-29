﻿using Newtonsoft.Json;

namespace EPiServer.VueStorefrontApiBridge.ApiModel.Cart
{
    public class ShippingAddressInformation
    {
        [JsonProperty("shipping_address")]
        public UserAddressModel ShippingAddress { get; set; }

        [JsonProperty("shipping_method_code")]
        public string ShippingMethodCode { get; set; }

        [JsonProperty("shipping_carrier_code")]
        public string ShippingCarrierCode { get; set; }
    }
}
