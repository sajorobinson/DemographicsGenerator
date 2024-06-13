namespace DemographicsGenerator.Models
{
    public class HealthStatus
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static HealthStatus GetRandomHealthStatus()
        {
            List<HealthStatus> healthStatusList = Helpers.Utility.GetRandomResourceList<HealthStatus>(Constants.Resources.HealthStatusFilePath);
            HealthStatus healthStatus = Helpers.Utility.GetRandomResource<HealthStatus>(healthStatusList);
            return healthStatus;
        }
    }
}
