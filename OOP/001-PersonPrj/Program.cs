using System.Data;
Person person1 = new Teacher("Barbara", 23, "Math");
Person person2 = new Student("Joe", 10, "#13");
Person person3 = new Employee("Dan", 23, 25555);
// Person person4 = new("Lily", 43);
// Person person5 = new("Chris", 23);
// Person person6 = new("Tony", 43);
// Person person7 = new("Violet", 23);
// Person person8 = new("Jony", 43);
// Person person9 = new("Mesut", 23);
// Person person10 = new("Donald", 43);
// Person person11 = new("Vikki", 43);

Student student = new Student("Daniel", 14, "Школа №14");
Console.WriteLine(student.ToString());

Employee employee = new Employee("Albert", 26, 1500);
Console.WriteLine(employee.ToString());

Teacher teacher = new Teacher("Arthur", 26, "Physics");
Console.WriteLine(teacher.ToString());


Repository repository = new Repository(10);
// repository.Append(person1);
// repository.Append(person2);
// repository.Append(person3);
// repository.Append(person4);
// repository.Append(person5);
// repository.Append(person6);
// repository.Append(person7);
// repository.Append(person8);
// repository.Append(person9);
// repository.Append(person10);
// repository.Append(person11);

repository.Append(person1, person2);

Printer printer = new Printer();
printer.Print(repository);

var res = repository.GetPersonById(5);
Console.WriteLine(res.Name);

