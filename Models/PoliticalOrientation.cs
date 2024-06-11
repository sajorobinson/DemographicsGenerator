namespace DemographicsGenerator.Models
{
    public class PoliticalOrientation
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        private int SpectrumX { get; init; } =
            Helpers.Utility.GetRandomNumber(Constants.PoliticalOrientation.SpectrumMin,
                Constants.PoliticalOrientation.SpectrumMax);

        private int SpectrumY { get; init; } =
            Helpers.Utility.GetRandomNumber(Constants.PoliticalOrientation.SpectrumMin,
                Constants.PoliticalOrientation.SpectrumMax);

        public static string GetPoliticalOrientationName(PoliticalOrientation politicalOrientation)
        {
            switch (politicalOrientation.SpectrumX)
            {
                // Right of centre
                case > 0 when politicalOrientation.SpectrumY > 0:
                    return "Right-Authoritarian";
                case > 0 when politicalOrientation.SpectrumY < 0:
                    return "Right-Libertarian";
                case > 0 when politicalOrientation.SpectrumY == 0:
                    return "Right-Centrist";
                case > 0:
                    return "Other";
                // Left of centre
                case < 0 when politicalOrientation.SpectrumY > 0:
                    return "Left-Authoritarian";
                case < 0 when politicalOrientation.SpectrumY < 0:
                    return "Left-Libertarian";
                case < 0 when politicalOrientation.SpectrumY == 0:
                    return "Left-Centrist";
                case < 0:
                    return "Other";
                // Centre
                case 0 when politicalOrientation.SpectrumY > 0:
                    return "Centrist-Authoritarian";
                case 0 when politicalOrientation.SpectrumY < 0:
                    return "Centrist-Libertarian";
                case 0 when politicalOrientation.SpectrumY == 0:
                    return "True Centrist";
                case 0:
                    return "Other";
                default:
                    return "Other";
            }
        }
    }
}