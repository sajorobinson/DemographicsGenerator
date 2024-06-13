namespace DemographicsGenerator.Models
{
    public class SexualOrientation
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static SexualOrientation GetRandomSexualOrientation()
        {
            List<SexualOrientation> sexualOrientationList = Helpers.Utility.GetRandomResourceList<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            SexualOrientation sexualOrientation = Helpers.Utility.GetRandomResource<SexualOrientation>(sexualOrientationList);
            return sexualOrientation;
        }
    }
}
