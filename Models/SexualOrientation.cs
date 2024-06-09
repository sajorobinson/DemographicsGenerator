namespace Models
{
    public class SexualOrientation
    {
        public string? Name {get; set;}
        public static SexualOrientation Get()
        {
            SexualOrientation sexualOrientation = Helpers.Utility.GetResource<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            return sexualOrientation;
        }        
    }
}