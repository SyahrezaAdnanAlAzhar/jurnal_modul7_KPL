using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static DataMahasiswa1302223041;

public class TeamMember1302223041
{
    public class Member
    {
        [JsonPropertyName("firstName")]
        public String firstName { get; set; }
        [JsonPropertyName("lastName")]
        public String lastName { get; set; }
        [JsonPropertyName("gender")]
        public String gender { get; set; }
        [JsonPropertyName("age")]
        public int age { get; set; }
        [JsonPropertyName("nim")]
        public String nim { get; set; }
    }
    public Member[] members { get; set; }

    public void ReadJSON()
    {
        string filePath = @"jurnal7_2_1302223041.json";

        string jsonText = File.ReadAllText(filePath);

        TeamMember1302223041 teamMember = JsonSerializer.Deserialize<TeamMember1302223041>(jsonText);

        for (int i = 0; i < teamMember.members.Length; i++)
        {
            Console.WriteLine($"{teamMember.members[i].nim} {teamMember.members[i].firstName} {teamMember.members[i].lastName} ({teamMember.members[i].age} {teamMember.members[i].gender})");
        }
    }
}