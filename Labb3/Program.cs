namespace Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            Hair hairCM = new Hair { Color = "Brown", LenghtCM = 15 };
            DateTime birthday = new DateTime(2004, 06, 28);
            string eyeColor = "Green";

            Person examplePerson = new Person(gender, hairCM, birthday, eyeColor);
            Console.WriteLine(examplePerson.ToString());
        }
    }
}