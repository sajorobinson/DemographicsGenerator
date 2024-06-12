namespace DemographicsGenerator.Models
{
    public class HealthStatus
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static HealthStatus GetRandomHealthStatus()
        {
            HealthStatus healthStatus = Helpers.Utility.GetResource<HealthStatus>(Constants.Resources.HealthStatusFilePath);
            return healthStatus;
        }
    }
}