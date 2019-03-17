using SatisfactoryCalculator.Logic.Models;
using System.IO;
using YamlDotNet.Serialization;

namespace SatisfactoryCalculator.Logic
{
    public static class FileDataLoader
    {
        private static T LoadFile<T>(string filename)
        {
            var yaml = File.ReadAllText(filename);
            var deserializer = new DeserializerBuilder()
                .Build();
            return deserializer.Deserialize<T>(yaml);
        }

        public static Recipe LoadRecipe(string name)
        {
            return LoadFile<Recipe>("Data/" + name.Replace(" ", "") + ".yml");
        }
    }
}
