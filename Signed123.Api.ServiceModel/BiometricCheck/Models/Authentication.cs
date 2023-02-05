using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public class Authentication
    {
        [JsonProperty("partnerId")] public int PartnerId { get; set; }
        [JsonProperty("sKey")] public string SKey { get; set; }

    }
}
