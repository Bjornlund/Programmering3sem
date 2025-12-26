// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Newtonsoft.Json;
using System.Text;
//using System.Text.Json; //Ved brug af det indbyggede json bibliotek, skal JsonObject have get+set

//EXERCISE: Simpel json serialisering og deserialisering med NewtonSoft.Json

//Opretter nyt C# object med info/værdier (det er ikke JSON her)
JsonObject jsonObject = new JsonObject()
{
    FirstName = "Bob",
    LastName = "Bobson",
    Age = 45
};

//Serialisering af object til JSON
string jsonnetOserial = JsonConvert.SerializeObject(jsonObject);
Console.WriteLine(jsonnetOserial); //SKrives i JSON format til console


JsonObject deSerial = JsonConvert.DeserializeObject<JsonObject>(jsonnetOserial);
Console.WriteLine(deSerial);

/// <summary>
/// JsonObject med fields der kan serialiseres
/// </summary>
class JsonObject
{
    private string firstName;
    private string lastName;
    private int age;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
}

