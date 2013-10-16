using NServiceBus;
using NServiceBus.Features;

namespace Worker
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Worker, UsingTransport<AzureStorageQueue>
    {
        public EndpointConfig()
        {
            Feature.Disable<SecondLevelRetries>();
            Feature.Disable<TimeoutManager>();
            Feature.Disable<Gateway>();
        }
    }
}
