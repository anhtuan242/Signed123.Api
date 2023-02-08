using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public class AddressDetail
    {
        [JsonProperty("user_address_first")] public string UserAddressFirst { get; set; } 
        [JsonProperty("user_address_second")] public string UserAddressSecond { get; set; } 
        [JsonProperty("user_zip_code")] public int UserZipCode { get; set; }

        [JsonProperty("user_city")] public string UserCity { get; set; } 
        [JsonProperty("user_state")] public string UserState { get; set; } 
        [JsonProperty("user_province")] public string UserProvince { get; set; } 

    }
}
