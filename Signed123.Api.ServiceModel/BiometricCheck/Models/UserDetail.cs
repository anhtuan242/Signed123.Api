using Newtonsoft.Json;
using Signed123.Features.Api.ServiceModel.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.BiometricCheck.Models
{
    public class UserDetail
    {

        [JsonProperty("user_contact")] public int UserContact { get; set; } 
        [JsonProperty("user_first_name")] public string UserFirstName { get; set; } 
        [JsonProperty("user_last_name")] public string UserLastName { get; set; }

        [JsonProperty("user_dob")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        public DateTime UserDob { get; set; }
        [JsonProperty("user_documentId")] public string UserDocumentId { get; set; }
        [JsonProperty("user_issuingDate")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        public DateTime UserIssuingDate { get; set; }

        [JsonProperty("user_expiryDate")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd")]
        public DateTime UserExpiryDate { get; set; }

    }
}
