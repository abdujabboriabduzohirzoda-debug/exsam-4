// class StudentService : IStudentService
// {
//     private List<Student> students = new List<Student>();

//     public void AddStudent(Student student)
//     {
//         try
//         {
//             foreach (var s in students)
//             {
//                 if (s.Id == student.Id)
//                     throw new Exception("Student already exists!");
//             }

//             students.Add(student);
//             Console.WriteLine("Student added successfully!");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//     public void DisplayStudents()
//     {
//         try
//         {
//             if (students.Count == 0)
//                 throw new Exception("No students found!");

//             foreach (var s in students)
//             {
//                 Console.WriteLine($"ID: {s.Id}");
//                 Console.WriteLine($"Name: {s.FullName}");
//                 Console.WriteLine($"Age: {s.Age}");
//                 Console.WriteLine($"Group: {s.Group}");
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//     public void UpdateStudent(int id, string name, int age, string group)
//     {
//         try
//         {
//             Student student = students.Find(s => s.Id == id);

//             if (student == null)
//                 throw new Exception("Student not found!");

//             student.FullName = name;
//             student.Age = age;
//             student.Group = group;

//             Console.WriteLine("Student updated successfully!");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//     public void DeleteStudent(int id)
//     {
//         try
//         {
//             Student student = students.Find(s => s.Id == id);

//             if (student == null)
//                 throw new Exception("Student not found!");

//             students.Remove(student);

//             Console.WriteLine("Student deleted successfully!");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//     public Student SearchByName(string name)
//     {
//         return students.Find(s =>s.FullName.Equals(name, StringComparison.OrdinalIgnoreCase));
//     }
//     public List<Student> SearchByGroup(string group)
//     {
//         return students.FindAll(s =>s.Group.Equals(group, StringComparison.OrdinalIgnoreCase));
//     }
// }
// Task 6