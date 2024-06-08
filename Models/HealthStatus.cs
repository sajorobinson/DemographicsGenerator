namespace Models
{
    public class HealthStatus
    {
        public string? Name { get; set; }
        public static HealthStatus Get()
        {
            HealthStatus healthStatus = Helpers.Utility.GetResource<HealthStatus>(Constants.Resources.HealthStatusFilePath);
            return healthStatus;
        }
    }
}