using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"/home/jeff/MyTestConsole/jsonDeserialize.json");
            var locales = JsonSerializer.Deserialize<List<Locales>>(json);
            foreach (var locale in locales)
            {
                Console.WriteLine($"Name: {locale.Name}\nCode: {locale.Code}\n");
            }
        }
        private class Locales
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public Locales (string code, string name)
            {
                Code = code;
                Name =  name;
            }
        }
    }
}
