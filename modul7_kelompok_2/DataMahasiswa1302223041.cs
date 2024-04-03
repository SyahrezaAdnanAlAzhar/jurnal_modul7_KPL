using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static DataMahasiswa1302223041;
public class DataMahasiswa1302223041
{
    public class alamat
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public alamat address { get; set; }
    public Course[] courses { get; set; }
    public class Course
    {
        [JsonPropertyName("code")]
        public String code { get; set; }
        [JsonPropertyName("name")]
        public String name { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = @"jurnal7_1_1302223041.json";

        string jsonText = File.ReadAllText(filePath);

        DataMahasiswa1302223041 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223041>(jsonText);

        Console.WriteLine($"Nama    : {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
        Console.WriteLine($"Gender  : {dataMahasiswa.gender}");
        Console.WriteLine($"Usia    : {dataMahasiswa.age}");
        Console.WriteLine($"Alamat  : {dataMahasiswa.address.streetAddress}, {dataMahasiswa.address.city}, {dataMahasiswa.address.state}");
        for (int i = 0; i < dataMahasiswa.courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {dataMahasiswa.courses[i].code} - {dataMahasiswa.courses[i].name}");
        }
    }
}