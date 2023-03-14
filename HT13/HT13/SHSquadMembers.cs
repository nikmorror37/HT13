using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HT13
{
    public class SHSquadMembers
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("secretIdentity")]
        public string SecretID { get; set; }
        [JsonPropertyName("powers")]
        public string[] Powers { get; set; }
        public SHSquadMembers() { }
        public SHSquadMembers(string name, int age, string secretIdentity, string[] powers)
        {
            Name = name;
            Age = age;
            SecretID = secretIdentity;
            Powers = new string [powers.Length];
            Array.Copy(powers, Powers, powers.Length);
        }
        public void ShowPowers()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine($"Способности участника: {power}");
            }
        }
    }
}
