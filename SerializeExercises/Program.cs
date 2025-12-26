// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Newtonsoft.Json;
//using System.Text.Json.Nodes;
using System.Text;
//using System.Text.Json; //Ved brug af det indbyggede json bibliotek, skal JsonObject have get+set

//EXERCISE: Simpel json serialisering og deserialisering med NewtonSoft.Json

//Opretter nyt C# object med info/værdier (det er ikke JSON her)
Person personA = new Person()
{
    FirstName = "Bob",
    LastName = "Bobson",
    Age = 45,
    Haircolor = HairColor.Red

};



//Serializing optimeret til større datamængde - json ligger i bin som json fil, hedder "data" - Undgår at allokere jsonstring i hukommelsen
using (StreamWriter streamWriter = new StreamWriter("data.json"))
using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
{
    JsonSerializer serializer = new JsonSerializer();
    serializer.Serialize(jsonWriter, personA);
}

//Deserialisering
Person personB;
using (StreamReader streamReader = new StreamReader("data.json"))
using (JsonReader jsonReader = new JsonTextReader(streamReader))
{
    JsonSerializer serializer = new JsonSerializer();
    personB = serializer.Deserialize<Person>(jsonReader);
}


////Simpel serialisering
////Serialisering af object til JSON
//string jsonnetOserial = JsonConvert.SerializeObject(personA);
//Console.WriteLine(jsonnetOserial); //SKrives i JSON format til console

//byte[] bytes = Encoding.UTF8.GetBytes(jsonnetOserial); //Hvis det skal encodes og sendes over netværk

//string jsonDecode = Encoding.UTF8.GetString(bytes);

////Decoding
//Person deSerial = JsonConvert.DeserializeObject<Person>(jsonDecode);

//Console.WriteLine($"{deSerial.FirstName}, {deSerial.LastName}, {deSerial.Age}, {deSerial.Haircolor}");

/// <summary>
/// JsonObject med fields der kan serialiseres
/// </summary>
class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private HairColor haircolor;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }
    public HairColor Haircolor { get => haircolor; set => haircolor = value; }

}

public enum HairColor
{
    Red,
    Black,
    Brown
}



//EXERCISE JSON.nent attributter kan fx bruges til overskriving af navne - brug samme property for at deserialisere

//JsonObject jsonObject = new JsonObject()
//{
//    FirstName = "Pjerrot",
//    Age = 500
//};
//string jsonnetOSerial = JsonConvert.SerializeObject(jsonObject);
//Console.WriteLine(jsonnetOSerial);


//JsonObject deSerial = JsonConvert.DeserializeObject<JsonObject>(jsonnetOSerial);
//Console.WriteLine(deSerial);

//class JsonObject
//{
//    public string FirstName { get; set; }
//    [JsonProperty]
//    private string LastName => FirstName;
//    [JsonProperty("myAge")]
//    public int Age;
//}