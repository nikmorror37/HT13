using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HT13
{
    public class SHSquad
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }
        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }
        [JsonPropertyName("formed")]
        public int WhenFormed { get; set; }
        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }
        [JsonPropertyName("activity")]
        public bool Activity { get; set; }
        [JsonPropertyName("members")]
        public SHSquadMembers[] Members { get; set; }

        public SHSquad() { }

        public SHSquad(string squadName, string homeTown, int formed, string secretBase, bool activity, SHSquadMembers[] members)
        {
            SquadName = squadName;
            HomeTown = homeTown;
            WhenFormed = formed;
            SecretBase = secretBase;
            Activity = activity;
            Members = new SHSquadMembers[members.Length];
            Array.Copy(members, Members, Members.Length);
        }
        public void ShowMembers()
        {
            foreach (var member in Members)
            {
                Console.WriteLine($"\nИмя: {member.Name}\nВозраст: {member.Age}\nТайная личность: {member.SecretID}");
                member.ShowPowers();
            }
        }


    }
}
