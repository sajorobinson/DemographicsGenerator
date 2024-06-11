using System.Reflection;
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

        public static T GetResource<T>(string filePath)
        {
            string json = Json.GetJsonString(filePath);
            List<T> objects = JsonSerializer.Deserialize<List<T>>(json)!;
            var target = GetRandomItem(objects);
            return target;
        }
    }
}