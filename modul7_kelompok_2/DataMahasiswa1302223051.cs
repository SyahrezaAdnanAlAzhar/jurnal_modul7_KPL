using System.Text.Json;
using System.IO;
using System;

public class DataMahasiswa1302223051
{
    public Nama nama { get; set; }
    public int nim { get; set; }
    public String fakultas { get; set; }

    public class KuliahMahasiswa
    {
        [JsonPropertyName("courses")]
        public Course[] Courses { get; set; }
    }

    public class Course
    {
        [JsonPropertyName("code")]
        public String code { get; set; }
        [JsonPropertyName("name")]
        public String name { get; set; }
    }

    public class Nama
    {
        public String depan { get; set; }
        public String belakang { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "Jurnal7_1_1302223051.json";

        string jsonText = File.ReadAllText(filePath);

        DataMahasiswa1302223051 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223051>(jsonText);

        Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan NIM {dataMahasiswa.nim} dari Fakultas {dataMahasiswa.fakultas}");

        KuliahMahasiswa KuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa>(jsonText);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        for (int i = 0; i < KuliahMahasiswa.Courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {KuliahMahasiswa.Courses[i].code} - {KuliahMahasiswa.Courses[i].name}");
        }

    }
}
