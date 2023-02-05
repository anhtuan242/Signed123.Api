﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Features.Api.ServiceModel.Base
{
    public class ResultInfo
    {

        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
     
    }

}
