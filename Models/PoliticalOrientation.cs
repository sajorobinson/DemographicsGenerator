namespace DemographicsGenerator.Models
{
    public class PoliticalOrientation
    {
        const int SpectrumMin = -1000;
        const int SpectrumMax = 1000;

        public string Name { get; set; } = Constants.Models.DefaultResponse;

        private int SpectrumX { get; init; } = Helpers.Utility.GetRandomNumber(SpectrumMin, SpectrumMax);

        private int SpectrumY { get; init; } = Helpers.Utility.GetRandomNumber(SpectrumMin, SpectrumMax);

        public static string GetPoliticalOrientationName(PoliticalOrientation politicalOrientation)
        {
            switch (politicalOrientation.SpectrumX)
            {
                // Right of centre
                case > 5 when politicalOrientation.SpectrumY > 0:
                    return "Right-Authoritarian";
                case > 5 when politicalOrientation.SpectrumY < 0:
                    return "Right-Libertarian";
                case > 5 when politicalOrientation.SpectrumY == 0:
                    return "Right-Centrist";
                case > 5:
                    return "Other";
                // Left of centre
                case < -5 when politicalOrientation.SpectrumY > 0:
                    return "Left-Authoritarian";
                case < -5 when politicalOrientation.SpectrumY < 0:
                    return "Left-Libertarian";
                case < -5 when politicalOrientation.SpectrumY == 0:
                    return "Left-Centrist";
                case < -5:
                    return "Other";
                // Centre
                case >= -5 or <= 5 when politicalOrientation.SpectrumY > 0:
                    return "Centrist-Authoritarian";
                case >= -5 or <= 5 when politicalOrientation.SpectrumY < 0:
                    return "Centrist-Libertarian";
                case >= -5 or <= 5 when politicalOrientation.SpectrumY == 0:
                    return "True Centrist";
                default:
                    return "Other";
            }
        }
    }
}