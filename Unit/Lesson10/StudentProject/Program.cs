using StudentProject.Models;

public class Program
{
    public static List<Student> students = new List<Student>();

    public static void Main(string[] args)
    {

        Student student = new Student();
        students.Add(student.CreateStudent("Sabina", "Askarova", "Code Academy", DateTime.Now, 1));
        students.Add(student.CreateStudent("Sabina2", "Askarova2", "Code Academy", DateTime.Now, 2));
        students.Add(student.CreateStudent("Sabina3", "Askarova3", "Code Academy", DateTime.Now, 1));

        foreach (var item in students)
        {
            Console.WriteLine(item.Name + " " + item.Surname + " " + item.School + " " + item.SchoolMail + " " + item.RoomNumber + " " + item.Price);
        }
    }
}
