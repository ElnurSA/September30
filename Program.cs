
////static void CheckPowerOfTwo(int n)
////{
////    //while(n > 1 && n % 2 ==0)
////    //{
////    //    n /= 2;
////    //}

////    //if (n == 1)
////    //{
////    //    Console.WriteLine("Quvvetidir");

////    //}
////    //else
////    //{
////    //    Console.WriteLine("Deil");
////    //}
////}

////CheckPowerOfTwo(8);


//using Practice;
//using Practice.Models;

////CustomMath math = new();

////Console.WriteLine(math.SumOfOddNumbers(new int[] {1,2,3,4,5,6}));

////Console.WriteLine(math.CheckNumOddOrEven(10));

////Console.WriteLine(math.FindPowOfEvenNumber(new int[] {1,2,3,4,5,6}, 4));

////Console.WriteLine(math.GetFactorial(4));




////static void GetEmployeesByAge(int age)
////{
////    Employee[] employees = GetEmployees();

////    Employee[] filteredEmployees = employees.Where(m => m.age > age).ToArray();

////    foreach(var employee in filteredEmployees)
////    {
////        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.email}";
////        Console.WriteLine(result);
////    }
////}

////GetEmployeesByAge(20);

////static int CountOfEmployeeByAge(int startAge, int endAge)
////{
////    Employee[] employees = GetEmployees();
////    Employee[] filteredEmployees = employees.Where(m => m.age > startAge && m.age < endAge).ToArray();

////    return filteredEmployees.Length;
////}

////static int CountOfEmployeeByAge(int startAge, int endAge) => GetEmployees().Where(m => m.age > startAge && m.age < endAge).ToArray().Length;

////static int SumOfEmployeeAges()
////{
////    var employees = GetEmployees();

////    //int sum = 0;

////    //foreach(var item in employees)
////    //{
////    //    sum += item.age;
////    //}
////    //return sum;

////    return employees.Sum(m => m.age);
////}

////static int SumOfEmployeeAges() => GetEmployees().Sum(m => m.age);

////Console.WriteLine(SumOfEmployeeAges());





////Console.WriteLine(CountOfEmployeeByAge(20,30));



//static void GetEmployeesByFilteredEmail(string str)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filteredEmployess = employees.Where(m => m.email.ToLower().StartsWith(str.ToLower())).ToArray();

//    foreach (var employee in filteredEmployess)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.email}";
//        Console.WriteLine(result);
//    }

//}


//GetEmployeesByFilteredEmail("j");











//static Employee[] GetEmployees()
//{
//    Employee employee1 = new()
//    {
//        id = 1,
//        name = "Alice",
//        surname = "Ansley",
//        age = 19,
//        address = "Los Angeles",
//        email = "alice@gmail.com"
//    };

//    Employee employee2 = new()
//    {
//        id = 2,
//        name = "John",
//        surname = "Laws",
//        age = 25,
//        address = "Berlin",
//        email = "john@gmail.com"
//    };

//    Employee employee3 = new()
//    {
//        id = 3,
//        name = "Mary",
//        surname = "Jane",
//        age = 22,
//        address = "Bakers street",
//        email = "mary@gmail.com"
//    };

//    Employee employee4 = new()
//    {
//        id = 4,
//        name = "Bob",
//        surname = "Marley",
//        age = 36,
//        address = "Miami",
//        email = "mob@gmail.com"
//    };

//    Employee[] employees = { employee1, employee2, employee3, employee4 };
//    return employees;
//}

using Practice;

//Animal animal = new Animal();

//animal.name = "Canavar";

//Bird bird = new();
//bird.name = "Serce";

//Console.WriteLine(bird.name);

//Fish fish = new();

//fish.HasCaviar = true;

//Console.WriteLine(fish.HasCaviar);

//Bird bird = new();

//bird.Sound();

//Animal animal = new();

//animal.Sound();

Factorial factorial = new();
//int a = 5;
//int b = 10;
//int result = a + b;

//int factrialResult = factorial.GetFactorial(4);

//Console.WriteLine(result + factrialResult);

//int factrialResult = factorial.GetFactorial(4);

//Console.WriteLine(factorial.Calculate(2,3) + factrialResult);

//Bird bird = new("hello");

//Student student = new();

//student.id = 1;
//student.name = "Tunzale";
//student.surname = "Memmedova";
//student.age = 24;
//student.address = "Nesimi";

//Console.WriteLine(student.GetFullData());