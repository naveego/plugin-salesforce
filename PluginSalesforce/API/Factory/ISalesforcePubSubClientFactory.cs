using PluginSalesforce.Helper;

namespace PluginSalesforce.API.Factory
{
    public interface ISalesforcePubSubClientFactory
    {
        SalesforcePubSubClient GetPubSubClient(string accessToken, string instanceUrl, string organizationId);
    }
}