using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public class Application
    {
       [JsonProperty("applicationId")] public int ApplicationId { set; get; }
       [JsonProperty("partnerId")] public int PartnerId { set; get; }
       [JsonProperty("applicationOwnershipType")] public string ApplicationOwnershipType { set; get; }
       [JsonProperty("customerRegId")] public int CustomerRegId { set; get; }
       [JsonProperty("isIdProvided")] public bool IsIdProvided { set; get; }
       [JsonProperty("isAddressProvided")] public bool IsAddressProvided { set; get; }
       [JsonProperty("isSelfieProvided")] public bool IsSelfieProvided { set; get; }
       [JsonProperty("isOtherDocProvided")] public bool IsOtherDocProvided { set; get; }
       [JsonProperty("partnerKey")] public string PartnerKey { set; get; }
       [JsonProperty("loginName")] public string LoginName { set; get; }
    }
}
