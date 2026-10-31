    // Task 1
    // Inheritance
    // yak classe ast ki xususiyatho va metodhoi classi digarro qabul mekunad
    // Polymorphism
    // yak metod metavonad dar sinfhoi gunogun paftori gunogun dowta bowad
    
    // Task 2
    // Static Class -> classes ki az on abekt soxta namewavad vale metodho ba xususiyathoi on ba nomi xudi class istifoda mewavad

    // Task 3
    // Generic -> ijozat medihad ki yak class yo metod ba namudhoi gunoguni kor kunad  
    
    // Task 4
    // Struct -> baroi nigoh dowtani maalumoti aloqamand istifoda mewavad
    



    // Task 5

    // try
    // {

    // MyQueue<int> numbers = new MyQueue<int>();

    //     numbers.Enqueue(10);
    //     numbers.Enqueue(20);
    //     numbers.Enqueue(30);

    //     Console.WriteLine("Integer Queue:");
    //     Console.WriteLine("First: " + numbers.Peek());
    //     Console.WriteLine("Removed: " + numbers.Dequeue());
    //     Console.WriteLine("Count: " + numbers.Count);

            
    //     MyQueue<string> names = new MyQueue<string>();

    //     names.Enqueue("Abdujabbor");
    //     names.Enqueue("Vahob");
    //     names.Enqueue("Said");

    //     Console.WriteLine("String Queue:");
    //     Console.WriteLine("First: " + names.Peek());
    //     Console.WriteLine("Removed: " + names.Dequeue());
    //     Console.WriteLine("Count: " + names.Count);

           
    //     names.Clear();

    //     Console.WriteLine("After Clear: " + names.Count);
    // }
    //     catch (Exception d)
    // {
    //     Console.WriteLine("Error: " + d.Message);
    // }



    // Task 6
     

    // IStudentService service = new StudentService();

    // while (true)
    // {
    // try
    // {
    //     Console.WriteLine(" Student management system ");
    //     Console.WriteLine("1. Add Student");
    //     Console.WriteLine("2. Display Students");
    //     Console.WriteLine("3. Update Student");
    //     Console.WriteLine("4. Delete Student");
    //     Console.WriteLine("5. Search By Name");
    //     Console.WriteLine("6. Search By Group");
    //     Console.WriteLine("7. Exit");

    //     Console.Write("Choose: ");
    //     int choice = int.Parse(Console.ReadLine());

    //     switch (choice)
    //     {
    //     case 1:
    //     Student student = new Student();

    //     Console.Write("Enter ID: ");
    //     student.Id = int.Parse(Console.ReadLine());

    //     Console.Write("Enter Full Name: ");
    //     student.FullName = Console.ReadLine();

    //     Console.Write("Enter Age: ");
    //     student.Age = int.Parse(Console.ReadLine());

    //     Console.Write("Enter Group: ");
    //     student.Group = Console.ReadLine();

    //     service.AddStudent(student);
    //     break;

    //     case 2:
    //     service.DisplayStudents();
    //     break;

    //     case 3:
    //     Console.Write("Enter ID: ");
    //     int updateId = int.Parse(Console.ReadLine());

    //     Console.Write("Enter New Name: ");
    //     string newName = Console.ReadLine();

    //     Console.Write("Enter New Age: ");
    //     int newAge = int.Parse(Console.ReadLine());

    //     Console.Write("Enter New Group: ");
    //     string newGroup = Console.ReadLine();

    //     service.UpdateStudent(
    //     updateId, newName, newAge, newGroup);
    //     break;

    //     case 4:
    //     Console.Write("Enter ID: ");
    //     int deleteId = int.Parse(Console.ReadLine());

    //     service.DeleteStudent(deleteId);
    //     break;

    //     case 5:
    //     Console.Write("Enter Name: ");
    //     string name = Console.ReadLine();

    //     Student found = service.SearchByName(name);

    //     if (found != null)
    //     {
    //     Console.WriteLine($"ID: {found.Id}");
    //     Console.WriteLine($"Name: {found.FullName}");
    //     Console.WriteLine($"Age: {found.Age}");
    //     Console.WriteLine($"Group: {found.Group}");
    //     }
    //     else
    //     {
    //     Console.WriteLine("Student not found!");
    //     }
    //     break;

    //     case 6:
    //     Console.Write("Enter Group: ");
    //     string group = Console.ReadLine();

    //     List<Student> result =
    //     service.SearchByGroup(group);

    //     if (result.Count == 0)
    //     {
    //     Console.WriteLine("No students found!");
    //     }
    //     else
    //     {
    //     foreach (var s in result)
    //     {
    //     Console.WriteLine(
    //         $"{s.Id} - {s.FullName} - {s.Age} - {s.Group}");
    //     }
    //     }
    //     break;

    //     case 7:
    //     Console.WriteLine("Goodbye!");
    //     return;

    //     default:
    //     Console.WriteLine("Invalid choice!");
    //     break;
    //     }
    //     }
    //     catch (FormatException)
    //     {
    //         Console.WriteLine("Please enter a valid number!");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
    //     }