namespace Models
{
    public class SexualOrientation
    {
        public string Name {get; set;} = Constants.Models.DefaultName;
        public string? GetRandomName()
        {
            SexualOrientation sexualOrientation = Helpers.Utility.GetResource<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            return sexualOrientation.Name;
        }
    }
}