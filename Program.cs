using System;

namespace darkLib.Csv
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = @"Dennis;Warrimont;warrimont.dennis@gmail.com" + Environment.NewLine +
                          "Chris;Sistermanns;sistermanns@google.com";

            var parser = new CsvParser(';');
            var result = parser.Parse<Person>(input);

            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
