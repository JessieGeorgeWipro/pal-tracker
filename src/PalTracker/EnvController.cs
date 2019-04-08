using Microsoft.AspNetCore.Mvc;
namespace PalTracker
{
   [Route("env")]
    public class EnvController
    {
        private readonly CloudFoundryInfo _cloudFoundryEnv;

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryEnv;

        public EnvController(CloudFoundryInfo cloudFoundryEnv)
        {
            _cloudFoundryEnv = cloudFoundryEnv;
        }
    }
}