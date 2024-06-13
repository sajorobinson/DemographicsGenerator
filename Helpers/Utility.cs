using System.Text.Json;

namespace DemographicsGenerator.Helpers
{
    public static class Utility
    {
        private static Random GetNewRandom()
        {
            Random random = new Random();
            return random;
        }

        public static T GetRandomItem<T>(List<T> list)
        {
            int randomIndex = GetNewRandom().Next(list.Count);
            return list[randomIndex];
        }

        public static int GetRandomNumber(int x, int y)
        {
            int randomNumber = GetNewRandom().Next(x, y + 1);
            return randomNumber;
        }

        public static List<T> GetRandomResourceList<T>(string filePath)
        {
            string json = Json.GetJsonString(filePath);
            List<T> objects = JsonSerializer.Deserialize<List<T>>(json)!;
            return objects;
        }

        public static T GetRandomResource<T>(List<T> objects)
        {
            var target = GetRandomItem(objects);
            return target;
        }
    }
}
