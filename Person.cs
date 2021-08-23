namespace darkLib.Csv
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Firstname} - {Lastname} - {Email}";
        }
    }
}
