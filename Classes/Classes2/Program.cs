// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce a name");
var username = Console.ReadLine();

Console.WriteLine("Introduce if it is a 'teacher' or a 'student'");
var type = Console.ReadLine();

if (type == "teacher")
{
    Teacher teacher = new Teacher();
    teacher.Username = username;
    Console.WriteLine("Introduce the subject");
    teacher.Subject = Console.ReadLine();

    Console.WriteLine($"The teacher is {teacher.Username} and the subject is {teacher.Subject}");
}

if (type == "student")
{
   Student student = new Student();
    student.Username = username;
    Console.WriteLine("Introduce the number of the student");
    student.NumberStudent = int.Parse(Console.ReadLine());

    Console.WriteLine($"The student is {student.Username} and the number is {student.NumberStudent}");
}
