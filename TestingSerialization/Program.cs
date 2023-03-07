using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the JSON data from the file
            string jsonString = File.ReadAllText("data.json");

            // deserialize the JSON string to a Car object
            Car car = JsonSerializer.Deserialize<Car>(jsonString);

            // create a new Car object with some modified properties
            Car newCar = new Car
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2020,
                Color = "Blue",
                Features = new List<string> { "Navigation", "Sunroof" }
            };

            // serialize the new Car object to JSON
            string newJsonString = JsonSerializer.Serialize(newCar);

            // write the JSON data to a new file
            File.WriteAllText("newdata.json", newJsonString);

            Console.WriteLine("Writing to new file is also done");
        }
    }

    // define classes to be serialized/deserialized
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public List<string> Features { get; set; }
    }
}
