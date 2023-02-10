using Microsoft.Extensions.Logging;
using ServiceStack;
using Signed123.Features.Api.ServiceModel.BiometricCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signed123.Api.ServiceInterface.Services
{
    public class SignedService  : BaseService
    {
        private static readonly ILogger Log = HostContext.Resolve<ILoggerFactory>().CreateLogger(typeof(SignedService));
        #region BiometricChecks

        public object Post(AuthTokenRequest request) => ExecuteBiomatricRequest<AuthTokenRequest, AuthTokenResponse>("POST", "/mobileServices/REST/mobileControllerServices/authToken", request);
        public object Post(CheckLivelinessRequest request) => ExecuteBiomatricRequest<CheckLivelinessRequest, CheckLivelinessResponse>("POST", "/mobileServices/REST/mobileControllerServices/checkLiveliness", request);
        public object Post(GetApplicationsRequest request) => ExecuteBiomatricRequest<GetApplicationsRequest, GetApplicationsResponse>("POST", "/mobileServices/REST/mobileControllerServices/getApplications", request);

        #endregion BiometricChecks

    }
}
