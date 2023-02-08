using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public  class DocumentDetail
    {
        [JsonProperty("doc_text")] public string DocText { get; set; }
        [JsonProperty("doc_type")] public string DocType { get; set; }
        [JsonProperty("doc_image")] public string DocImage { get; set; }
        [JsonProperty("doc_image_back")] public string DocImageBack { get; set; }

    }
}
