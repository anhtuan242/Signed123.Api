using Newtonsoft.Json;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.BiometricCheck.Models;
using Signed123.Features.Api.ServiceModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck
{
    [Route("/mobileServices/REST/mobileControllerServices/getApplications", Verbs = "POST")]
    public class GetApplicationsRequest : IApiRequest<GetApplicationsResponse>
    {
        [JsonProperty("cust_contact_code")] public int CustContactCode { set; get; }
        [JsonProperty("cust_contact")] public int CustContact { set; get; }
    }
    public class GetApplicationsResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("applications")] public Application Applications { get; set; }
    }
}
