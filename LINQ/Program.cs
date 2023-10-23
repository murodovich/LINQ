//using LINQ;

//var result = Employee.GetEmployees().Select(s => new
//{
//    Name = s.FirstName,
//    ProgrammingLanguage = string.Join(", ",s.ProgrammingLanguage),
//    //Language = string.Join(" ,", s.Language)
//});
//foreach (var employee in result)
//{
//    Console.WriteLine(employee.Name);
//    Console.WriteLine(employee.ProgrammingLanguage);
//    //Console.WriteLine(employee.Language);
//}



using LINQ;

//var result = Student.GetAllStudents()
//    .OrderBy(x => x.FirstName)
//    .ThenByDescending(x => x.Course)
//    .ThenBy(x => x.Contract)
//    .ThenByDescending (x => x.Age)
//    .ToList();
//foreach (var student in result)
//{
//    Console.WriteLine($"{student.FirstName}  -- {student.Course} -- {student.Contract} -- {student.Age}");
//}




//var result1 = Student.GetAllStudents().Average( x => x.Contract);

//Console.WriteLine($"Kantraktning ortacha miqdori : {result1}");


//var result2 = Student.GetAllStudents ().Average( x => x.Age);
//Console.WriteLine($"Ortacha yoshi : {result2}");


var result3 = Student.GetAllStudents().Any(x => x.Talimshakli == "Sirtqi");
if(result3 == true)
{
    var result = from student in Student.GetAllStudents()
                 where student.Talimshakli == "Sirtqi"
                 select student;
    foreach(var student in result)
    {
        Console.WriteLine($"{student.LastName} -- " +
            $"{student.FirstName} --" +
            $"{student.Contract} -- " +
            $"{student.Age} -- " +
            $"{student.Course} --" +
            $"{student.Talimshakli}");
    }
        
        
}
