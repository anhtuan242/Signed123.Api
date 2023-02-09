using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{
   
    [Route("/fraudServices/REST/v1/sendSMSOrEmail", Verbs = "POST")]
    public class SendSMSOrEmailRequest : IApiRequest<SendSMSOrEmailResponse>
    {
        [JsonProperty("countryCode")] public string CountryCode { set; get; }
        [JsonProperty("emailId")] public string EmailId { set; get; }
        [JsonProperty("applicationId")] public int ApplicationId { set; get; }
        [JsonProperty("memberid")] public int Memberid { set; get; }
        [JsonProperty("user_number")] public int UserNumber { set; get; }   
    }
    public class SendSMSOrEmailResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("customerRegId")] public int CustomerRegId { get; set; }    
        [JsonProperty("description1")] public string Description1 { get; set; }
        [JsonProperty("description2")] public string Description2 { get; set; }
    }
}
