using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public class Partner
    {
        [JsonProperty("username")] public string Username { get; set; }     
    }
}
