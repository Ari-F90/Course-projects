
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        for (int i = 0; i < 5; i++)
        {
          Console.WriteLine("Introduce a name");
          var username = Console.ReadLine();
          Console.WriteLine("Introduce an age");
          var age = int.Parse(Console.ReadLine());
           people.Add(new Person
           {
            Username = username,
            Age = age
           })
        }
        foreach (person in people)
        {
          if (person.Age >= 18)
          {
            Console.WriteLine($"The name of this person is {person.Username}");
          }
        }

    }
}







