using System.Text.Json;

namespace Helpers
{
    public class Utility
    {
        public static Random MakeNewRandom()
        {
            Random random = new Random();
            return random;
        }
        public static T GetRandomItem<T>(List<T> list)
        {
            int randomIndex = MakeNewRandom().Next(list.Count);
            return list[randomIndex];
        }
        public static int GetRandomNumber(int x, int y)
        {
            int randomNumber = MakeNewRandom().Next(x, y + 1);
            return randomNumber;
        }
        public static T GetResource<T>(string filePath)
        {
            string json = Json.ReadJsonFile(filePath);
            List<T> objects = JsonSerializer.Deserialize<List<T>>(json)!;
            var target = GetRandomItem(objects);
            return target;
        }
    }
}