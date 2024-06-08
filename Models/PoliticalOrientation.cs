namespace Models
{
    public class PoliticalOrientation
    {
        public string? Name { get; set; }
        public int SpectrumX { get; set; }
        public int SpectrumY { get; set; }
        public PoliticalOrientation GetPoliticalOrientation()
        {
            PoliticalOrientation politicalOrientation = new PoliticalOrientation();
            int x = Helpers.Utility.GetRandomNumber(Constants.PoliticalOrientation.SpectrumMin, Constants.PoliticalOrientation.SpectrumMax);
            int y = Helpers.Utility.GetRandomNumber(Constants.PoliticalOrientation.SpectrumMin, Constants.PoliticalOrientation.SpectrumMax);
            politicalOrientation.SpectrumX = x;
            politicalOrientation.SpectrumY = y;
            return politicalOrientation;
        }
        public string GetPoliticalOrientationName(PoliticalOrientation politicalOrientation)
        {
            if (politicalOrientation.SpectrumX > 0)
            {
                // Right of centre
                if (politicalOrientation.SpectrumY > 0)
                {
                    return "Right-Authoritarian";
                }
                else if (politicalOrientation.SpectrumY < 0)
                {
                    return "Right-Libertarian";
                }
                else if (politicalOrientation.SpectrumY == 0)
                {
                    return "Right-Centrist";
                }
                else
                {
                    return "Other";
                }
            }
            else if (politicalOrientation.SpectrumX < 0)
            {
                // Left of centre
                if (politicalOrientation.SpectrumY > 0)
                {
                    return "Left-Authoritarian";
                }
                else if (politicalOrientation.SpectrumY < 0)
                {
                    return "Left-Libertarian";
                }
                else if (politicalOrientation.SpectrumY == 0)
                {
                    return "Left-Centrist";
                }
                else
                {
                    return "Other";
                }
            }
            else if (politicalOrientation.SpectrumX == 0)
            {
                // Centre
                if (politicalOrientation.SpectrumY > 0)
                {
                    return "Centrist-Authoritarian";
                }
                else if (politicalOrientation.SpectrumY < 0)
                {
                    return "Centrist-Libertarian";
                }
                else if (politicalOrientation.SpectrumY == 0)
                {
                    return "True Centrist";
                }
                else
                {
                    return "Other";
                }
            }
            else
            {
                return "Other";
            }
        }
    }
}