using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Signed123.Features.Api.ServiceModel.Interfaces.IApiRequest;

namespace Signed123.Features.Api.ServiceModel.Interfaces
{

        public interface IApiRequest
        { }
        public interface IApiRequest<TResponse> : IReturn<TResponse>, IApiRequest where TResponse : IApiResponse
        { }

}
