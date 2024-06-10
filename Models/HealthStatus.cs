namespace Models
{
    public class HealthStatus
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            HealthStatus healthStatus = Helpers.Utility.GetResource<HealthStatus>(Constants.Resources.HealthStatusFilePath);
            return healthStatus.Name;
        }
    }
}