namespace StudentProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string School { get; set; }
        public string SchoolMail { get => $"{Name}.{Surname}@edu.az"; }
        public DateTime BirhtDate { get; set; }
        public int StudentId { get; set; }
        public int RoomNumber { get; set; }
        private int _price;
        public int Price
        {
            get { if (RoomNumber == 1) return 1000;
                else if (RoomNumber == 2)
                    return 2000;
                return -1;
            }

        }



        public Student CreateStudent(string Name, string Surname, string School, DateTime BirthDate, int RoomNUmber)
        {
            Student student = new Student();
            //Guid guid=Guid.NewGuid();
            //student.Id = guid.;
            student.Name = Name;
            student.Surname = Surname;
            student.School = School;
            student.BirhtDate = BirhtDate;
            student.RoomNumber = RoomNUmber;
            return student;
        }
    }
}
