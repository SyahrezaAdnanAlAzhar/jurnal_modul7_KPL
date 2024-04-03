using System.Text.Json;
using System.IO;
using System;

public class DataMahasiswa1302220112
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public Address address { get; set; }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public Course course[]

    public DataMahasiswa1302220112()
	{
		
	}
    public void ReadJSON()
    {
        string filePath = "jurnal7_1_1302220112"
        string jsonText = File.ReadAllText(filePath);

        DataMahasiswa1302220112 dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220112>(jsonText);

        Console.WriteLine($"nama {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
        Console.WriteLine($"Berjenis kelamin {dataMahasiswa.gender} dan berusia {dataMahasiswa.age}");
        Console.WriteLine($"Beralamat di jalan {dataMahasiswa.address.street}, kota {dataMahasiswa.address.city}, provinsi {dataMahasiswa.address.state}");
        Console.WriteLine($"Mengambil mata kuliah:");
        Console.WriteLine(dataMahasiswa.course[0]);
        Console.WriteLine(dataMahasiswa.course[1]);
    }
}
