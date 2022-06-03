namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person();
      person.Name = "Mike";
      person.Age = 20;
      person.GetNameAndAge();

      Teacher teacher = new Teacher();
      teacher.Name = "Denjay";
      teacher.Age = 39;
      teacher.TeacherID = "198903";
      teacher.Subject = "Math";
      teacher.GetNameAndAge();

      Student student = new Student();
      student.Name = "Sara";
      student.Age = 19;
      student.StudentID = "9882";
      student.Email = "anjay123@gmail.com";
      student.GetNameAndAge();

    }
  }
}