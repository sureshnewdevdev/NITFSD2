namespace ExampleApp
{
    // Partial Class - File 2
    public partial class Person
    {
        // Partial method implementation
        partial void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }

        public void DisplayPerson()
        {
            PrintFullName();
        }
    }
}
