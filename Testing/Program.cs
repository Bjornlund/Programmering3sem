// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.Json;

Testing.TestClass t = new Testing.TestClass();

t.Health = 16;

Console.WriteLine(t.Health);

Testing.Parrot a = new Testing.Parrot();

a.Eat();

Dictionary<string, int> myDict = new Dictionary<string, int>();

myDict.Add("Cat", 1);
myDict.Add("Dog", 2);

if(myDict.ContainsKey("Dog"))
{
    int value = myDict["Dog"];
    Console.WriteLine(value);
}

JsonObject jsonObject = new JsonObject()
{
    FirstName = "Pjerrot",
    LastName = "Pjerrotson",
    Age = 500
};
string jsonObjectSerialized = JsonSerializer.Serialize(jsonObject);
Console.WriteLine(jsonObjectSerialized);
JsonObject jODe = JsonSerializer.Deserialize<JsonObject>(jsonObjectSerialized);
Console.WriteLine(jODe);
class JsonObject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}