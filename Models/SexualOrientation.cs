namespace DemographicsGenerator.Models
{
    public class SexualOrientation
    {
        public string Name {get; set;} = Constants.Models.DefaultName;
        public static SexualOrientation GetRandomName()
        {
            SexualOrientation sexualOrientation = Helpers.Utility.GetResource<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            return sexualOrientation;
        }
    }
}