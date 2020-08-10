using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using data;

namespace api
{
    public class RestomgrService : Restomgr.RestomgrBase
    {
        private readonly ILogger<RestomgrService> _logger;
        public RestomgrService(ILogger<RestomgrService> logger)
        {
            _logger = logger;
        }

        public override Task<RestoReply> GetResto(RestoRequest request, ServerCallContext context)
        {
            data.RestoDA restoda = new RestoDA();
            //resto  da.Add(new RestoEntity{ request.Name });

            return Task.FromResult(new RestoReply
            {
                //Message = "Resto " + request.Name
                //restoda.Add(new RestoEntity{ name= request.Name })
                Message = "test2"
            });
        }
    }
}
