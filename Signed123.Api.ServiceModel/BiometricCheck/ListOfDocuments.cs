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

    [Route("/mobileServices/REST/mobileControllerServices/listOfDocuments", Verbs = "POST")]
    public class ListOfDocumentsRequest : IApiRequest<ListOfDocumentsResponse>
    {
        [JsonProperty("partnerId")] public int PartnerId { set; get; }
        [JsonProperty("type")] public string Type { set; get; }
    }
    public class ListOfDocumentsResponse : IApiResponse
    {
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("list")] public string [] ListDocuments { get; set; }
    }
}
