namespace Models
{
    public class SexualOrientation
    {
        string? Name {get; set;}
        public static SexualOrientation Get()
        {
            SexualOrientation sexualOrientation = Helpers.Utility.GetResource<SexualOrientation>(Constants.Resources.SexualOrientationFilePath);
            return sexualOrientation;
        }        
    }
}