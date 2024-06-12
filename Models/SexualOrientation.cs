namespace DemographicsGenerator.Models
{
    public class SexualOrientation
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static SexualOrientation GetRandomSexualOrientation()
        {
            SexualOrientation sexualOrientation = Helpers.Utility.GetResource<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            return sexualOrientation;
        }
    }
}