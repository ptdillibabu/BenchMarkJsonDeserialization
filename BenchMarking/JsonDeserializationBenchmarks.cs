using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using System.Text.Json;

public class JsonDeserializationBenchmarks
{
    private const string JsonString = "{\"Name\":\"John Doe\",\"Age\":30,\"Email\":\"john.doe@example.com\"}";

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    [Benchmark]
    public Person DeserializeUsingNewtonsoftJson()
    {
        return JsonConvert.DeserializeObject<Person>(JsonString);
    }

    [Benchmark]
    public Person DeserializeUsingSystemTextJson()
    {
        return System.Text.Json.JsonSerializer.Deserialize<Person>(JsonString);
    }
}